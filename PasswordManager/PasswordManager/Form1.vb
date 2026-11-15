Imports System.Data.SqlClient
Imports System.IO

Public Class FormAdd
    Dim connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=PasswordDB;Integrated Security=True"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim keyword = txtKeyword.Text.Trim()
        Dim user = txtUsername.Text.Trim()
        Dim pass = txtPassword.Text
        Dim tag = txtTag.Text.Trim()

        If String.IsNullOrWhiteSpace(keyword) OrElse String.IsNullOrWhiteSpace(user) OrElse String.IsNullOrWhiteSpace(pass) Then
            MessageBox.Show("Keyword, Username and Password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Uses the  AESModule.AesKey
        Dim enc = Encrypt(pass)

        ' Try SQL first; if fails write to local fallback
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim cmd As New SqlCommand("INSERT INTO Credentials (Keyword, Username, Password, Tag) VALUES (@k, @u, @p, @t)", con)
                cmd.Parameters.AddWithValue("@k", keyword)
                cmd.Parameters.AddWithValue("@u", user)
                cmd.Parameters.AddWithValue("@p", enc)
                cmd.Parameters.AddWithValue("@t", If(String.IsNullOrEmpty(tag), DBNull.Value, CType(tag, Object)))
                cmd.ExecuteNonQuery()
                MessageBox.Show("Credential saved to SQL database.")
            End Using
        Catch ex As Exception
            ' On any SQL failure, persist to an encrypted local fallback file
            SaveCredentialToLocal(keyword, user, enc, tag)
            MessageBox.Show("SQL server not available. Saved locally (offline mode).")
        End Try

        txtKeyword.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtTag.Text = ""
    End Sub

    ' ---- Local fallback storage ----
    Private ReadOnly Property LocalStoragePath As String
        Get
            ' Folder in %LOCALAPPDATA%\PasswordManager
            Dim folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordManager")
            If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
            Return Path.Combine(folder, "localstore.dat")
        End Get
    End Property

    Private Sub SaveCredentialToLocal(keyword As String, username As String, encryptedPassword As String, tag As String)
        Dim list As New List(Of Dictionary(Of String, String))

        ' Load existing (decrypt file, then deserialize JSON)
        If File.Exists(LocalStoragePath) Then
            Try
                Dim encrypted = File.ReadAllText(LocalStoragePath)
                If Not String.IsNullOrEmpty(encrypted) Then
                    Dim json = Decrypt(encrypted) ' uses AESModule.AesKey
                    If Not String.IsNullOrEmpty(json) Then
                        list = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)
                    End If
                End If
            Catch ex As Exception
                list = New List(Of Dictionary(Of String, String))
            End Try
        End If

        Dim record As New Dictionary(Of String, String)
        record("Keyword") = keyword
        record("Username") = username
        record("Password") = encryptedPassword
        record("Tag") = tag
        list.Add(record)


        Dim jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(list)
        Dim encryptedOut = Encrypt(jsonOut)
        File.WriteAllText(LocalStoragePath, encryptedOut)
    End Sub

    Private Sub FormAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub
End Class
