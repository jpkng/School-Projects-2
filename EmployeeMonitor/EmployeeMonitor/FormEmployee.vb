Imports System.Data.SqlClient

Public Class FormEmployee
    Private ReadOnly connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=EmployeeDataBase;Integrated Security=True"

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim name = txtName.Text.Trim()
        Dim position = txtPosition.Text.Trim()
        Dim rate As Decimal

        If name = "" OrElse Not Decimal.TryParse(txtRate.Text, rate) Then
            MessageBox.Show("Please enter valid details.")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("INSERT INTO Employees (FullName, Position, RatePerDay) VALUES (@n,@p,@r)", conn)
                    cmd.Parameters.AddWithValue("@n", name)
                    cmd.Parameters.AddWithValue("@p", position)
                    cmd.Parameters.AddWithValue("@r", rate)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Employee added successfully.")
            txtName.Clear() : txtPosition.Clear() : txtRate.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
