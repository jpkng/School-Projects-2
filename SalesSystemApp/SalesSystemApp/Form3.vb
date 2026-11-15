Imports System.Data.SqlClient

Public Class ProductManagementForm
    Dim connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=SalesDBase;Integrated Security=True"

    Private Sub ProductManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    ' Load all products into DataGridView
    Private Sub LoadProducts()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT ProductID, ProductName, Price FROM Products"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvProducts.DataSource = dt
        End Using
    End Sub

    ' Add a new product
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim productName As String = txtProductName.Text.Trim()
        Dim price As Decimal

        ' Validation
        If String.IsNullOrWhiteSpace(productName) OrElse Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please enter valid product details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Insert into database
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Products (ProductName, Price) VALUES (@name, @price)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", productName)
                cmd.Parameters.AddWithValue("@price", price)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Refresh DataGridView
        LoadProducts()
        ClearFields()
    End Sub

    ' Select product from DataGridView and display in text fields
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            lblProductID.Text = row.Cells("ProductID").Value.ToString() ' Store ProductID for updating/deleting
        End If
    End Sub

    ' Edit selected product
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim productId As Integer
        Dim productName As String = txtProductName.Text.Trim()
        Dim price As Decimal

        ' Validation
        If Not Integer.TryParse(lblProductID.Text, productId) OrElse String.IsNullOrWhiteSpace(productName) OrElse Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please select a valid product and enter details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update database
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Products SET ProductName=@name, Price=@price WHERE ProductID=@id"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", productName)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@id", productId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Refresh DataGridView
        LoadProducts()
        ClearFields()
    End Sub

    ' Delete selected product
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim productId As Integer

        ' Validation
        If Not Integer.TryParse(lblProductID.Text, productId) Then
            MessageBox.Show("Please select a valid product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm deletion
        If MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM Products WHERE ProductID=@id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", productId)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Refresh DataGridView
            LoadProducts()
            ClearFields()
        End If
    End Sub

    ' Clear text fields
    Private Sub ClearFields()
        txtProductName.Clear()
        txtPrice.Clear()
        lblProductID.Text = ""
    End Sub
End Class
