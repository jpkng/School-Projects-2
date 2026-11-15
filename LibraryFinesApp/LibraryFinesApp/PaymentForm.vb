Imports System.Data.SqlClient

Public Class PaymentForm

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
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

    Private Sub cbStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStudent.SelectedIndexChanged
        If cbStudent.SelectedIndex >= 0 Then
            LoadUnpaidFines()
        End If
    End Sub

    Private Sub LoadUnpaidFines()
        Using con As SqlConnection = GetConnection()
            Dim cmd As New SqlCommand("SELECT RecordID, BookID, FineAmount, PaidAmount, (FineAmount - PaidAmount) AS Balance FROM BorrowRecords WHERE StudentID=@sid AND FineAmount > PaidAmount", con)
            cmd.Parameters.AddWithValue("@sid", cbStudent.SelectedValue)
            Dim dt As New DataTable()
            con.Open()
            dt.Load(cmd.ExecuteReader())
            dgvUnpaid.DataSource = dt

            ' Calculate total due
            Dim total As Decimal = 0
            For Each row As DataRow In dt.Rows
                total += Convert.ToDecimal(row("Balance"))
            Next
            lblTotalDue.Text = "Total Due: ₱" & total.ToString("F2")
        End Using
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If Not IsNumeric(txtPayment.Text) Then
            MessageBox.Show("Please enter a valid payment amount.")
            Exit Sub
        End If

        Dim payment As Decimal = Convert.ToDecimal(txtPayment.Text)
        If payment <= 0 Then
            MessageBox.Show("Payment must be greater than 0.")
            Exit Sub
        End If

        Dim remainingPayment As Decimal = payment

        Using con As SqlConnection = GetConnection()
            con.Open()

            For Each row As DataGridViewRow In dgvUnpaid.Rows
                If remainingPayment <= 0 Then Exit For

                Dim recordId As Integer = row.Cells("RecordID").Value
                Dim balance As Decimal = Convert.ToDecimal(row.Cells("Balance").Value)
                Dim payAmount As Decimal = If(remainingPayment >= balance, balance, remainingPayment)

                Dim cmd As New SqlCommand("UPDATE BorrowRecords SET PaidAmount = PaidAmount + @payAmount WHERE RecordID = @recordId", con)
                cmd.Parameters.AddWithValue("@payAmount", payAmount)
                cmd.Parameters.AddWithValue("@recordId", recordId)
                cmd.ExecuteNonQuery()

                remainingPayment -= payAmount
            Next
        End Using

        MessageBox.Show("Payment successful!")
        LoadUnpaidFines()
    End Sub
End Class
