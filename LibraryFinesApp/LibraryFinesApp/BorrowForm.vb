Imports System.Data.SqlClient

Public Class BorrowForm

    Private Sub BorrowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
        LoadBooks()
        LoadBorrowedRecords()
    End Sub

    Private Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=LibraryPenaltyDB;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function

    Private Sub LoadStudents()
        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("SELECT StudentID, FullName FROM Students", con)
            Dim dt As New DataTable()
            con.Open()
            dt.Load(cmd.ExecuteReader())
            cbStudent.DisplayMember = "FullName"
            cbStudent.ValueMember = "StudentID"
            cbStudent.DataSource = dt
        End Using
    End Sub

    Private Sub LoadBooks()
        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("SELECT BookID, Title FROM Books", con)
            Dim dt As New DataTable()
            con.Open()
            dt.Load(cmd.ExecuteReader())
            cbBook.DisplayMember = "Title"
            cbBook.ValueMember = "BookID"
            cbBook.DataSource = dt
        End Using
    End Sub

    Private Sub LoadBorrowedRecords()
        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("SELECT r.RecordID, s.FullName, b.Title, r.BorrowDate, r.DueDate, r.ReturnDate, r.FineAmount FROM BorrowRecords r JOIN Students s ON r.StudentID = s.StudentID JOIN Books b ON r.BookID = b.BookID", con)
            Dim dt As New DataTable()
            con.Open()
            dt.Load(cmd.ExecuteReader())
            dgvBorrowed.DataSource = dt
        End Using
    End Sub

    Private Function CalculateFine(dueDate As Date, returnDate As Date) As Decimal
        Dim finePerDay As Decimal = 5D
        Dim daysLate As Integer = (returnDate - dueDate).Days
        If daysLate > 0 Then
            Return daysLate * finePerDay
        End If
        Return 0D
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim fine = CalculateFine(dtDueDate.Value, dtReturnDate.Value)

        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("INSERT INTO BorrowRecords (StudentID, BookID, BorrowDate, DueDate, ReturnDate, FineAmount, PaidAmount) VALUES (@sid, @bid, @bdate, @ddate, @rdate, @fine, 0)", con)
            cmd.Parameters.AddWithValue("@sid", cbStudent.SelectedValue)
            cmd.Parameters.AddWithValue("@bid", cbBook.SelectedValue)
            cmd.Parameters.AddWithValue("@bdate", dtBorrowDate.Value.Date)
            cmd.Parameters.AddWithValue("@ddate", dtDueDate.Value.Date)
            cmd.Parameters.AddWithValue("@rdate", dtReturnDate.Value.Date)
            cmd.Parameters.AddWithValue("@fine", fine)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Borrow record saved!")
            LoadBorrowedRecords()
        End Using
    End Sub
End Class
