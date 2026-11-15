Imports System.Data.SqlClient

Public Class FormSalary
    Private ReadOnly connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=EmployeeDataBase;Integrated Security=True"

    Private Sub FormSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpMonth.Format = DateTimePickerFormat.Custom
        dtpMonth.CustomFormat = "MMMM yyyy"
    End Sub

    Private Sub btnSalary_Click(sender As Object, e As EventArgs) Handles btnSalary.Click
        Dim empId As Integer
        If Not Integer.TryParse(txtEmpID2.Text.Trim(), empId) Then
            MessageBox.Show("Invalid Employee ID")
            Return
        End If

        Dim startDate As Date = New Date(dtpMonth.Value.Year, dtpMonth.Value.Month, 1)
        Dim endDate As Date = startDate.AddMonths(1).AddDays(-1)

        Try
            Dim daysPresent As Integer = 0
            Dim ratePerDay As Decimal = 0

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmd1 As New SqlCommand("SELECT RatePerDay FROM Employees WHERE EmployeeID=@id", conn)
                    cmd1.Parameters.AddWithValue("@id", empId)
                    Dim val = cmd1.ExecuteScalar()
                    If val Is Nothing Then
                        MessageBox.Show("Employee not found.")
                        Return
                    End If
                    ratePerDay = Convert.ToDecimal(val)
                End Using

                Using cmd2 As New SqlCommand("SELECT COUNT(*) FROM Attendance WHERE EmployeeID=@id AND Status='present' AND DatePresent BETWEEN @s AND @e", conn)
                    cmd2.Parameters.AddWithValue("@id", empId)
                    cmd2.Parameters.AddWithValue("@s", startDate)
                    cmd2.Parameters.AddWithValue("@e", endDate)
                    daysPresent = Convert.ToInt32(cmd2.ExecuteScalar())
                End Using
            End Using

            Dim totalSalary = daysPresent * ratePerDay
            lblSalary.Text = totalSalary.ToString("C2")

            Dim monthKey As String = startDate.ToString("yyyy-MM")
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Using cmdCheck As New SqlCommand("SELECT SalaryID FROM Salary WHERE EmployeeID=@id AND MonthCovered=@m", conn)
                    cmdCheck.Parameters.AddWithValue("@id", empId)
                    cmdCheck.Parameters.AddWithValue("@m", monthKey)
                    Dim existing = cmdCheck.ExecuteScalar()
                    If existing IsNot Nothing Then
                        Using upd As New SqlCommand("UPDATE Salary SET TotalDaysPresent=@d, TotalSalary=@s WHERE SalaryID=@sid", conn)
                            upd.Parameters.AddWithValue("@d", daysPresent)
                            upd.Parameters.AddWithValue("@s", totalSalary)
                            upd.Parameters.AddWithValue("@sid", existing)
                            upd.ExecuteNonQuery()
                        End Using
                    Else
                        Using ins As New SqlCommand("INSERT INTO Salary (EmployeeID, MonthCovered, TotalDaysPresent, TotalSalary) VALUES (@id,@m,@d,@s)", conn)
                            ins.Parameters.AddWithValue("@id", empId)
                            ins.Parameters.AddWithValue("@m", monthKey)
                            ins.Parameters.AddWithValue("@d", daysPresent)
                            ins.Parameters.AddWithValue("@s", totalSalary)
                            ins.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using

            MessageBox.Show("Salary computed & saved.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
