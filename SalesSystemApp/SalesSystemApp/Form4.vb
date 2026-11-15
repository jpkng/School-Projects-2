Imports System.Data.SqlClient

Public Class SalesTransactionForm
    Dim connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=SalesDBase;Integrated Security=True"

    Private Sub SalesTransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    ' Load products into ComboBox
    Private Sub LoadProducts()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT ProductID, ProductName FROM Products"
            Dim da As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            cmbProducts.DataSource = dt
            cmbProducts.DisplayMember = "ProductName"
            cmbProducts.ValueMember = "ProductID"
        End Using
    End Sub

    ' Function to get product price from database
    Private Function GetProductPrice(productId As Integer) As Decimal
        Dim price As Decimal = 0
        Dim query As String = "SELECT Price FROM Products WHERE ProductID = @id"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", productId)
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    price = Convert.ToDecimal(result)
                End If
            End Using
        End Using

        Return price
    End Function

    ' Auto-fill price when selecting a product
    Private Sub cmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducts.SelectedIndexChanged
        If cmbProducts.SelectedIndex >= 0 Then
            Dim selectedProductId As Integer = Convert.ToInt32(cmbProducts.SelectedValue)
            txtPrice.Text = GetProductPrice(selectedProductId).ToString("0.00")
        End If
    End Sub

    ' Create a new sales transaction
    Private Sub btnCreateSale_Click(sender As Object, e As EventArgs) Handles btnCreateSale.Click
        Dim productId As Integer
        Dim quantity As Integer
        Dim total As Decimal

        ' Validate input
        If cmbProducts.SelectedIndex < 0 OrElse Not Integer.TryParse(cmbProducts.SelectedValue.ToString(), productId) Then
            MessageBox.Show("Please select a valid product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate total price
        Dim price As Decimal = GetProductPrice(productId)
        total = price * quantity

        ' Insert into Sales and SalesDetails table
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                ' Insert into Sales table
                Dim salesQuery As String = "INSERT INTO Sales (UserID, SaleDate, TotalAmount) VALUES (1, GETDATE(), @total); SELECT SCOPE_IDENTITY();"
                Dim saleId As Integer

                Using cmd As New SqlCommand(salesQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@total", total)
                    saleId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Insert into SalesDetails table
                Dim detailQuery As String = "INSERT INTO SalesDetails (SaleID, ProductID, Quantity, Price) VALUES (@saleId, @productId, @quantity, @price)"
                Using cmd As New SqlCommand(detailQuery, conn, transaction)
                    cmd.Parameters.AddWithValue("@saleId", saleId)
                    cmd.Parameters.AddWithValue("@productId", productId)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.ExecuteNonQuery()
                End Using

                transaction.Commit()
                MessageBox.Show("Sale created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error creating sale: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
