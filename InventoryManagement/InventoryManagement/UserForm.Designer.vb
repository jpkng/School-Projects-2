<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Me.btnUSTransactions = New System.Windows.Forms.Button()
        Me.btnUSViewTransactions = New System.Windows.Forms.Button()
        Me.btnUSLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUSTransactions
        '
        Me.btnUSTransactions.Location = New System.Drawing.Point(140, 132)
        Me.btnUSTransactions.Name = "btnUSTransactions"
        Me.btnUSTransactions.Size = New System.Drawing.Size(173, 23)
        Me.btnUSTransactions.TabIndex = 0
        Me.btnUSTransactions.Text = "Transactions"
        Me.btnUSTransactions.UseVisualStyleBackColor = True
        '
        'btnUSViewTransactions
        '
        Me.btnUSViewTransactions.Location = New System.Drawing.Point(140, 171)
        Me.btnUSViewTransactions.Name = "btnUSViewTransactions"
        Me.btnUSViewTransactions.Size = New System.Drawing.Size(173, 23)
        Me.btnUSViewTransactions.TabIndex = 1
        Me.btnUSViewTransactions.Text = "View Transactions"
        Me.btnUSViewTransactions.UseVisualStyleBackColor = True
        '
        'btnUSLogout
        '
        Me.btnUSLogout.Location = New System.Drawing.Point(140, 214)
        Me.btnUSLogout.Name = "btnUSLogout"
        Me.btnUSLogout.Size = New System.Drawing.Size(173, 23)
        Me.btnUSLogout.TabIndex = 2
        Me.btnUSLogout.Text = "Log Out"
        Me.btnUSLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome, User"
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(488, 317)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUSLogout)
        Me.Controls.Add(Me.btnUSViewTransactions)
        Me.Controls.Add(Me.btnUSTransactions)
        Me.Name = "UserForm"
        Me.Text = "UserForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUSTransactions As Button
    Friend WithEvents btnUSViewTransactions As Button
    Friend WithEvents btnUSLogout As Button
    Friend WithEvents Label1 As Label
End Class
