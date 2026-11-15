Public Class MainForm
    Private Sub btnProductManagement_Click(sender As Object, e As EventArgs) Handles btnProductManagement.Click
        Dim pmForm As New ProductManagementForm()
        pmForm.Show()
    End Sub

    Private Sub btnSalesTransactions_Click(sender As Object, e As EventArgs) Handles btnSalesTransactions.Click
        Dim salesForm As New SalesTransactionForm()
        salesForm.Show()
    End Sub

    Private Sub btnReporting_Click(sender As Object, e As EventArgs) Handles btnReporting.Click
        Dim reportForm As New ReportingForm()
        reportForm.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub
End Class
