Imports System.Data.SqlClient

Public Class LoginForm
    Private connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True"

    ' --- Login Button ---
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname As String = txtUsername.Text.Trim()
        Dim pwd As String = txtPassword.Text.Trim()

        If uname = "" OrElse pwd = "" Then
            MessageBox.Show("Please enter username and password.")
            Return
        End If

        Dim plainPwd As String = pwd

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT Role FROM Users WHERE Username=@u AND PasswordHash=@p", conn)
                cmd.Parameters.AddWithValue("@u", uname)
                cmd.Parameters.AddWithValue("@p", plainPwd)
                conn.Open()

                Dim roleObj As Object = cmd.ExecuteScalar()
                If roleObj Is Nothing Then
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim role As String = roleObj.ToString()
                    Me.Hide() ' hide login form

                    Select Case role
                        Case "Admin"
                            Dim f As New AdminForm()
                            f.ShowDialog()
                        Case "Supervisor"
                            Dim f As New SupervisorForm()
                            f.ShowDialog()
                        Case "User"
                            Dim f As New UserForm()
                            f.ShowDialog()
                    End Select

                    ' When the dashboard form closes, show login again
                    Me.Show()
                    txtUsername.Clear()
                    txtPassword.Clear()
                End If
            End Using
        End Using
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nothing here yet
    End Sub
End Class
