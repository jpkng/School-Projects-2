<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowForm
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
        Me.cbBook = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.dtDueDate = New System.Windows.Forms.DateTimePicker()
        Me.dtReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFine = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvBorrowed = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBorrowed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbStudent
        '
        Me.cbStudent.FormattingEnabled = True
        Me.cbStudent.Location = New System.Drawing.Point(105, 27)
        Me.cbStudent.Name = "cbStudent"
        Me.cbStudent.Size = New System.Drawing.Size(162, 21)
        Me.cbStudent.TabIndex = 0
        '
        'cbBook
        '
        Me.cbBook.FormattingEnabled = True
        Me.cbBook.Location = New System.Drawing.Point(105, 54)
        Me.cbBook.Name = "cbBook"
        Me.cbBook.Size = New System.Drawing.Size(162, 21)
        Me.cbBook.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Book Title:"
        '
        'dtBorrowDate
        '
        Me.dtBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBorrowDate.Location = New System.Drawing.Point(527, 28)
        Me.dtBorrowDate.Name = "dtBorrowDate"
        Me.dtBorrowDate.Size = New System.Drawing.Size(106, 20)
        Me.dtBorrowDate.TabIndex = 4
        '
        'dtDueDate
        '
        Me.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDueDate.Location = New System.Drawing.Point(527, 55)
        Me.dtDueDate.Name = "dtDueDate"
        Me.dtDueDate.Size = New System.Drawing.Size(106, 20)
        Me.dtDueDate.TabIndex = 5
        '
        'dtReturnDate
        '
        Me.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReturnDate.Location = New System.Drawing.Point(527, 81)
        Me.dtReturnDate.Name = "dtReturnDate"
        Me.dtReturnDate.Size = New System.Drawing.Size(106, 20)
        Me.dtReturnDate.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(452, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Borrow Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Due Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(453, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Return Date:"
        '
        'lblFine
        '
        Me.lblFine.AutoSize = True
        Me.lblFine.Location = New System.Drawing.Point(105, 87)
        Me.lblFine.Name = "lblFine"
        Me.lblFine.Size = New System.Drawing.Size(61, 13)
        Me.lblFine.TabIndex = 10
        Me.lblFine.Text = "Fine: ₱0.00"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(183, 82)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvBorrowed
        '
        Me.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowed.Location = New System.Drawing.Point(12, 142)
        Me.dgvBorrowed.Name = "dgvBorrowed"
        Me.dgvBorrowed.Size = New System.Drawing.Size(684, 150)
        Me.dgvBorrowed.TabIndex = 12
        '
        'BorrowForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibraryFinesApp.My.Resources.Resources.Screenshot_2025_04_21_191426
        Me.ClientSize = New System.Drawing.Size(708, 340)
        Me.Controls.Add(Me.dgvBorrowed)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblFine)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtReturnDate)
        Me.Controls.Add(Me.dtDueDate)
        Me.Controls.Add(Me.dtBorrowDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBook)
        Me.Controls.Add(Me.cbStudent)
        Me.Name = "BorrowForm"
        Me.Text = "BorrowForm"
        CType(Me.dgvBorrowed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbStudent As ComboBox
    Friend WithEvents cbBook As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtBorrowDate As DateTimePicker
    Friend WithEvents dtDueDate As DateTimePicker
    Friend WithEvents dtReturnDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFine As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvBorrowed As DataGridView
End Class
