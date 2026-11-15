Imports System.Data.SqlClient

Public Class UserManagementForm
    Private connectionString As String = "Data Source=GAY-ASS\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True"

    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.AddRange(New String() {"Admin", "Supervisor", "User"})
        LoadUsers()
    End Sub

    ' Load users into grid
    Private Sub LoadUsers()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT UserID, Username, Role FROM Users", conn)
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                dgvUsers.DataSource = dt
            End Using
        End Using
    End Sub

    ' Add new user (plain text password)
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If txtUMUsername.Text = "" OrElse txtUMPassword.Text = "" OrElse cmbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("INSERT INTO Users (Username, PasswordHash, Role) VALUES (@u,@p,@r)", conn)
                cmd.Parameters.AddWithValue("@u", txtUMUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@p", txtUMPassword.Text.Trim())  ' plain text password
                cmd.Parameters.AddWithValue("@r", cmbRole.SelectedItem.ToString())
                conn.Open()
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User added successfully.")
                    LoadUsers()
                    txtUMUsername.Clear()
                    txtUMPassword.Clear()
                    cmbRole.SelectedIndex = -1
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Update role of selected user
    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If dgvUsers.CurrentRow Is Nothing OrElse cmbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a user and role.")
            Return
        End If

        Dim userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells("UserID").Value)

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("UPDATE Users SET Role=@r WHERE UserID=@id", conn)
                cmd.Parameters.AddWithValue("@r", cmbRole.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@id", userId)
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("User role updated.")
                LoadUsers()
            End Using
        End Using
    End Sub

    ' Delete selected user
    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user.")
            Return
        End If

        Dim userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells("UserID").Value)

        If MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("DELETE FROM Users WHERE UserID=@id", conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User deleted.")
                    LoadUsers()
                End Using
            End Using
        End If
    End Sub

    ' Reset password (plain text)
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If dgvUsers.CurrentRow Is Nothing OrElse txtUMPassword.Text = "" Then
            MessageBox.Show("Select a user and enter a new password.")
            Return
        End If

        Dim userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells("UserID").Value)

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("UPDATE Users SET PasswordHash=@p WHERE UserID=@id", conn)
                cmd.Parameters.AddWithValue("@p", txtUMPassword.Text.Trim()) ' plain text password
                cmd.Parameters.AddWithValue("@id", userId)
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Password reset successfully.")
                LoadUsers()
                txtUMPassword.Clear()
            End Using
        End Using
    End Sub

    ' Close and return to AdminForm
    Private Sub btnUMClose_Click(sender As Object, e As EventArgs) Handles btnUMClose.Click
        Me.Close()
        AdminForm.Show()
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub
End Class
