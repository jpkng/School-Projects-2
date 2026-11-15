Imports System.Data.SqlClient

Public Class ProductForm
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Dim conn As SqlConnection = DBHelper.GetConnection()
        Dim adapter As New SqlDataAdapter("SELECT * FROM Products", conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim conn As SqlConnection = DBHelper.GetConnection()
        Dim cmd As New SqlCommand("INSERT INTO Products (ProductName, Price, Quantity) VALUES (@name, @price, @qty)", conn)
        cmd.Parameters.AddWithValue("@name", txtProductName.Text)
        cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text))
        cmd.Parameters.AddWithValue("@qty", Integer.Parse(txtQuantity.Text))
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        LoadProducts()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to edit.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("ProductID").Value)

        Dim conn As SqlConnection = DBHelper.GetConnection()
        Dim cmd As New SqlCommand("UPDATE Products SET ProductName=@name, Price=@price, Quantity=@qty WHERE ProductID=@id", conn)
        cmd.Parameters.AddWithValue("@name", txtProductName.Text)
        cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text))
        cmd.Parameters.AddWithValue("@qty", Integer.Parse(txtQuantity.Text))
        cmd.Parameters.AddWithValue("@id", productId)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        LoadProducts()
        MessageBox.Show("Product updated successfully.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("ProductID").Value)

        If MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim conn As SqlConnection = DBHelper.GetConnection()
            Dim cmd As New SqlCommand("DELETE FROM Products WHERE ProductID=@id", conn)
            cmd.Parameters.AddWithValue("@id", productId)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            LoadProducts()
            MessageBox.Show("Product deleted successfully.")
        End If
    End Sub
End Class
