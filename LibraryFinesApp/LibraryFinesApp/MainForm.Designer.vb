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
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStudents
        '
        Me.btnStudents.Location = New System.Drawing.Point(12, 12)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(142, 23)
        Me.btnStudents.TabIndex = 0
        Me.btnStudents.Text = "Manage Students"
        Me.btnStudents.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.Location = New System.Drawing.Point(183, 12)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(142, 23)
        Me.btnBooks.TabIndex = 1
        Me.btnBooks.Text = "Manage Books"
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(357, 12)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(142, 23)
        Me.btnBorrow.TabIndex = 2
        Me.btnBorrow.Text = "Borrow And Return"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnPayments
        '
        Me.btnPayments.Location = New System.Drawing.Point(183, 41)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(142, 23)
        Me.btnPayments.TabIndex = 3
        Me.btnPayments.Text = "Payments And Fines"
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.LibraryFinesApp.My.Resources.Resources.Screenshot_2025_04_21_191426
        Me.ClientSize = New System.Drawing.Size(522, 430)
        Me.Controls.Add(Me.btnPayments)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnBooks)
        Me.Controls.Add(Me.btnStudents)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStudents As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnPayments As Button
End Class
