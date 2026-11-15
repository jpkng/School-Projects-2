Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class UserMaintenanceForm

    Private connectionString As String =
        "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=UserMaintenanceDB;Integrated Security=True"

    Private Sub UserMaintenanceForm_Load(sender As Object,
                                         e As EventArgs) Handles MyBase.Load

        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Staff")
        cmbRole.Items.Add("Player")

        txtPassword.PasswordChar = "*"

        LoadUsers()

    End Sub

    ' =========================
    ' LOAD USERS
    ' =========================

    Private Sub LoadUsers()

        Try

            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim query As String = "SELECT * FROM Users"

                Dim adapter As New SqlDataAdapter(query, con)

                Dim table As New DataTable()

                adapter.Fill(table)

                dgvUsers.DataSource = table

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    ' =========================
    ' GENERATE USERNAME
    ' =========================

    Private Function GenerateUsername(fullname As String) As String

        Dim names() As String =
            fullname.Split(" "c)

        If names.Length >= 2 Then

            Return names(0).Substring(0, 1).ToLower &
                   names(names.Length - 1).ToLower

        Else

            Return fullname.ToLower

        End If

    End Function

    ' =========================
    ' GENERATE PASSWORD
    ' =========================

    Private Function GeneratePassword() As String

        Dim chars As String =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#$%"

        Dim result As String = ""

        Dim rnd As New Random()

        For i As Integer = 1 To 10

            result &= chars(rnd.Next(chars.Length))

        Next

        Return result

    End Function

    ' =========================
    ' PASSWORD VALIDATION
    ' =========================

    Private Function IsStrongPassword(password As String) As Boolean

        If password.Length < 8 Then Return False

        Dim hasUpper As Boolean = password.Any(AddressOf Char.IsUpper)
        Dim hasLower As Boolean = password.Any(AddressOf Char.IsLower)
        Dim hasDigit As Boolean = password.Any(AddressOf Char.IsDigit)

        Dim hasSpecial As Boolean = False

        For Each c As Char In password
            If Not Char.IsLetterOrDigit(c) Then
                hasSpecial = True
                Exit For
            End If
        Next

        Return hasUpper And hasLower And hasDigit And hasSpecial

    End Function

    ' =========================
    ' EMAIL VALIDATION
    ' =========================

    Private Function IsValidEmail(email As String) As Boolean

        Dim pattern As String =
            "^[^@\s]+@[^@\s]+\.[^@\s]+$"

        Return Regex.IsMatch(email, pattern)

    End Function

    ' =========================
    ' GENERATE BUTTON
    ' =========================

    Private Sub btnGenerate_Click(sender As Object,
                                  e As EventArgs) Handles btnGenerate.Click

        If txtFullName.Text.Trim = "" Then

            MessageBox.Show(
                "Enter full name first.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Exit Sub

        End If

        txtUsername.Text =
            GenerateUsername(txtFullName.Text)

        txtPassword.Text =
            GeneratePassword()

        MessageBox.Show(
            "Username and password generated successfully.",
            "Generated",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    ' =========================
    ' SAVE BUTTON
    ' =========================

    Private Sub btnSave_Click(sender As Object,
                              e As EventArgs) Handles btnSave.Click

        ' VALIDATIONS

        If txtFullName.Text.Trim = "" Then

            MessageBox.Show("Full name is required.")
            txtFullName.Focus()
            Exit Sub

        End If

        If txtEmail.Text.Trim = "" Then

            MessageBox.Show("Email is required.")
            txtEmail.Focus()
            Exit Sub

        End If

        If Not IsValidEmail(txtEmail.Text.Trim) Then

            MessageBox.Show("Invalid email format.")
            txtEmail.Focus()
            Exit Sub

        End If

        If txtUsername.Text.Trim = "" Then

            MessageBox.Show("Username is required.")
            txtUsername.Focus()
            Exit Sub

        End If

        If txtPassword.Text.Trim = "" Then

            MessageBox.Show("Password is required.")
            txtPassword.Focus()
            Exit Sub

        End If

        If cmbRole.Text = "" Then

            MessageBox.Show("Please select role.")
            cmbRole.Focus()
            Exit Sub

        End If

        If Not IsStrongPassword(txtPassword.Text) Then

            MessageBox.Show(
                "Weak Password!" & vbCrLf &
                vbCrLf &
                "Password must contain:" & vbCrLf &
                "- Minimum 8 characters" & vbCrLf &
                "- Uppercase letter" & vbCrLf &
                "- Lowercase letter" & vbCrLf &
                "- Number" & vbCrLf &
                "- Special character",
                "Password Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Exit Sub

        End If

        Try

            Using con As New SqlConnection(connectionString)

                con.Open()

                ' CHECK DUPLICATE USERNAME

                Dim checkQuery As String =
                    "SELECT COUNT(*) FROM Users
                     WHERE Username=@Username"

                Using checkCmd As New SqlCommand(checkQuery, con)

                    checkCmd.Parameters.AddWithValue(
                        "@Username",
                        txtUsername.Text.Trim)

                    Dim count As Integer =
                        Convert.ToInt32(checkCmd.ExecuteScalar())

                    If count > 0 Then

                        MessageBox.Show(
                            "Username already exists.",
                            "Duplicate",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

                        Exit Sub

                    End If

                End Using

                ' INSERT USER

                Dim insertQuery As String =
                    "INSERT INTO Users
                    (FullName,
                     Email,
                     Username,
                     PasswordHash,
                     UserRole,
                     IsFirstLogin)

                     VALUES

                    (@FullName,
                     @Email,
                     @Username,
                     @Password,
                     @Role,
                     1)"

                Using cmd As New SqlCommand(insertQuery, con)

                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        txtFullName.Text.Trim)

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text.Trim)

                    cmd.Parameters.AddWithValue(
                        "@Username",
                        txtUsername.Text.Trim)

                    cmd.Parameters.AddWithValue(
                        "@Password",
                        txtPassword.Text)

                    cmd.Parameters.AddWithValue(
                        "@Role",
                        cmbRole.Text)

                    cmd.ExecuteNonQuery()

                End Using

                MessageBox.Show(
                    "User saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                LoadUsers()

                ClearFields()

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    ' =========================
    ' CLEAR FIELDS
    ' =========================

    Private Sub ClearFields()

        txtFullName.Clear()
        txtEmail.Clear()
        txtUsername.Clear()
        txtPassword.Clear()

        cmbRole.SelectedIndex = -1

    End Sub

    ' =========================
    ' CLEAR BUTTON
    ' =========================

    Private Sub btnClear_Click(sender As Object,
                               e As EventArgs) Handles btnClear.Click

        ClearFields()

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object,
                                               e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If

    End Sub
End Class