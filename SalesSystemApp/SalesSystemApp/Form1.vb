Imports System.Data.SqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If AuthenticateUser(username, password) Then
            Me.Hide()
            Dim mainForm As New MainForm()
            mainForm.Show()
        Else
            MessageBox.Show("Invalid login credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim isValid As Boolean = False
        Dim connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=SalesDBase;Integrated Security=True"

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                isValid = count > 0
            End Using
        End Using

        Return isValid
    End Function
End Class
