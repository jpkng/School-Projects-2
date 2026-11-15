<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUMUsername = New System.Windows.Forms.TextBox()
        Me.txtUMPassword = New System.Windows.Forms.TextBox()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.btnUMClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(298, 12)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(480, 426)
        Me.dgvUsers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txtUMUsername
        '
        Me.txtUMUsername.Location = New System.Drawing.Point(103, 21)
        Me.txtUMUsername.Name = "txtUMUsername"
        Me.txtUMUsername.Size = New System.Drawing.Size(189, 20)
        Me.txtUMUsername.TabIndex = 3
        '
        'txtUMPassword
        '
        Me.txtUMPassword.Location = New System.Drawing.Point(103, 47)
        Me.txtUMPassword.Name = "txtUMPassword"
        Me.txtUMPassword.Size = New System.Drawing.Size(189, 20)
        Me.txtUMPassword.TabIndex = 4
        Me.txtUMPassword.UseSystemPasswordChar = True
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(103, 73)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(121, 21)
        Me.cmbRole.TabIndex = 5
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(101, 112)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(107, 39)
        Me.btnAddUser.TabIndex = 6
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.Location = New System.Drawing.Point(101, 157)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(107, 37)
        Me.btnUpdateUser.TabIndex = 7
        Me.btnUpdateUser.Text = "Update User"
        Me.btnUpdateUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(103, 246)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(105, 40)
        Me.btnDeleteUser.TabIndex = 8
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnResetPassword
        '
        Me.btnResetPassword.Location = New System.Drawing.Point(101, 200)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(107, 40)
        Me.btnResetPassword.TabIndex = 9
        Me.btnResetPassword.Text = "ResetPassword"
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'btnUMClose
        '
        Me.btnUMClose.Location = New System.Drawing.Point(103, 292)
        Me.btnUMClose.Name = "btnUMClose"
        Me.btnUMClose.Size = New System.Drawing.Size(107, 42)
        Me.btnUMClose.TabIndex = 10
        Me.btnUMClose.Text = "Close"
        Me.btnUMClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Role:"
        '
        'UserManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUMClose)
        Me.Controls.Add(Me.btnResetPassword)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.txtUMPassword)
        Me.Controls.Add(Me.txtUMUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvUsers)
        Me.Name = "UserManagementForm"
        Me.Text = "UserManagementForm"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUMUsername As TextBox
    Friend WithEvents txtUMPassword As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnUMClose As Button
    Friend WithEvents Label3 As Label
End Class
