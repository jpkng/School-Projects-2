Imports System.Data.SqlClient

Module DatabaseModule

    Public connectionString As String =
        "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=UserMaintenanceDB;Integrated Security=True"

    Public con As New SqlConnection(connectionString)

End Module