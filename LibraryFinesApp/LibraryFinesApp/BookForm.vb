Imports System.Data.SqlClient

Public Class BookForm

    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
    End Sub

    Private Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=LibraryPenaltyDB;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function

    Private Sub LoadBooks()
        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("SELECT * FROM Books", con)
            Dim dt As New DataTable()
            con.Open()
            dt.Load(cmd.ExecuteReader())
            dgvBooks.DataSource = dt
        End Using
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        If txtTitle.Text = "" Or txtAuthor.Text = "" Then
            MessageBox.Show("Please fill in both fields.")
            Exit Sub
        End If

        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("INSERT INTO Books (Title, Author) VALUES (@title, @auth)", con)
            cmd.Parameters.AddWithValue("@title", txtTitle.Text)
            cmd.Parameters.AddWithValue("@auth", txtAuthor.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book added.")
            LoadBooks()
            txtTitle.Clear()
            txtAuthor.Clear()
        End Using
    End Sub

End Class
