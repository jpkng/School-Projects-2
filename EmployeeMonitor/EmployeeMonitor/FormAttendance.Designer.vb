<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAttendance
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
        Me.txtEmpID1 = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status:"
        '
        'txtEmpID1
        '
        Me.txtEmpID1.Location = New System.Drawing.Point(107, 40)
        Me.txtEmpID1.Name = "txtEmpID1"
        Me.txtEmpID1.Size = New System.Drawing.Size(215, 20)
        Me.txtEmpID1.TabIndex = 3
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(107, 79)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(215, 20)
        Me.dtpDate.TabIndex = 4
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Present", "Absent", "Late"})
        Me.cmbStatus.Location = New System.Drawing.Point(107, 114)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(215, 21)
        Me.cmbStatus.TabIndex = 5
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnAttendance.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.Location = New System.Drawing.Point(107, 158)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(156, 41)
        Me.btnAttendance.TabIndex = 6
        Me.btnAttendance.Text = "Attendance"
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'FormAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(519, 260)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtEmpID1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAttendance"
        Me.Text = "FormAttendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmpID1 As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnAttendance As Button
End Class
