Imports System.Data.SqlClient

Public Class MainForm
    Public Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=ProjectForFinals;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sales and Inventory System"
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        Dim frm As New ProductForm()
        frm.showDialog()
    End Sub

    Private Sub NewSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSalesToolStripMenuItem.Click
        Dim frm As New SalesForm()
        frm.showDialog()
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        Dim frm As New SalesReportForm()
        frm.ShowDialog()
    End Sub
End Class
