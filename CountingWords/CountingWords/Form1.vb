Public Class Form1

    ' Function to count characters in the text box
    Private Function CountCharacters(ByVal text As String) As Integer
        Return text.Length
    End Function

    ' Function to count words in the text box
    Private Function CountWords(ByVal text As String) As Integer
        ' Check if the text box is empty
        If txtWords.Text = String.Empty Then Return 0

        ' Split the words based on spaces
        Dim strWords() As String = text.Split(" "c)

        ' Return the number of words
        Return strWords.Length
    End Function

    ' Method to update the display based on the selected radio button
    Private Sub UpdateDisplay()
        ' Check if the words radio button is selected
        If radCountWords.Checked = True Then
            lblResults.Text = CountWords(txtWords.Text) & " words"
        Else
            lblResults.Text = CountCharacters(txtWords.Text) & " characters"
        End If
    End Sub

    ' Event handler for text box text change
    Private Sub txtWords_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWords.TextChanged
        UpdateDisplay()
    End Sub

    ' Event handler for changing radio button selection to words
    Private Sub radCountWords_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radCountWords.CheckedChanged
        UpdateDisplay()
    End Sub

    ' Event handler for changing radio button selection to characters
    Private Sub radCountChars_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radCountChars.CheckedChanged
        UpdateDisplay()
    End Sub

    ' Event handler for clicking the "Show Me!" button
    Private Sub btnShowMe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowMe.Click
        MessageBox.Show(lblResults.Text, "Word Counter")
    End Sub

End Class
