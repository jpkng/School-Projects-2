<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.btnADUsers = New System.Windows.Forms.Button()
        Me.btnADTransactions = New System.Windows.Forms.Button()
        Me.btnADViewTransactions = New System.Windows.Forms.Button()
        Me.btnADLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnADReports = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnADUsers
        '
        Me.btnADUsers.Location = New System.Drawing.Point(145, 112)
        Me.btnADUsers.Name = "btnADUsers"
        Me.btnADUsers.Size = New System.Drawing.Size(160, 23)
        Me.btnADUsers.TabIndex = 0
        Me.btnADUsers.Text = "User Management"
        Me.btnADUsers.UseVisualStyleBackColor = True
        '
        'btnADTransactions
        '
        Me.btnADTransactions.Location = New System.Drawing.Point(145, 151)
        Me.btnADTransactions.Name = "btnADTransactions"
        Me.btnADTransactions.Size = New System.Drawing.Size(160, 23)
        Me.btnADTransactions.TabIndex = 1
        Me.btnADTransactions.Text = "Transactions"
        Me.btnADTransactions.UseVisualStyleBackColor = True
        '
        'btnADViewTransactions
        '
        Me.btnADViewTransactions.Location = New System.Drawing.Point(145, 194)
        Me.btnADViewTransactions.Name = "btnADViewTransactions"
        Me.btnADViewTransactions.Size = New System.Drawing.Size(160, 23)
        Me.btnADViewTransactions.TabIndex = 2
        Me.btnADViewTransactions.Text = "View Transactions"
        Me.btnADViewTransactions.UseVisualStyleBackColor = True
        '
        'btnADLogout
        '
        Me.btnADLogout.Location = New System.Drawing.Point(145, 284)
        Me.btnADLogout.Name = "btnADLogout"
        Me.btnADLogout.Size = New System.Drawing.Size(160, 23)
        Me.btnADLogout.TabIndex = 4
        Me.btnADLogout.Text = "Log Out"
        Me.btnADLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome, Admin"
        '
        'btnADReports
        '
        Me.btnADReports.Location = New System.Drawing.Point(145, 241)
        Me.btnADReports.Name = "btnADReports"
        Me.btnADReports.Size = New System.Drawing.Size(160, 23)
        Me.btnADReports.TabIndex = 3
        Me.btnADReports.Text = "Reports"
        Me.btnADReports.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(465, 334)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnADLogout)
        Me.Controls.Add(Me.btnADReports)
        Me.Controls.Add(Me.btnADViewTransactions)
        Me.Controls.Add(Me.btnADTransactions)
        Me.Controls.Add(Me.btnADUsers)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnADUsers As Button
    Friend WithEvents btnADTransactions As Button
    Friend WithEvents btnADViewTransactions As Button
    Friend WithEvents btnADLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnADReports As Button
End Class
