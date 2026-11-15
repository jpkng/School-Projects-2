Imports System.Data.SqlClient

Module DatabaseHelper
    Public connectionString As String = "Data Source=GAY-ASS;Initial Catalog=LibraryPenaltyDB;Integrated Security=True"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Module
