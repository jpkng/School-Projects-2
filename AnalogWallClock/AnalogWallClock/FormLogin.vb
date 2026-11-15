Imports System.Data.SqlClient

Public Class FormLogin
    Private connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=ClockAttendance;Integrated Security=True"

    ' LOGIN button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim empID As String = txtEmployeeID.Text.Trim()

        If empID = "" Then
            MessageBox.Show("Please enter your Employee ID.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' 🔹 1. Get Employee Name
                Dim empName As String = ""
                Dim empCmd As New SqlCommand("SELECT EmployeeName FROM tblEmployee WHERE EmployeeID=@id", conn)
                empCmd.Parameters.AddWithValue("@id", empID)
                Dim result As Object = empCmd.ExecuteScalar()

                If result Is Nothing Then
                    MessageBox.Show("Employee ID not found. Please contact admin.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                Else
                    empName = result.ToString()
                End If

                ' 🔹 2. Auto-close old sessions with no logout time
                Dim fixOld As New SqlCommand("UPDATE tblAttendance SET LogoutTime=@now WHERE EmployeeID=@id AND LogoutTime IS NULL", conn)
                fixOld.Parameters.AddWithValue("@id", empID)
                fixOld.Parameters.AddWithValue("@now", DateTime.Now)
                fixOld.ExecuteNonQuery()

                ' 🔹 3. Insert new login record WITH employee name
                Dim cmd As New SqlCommand("INSERT INTO tblAttendance (EmployeeID, EmployeeName, LoginTime) VALUES (@id, @name, @login)", conn)
                cmd.Parameters.AddWithValue("@id", empID)
                cmd.Parameters.AddWithValue("@name", empName)
                cmd.Parameters.AddWithValue("@login", DateTime.Now)
                cmd.ExecuteNonQuery()

                MessageBox.Show($"Welcome {empName}! Login successful at {DateTime.Now:hh:mm:ss tt}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEmployeeID.Clear()
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' LOGOUT button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim empID As String = txtEmployeeID.Text.Trim()

        If empID = "" Then
            MessageBox.Show("Please enter your Employee ID.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' 🔹 Find latest active session
                Dim checkCmd As New SqlCommand("SELECT TOP 1 ID FROM tblAttendance WHERE EmployeeID=@id AND LogoutTime IS NULL ORDER BY LoginTime DESC", conn)
                checkCmd.Parameters.AddWithValue("@id", empID)
                Dim result As Object = checkCmd.ExecuteScalar()

                If result Is Nothing Then
                    MessageBox.Show("You are not currently logged in.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                ' 🔹 Update logout time
                Dim updateCmd As New SqlCommand("UPDATE tblAttendance SET LogoutTime=@logout WHERE ID=@id", conn)
                updateCmd.Parameters.AddWithValue("@logout", DateTime.Now)
                updateCmd.Parameters.AddWithValue("@id", CInt(result))
                updateCmd.ExecuteNonQuery()

                MessageBox.Show("Logout successful at " & DateTime.Now.ToString("hh:mm:ss tt"),
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEmployeeID.Clear()
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' OPEN CLOCK button
    Private Sub btnOpenClock_Click(sender As Object, e As EventArgs) Handles btnOpenClock.Click
        Dim clockForm As New Form1() ' Opens your existing analog + digital clock
        clockForm.Show()
    End Sub
End Class
