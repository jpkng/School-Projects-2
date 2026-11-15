Public Class Form1
    Private Sub btnStringCompare_Click(sender As Object, e As EventArgs) Handles btnStringCompare.Click
        'Declare variable
        Dim strName As String

        'get the name
        strName = txtName2.Text

        'Compare the name
        If String.Compare(strName, "STEPHANIE", True) = 0 Then
            MsgBox("Hello, Stephanie")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName1.TextChanged

    End Sub
End Class
