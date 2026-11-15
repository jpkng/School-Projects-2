Imports System.Data.SqlClient

Public Class ReportingForm
    Dim connectionString As String = "Data Source=YOUR_SERVER;Initial Catalog=SalesDBase;Integrated Security=True"

    ' Load all sales transactions on form load
    Private Sub ReportingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = DateTime.Today.AddDays(-30) ' Default: last 30 days
        dtpTo.Value = DateTime.Today
        LoadSalesReport()
    End Sub

    ' Load sales transactions based on date range
    Private Sub LoadSalesReport()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT s.SaleID, s.SaleDate, u.Username, SUM(sd.Quantity * p.Price) AS TotalAmount 
                                   FROM Sales s
                                   JOIN Users u ON s.UserID = u.UserID
                                   JOIN SalesDetails sd ON s.SaleID = sd.SaleID
                                   JOIN Products p ON sd.ProductID = p.ProductID
                                   WHERE s.SaleDate BETWEEN @fromDate AND @toDate
                                   GROUP BY s.SaleID, s.SaleDate, u.Username"

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@fromDate", dtpFrom.Value.Date)
            cmd.Parameters.AddWithValue("@toDate", dtpTo.Value.Date)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvSalesReport.DataSource = dt
        End Using
    End Sub

    ' Generate report button click
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        LoadSalesReport()
    End Sub
End Class
