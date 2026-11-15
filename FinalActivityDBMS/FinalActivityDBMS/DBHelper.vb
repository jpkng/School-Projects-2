Imports System.Data.SqlClient

Public Class DBHelper

    Public Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=ProjectForFinals;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function

    Private Sub DBHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class