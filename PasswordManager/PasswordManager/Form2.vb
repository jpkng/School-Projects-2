Imports System.Data.SqlClient
Imports System.IO
Imports Newtonsoft.Json
Imports System.Security.Cryptography

Public Class FormView
    ' Connection string to the local SQL Server instance (adjust as needed)
    Dim connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=PasswordDB;Integrated Security=True"
    Private Const MASTER_PASSWORD As String = "letmein" ' simple master password used for protected actions

    Private ReadOnly toolTipInfo As New ToolTip()

    Private Sub FormView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Basic UI behavior
        dgvCredentials.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCredentials.MultiSelect = False

        PopulateFilters()
        toolTipInfo.IsBalloon = True
        toolTipInfo.ShowAlways = True

        ' ensure grid has no selection at start
        dgvCredentials.DataSource = Nothing
        dgvCredentials.ClearSelection()
    End Sub

    ' ----------- FILTER/TAG SETUP -----------
    Private Sub PopulateFilters()
        cmbFilters.Items.Clear()
        ' Try SQL first; if unavailable, fall back to local store
        If TryConnectToSql() Then
            Try
                Using con As New SqlConnection(connectionString)
                    con.Open()
                    Dim cmd As New SqlCommand("SELECT DISTINCT Tag FROM Credentials WHERE Tag IS NOT NULL AND TRIM(Tag) <> ''", con)
                    Dim reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim t = reader("Tag").ToString()
                        If Not String.IsNullOrWhiteSpace(t) AndAlso Not cmbFilters.Items.Contains(t) Then
                            cmbFilters.Items.Add(t)
                        End If
                    End While
                End Using
            Catch
                LoadFiltersFromLocal()
            End Try
        Else
            LoadFiltersFromLocal()
        End If

        If cmbFilters.Items.Count > 0 Then cmbFilters.SelectedIndex = 0
    End Sub

    Private Sub LoadFiltersFromLocal()
        Try
            Dim path = LocalStoragePath
            If Not File.Exists(path) Then Return
            Dim encrypted = File.ReadAllText(path)
            If String.IsNullOrEmpty(encrypted) Then Return
            Dim json = SafeDecrypt(encrypted)
            If String.IsNullOrEmpty(json) Then Return
            Dim list = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)
            Dim tags = list.
                Where(Function(d) d.ContainsKey("Tag") AndAlso Not String.IsNullOrEmpty(d("Tag"))).
                Select(Function(d) d("Tag")).Distinct()
            For Each t In tags
                If Not cmbFilters.Items.Contains(t) Then cmbFilters.Items.Add(t)
            Next
        Catch
            ' ignore any local read/decrypt errors
        End Try
    End Sub

    ' ----------- SEARCH HANDLER -----------
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If chkViewByFilter.Checked Then
            If Not ValidateMasterPassword() Then Return
            If cmbFilters.SelectedItem Is Nothing Then
                MessageBox.Show("Select a filter/tag first.")
                Return
            End If
            LoadCredentialsByFilter(cmbFilters.SelectedItem.ToString())
        Else
            LoadCredentialsByKeyword(txtKeywordSearch.Text.Trim())
        End If
    End Sub

    Private Function ValidateMasterPassword() As Boolean
        Dim input = InputBox("Enter master password to view by filters/tags:", "Master Password")
        If input <> MASTER_PASSWORD Then
            MessageBox.Show("Incorrect master password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' ----------- LOAD BY KEYWORD OR FILTER -----------
    Private Sub LoadCredentialsByKeyword(keyword As String)
        If String.IsNullOrEmpty(keyword) Then
            MessageBox.Show("Please enter a keyword to search.")
            Return
        End If

        If TryConnectToSql() Then
            Try
                Using con As New SqlConnection(connectionString)
                    con.Open()
                    Dim cmd As New SqlCommand("SELECT * FROM Credentials WHERE LOWER(Keyword) LIKE LOWER(@k)", con)
                    cmd.Parameters.AddWithValue("@k", "%" & keyword & "%")
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Decrypt stored passwords safely before showing them in the UI
                    For Each row As DataRow In table.Rows
                        row("Password") = SafeDecryptCell(row("Password").ToString())
                    Next

                    dgvCredentials.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error reading from SQL: " & ex.Message)
            End Try
        Else
            Dim table = LoadLocalAsDataTable()
            Dim filtered = table.Select($"Keyword = '{EscapeForSelect(keyword)}'")
            Dim result = If(filtered.Length > 0, filtered.CopyToDataTable(), table.Clone())
            dgvCredentials.DataSource = result
        End If

        dgvCredentials.ClearSelection()
    End Sub

    Private Sub LoadCredentialsByFilter(tag As String)
        If TryConnectToSql() Then
            Try
                Using con As New SqlConnection(connectionString)
                    con.Open()
                    Dim cmd As New SqlCommand("SELECT * FROM Credentials WHERE Tag = @t", con)
                    cmd.Parameters.AddWithValue("@t", tag)
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    For Each row As DataRow In table.Rows
                        row("Password") = SafeDecryptCell(row("Password").ToString())
                    Next

                    dgvCredentials.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error reading from SQL: " & ex.Message)
            End Try
        Else
            Dim table = LoadLocalAsDataTable()
            Dim filtered = table.Select($"Tag = '{EscapeForSelect(tag)}'")
            Dim result = If(filtered.Length > 0, filtered.CopyToDataTable(), table.Clone())
            dgvCredentials.DataSource = result
        End If

        dgvCredentials.ClearSelection()
    End Sub

    ' ----------- DELETE HANDLER -----------
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCredentials.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a record to delete.")
            Return
        End If

        ' Confirm deletion explicitly
        Dim confirm = MessageBox.Show("Are you sure you want to delete the selected record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        ' Temporarily disable edit button to avoid accidental triggers
        Dim prevEditEnabled = btnEdit.Enabled
        btnEdit.Enabled = False

        Try
            Dim selectedRow = dgvCredentials.SelectedRows(0)
            Dim idObj = selectedRow.Cells("ID").Value
            Dim idOk As Integer

            If idObj IsNot Nothing AndAlso Integer.TryParse(idObj.ToString(), idOk) Then
                If TryConnectToSql() Then
                    Using con As New SqlConnection(connectionString)
                        con.Open()
                        Dim cmd As New SqlCommand("DELETE FROM Credentials WHERE ID = @id", con)
                        cmd.Parameters.AddWithValue("@id", idOk)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Deleted from SQL database.")
                Else
                    Dim kw = selectedRow.Cells("Keyword").Value.ToString()
                    Dim usr = selectedRow.Cells("Username").Value.ToString()
                    RemoveLocalRecord(kw, usr)
                    MessageBox.Show("Deleted from local store.")
                End If

                ' After delete, clear selection and refresh grid according to current mode
                dgvCredentials.ClearSelection()

                If chkViewByFilter.Checked AndAlso cmbFilters.SelectedItem IsNot Nothing Then
                    LoadCredentialsByFilter(cmbFilters.SelectedItem.ToString())
                Else
                    Dim currentKeyword = txtKeywordSearch.Text.Trim()
                    If Not String.IsNullOrEmpty(currentKeyword) Then
                        LoadCredentialsByKeyword(currentKeyword)
                    Else
                        dgvCredentials.DataSource = Nothing
                    End If
                End If

                PopulateFilters()
            Else
                MessageBox.Show("Selected record has no valid ID.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        Finally
            ' restore edit button state
            btnEdit.Enabled = prevEditEnabled
            dgvCredentials.ClearSelection()
        End Try
    End Sub

    ' ----------- EDIT HANDLER -----------
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvCredentials.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a record to edit.")
            Return
        End If

        Dim row = dgvCredentials.SelectedRows(0)
        Dim idObj = row.Cells("ID").Value
        Dim oldUser = If(row.Cells("Username").Value IsNot Nothing, row.Cells("Username").Value.ToString(), "")
        Dim oldPass = If(row.Cells("Password").Value IsNot Nothing, row.Cells("Password").Value.ToString(), "")
        Dim oldTag = If(row.Cells("Tag").Value IsNot Nothing, row.Cells("Tag").Value.ToString(), "")

        ' Prompt user for new values
        Dim newUser = InputBox("Enter new Username:", "Edit Username", oldUser)
        Dim newPass = InputBox("Enter new Password:", "Edit Password", oldPass)
        Dim newTag = InputBox("Enter Tag/Filter (Social, Entertainment, Office Work, Banking, Others):", "Edit Tag", oldTag)

        If String.IsNullOrWhiteSpace(newUser) OrElse String.IsNullOrWhiteSpace(newPass) Then
            MessageBox.Show("Username and Password cannot be empty.")
            Return
        End If

        Dim enc = Encrypt(newPass)
        Dim id As Integer
        Dim updatedSuccessfully As Boolean = False

        If TryConnectToSql() AndAlso idObj IsNot Nothing AndAlso Integer.TryParse(idObj.ToString(), id) Then
            Try
                Using con As New SqlConnection(connectionString)
                    con.Open()
                    Dim cmd As New SqlCommand("UPDATE Credentials SET Username = @u, Password = @p, Tag = @t WHERE ID = @id", con)
                    cmd.Parameters.AddWithValue("@u", newUser)
                    cmd.Parameters.AddWithValue("@p", enc)
                    cmd.Parameters.AddWithValue("@t", If(String.IsNullOrEmpty(newTag), DBNull.Value, CType(newTag, Object)))
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
                updatedSuccessfully = True
                MessageBox.Show("Record updated successfully in SQL.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("SQL update failed: " & ex.Message)
            End Try
        Else
            Try
                Dim kw = row.Cells("Keyword").Value.ToString()
                UpdateLocalRecord(kw, oldUser, newUser, enc, newTag)
                updatedSuccessfully = True
                MessageBox.Show("Record updated successfully in local storage.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Local update failed: " & ex.Message)
            End Try
        End If

        ' Auto-refresh the DataGridView and filters after update
        If updatedSuccessfully Then
            If chkViewByFilter.Checked AndAlso cmbFilters.SelectedItem IsNot Nothing Then
                LoadCredentialsByFilter(cmbFilters.SelectedItem.ToString())
            Else
                Dim currentKeyword = txtKeywordSearch.Text.Trim()
                If Not String.IsNullOrEmpty(currentKeyword) Then
                    LoadCredentialsByKeyword(currentKeyword)
                Else
                    dgvCredentials.DataSource = Nothing
                End If
            End If

            PopulateFilters()
        End If
    End Sub

    ' ----------- LOCAL STORAGE HELPERS -----------
    Private ReadOnly Property LocalStoragePath As String
        Get
            Dim folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PasswordManager")
            If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
            Return Path.Combine(folder, "localstore.dat")
        End Get
    End Property

    Private Function LoadLocalAsDataTable() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Keyword", GetType(String))
        dt.Columns.Add("Username", GetType(String))
        dt.Columns.Add("Password", GetType(String))
        dt.Columns.Add("Tag", GetType(String))

        If Not File.Exists(LocalStoragePath) Then Return dt

        Try
            Dim encrypted = File.ReadAllText(LocalStoragePath)
            If String.IsNullOrEmpty(encrypted) Then Return dt
            Dim json = SafeDecrypt(encrypted)
            If String.IsNullOrEmpty(json) Then Return dt
            Dim list = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)
            Dim idCounter = 1
            For Each rec In list
                Dim row = dt.NewRow()
                row("ID") = idCounter
                row("Keyword") = If(rec.ContainsKey("Keyword"), rec("Keyword"), "")
                row("Username") = If(rec.ContainsKey("Username"), rec("Username"), "")
                Dim encryptedPass = If(rec.ContainsKey("Password"), rec("Password"), "")
                row("Password") = SafeDecryptCell(encryptedPass)
                row("Tag") = If(rec.ContainsKey("Tag"), rec("Tag"), "")
                dt.Rows.Add(row)
                idCounter += 1
            Next
        Catch
            ' ignore any local read/decrypt/deserialize errors
        End Try

        Return dt
    End Function

    Private Sub RemoveLocalRecord(keyword As String, username As String)
        Try
            If Not File.Exists(LocalStoragePath) Then Return
            Dim encrypted = File.ReadAllText(LocalStoragePath)
            Dim json = SafeDecrypt(encrypted)
            If String.IsNullOrEmpty(json) Then Return
            Dim list = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)
            list.RemoveAll(Function(d) d("Keyword") = keyword AndAlso d("Username") = username)
            Dim out = JsonConvert.SerializeObject(list)
            File.WriteAllText(LocalStoragePath, Encrypt(out))
        Catch
            ' ignore
        End Try
    End Sub

    Private Sub UpdateLocalRecord(keyword As String, oldUsername As String, newUsername As String, newEncryptedPass As String, newTag As String)
        Try
            If Not File.Exists(LocalStoragePath) Then Return
            Dim encrypted = File.ReadAllText(LocalStoragePath)
            Dim json = SafeDecrypt(encrypted)
            If String.IsNullOrEmpty(json) Then Return
            Dim list = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(json)
            For Each rec In list
                If rec.ContainsKey("Keyword") AndAlso rec("Keyword") = keyword AndAlso rec.ContainsKey("Username") AndAlso rec("Username") = oldUsername Then
                    rec("Username") = newUsername
                    rec("Password") = newEncryptedPass
                    rec("Tag") = newTag
                End If
            Next
            Dim out = JsonConvert.SerializeObject(list)
            File.WriteAllText(LocalStoragePath, Encrypt(out))
        Catch
            ' ignore
        End Try
    End Sub

    ' ----------- UTILITY -----------
    Private Function TryConnectToSql() As Boolean
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Function EscapeForSelect(value As String) As String
        Return value.Replace("'", "''")
    End Function

    ' Safe decrypt helpers to avoid padding errors for non-encrypted strings
    Private Function SafeDecryptCell(cipherText As String) As String
        If String.IsNullOrEmpty(cipherText) Then Return ""
        Try
            Return Decrypt(cipherText)
        Catch ex As CryptographicException
            ' If decryption fails, return the original text assuming it is plaintext
            Return cipherText
        Catch
            Return cipherText
        End Try
    End Function

    Private Function SafeDecrypt(cipherText As String) As String
        If String.IsNullOrEmpty(cipherText) Then Return ""
        Try
            Return Decrypt(cipherText)
        Catch
            Return ""
        End Try
    End Function

    ' ----------- DGV PASSWORD COPY HANDLER -----------
    Private Sub dgvCredentials_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCredentials.CellContentClick
        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

            Dim colName = dgvCredentials.Columns(e.ColumnIndex).Name
            If String.Equals(colName, "Password", StringComparison.OrdinalIgnoreCase) Then
                Dim valObj = dgvCredentials.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                If valObj Is Nothing Then
                    toolTipInfo.Show("No password to copy", dgvCredentials, Cursor.Position.X - Me.Location.X, Cursor.Position.Y - Me.Location.Y, 1200)
                    Return
                End If

                Dim pwd As String = valObj.ToString()
                If String.IsNullOrEmpty(pwd) Then
                    toolTipInfo.Show("No password to copy", dgvCredentials, Cursor.Position.X - Me.Location.X, Cursor.Position.Y - Me.Location.Y, 1200)
                    Return
                End If

                Clipboard.SetText(pwd)

                Dim cellRect = dgvCredentials.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
                Dim showX = Math.Max(0, cellRect.X + cellRect.Width \ 2)
                Dim showY = Math.Max(0, cellRect.Y + cellRect.Height \ 2)
                toolTipInfo.Show("Password copied to clipboard", dgvCredentials, showX, showY, 1500)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to copy to clipboard: " & ex.Message, "Clipboard error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub pnlContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlContainer.Paint
        ' no custom painting required
    End Sub
End Class
