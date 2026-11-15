Public Class AdminForm
    Private Sub btnADUsers_Click(sender As Object, e As EventArgs) Handles btnADUsers.Click
        Dim f As New UserManagementForm()
        f.ShowDialog()
    End Sub

    Private Sub btnADTransactions_Click(sender As Object, e As EventArgs) Handles btnADTransactions.Click
        Dim f As New TransactionForm()
        f.ShowDialog()
    End Sub

    Private Sub btnADViewTransactions_Click(sender As Object, e As EventArgs) Handles btnADViewTransactions.Click
        Dim f As New TransactionViewerForm()
        f.ShowDialog()
    End Sub

    Private Sub btnADReports_Click(sender As Object, e As EventArgs) Handles btnADReports.Click
        MessageBox.Show("Reports module coming soon.")
    End Sub

    Private Sub btnADLogout_Click(sender As Object, e As EventArgs) Handles btnADLogout.Click
        Me.Close()
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
