Public Class FormMain

    ' A helper method to load forms into pnlChilds
    Private Sub LoadFormInPanel(childForm As Form)
        ' Clear existing controls inside pnlChilds
        pnlChilds.Controls.Clear()

        ' Configure the form to behave as a control inside the panel
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Add it to the panel and show
        pnlChilds.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        LoadFormInPanel(New FormAdd())
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        LoadFormInPanel(New FormView())
    End Sub

    Private Sub btnTestPassword_Click(sender As Object, e As EventArgs) Handles btnTestPassword.Click
        ' Load Password Strength Tester inside pnlChilds
        LoadFormInPanel(New FormStrengthTester())
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint
        ' optional if you want to handle custom drawing later
    End Sub
End Class
