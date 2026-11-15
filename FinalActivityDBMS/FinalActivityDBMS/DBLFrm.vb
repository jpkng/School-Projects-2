Imports System.Data.SqlClient
Public Class DBLFrm

    Public Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=ProjectForFinals;Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub DBLFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class