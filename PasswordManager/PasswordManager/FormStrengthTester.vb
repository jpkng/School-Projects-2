Imports System.Text

Public Class FormStrengthTester
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Toggle password masking when the "Show password" checkbox changes
        txtTestPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    ' Small lists of common passwords/words used for penalty detection
    Private ReadOnly commonPasswords As String() = New String() {"123456", "password", "123456789", "qwerty", "iloveyou", "abc123", "111111", "welcome", "monkey", "letmein"}
    Private ReadOnly commonWords As String() = New String() {"password", "admin", "login", "welcome", "love", "ilove", "hello", "user", "username", "qwerty", "steam", "google", "youtube", "netflix"}

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset UI elements when Clear is clicked
        txtTestPassword.Text = ""
        pbStrength.Value = 0
        lblStrengthTier.Text = ""
        lblTimeToCrack.Text = ""
        txtExplanation.Text = ""
    End Sub

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim pwd = txtTestPassword.Text
        If String.IsNullOrEmpty(pwd) Then
            MessageBox.Show("Please enter a password to test.", "Input required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Compute adjusted entropy and estimated guesses from that entropy
        Dim entropy = AdjustedEntropy(pwd)
        Dim guesses = GuessesFromEntropy(entropy)

        ' Scale meter to a 0-100 range using a capped entropy display (120 bits max shown)
        Dim displayEntropy = Math.Min(120, entropy)
        Dim meterValue = CInt((displayEntropy / 120.0) * 100)
        pbStrength.Value = Math.Max(0, Math.Min(100, meterValue))

        ' Convert entropy to a human-friendly tier label
        Dim tier = TierFromEntropy(entropy)
        lblStrengthTier.Text = tier

        ' Typical attacker speeds used for time-to-crack estimates
        Dim onlineSpeed = 100.0 ' guesses per second for online throttled attacks
        Dim offlineGpu = 10000000000.0 ' ~10 billion guesses/second for a powerful GPU cluster

        Dim yearsOnline = TimeToCrack(guesses, onlineSpeed)
        Dim yearsOffline = TimeToCrack(guesses, offlineGpu)

        lblTimeToCrack.Text = "Estimated time to crack: online ~ " & HumanDuration(yearsOnline) & ", offline GPU ~ " & HumanDuration(yearsOffline)

        ' Build user-facing explanation of the score and weaknesses
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("Length: " & pwd.Length & " characters")
        sb.AppendLine("Character set size: " & CharsetSize(pwd))
        sb.AppendLine("Base entropy: " & Math.Round(BaseEntropy(pwd), 2) & " bits")
        Dim penalty = DetectDictionaryPenalty(pwd)
        sb.AppendLine("Detected penalties: " & Math.Round(penalty, 2) & " bits")
        sb.AppendLine("Adjusted entropy: " & Math.Round(entropy, 2) & " bits")
        sb.AppendLine()
        sb.AppendLine("Why this rating:")
        If penalty >= 40 Then
            sb.AppendLine("- Exact match to a common password or heavy weakness detected.")
        End If
        If pwd.Length < 8 Then
            sb.AppendLine("- Password is shorter than recommended minimum, increase length.")
        End If
        If commonWords.Any(Function(w) pwd.ToLower().Contains(w)) Then
            sb.AppendLine("- Contains common words or substrings, avoid dictionary words.")
        End If
        If pwd.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
            sb.AppendLine("- Contains symbols, that helps increase entropy.")
        Else
            sb.AppendLine("- No symbols detected, adding symbols improves strength.")
        End If
        sb.AppendLine("- Avoid repeated characters, common sequences, or predictable substitutions.")
        sb.AppendLine()
        sb.AppendLine("Tips to improve password:")
        sb.AppendLine("- Use at least 12 to 16 characters.")
        sb.AppendLine("- Mix uppercase, lowercase, digits, and symbols.")
        sb.AppendLine("- Avoid dictionary words and common phrases like 'iloveyou'.")
        sb.AppendLine("- Consider a random passphrase of unrelated words, or use a password manager to generate and store a unique password.")

        sb.AppendLine()
        sb.AppendLine("Notice: The time to crack values are rough estimates. They depend on attacker resources, hash verification speed, and account rate limits.")
        txtExplanation.Text = sb.ToString()
    End Sub


    Private Function CharsetSize(pwd As String) As Integer
        ' Approximate size of character set used in the password (lower/upper/digits/symbols)
        Dim hasLower = pwd.Any(Function(c) Char.IsLower(c))
        Dim hasUpper = pwd.Any(Function(c) Char.IsUpper(c))
        Dim hasDigit = pwd.Any(Function(c) Char.IsDigit(c))
        Dim hasSymbol = pwd.Any(Function(c) Not Char.IsLetterOrDigit(c))
        Dim size As Integer = 0
        If hasLower Then size += 26
        If hasUpper Then size += 26
        If hasDigit Then size += 10
        If hasSymbol Then size += 32 ' approximate common printable symbols
        Return Math.Max(1, size)
    End Function

    Private Function BaseEntropy(pwd As String) As Double
        ' Shannon-style entropy estimate: log2(charset_size) * length
        Dim cs = CharsetSize(pwd)
        Dim perChar = Math.Log(cs) / Math.Log(2) ' log2
        Return perChar * pwd.Length
    End Function

    Private Function DetectDictionaryPenalty(pwd As String) As Double
        ' Reduce entropy for dictionary words, exact common passwords, repeated sequences, and sequential runs
        Dim lowered = pwd.ToLower()
        Dim penalty As Double = 0

        ' Full match to very common passwords -> huge penalty (treat as trivial)
        For Each cp In commonPasswords
            If lowered = cp Then
                Return 40.0 ' immediate heavy penalty for exact common password
            End If
        Next

        ' Substring matches to common words reduce entropy incrementally
        For Each w In commonWords
            If w.Length >= 3 AndAlso lowered.Contains(w) Then
                penalty += Math.Min(20, w.Length * 2) ' scale by word length
            End If
        Next

        ' Penalize long repeated characters like "aaaa" or "1111"
        Dim maxRepeat = 1
        Dim curRepeat = 1
        For i = 1 To pwd.Length - 1
            If pwd(i) = pwd(i - 1) Then
                curRepeat += 1
                If curRepeat > maxRepeat Then maxRepeat = curRepeat
            Else
                curRepeat = 1
            End If
        Next
        If maxRepeat >= 3 Then
            penalty += (maxRepeat - 2) * 6 ' penalize repeats beyond length 2
        End If

        ' Detect simple sequential runs like "12345" or "abcde"
        Dim seqPenalty = 0
        Dim lower = lowered
        For i = 0 To lower.Length - 3
            Dim segment = lower.Substring(i, Math.Min(5, lower.Length - i))
            If IsSequential(segment) Then
                seqPenalty += 10
            End If
        Next
        penalty += seqPenalty

        Return Math.Min(penalty, 60) ' cap total penalty to avoid negative entropy overflows
    End Function

    Private Function IsSequential(s As String) As Boolean
        ' Check if characters form an ascending or descending sequential run
        If s.Length < 3 Then Return False
        Dim asc = True
        Dim desc = True
        For i = 1 To s.Length - 1
            If AscW(s(i)) <> AscW(s(i - 1)) + 1 Then asc = False
            If AscW(s(i)) <> AscW(s(i - 1)) - 1 Then desc = False
        Next
        Return asc Or desc
    End Function

    Private Function AdjustedEntropy(pwd As String) As Double
        ' Base entropy minus detected penalties; floor at 0
        Dim base = BaseEntropy(pwd)
        Dim penalty = DetectDictionaryPenalty(pwd)
        Dim adjusted = base - penalty
        If adjusted < 0 Then adjusted = 0
        Return adjusted
    End Function

    Private Function GuessesFromEntropy(entropy As Double) As Double
        ' Convert entropy bits to number of guesses (2^entropy)
        Return Math.Pow(2.0, entropy)
    End Function

    Private Function TimeToCrack(guesses As Double, guessesPerSecond As Double) As Double
        ' Convert guesses and attack speed into years to crack
        Dim seconds = guesses / guessesPerSecond
        Dim years = seconds / (60.0 * 60.0 * 24.0 * 365.25)
        Return years
    End Function

    Private Function HumanDuration(years As Double) As String
        ' Convert years into a readable duration string (minutes/hours/days/years/thousands)
        If Double.IsInfinity(years) OrElse Double.IsNaN(years) Then Return "Unknown"
        If years < 1.0 / (365.25) Then
            Dim hours = years * 365.25 * 24
            If hours < 1 Then
                Dim minutes = hours * 60
                Return $"{Math.Round(minutes, 2)} minutes"
            End If
            Return $"{Math.Round(hours, 2)} hours"
        End If
        If years < 1 Then
            Dim days = years * 365.25
            Return $"{Math.Round(days, 2)} days"
        End If
        If years < 1000 Then
            Return $"{Math.Round(years, 2)} years"
        End If
        Dim millennia = years / 1000.0
        Return $"{Math.Round(millennia, 2)} thousand years"
    End Function

    Private Function TierFromEntropy(entropy As Double) As String
        If entropy < 28 Then
            Return "Very Weak - Using that password is like leaving your front door wide open"
        ElseIf entropy < 36 Then
            Return "Weak - Using that password is like locking your door but leaving the key out."
        ElseIf entropy < 60 Then
            Return "Moderate - Not the best security, but still a barrier."
        ElseIf entropy < 80 Then
            Return "Strong - Using that password is like locking your door and hiding the key in a vault."
        Else
            Return "Very Strong - Using that password makes you as secure as Fort Knox."
        End If
    End Function

    Private Sub FormStrengthTester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExplain_Click(sender As Object, e As EventArgs) Handles btnExplain.Click
        Dim message As String =
            "Online cracking means an attacker guesses passwords through a live connection (like a login page). " &
            "It’s limited by server speed and lockouts, so it can take years." & vbCrLf & vbCrLf &
            "Offline cracking means the attacker already has the password hash file. " &
            "They can use powerful GPUs to test billions of passwords per second making the time to crack needed much faster."
        MessageBox.Show(message, "Online vs Offline GPU Cracking", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub

    Private Sub txtExplanation_TextChanged(sender As Object, e As EventArgs) Handles txtExplanation.TextChanged

    End Sub
End Class
