Public Class SupervisorForm
    Private Sub btnSVTransactions_Click(sender As Object, e As EventArgs) Handles btnSVTransactions.Click
        Dim f As New TransactionForm()
        f.ShowDialog()
    End Sub

    Private Sub btnSVViewTransactions_Click(sender As Object, e As EventArgs) Handles btnSVViewTransactions.Click
        Dim f As New TransactionViewerForm()
        f.ShowDialog()
    End Sub

    Private Sub btnSVReports_Click(sender As Object, e As EventArgs) Handles btnSVReports.Click
        MessageBox.Show("Reports module coming soon.")
    End Sub

    Private Sub btnSVLogout_Click(sender As Object, e As EventArgs) Handles btnSVLogout.Click
        Me.Close()
    End Sub
End Class
