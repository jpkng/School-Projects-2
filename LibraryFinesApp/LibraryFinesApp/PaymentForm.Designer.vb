<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Me.cbStudent = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.dgvUnpaid = New System.Windows.Forms.DataGridView()
        CType(Me.dgvUnpaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbStudent
        '
        Me.cbStudent.FormattingEnabled = True
        Me.cbStudent.Location = New System.Drawing.Point(269, 35)
        Me.cbStudent.Name = "cbStudent"
        Me.cbStudent.Size = New System.Drawing.Size(192, 21)
        Me.cbStudent.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Name:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(269, 72)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(88, 13)
        Me.lblTotalDue.TabIndex = 2
        Me.lblTotalDue.Text = "Total Due: ₱0.00"
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(269, 101)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(192, 20)
        Me.txtPayment.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Payment:"
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(272, 143)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(120, 23)
        Me.btnPay.TabIndex = 5
        Me.btnPay.Text = "Submit Payment"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'dgvUnpaid
        '
        Me.dgvUnpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnpaid.Location = New System.Drawing.Point(12, 186)
        Me.dgvUnpaid.Name = "dgvUnpaid"
        Me.dgvUnpaid.Size = New System.Drawing.Size(629, 150)
        Me.dgvUnpaid.TabIndex = 6
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.LibraryFinesApp.My.Resources.Resources.Screenshot_2025_04_21_191426
        Me.ClientSize = New System.Drawing.Size(653, 376)
        Me.Controls.Add(Me.dgvUnpaid)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbStudent)
        Me.Name = "PaymentForm"
        Me.Text = "PaymentForm"
        CType(Me.dgvUnpaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbStudent As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents dgvUnpaid As DataGridView
End Class
