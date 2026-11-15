Imports System.Data.SqlClient

Public Class TransactionForm
    Private connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True"

    Private Sub TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
        LoadItemsIntoGrid()
        dtpDate.Value = Date.Today

        ' If editing an existing transaction (opened from TransactionViewerForm)
        If Me.Tag IsNot Nothing Then
            LoadTransactionForEdit(Convert.ToInt32(Me.Tag))
        End If
    End Sub

    ' Load customers into combo
    Private Sub LoadCustomers()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT CustomerID, CustomerName FROM Customers", conn)
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                cmbCustomer.DataSource = dt
                cmbCustomer.DisplayMember = "CustomerName"
                cmbCustomer.ValueMember = "CustomerID"
            End Using
        End Using
    End Sub

    ' Setup DataGridView
    Private Sub LoadItemsIntoGrid()
        dgvItems.Columns.Clear()

        ' Item dropdown
        Dim colItem As New DataGridViewComboBoxColumn()
        colItem.HeaderText = "Item"
        colItem.Name = "Item"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT ItemID, ItemName FROM Items", conn)
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                colItem.DataSource = dt
                colItem.DisplayMember = "ItemName"
                colItem.ValueMember = "ItemID"
            End Using
        End Using
        dgvItems.Columns.Add(colItem)

        ' Qty
        Dim colQty As New DataGridViewTextBoxColumn()
        colQty.HeaderText = "Qty"
        colQty.Name = "Qty"
        dgvItems.Columns.Add(colQty)

        ' UnitPrice
        Dim colPrice As New DataGridViewTextBoxColumn()
        colPrice.HeaderText = "Unit Price"
        colPrice.Name = "UnitPrice"
        colPrice.ReadOnly = True
        dgvItems.Columns.Add(colPrice)

        ' Subtotal
        Dim colSubtotal As New DataGridViewTextBoxColumn()
        colSubtotal.HeaderText = "Subtotal"
        colSubtotal.Name = "Subtotal"
        colSubtotal.ReadOnly = True
        dgvItems.Columns.Add(colSubtotal)
    End Sub

    ' Handle changes in item/qty
    Private Sub dgvItems_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellValueChanged
        If e.RowIndex >= 0 Then
            If dgvItems.Columns(e.ColumnIndex).Name = "Item" Or dgvItems.Columns(e.ColumnIndex).Name = "Qty" Then
                UpdateRowSubtotal(e.RowIndex)
                UpdateTotal()
            End If
        End If
    End Sub

    Private Sub dgvItems_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvItems.CurrentCellDirtyStateChanged
        If dgvItems.IsCurrentCellDirty Then
            dgvItems.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    ' Update one row
    Private Sub UpdateRowSubtotal(rowIndex As Integer)
        Try
            Dim row = dgvItems.Rows(rowIndex)
            If row.Cells("Item").Value IsNot Nothing Then
                Dim itemId As Integer = Convert.ToInt32(row.Cells("Item").Value)
                Dim unitPrice As Decimal = GetItemPrice(itemId)
                row.Cells("UnitPrice").Value = unitPrice

                Dim qty As Integer = 0
                If row.Cells("Qty").Value IsNot Nothing Then
                    Integer.TryParse(row.Cells("Qty").Value.ToString(), qty)
                End If

                row.Cells("Subtotal").Value = unitPrice * qty
            End If
        Catch
            ' ignore errors while typing
        End Try
    End Sub

    Private Function GetItemPrice(itemId As Integer) As Decimal
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT UnitPrice FROM Items WHERE ItemID=@id", conn)
                cmd.Parameters.AddWithValue("@id", itemId)
                conn.Open()
                Return Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    ' Update total
    Private Sub UpdateTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvItems.Rows
            If row.Cells("Subtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("Subtotal").Value)
            End If
        Next
        lblTotal.Text = "Total: " & total.ToString("C2")
    End Sub

    ' Save (insert or update)
    Private Sub btnTSSave_Click(sender As Object, e As EventArgs) Handles btnTSSave.Click
        If cmbCustomer.SelectedValue Is Nothing OrElse dgvItems.Rows.Count = 0 Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim customerId As Integer = Convert.ToInt32(cmbCustomer.SelectedValue)
        Dim transDate As Date = dtpDate.Value
        Dim transactionId As Integer

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim trans As SqlTransaction = conn.BeginTransaction()

            Try
                If Me.Tag Is Nothing Then
                    ' Insert new transaction
                    Using cmd As New SqlCommand("INSERT INTO Transactions (CustomerID, Date) OUTPUT INSERTED.TransactionID VALUES (@c,@d)", conn, trans)
                        cmd.Parameters.AddWithValue("@c", customerId)
                        cmd.Parameters.AddWithValue("@d", transDate)
                        transactionId = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
                Else
                    ' Update existing
                    transactionId = Convert.ToInt32(Me.Tag)
                    Using cmd As New SqlCommand("UPDATE Transactions SET CustomerID=@c, Date=@d WHERE TransactionID=@id", conn, trans)
                        cmd.Parameters.AddWithValue("@c", customerId)
                        cmd.Parameters.AddWithValue("@d", transDate)
                        cmd.Parameters.AddWithValue("@id", transactionId)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Delete old details
                    Using cmd As New SqlCommand("DELETE FROM TransactionDetails WHERE TransactionID=@id", conn, trans)
                        cmd.Parameters.AddWithValue("@id", transactionId)
                        cmd.ExecuteNonQuery()
                    End Using
                End If

                ' Insert details
                For Each row As DataGridViewRow In dgvItems.Rows
                    If row.IsNewRow Then Continue For
                    If row.Cells("Item").Value Is Nothing Or row.Cells("Qty").Value Is Nothing Then Continue For

                    Dim itemId As Integer = Convert.ToInt32(row.Cells("Item").Value)
                    Dim qty As Integer = Convert.ToInt32(row.Cells("Qty").Value)
                    Dim subtotal As Decimal = Convert.ToDecimal(row.Cells("Subtotal").Value)

                    Using cmd As New SqlCommand("INSERT INTO TransactionDetails (TransactionID, ItemID, Qty, Subtotal) VALUES (@tid,@i,@q,@s)", conn, trans)
                        cmd.Parameters.AddWithValue("@tid", transactionId)
                        cmd.Parameters.AddWithValue("@i", itemId)
                        cmd.Parameters.AddWithValue("@q", qty)
                        cmd.Parameters.AddWithValue("@s", subtotal)
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                trans.Commit()

                If Me.Tag Is Nothing Then
                    MessageBox.Show("Transaction saved successfully.")
                Else
                    MessageBox.Show("Transaction updated successfully.")
                End If

                Me.Close()
            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnTSCancel_Click(sender As Object, e As EventArgs) Handles btnTSCancel.Click
        Me.Close()
    End Sub

    ' Load existing for edit
    Private Sub LoadTransactionForEdit(transId As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Header
            Using cmd As New SqlCommand("SELECT CustomerID, Date FROM Transactions WHERE TransactionID=@id", conn)
                cmd.Parameters.AddWithValue("@id", transId)
                Using rdr = cmd.ExecuteReader()
                    If rdr.Read() Then
                        cmbCustomer.SelectedValue = rdr("CustomerID")
                        dtpDate.Value = Convert.ToDateTime(rdr("Date"))
                    End If
                End Using
            End Using

            ' Details
            Using cmd As New SqlCommand("SELECT ItemID, Qty, Subtotal FROM TransactionDetails WHERE TransactionID=@id", conn)
                cmd.Parameters.AddWithValue("@id", transId)
                Using rdr = cmd.ExecuteReader()
                    dgvItems.Rows.Clear()
                    While rdr.Read()
                        Dim idx = dgvItems.Rows.Add()
                        dgvItems.Rows(idx).Cells("Item").Value = rdr("ItemID")
                        dgvItems.Rows(idx).Cells("Qty").Value = rdr("Qty")
                        dgvItems.Rows(idx).Cells("UnitPrice").Value = GetItemPrice(rdr("ItemID"))
                        dgvItems.Rows(idx).Cells("Subtotal").Value = rdr("Subtotal")
                    End While
                End Using
            End Using
        End Using
        UpdateTotal()
    End Sub
End Class
