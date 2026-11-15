<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTSSave = New System.Windows.Forms.Button()
        Me.btnTSCancel = New System.Windows.Forms.Button()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(72, 12)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(240, 21)
        Me.cmbCustomer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer: "
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(72, 39)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(240, 20)
        Me.dtpDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date:"
        '
        'dgvItems
        '
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvItems.Location = New System.Drawing.Point(337, 12)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.Size = New System.Drawing.Size(451, 410)
        Me.dgvItems.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Qty"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "UnitPrice"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Subtotal"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(109, 72)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Label3"
        Me.lblTotal.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total:"
        '
        'btnTSSave
        '
        Me.btnTSSave.Location = New System.Drawing.Point(72, 103)
        Me.btnTSSave.Name = "btnTSSave"
        Me.btnTSSave.Size = New System.Drawing.Size(98, 47)
        Me.btnTSSave.TabIndex = 7
        Me.btnTSSave.Text = "Save"
        Me.btnTSSave.UseVisualStyleBackColor = True
        '
        'btnTSCancel
        '
        Me.btnTSCancel.Location = New System.Drawing.Point(176, 105)
        Me.btnTSCancel.Name = "btnTSCancel"
        Me.btnTSCancel.Size = New System.Drawing.Size(98, 45)
        Me.btnTSCancel.TabIndex = 8
        Me.btnTSCancel.Text = "Cancel"
        Me.btnTSCancel.UseVisualStyleBackColor = True
        '
        'TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTSCancel)
        Me.Controls.Add(Me.btnTSSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Name = "TransactionForm"
        Me.Text = "TransactionForm"
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTSSave As Button
    Friend WithEvents btnTSCancel As Button
End Class
