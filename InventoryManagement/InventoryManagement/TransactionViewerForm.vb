Imports System.Data.SqlClient

Public Class TransactionViewerForm
    Private connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True"

    Private Sub TransactionViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()
    End Sub

    ' Load transaction headers
    Private Sub LoadTransactions()
        Using conn As New SqlConnection(connectionString)
            Dim sql As String = "
           SELECT 
    t.TransactionID,
    t.CustomerID,
    c.CustomerName,
    t.[Date],
    SUM(d.Subtotal) AS TotalAmount
FROM Transactions t
INNER JOIN Customers c ON t.CustomerID = c.CustomerID
INNER JOIN TransactionDetails d ON t.TransactionID = d.TransactionID
GROUP BY t.TransactionID, t.CustomerID, c.CustomerName, t.[Date]
ORDER BY t.[Date] DESC;

        "

            Using cmd As New SqlCommand(sql, conn)
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)

                Try
                    da.Fill(dt)
                    dgvTransactions.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show("Error loading transactions: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    ' When a transaction is selected → load details
    Private Sub dgvTransactions_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTransactions.SelectionChanged
        If dgvTransactions.CurrentRow Is Nothing Then Return
        Dim transId As Integer = Convert.ToInt32(dgvTransactions.CurrentRow.Cells("TransactionID").Value)
        LoadDetails(transId)
    End Sub

    ' Load details for selected transaction
    Private Sub LoadDetails(transId As Integer)
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT i.ItemName, d.Qty, d.Subtotal FROM TransactionDetails d INNER JOIN Items i ON d.ItemID = i.ItemID WHERE d.TransactionID=@tid", conn)
                cmd.Parameters.AddWithValue("@tid", transId)
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                dgvDetails.DataSource = dt
            End Using
        End Using
    End Sub

    ' Refresh transactions
    Private Sub btnTVRefresh_Click(sender As Object, e As EventArgs) Handles btnTVRefresh.Click
        LoadTransactions()
        dgvDetails.DataSource = Nothing
    End Sub

    ' Delete transaction (Admin & Supervisor only)
    Private Sub btnTVDelete_Click(sender As Object, e As EventArgs) Handles btnTVDelete.Click
        If dgvTransactions.CurrentRow Is Nothing Then Return
        Dim transId As Integer = Convert.ToInt32(dgvTransactions.CurrentRow.Cells("TransactionID").Value)

        If MessageBox.Show("Delete this transaction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim trans As SqlTransaction = conn.BeginTransaction()
                Try
                    ' Delete details first
                    Using cmd1 As New SqlCommand("DELETE FROM TransactionDetails WHERE TransactionID=@id", conn, trans)
                        cmd1.Parameters.AddWithValue("@id", transId)
                        cmd1.ExecuteNonQuery()
                    End Using

                    ' Delete header
                    Using cmd2 As New SqlCommand("DELETE FROM Transactions WHERE TransactionID=@id", conn, trans)
                        cmd2.Parameters.AddWithValue("@id", transId)
                        cmd2.ExecuteNonQuery()
                    End Using

                    trans.Commit()
                    MessageBox.Show("Transaction deleted.")
                    LoadTransactions()
                    dgvDetails.DataSource = Nothing
                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' Edit transaction (reopen TransactionForm in edit mode)
    Private Sub btnTVEdit_Click(sender As Object, e As EventArgs) Handles btnTVEdit.Click
        If dgvTransactions.CurrentRow Is Nothing Then Return
        Dim transId As Integer = Convert.ToInt32(dgvTransactions.CurrentRow.Cells("TransactionID").Value)

        Dim f As New TransactionForm()
        f.Tag = transId   ' Pass transaction ID for edit
        f.ShowDialog()

        LoadTransactions()
    End Sub

    ' Close viewer
    Private Sub btnTVClose_Click(sender As Object, e As EventArgs) Handles btnTVClose.Click
        Me.Close()
    End Sub

End Class
