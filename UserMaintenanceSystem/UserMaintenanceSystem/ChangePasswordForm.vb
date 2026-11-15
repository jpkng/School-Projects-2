Imports System.Data.SqlClient

Public Class ChangePasswordForm

    Public Shared loggedInUsername As String

    Private connectionString As String =
        "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=UserMaintenanceDB;Integrated Security=True"

    Private Sub ChangePasswordForm_Load(sender As Object,
                                        e As EventArgs) Handles MyBase.Load

        txtNewPassword.PasswordChar = "*"
        txtConfirmPassword.PasswordChar = "*"

        lblUsername.Text = loggedInUsername

    End Sub

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
    ' UPDATE PASSWORD
    ' =========================

    Private Sub btnUpdate_Click(sender As Object,
                                e As EventArgs) Handles btnUpdate.Click

        If txtNewPassword.Text.Trim = "" Then

            MessageBox.Show("Enter new password.")
            txtNewPassword.Focus()
            Exit Sub

        End If

        If txtConfirmPassword.Text.Trim = "" Then

            MessageBox.Show("Confirm your password.")
            txtConfirmPassword.Focus()
            Exit Sub

        End If

        If txtNewPassword.Text <>
            txtConfirmPassword.Text Then

            MessageBox.Show(
                "Passwords do not match.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Exit Sub

        End If

        If Not IsStrongPassword(txtNewPassword.Text) Then

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

                Dim query As String =
                    "UPDATE Users
                     SET PasswordHash=@Password,
                         IsFirstLogin=0
                     WHERE Username=@Username"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue(
                        "@Password",
                        txtNewPassword.Text)

                    cmd.Parameters.AddWithValue(
                        "@Username",
                        loggedInUsername)

                    cmd.ExecuteNonQuery()

                End Using

                MessageBox.Show(
                    "Password updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                Me.Close()

                LoginForm.Show()

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object,
                                               e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked Then

            txtNewPassword.PasswordChar = ""
            txtConfirmPassword.PasswordChar = ""

        Else

            txtNewPassword.PasswordChar = "*"
            txtConfirmPassword.PasswordChar = "*"

        End If

    End Sub

End Class