<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.btnToEmployee = New System.Windows.Forms.Button()
        Me.btnToAttendance = New System.Windows.Forms.Button()
        Me.btnToSalary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnToEmployee
        '
        Me.btnToEmployee.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnToEmployee.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToEmployee.Location = New System.Drawing.Point(92, 58)
        Me.btnToEmployee.Name = "btnToEmployee"
        Me.btnToEmployee.Size = New System.Drawing.Size(171, 41)
        Me.btnToEmployee.TabIndex = 0
        Me.btnToEmployee.Text = "Employee Info"
        Me.btnToEmployee.UseVisualStyleBackColor = False
        '
        'btnToAttendance
        '
        Me.btnToAttendance.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnToAttendance.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToAttendance.Location = New System.Drawing.Point(92, 105)
        Me.btnToAttendance.Name = "btnToAttendance"
        Me.btnToAttendance.Size = New System.Drawing.Size(171, 37)
        Me.btnToAttendance.TabIndex = 1
        Me.btnToAttendance.Text = "Go to Attendance"
        Me.btnToAttendance.UseVisualStyleBackColor = False
        '
        'btnToSalary
        '
        Me.btnToSalary.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnToSalary.Font = New System.Drawing.Font("Yu Mincho", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToSalary.Location = New System.Drawing.Point(92, 148)
        Me.btnToSalary.Name = "btnToSalary"
        Me.btnToSalary.Size = New System.Drawing.Size(171, 41)
        Me.btnToSalary.TabIndex = 2
        Me.btnToSalary.Text = "Salary Computation"
        Me.btnToSalary.UseVisualStyleBackColor = False
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(366, 269)
        Me.Controls.Add(Me.btnToSalary)
        Me.Controls.Add(Me.btnToAttendance)
        Me.Controls.Add(Me.btnToEmployee)
        Me.Name = "FormMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnToEmployee As Button
    Friend WithEvents btnToAttendance As Button
    Friend WithEvents btnToSalary As Button
End Class
