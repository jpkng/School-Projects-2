Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnToEmployee_Click(sender As Object, e As EventArgs) Handles btnToEmployee.Click
        Dim f As New FormEmployee
        f.ShowDialog()
    End Sub

    Private Sub btnToAttendance_Click(sender As Object, e As EventArgs) Handles btnToAttendance.Click
        Dim f As New FormAttendance
        f.ShowDialog()
    End Sub

    Private Sub btnToSalary_Click(sender As Object, e As EventArgs) Handles btnToSalary.Click
        Dim f As New FormSalary
        f.ShowDialog()
    End Sub
End Class
