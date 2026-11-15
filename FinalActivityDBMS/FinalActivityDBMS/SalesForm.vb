Imports System.Data.SqlClient

Public Class SalesForm
    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Dim conn As SqlConnection = DBHelper.GetConnection()
        Dim adapter As New SqlDataAdapter("SELECT * FROM Products", conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to sell.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("ProductID").Value)
        Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("Price").Value)
        Dim currentQty As Integer = Convert.ToInt32(selectedRow.Cells("Quantity").Value)
        Dim sellQty As Integer = Integer.Parse(txtQuantity.Text)

        If sellQty > currentQty Then
            MessageBox.Show("Not enough stock available.")
            Return
        End If

        Dim conn As SqlConnection = DBHelper.GetConnection()
        conn.Open()

        ' Insert into Sales table
        Dim cmdSale As New SqlCommand("INSERT INTO Sales DEFAULT VALUES; SELECT SCOPE_IDENTITY();", conn)
        Dim saleId As Integer = Convert.ToInt32(cmdSale.ExecuteScalar())

        ' Insert into SaleDetails table
        Dim cmdDetail As New SqlCommand("INSERT INTO SaleDetails (SaleID, ProductID, Quantity, Price) VALUES (@saleId, @productId, @qty, @price)", conn)
        cmdDetail.Parameters.AddWithValue("@saleId", saleId)
        cmdDetail.Parameters.AddWithValue("@productId", productId)
        cmdDetail.Parameters.AddWithValue("@qty", sellQty)
        cmdDetail.Parameters.AddWithValue("@price", price)
        cmdDetail.ExecuteNonQuery()

        ' Update product quantity
        Dim newQty As Integer = currentQty - sellQty
        Dim cmdUpdateQty As New SqlCommand("UPDATE Products SET Quantity=@newQty WHERE ProductID=@id", conn)
        cmdUpdateQty.Parameters.AddWithValue("@newQty", newQty)
        cmdUpdateQty.Parameters.AddWithValue("@id", productId)
        cmdUpdateQty.ExecuteNonQuery()

        conn.Close()

        MessageBox.Show("Sale recorded and inventory updated successfully.")
        LoadProducts()
    End Sub
End Class
