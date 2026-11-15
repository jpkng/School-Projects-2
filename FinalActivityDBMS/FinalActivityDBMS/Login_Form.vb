Imports System.Data.SqlClient

Public Class Login_Form
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As SqlConnection = DBHelper.GetConnection()
        Dim cmd As New SqlCommand("SELECT * FROM Users WHERE Username=@username AND Password=@password", conn)

        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)

        conn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            MessageBox.Show("Login successful!")
            Dim frm As New MainForm()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password!")
        End If

        conn.Close()
    End Sub
End Class
