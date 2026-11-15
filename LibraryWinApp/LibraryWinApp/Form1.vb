Imports System.Data.SqlClient
Public Class Form1
    Private dao As New DataAccess()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
        LoadMembers()
        LogActivity("Application started.")
    End Sub

    ' Load books into dgvBooks
    Private Sub LoadBooks(Optional filter As String = "")
        Dim sql As String = "SELECT BookId, Title, Author, IsAvailable FROM Books"
        If Not String.IsNullOrWhiteSpace(filter) Then
            sql &= " WHERE Title LIKE @q OR Author LIKE @q"
            Dim dt = dao.GetDataTable(sql, New SqlParameter() {New SqlParameter("@q", "%" & filter & "%")})
            dgvBooks.DataSource = dt
        Else
            dgvBooks.DataSource = dao.GetDataTable(sql)
        End If
        ' make IsAvailable show friendly text
        If dgvBooks.Columns.Contains("IsAvailable") Then
            dgvBooks.Columns("IsAvailable").HeaderText = "Available"
        End If
        If dgvBooks.Columns.Contains("BookId") Then
            dgvBooks.Columns("BookId").Visible = False
        End If
    End Sub

    Private Sub LoadMembers(Optional filter As String = "")
        Dim sql As String = "SELECT m.MemberId, m.Name, COUNT(br.BorrowId) AS BorrowedCount FROM Members m LEFT JOIN BorrowRecords br ON m.MemberId = br.MemberId AND br.ReturnDate IS NULL GROUP BY m.MemberId, m.Name"
        If Not String.IsNullOrWhiteSpace(filter) Then
            sql &= " HAVING m.Name LIKE @q"
            Dim dt = dao.GetDataTable(sql, New SqlParameter() {New SqlParameter("@q", "%" & filter & "%")})
            dgvMembers.DataSource = dt
        Else
            dgvMembers.DataSource = dao.GetDataTable(sql)
        End If
        If dgvMembers.Columns.Contains("MemberId") Then dgvMembers.Columns("MemberId").Visible = False
    End Sub

    ' Add book
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Dim title = txtBookTitle.Text.Trim()
        Dim author = txtBookAuthor.Text.Trim()
        If title = "" Or author = "" Then
            ShowMessage("Please enter both title and author.", True)
            Return
        End If

        Dim exists = dao.ExecuteScalar(Of Integer)("SELECT COUNT(1) FROM Books WHERE LOWER(Title) = @t", New SqlParameter() {New SqlParameter("@t", title.ToLower())})
        If exists > 0 Then
            ShowMessage($"Book ""{title}"" already exists.", True)
            Return
        End If

        Dim rows = dao.ExecuteNonQuery("INSERT INTO Books (Title, Author, IsAvailable) VALUES (@title, @author, 1)",
                                      New SqlParameter() {New SqlParameter("@title", title), New SqlParameter("@author", author)})
        If rows > 0 Then
            ShowMessage($"Book ""{title}"" added.", False)
            LogActivity($"Added book: {title} by {author}")
            txtBookTitle.Text = ""
            txtBookAuthor.Text = ""
            LoadBooks(txtSearch.Text.Trim())
        Else
            ShowMessage("Failed to add book.", True)
        End If
    End Sub

    ' Register member
    Private Sub btnRegisterMember_Click(sender As Object, e As EventArgs) Handles btnRegisterMember.Click
        Dim name = txtMemberName.Text.Trim()
        If name = "" Then
            ShowMessage("Please enter a member name.", True)
            Return
        End If
        Dim exists = dao.ExecuteScalar(Of Integer)("SELECT COUNT(1) FROM Members WHERE LOWER(Name) = @n", New SqlParameter() {New SqlParameter("@n", name.ToLower())})
        If exists > 0 Then
            ShowMessage($"Member ""{name}"" already registered.", True)
            Return
        End If

        Dim rows = dao.ExecuteNonQuery("INSERT INTO Members (Name) VALUES (@name)", New SqlParameter() {New SqlParameter("@name", name)})
        If rows > 0 Then
            ShowMessage($"Member ""{name}"" registered.", False)
            LogActivity($"Registered member: {name}")
            txtMemberName.Text = ""
            LoadMembers(txtSearch.Text.Trim())
        Else
            ShowMessage("Failed to register member.", True)
        End If
    End Sub

    ' Borrow
    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Dim memberName = txtBorrowMember.Text.Trim()
        Dim bookTitle = txtBorrowBook.Text.Trim()
        If memberName = "" Or bookTitle = "" Then
            ShowMessage("Please enter both member name and book title.", True)
            Return
        End If

        Dim memberIdObj = dao.ExecuteScalar(Of Object)("SELECT MemberId FROM Members WHERE LOWER(Name)=@n", New SqlParameter() {New SqlParameter("@n", memberName.ToLower())})
        If memberIdObj Is Nothing Then
            ShowMessage($"Member ""{memberName}"" not found.", True)
            Return
        End If
        Dim memberId = Convert.ToInt32(memberIdObj)

        Dim bookIdObj = dao.ExecuteScalar(Of Object)("SELECT BookId FROM Books WHERE LOWER(Title)=@t", New SqlParameter() {New SqlParameter("@t", bookTitle.ToLower())})
        If bookIdObj Is Nothing Then
            ShowMessage($"Book ""{bookTitle}"" not found.", True)
            Return
        End If
        Dim bookId = Convert.ToInt32(bookIdObj)

        Dim isAvailable = dao.ExecuteScalar(Of Integer)("SELECT CASE WHEN IsAvailable=1 THEN 1 ELSE 0 END FROM Books WHERE BookId=@id", New SqlParameter() {New SqlParameter("@id", bookId)})
        If isAvailable = 0 Then
            ShowMessage($"Book ""{bookTitle}"" is currently unavailable.", True)
            Return
        End If

        Using con As New SqlClient.SqlConnection(DbConfig.ConnectionString)
            con.Open()
            Dim tran = con.BeginTransaction()
            Try
                Dim cmd1 As New SqlClient.SqlCommand("INSERT INTO BorrowRecords (MemberId, BookId, BorrowDate) VALUES (@m,@b,GETDATE())", con, tran)
                cmd1.Parameters.AddWithValue("@m", memberId)
                cmd1.Parameters.AddWithValue("@b", bookId)
                cmd1.ExecuteNonQuery()

                Dim cmd2 As New SqlClient.SqlCommand("UPDATE Books SET IsAvailable = 0 WHERE BookId = @b", con, tran)
                cmd2.Parameters.AddWithValue("@b", bookId)
                cmd2.ExecuteNonQuery()

                tran.Commit()
                ShowMessage($"{memberName} borrowed ""{bookTitle}"".", False)
                LogActivity($"{memberName} borrowed ""{bookTitle}""")
                txtBorrowMember.Text = ""
                txtBorrowBook.Text = ""
                LoadBooks(txtSearch.Text.Trim())
                LoadMembers()
            Catch ex As Exception
                tran.Rollback()
                ShowMessage("Error while borrowing: " & ex.Message, True)
            End Try
        End Using
    End Sub

    ' Return
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim memberName = txtBorrowMember.Text.Trim()
        Dim bookTitle = txtBorrowBook.Text.Trim()
        If memberName = "" Or bookTitle = "" Then
            ShowMessage("Please enter both member name and book title.", True)
            Return
        End If

        Dim memberIdObj = dao.ExecuteScalar(Of Object)("SELECT MemberId FROM Members WHERE LOWER(Name)=@n", New SqlParameter() {New SqlParameter("@n", memberName.ToLower())})
        If memberIdObj Is Nothing Then
            ShowMessage($"Member ""{memberName}"" not found.", True)
            Return
        End If
        Dim memberId = Convert.ToInt32(memberIdObj)

        Dim bookIdObj = dao.ExecuteScalar(Of Object)("SELECT BookId FROM Books WHERE LOWER(Title)=@t", New SqlParameter() {New SqlParameter("@t", bookTitle.ToLower())})
        If bookIdObj Is Nothing Then
            ShowMessage($"Book ""{bookTitle}"" not found.", True)
            Return
        End If
        Dim bookId = Convert.ToInt32(bookIdObj)

        ' Find active borrow record
        Dim borrowIdObj = dao.ExecuteScalar(Of Object)("SELECT TOP 1 BorrowId FROM BorrowRecords WHERE MemberId=@m AND BookId=@b AND ReturnDate IS NULL ORDER BY BorrowDate DESC",
                                                       New SqlParameter() {New SqlParameter("@m", memberId), New SqlParameter("@b", bookId)})
        If borrowIdObj Is Nothing Then
            ShowMessage($"{memberName} did not borrow ""{bookTitle}"".", True)
            Return
        End If
        Dim borrowId = Convert.ToInt32(borrowIdObj)

        Using con As New SqlClient.SqlConnection(DbConfig.ConnectionString)
            con.Open()
            Dim tran = con.BeginTransaction()
            Try
                Dim cmd1 As New SqlClient.SqlCommand("UPDATE BorrowRecords SET ReturnDate = GETDATE() WHERE BorrowId = @id", con, tran)
                cmd1.Parameters.AddWithValue("@id", borrowId)
                cmd1.ExecuteNonQuery()

                Dim cmd2 As New SqlClient.SqlCommand("UPDATE Books SET IsAvailable = 1 WHERE BookId = @b", con, tran)
                cmd2.Parameters.AddWithValue("@b", bookId)
                cmd2.ExecuteNonQuery()

                tran.Commit()
                ShowMessage($"{memberName} returned ""{bookTitle}"".", False)
                LogActivity($"{memberName} returned ""{bookTitle}""")
                txtBorrowMember.Text = ""
                txtBorrowBook.Text = ""
                LoadBooks(txtSearch.Text.Trim())
                LoadMembers()
            Catch ex As Exception
                tran.Rollback()
                ShowMessage("Error while returning: " & ex.Message, True)
            End Try
        End Using
    End Sub

    ' Search textbox change
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim q = txtSearch.Text.Trim()
        LoadBooks(q)
        LoadMembers(q)
    End Sub

    ' Show available
    Private Sub btnShowAvailable_Click(sender As Object, e As EventArgs) Handles btnShowAvailable.Click
        Dim dt = dao.GetDataTable("SELECT BookId, Title, Author, IsAvailable FROM Books WHERE IsAvailable = 1")
        dgvBooks.DataSource = dt
        LogActivity("Viewed available books")
    End Sub

    ' Show all
    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        LoadBooks()
        LogActivity("Viewed all books")
    End Sub

    ' Helper: message to user
    Private Sub ShowMessage(msg As String, isError As Boolean)
        ' Basic message box, you may replace with toast style UI
        If isError Then
            MessageBox.Show(msg, "Library", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show(msg, "Library", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Activity log
    Private Sub LogActivity(text As String)
        Dim t = $"{DateTime.Now:HH:mm:ss} - {text}"
        txtActivity.AppendText(t & Environment.NewLine)
    End Sub
End Class
