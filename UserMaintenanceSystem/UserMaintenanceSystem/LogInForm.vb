Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class LoginForm

    Private connectionString As String =
        "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=UserMaintenanceDB;Integrated Security=True"

    Private Sub LoginForm_Load(sender As Object,
                                e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "*"

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object,
                                               e As EventArgs) Handles chkShowPassword.CheckedChanged

        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object,
                               e As EventArgs) Handles btnLogin.Click

        ' VALIDATION

        If txtUsername.Text.Trim = "" Then

            MessageBox.Show("Please enter username.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtUsername.Focus()
            Exit Sub

        End If

        If txtPassword.Text.Trim = "" Then

            MessageBox.Show("Please enter password.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtPassword.Focus()
            Exit Sub

        End If

        Try

            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim query As String =
                    "SELECT * FROM Users
                     WHERE Username=@Username
                     AND PasswordHash=@Password"

                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@Username",
                                                txtUsername.Text.Trim)

                    cmd.Parameters.AddWithValue("@Password",
                                                txtPassword.Text)

                    Dim reader As SqlDataReader =
                        cmd.ExecuteReader()

                    If reader.HasRows Then

                        reader.Read()

                        Dim role As String =
                            reader("UserRole").ToString()

                        Dim firstLogin As Boolean =
                            Convert.ToBoolean(reader("IsFirstLogin"))

                        MessageBox.Show("Login Successful!" &
                                        vbCrLf &
                                        "Role: " & role,
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)

                        If firstLogin = True Then

                            MessageBox.Show(
                                "You are required to change your password.",
                                "First Login",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                            ChangePasswordForm.loggedInUsername =
                                txtUsername.Text.Trim

                            ChangePasswordForm.Show()

                            Me.Hide()

                        Else

                            MessageBox.Show(
                                "Welcome to the system!",
                                "Login Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                            UserMaintenanceForm.Show()
                            Me.Hide()

                        End If

                    Else

                        MessageBox.Show(
                            "Invalid Username or Password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object,
                              e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

End Class