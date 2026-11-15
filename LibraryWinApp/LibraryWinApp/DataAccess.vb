Imports System.Data
Imports System.Data.SqlClient

Public Class DataAccess
    Private ReadOnly connString As String = DbConfig.ConnectionString

    Public Function GetDataTable(query As String, Optional params As SqlParameter() = Nothing) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, con)
                If params IsNot Nothing Then cmd.Parameters.AddRange(params)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ExecuteNonQuery(query As String, Optional params As SqlParameter() = Nothing) As Integer
        Using con As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, con)
                If params IsNot Nothing Then cmd.Parameters.AddRange(params)
                con.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ExecuteScalar(Of T)(query As String, Optional params As SqlParameter() = Nothing) As T
        Using con As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, con)
                If params IsNot Nothing Then cmd.Parameters.AddRange(params)
                con.Open()
                Dim obj = cmd.ExecuteScalar()
                If obj Is Nothing OrElse obj Is DBNull.Value Then
                    Return Nothing
                End If
                Return CType(obj, T)
            End Using
        End Using
    End Function
End Class
