<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupervisorForm
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
        Me.btnSVTransactions = New System.Windows.Forms.Button()
        Me.btnSVViewTransactions = New System.Windows.Forms.Button()
        Me.btnSVLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSVReports = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSVTransactions
        '
        Me.btnSVTransactions.Location = New System.Drawing.Point(165, 134)
        Me.btnSVTransactions.Name = "btnSVTransactions"
        Me.btnSVTransactions.Size = New System.Drawing.Size(185, 23)
        Me.btnSVTransactions.TabIndex = 0
        Me.btnSVTransactions.Text = "Transactions"
        Me.btnSVTransactions.UseVisualStyleBackColor = True
        '
        'btnSVViewTransactions
        '
        Me.btnSVViewTransactions.Location = New System.Drawing.Point(165, 177)
        Me.btnSVViewTransactions.Name = "btnSVViewTransactions"
        Me.btnSVViewTransactions.Size = New System.Drawing.Size(185, 23)
        Me.btnSVViewTransactions.TabIndex = 1
        Me.btnSVViewTransactions.Text = "View Transactions"
        Me.btnSVViewTransactions.UseVisualStyleBackColor = True
        '
        'btnSVLogout
        '
        Me.btnSVLogout.Location = New System.Drawing.Point(165, 262)
        Me.btnSVLogout.Name = "btnSVLogout"
        Me.btnSVLogout.Size = New System.Drawing.Size(185, 23)
        Me.btnSVLogout.TabIndex = 3
        Me.btnSVLogout.Text = "Log Out"
        Me.btnSVLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome, Supervisor"
        '
        'btnSVReports
        '
        Me.btnSVReports.Location = New System.Drawing.Point(165, 219)
        Me.btnSVReports.Name = "btnSVReports"
        Me.btnSVReports.Size = New System.Drawing.Size(185, 23)
        Me.btnSVReports.TabIndex = 2
        Me.btnSVReports.Text = "Reports"
        Me.btnSVReports.UseVisualStyleBackColor = True
        '
        'SupervisorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(518, 320)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSVLogout)
        Me.Controls.Add(Me.btnSVReports)
        Me.Controls.Add(Me.btnSVViewTransactions)
        Me.Controls.Add(Me.btnSVTransactions)
        Me.Name = "SupervisorForm"
        Me.Text = "SupervisorForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSVTransactions As Button
    Friend WithEvents btnSVViewTransactions As Button
    Friend WithEvents btnSVLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSVReports As Button
End Class
