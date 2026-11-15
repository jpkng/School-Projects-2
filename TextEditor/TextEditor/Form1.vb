Public Class Form1
    ' Reference controls within Form1 instead of a separate class
    ' Ensure txtEdit and sspStatus exist on the form

    ' Method to clear the text box
    Private Sub ClearEditBox()
        txtEdit.Text = String.Empty
        txtEdit.ForeColor = Color.Black
        sspStatus.Text = "Text box cleared"
    End Sub

    ' Method to set text color to red
    Private Sub RedText()
        txtEdit.ForeColor = Color.Red
        sspStatus.Text = "The text is red"
    End Sub

    ' Method to set text color to blue
    Private Sub BlueText()
        txtEdit.ForeColor = Color.Blue
        sspStatus.Text = "The text is blue"
    End Sub

    ' Method to convert text to uppercase
    Private Sub UppercaseText()
        txtEdit.Text = txtEdit.Text.ToUpper()
        sspStatus.Text = "The text is all uppercase"
    End Sub

    ' Method to convert text to lowercase
    Private Sub LowercaseText()
        txtEdit.Text = txtEdit.Text.ToLower()
        sspStatus.Text = "The text is all lowercase"
    End Sub

    ' Button event handlers
    Private Sub tbrClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrClear.Click
        ClearEditBox()
    End Sub

    Private Sub tbrRed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrRed.Click
        RedText()
    End Sub

    Private Sub tbrBlue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrBlue.Click
        BlueText()
    End Sub

    Private Sub tbrUpperCase_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrUpperCase.Click
        UppercaseText()
    End Sub

    Private Sub tbrLowerCase_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrLowerCase.Click
        LowercaseText()
    End Sub

    ' Show About dialog
    Private Sub ShowAboutBox()
        Dim objAbout As New About
        objAbout.ShowDialog(Me)
    End Sub

    Private Sub tbrHelpAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrHelpAbout.Click
        ShowAboutBox()
    End Sub

    ' Update status text when text changes
    Private Sub txtEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEdit.TextChanged
        sspStatus.Text = "Ready"
    End Sub
End Class
