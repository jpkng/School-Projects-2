Public Class UserForm
    Private Sub btnUSTransactions_Click(sender As Object, e As EventArgs) Handles btnUSTransactions.Click
        Dim f As New TransactionForm()
        f.ShowDialog()
    End Sub

    Private Sub btnUSViewTransactions_Click(sender As Object, e As EventArgs) Handles btnUSViewTransactions.Click
        Dim f As New TransactionViewerForm()
        f.ShowDialog()
    End Sub

    Private Sub btnUSLogout_Click(sender As Object, e As EventArgs) Handles btnUSLogout.Click
        Me.Close()
    End Sub
End Class
