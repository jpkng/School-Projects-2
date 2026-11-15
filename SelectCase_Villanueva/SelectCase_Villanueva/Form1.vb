Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData.SelectedIndexChanged
        'Declare vaiables
        Dim strName As String
        Dim strFavoriteColor As String

        strName = lstData.Items(lstData.SelectedIndex)
        Select Case strName
            Case "Bryan"
                strFavoriteColor = "Madras Yellow"
            Case "Stepanie"
                strFavoriteColor = "Sea Blue"
            Case "Cathy"
                strFavoriteColor = "Morning Mist"
            Case "Betty"
                strFavoriteColor = "Passionate purple"
            Case "Edward"
                strFavoriteColor = "Battleship Gray"

        End Select
        MsgBox(strName & " 's Favorite color is " & strFavoriteColor)
    End Sub
End Class
