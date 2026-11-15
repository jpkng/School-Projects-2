Imports System.Data.SqlClient

Public Class SalesReportForm
    Private Sub SalesReportForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSalesReport()
    End Sub

    Private Sub LoadSalesReport()
        Dim conn As SqlConnection = DBHelper.GetConnection()
        Dim query As String = "
            SELECT 
                S.SaleID,
                S.SaleDate,
                P.ProductName,
                D.Quantity,
                D.Price,
                (D.Quantity * D.Price) AS Total
            FROM 
                Sales S
            INNER JOIN SaleDetails D ON S.SaleID = D.SaleID
            INNER JOIN Products P ON D.ProductID = P.ProductID
            ORDER BY S.SaleDate DESC
        "
        Dim adapter As New SqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class
