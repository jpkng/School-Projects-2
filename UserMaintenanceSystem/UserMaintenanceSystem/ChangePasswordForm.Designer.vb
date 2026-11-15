<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(191, 64)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(238, 20)
        Me.txtNewPassword.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Password:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(191, 156)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 36)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update Password"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(188, 39)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(191, 101)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(238, 20)
        Me.txtConfirmPassword.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Confirm Password:"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(191, 133)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPassword.TabIndex = 6
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 267)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Name = "ChangePasswordForm"
        Me.Text = "ChangePasswordForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkShowPassword As CheckBox
End Class
