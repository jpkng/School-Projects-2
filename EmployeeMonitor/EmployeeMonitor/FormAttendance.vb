Imports System.Data.SqlClient

Public Class FormAttendance
    Private ReadOnly connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=EmployeeDataBase;Integrated Security=True"

    Private Sub FormAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.AddRange(New String() {"present", "absent", "late"})
        cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Dim empId As Integer
        If Not Integer.TryParse(txtEmpID1.Text.Trim(), empId) Then
            MessageBox.Show("Invalid Employee ID")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("INSERT INTO Attendance (EmployeeID, DatePresent, Status) VALUES (@id,@d,@s)", conn)
                    cmd.Parameters.AddWithValue("@id", empId)
                    cmd.Parameters.AddWithValue("@d", dtpDate.Value.Date)
                    cmd.Parameters.AddWithValue("@s", cmbStatus.SelectedItem.ToString().ToLower())
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Attendance recorded.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
