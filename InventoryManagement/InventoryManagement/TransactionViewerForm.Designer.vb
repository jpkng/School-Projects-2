<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionViewerForm
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
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.dgvDetails = New System.Windows.Forms.DataGridView()
        Me.btnTVEdit = New System.Windows.Forms.Button()
        Me.btnTVDelete = New System.Windows.Forms.Button()
        Me.btnTVRefresh = New System.Windows.Forms.Button()
        Me.btnTVClose = New System.Windows.Forms.Button()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTransactions
        '
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Location = New System.Drawing.Point(33, 12)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.Size = New System.Drawing.Size(440, 150)
        Me.dgvTransactions.TabIndex = 0
        '
        'dgvDetails
        '
        Me.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetails.Location = New System.Drawing.Point(33, 185)
        Me.dgvDetails.Name = "dgvDetails"
        Me.dgvDetails.Size = New System.Drawing.Size(344, 150)
        Me.dgvDetails.TabIndex = 1
        '
        'btnTVEdit
        '
        Me.btnTVEdit.Location = New System.Drawing.Point(402, 198)
        Me.btnTVEdit.Name = "btnTVEdit"
        Me.btnTVEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnTVEdit.TabIndex = 2
        Me.btnTVEdit.Text = "Edit"
        Me.btnTVEdit.UseVisualStyleBackColor = True
        '
        'btnTVDelete
        '
        Me.btnTVDelete.Location = New System.Drawing.Point(402, 228)
        Me.btnTVDelete.Name = "btnTVDelete"
        Me.btnTVDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnTVDelete.TabIndex = 3
        Me.btnTVDelete.Text = "Delete"
        Me.btnTVDelete.UseVisualStyleBackColor = True
        '
        'btnTVRefresh
        '
        Me.btnTVRefresh.Location = New System.Drawing.Point(402, 258)
        Me.btnTVRefresh.Name = "btnTVRefresh"
        Me.btnTVRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnTVRefresh.TabIndex = 4
        Me.btnTVRefresh.Text = "Refresh"
        Me.btnTVRefresh.UseVisualStyleBackColor = True
        '
        'btnTVClose
        '
        Me.btnTVClose.Location = New System.Drawing.Point(402, 288)
        Me.btnTVClose.Name = "btnTVClose"
        Me.btnTVClose.Size = New System.Drawing.Size(75, 23)
        Me.btnTVClose.TabIndex = 5
        Me.btnTVClose.Text = "Close"
        Me.btnTVClose.UseVisualStyleBackColor = True
        '
        'TransactionViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(562, 386)
        Me.Controls.Add(Me.btnTVClose)
        Me.Controls.Add(Me.btnTVRefresh)
        Me.Controls.Add(Me.btnTVDelete)
        Me.Controls.Add(Me.btnTVEdit)
        Me.Controls.Add(Me.dgvDetails)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Name = "TransactionViewerForm"
        Me.Text = "TransactionViewerForm"
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents dgvDetails As DataGridView
    Friend WithEvents btnTVEdit As Button
    Friend WithEvents btnTVDelete As Button
    Friend WithEvents btnTVRefresh As Button
    Friend WithEvents btnTVClose As Button
End Class
