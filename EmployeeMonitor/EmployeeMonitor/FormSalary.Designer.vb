<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpID2 = New System.Windows.Forms.TextBox()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.btnSalary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Month Covered:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee Salary:"
        '
        'txtEmpID2
        '
        Me.txtEmpID2.Location = New System.Drawing.Point(141, 43)
        Me.txtEmpID2.Name = "txtEmpID2"
        Me.txtEmpID2.Size = New System.Drawing.Size(183, 20)
        Me.txtEmpID2.TabIndex = 3
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM yyyy"
        Me.dtpMonth.Location = New System.Drawing.Point(155, 81)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(200, 20)
        Me.dtpMonth.TabIndex = 4
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(152, 118)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(216, 13)
        Me.lblSalary.TabIndex = 5
        Me.lblSalary.Text = "Computed Employee Salary will appear here."
        '
        'btnSalary
        '
        Me.btnSalary.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnSalary.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalary.Location = New System.Drawing.Point(68, 152)
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(145, 45)
        Me.btnSalary.TabIndex = 6
        Me.btnSalary.Text = "Calculate Salary"
        Me.btnSalary.UseVisualStyleBackColor = False
        '
        'FormSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(497, 235)
        Me.Controls.Add(Me.btnSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.dtpMonth)
        Me.Controls.Add(Me.txtEmpID2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSalary"
        Me.Text = "FormSalary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmpID2 As TextBox
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents lblSalary As Label
    Friend WithEvents btnSalary As Button
End Class
