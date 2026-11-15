Imports System.Data.SqlClient

Public Class StudentForm

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    Private Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=LibraryPenaltyDB;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function

    Private Sub LoadStudents()
        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("SELECT * FROM Students", con)
            Dim dt As New DataTable()
            con.Open()
            dt.Load(cmd.ExecuteReader())
            dgvStudents.DataSource = dt
        End Using
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        If txtName.Text = "" Or txtGrade.Text = "" Or txtSection.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("INSERT INTO Students (FullName, GradeLevel, Section) VALUES (@name, @grade, @section)", con)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@grade", txtGrade.Text)
            cmd.Parameters.AddWithValue("@section", txtSection.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student added.")
            LoadStudents()
            txtName.Clear()
            txtGrade.Clear()
            txtSection.Clear()
        End Using
    End Sub

End Class
