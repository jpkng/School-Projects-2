<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnProductManagement = New System.Windows.Forms.Button()
        Me.btnSalesTransactions = New System.Windows.Forms.Button()
        Me.btnReporting = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProductManagement
        '
        Me.btnProductManagement.Location = New System.Drawing.Point(302, 125)
        Me.btnProductManagement.Name = "btnProductManagement"
        Me.btnProductManagement.Size = New System.Drawing.Size(138, 23)
        Me.btnProductManagement.TabIndex = 0
        Me.btnProductManagement.Text = "Product Management"
        Me.btnProductManagement.UseVisualStyleBackColor = True
        '
        'btnSalesTransactions
        '
        Me.btnSalesTransactions.Location = New System.Drawing.Point(302, 165)
        Me.btnSalesTransactions.Name = "btnSalesTransactions"
        Me.btnSalesTransactions.Size = New System.Drawing.Size(138, 23)
        Me.btnSalesTransactions.TabIndex = 1
        Me.btnSalesTransactions.Text = "Sales Transactions"
        Me.btnSalesTransactions.UseVisualStyleBackColor = True
        '
        'btnReporting
        '
        Me.btnReporting.Location = New System.Drawing.Point(302, 207)
        Me.btnReporting.Name = "btnReporting"
        Me.btnReporting.Size = New System.Drawing.Size(138, 23)
        Me.btnReporting.TabIndex = 2
        Me.btnReporting.Text = "Sales Report"
        Me.btnReporting.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(302, 248)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(138, 23)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnReporting)
        Me.Controls.Add(Me.btnSalesTransactions)
        Me.Controls.Add(Me.btnProductManagement)
        Me.Name = "MainForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProductManagement As Button
    Friend WithEvents btnSalesTransactions As Button
    Friend WithEvents btnReporting As Button
    Friend WithEvents btnLogout As Button
End Class
