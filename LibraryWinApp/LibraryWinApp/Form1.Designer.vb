<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBookAuthor = New System.Windows.Forms.TextBox()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRegisterMember = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.txtBorrowBook = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBorrowMember = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.btnShowAvailable = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtActivity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBookTitle
        '
        Me.txtBookTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBookTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtBookTitle.Location = New System.Drawing.Point(120, 36)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(280, 23)
        Me.txtBookTitle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Book Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Book Author:"
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBookAuthor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtBookAuthor.Location = New System.Drawing.Point(120, 68)
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Size = New System.Drawing.Size(280, 23)
        Me.txtBookAuthor.TabIndex = 3
        '
        'btnAddBook
        '
        Me.btnAddBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBook.FlatAppearance.BorderSize = 0
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddBook.ForeColor = System.Drawing.Color.White
        Me.btnAddBook.Location = New System.Drawing.Point(28, 104)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(160, 38)
        Me.btnAddBook.TabIndex = 4
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAddBook)
        Me.GroupBox1.Controls.Add(Me.txtBookAuthor)
        Me.GroupBox1.Controls.Add(Me.txtBookTitle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 160)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add A Book"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnRegisterMember)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtMemberName)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 140)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Member Registration"
        '
        'btnRegisterMember
        '
        Me.btnRegisterMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnRegisterMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegisterMember.FlatAppearance.BorderSize = 0
        Me.btnRegisterMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterMember.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegisterMember.ForeColor = System.Drawing.Color.White
        Me.btnRegisterMember.Location = New System.Drawing.Point(28, 74)
        Me.btnRegisterMember.Name = "btnRegisterMember"
        Me.btnRegisterMember.Size = New System.Drawing.Size(180, 44)
        Me.btnRegisterMember.TabIndex = 2
        Me.btnRegisterMember.Text = "Register Member"
        Me.btnRegisterMember.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Member Name:"
        '
        'txtMemberName
        '
        Me.txtMemberName.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMemberName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtMemberName.Location = New System.Drawing.Point(120, 38)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(280, 23)
        Me.txtMemberName.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btnReturn)
        Me.GroupBox3.Controls.Add(Me.btnBorrow)
        Me.GroupBox3.Controls.Add(Me.txtBorrowBook)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtBorrowMember)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 260)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Borrow and Returns"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(154, 120)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(110, 42)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnBorrow
        '
        Me.btnBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrow.FlatAppearance.BorderSize = 0
        Me.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnBorrow.Location = New System.Drawing.Point(28, 120)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(110, 42)
        Me.btnBorrow.TabIndex = 7
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = False
        '
        'txtBorrowBook
        '
        Me.txtBorrowBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtBorrowBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBorrowBook.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBorrowBook.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtBorrowBook.Location = New System.Drawing.Point(120, 79)
        Me.txtBorrowBook.Name = "txtBorrowBook"
        Me.txtBorrowBook.Size = New System.Drawing.Size(276, 23)
        Me.txtBorrowBook.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Book Title:"
        '
        'txtBorrowMember
        '
        Me.txtBorrowMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtBorrowMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBorrowMember.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBorrowMember.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtBorrowMember.Location = New System.Drawing.Point(120, 43)
        Me.txtBorrowMember.Name = "txtBorrowMember"
        Me.txtBorrowMember.Size = New System.Drawing.Size(276, 23)
        Me.txtBorrowMember.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Member Name:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btnShowAll)
        Me.GroupBox4.Controls.Add(Me.btnShowAvailable)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(460, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(652, 160)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Book Availability"
        '
        'btnShowAll
        '
        Me.btnShowAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAll.FlatAppearance.BorderSize = 0
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.Location = New System.Drawing.Point(386, 74)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(150, 44)
        Me.btnShowAll.TabIndex = 3
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = False
        '
        'btnShowAvailable
        '
        Me.btnShowAvailable.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnShowAvailable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAvailable.FlatAppearance.BorderSize = 0
        Me.btnShowAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAvailable.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnShowAvailable.Location = New System.Drawing.Point(220, 74)
        Me.btnShowAvailable.Name = "btnShowAvailable"
        Me.btnShowAvailable.Size = New System.Drawing.Size(150, 44)
        Me.btnShowAvailable.TabIndex = 2
        Me.btnShowAvailable.Text = "Show Available"
        Me.btnShowAvailable.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(36, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Search Book or Members:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.Location = New System.Drawing.Point(220, 36)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(400, 23)
        Me.txtSearch.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.txtActivity)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.dgvMembers)
        Me.GroupBox5.Controls.Add(Me.dgvBooks)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(460, 188)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(652, 590)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Information"
        '
        'txtActivity
        '
        Me.txtActivity.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActivity.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.txtActivity.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtActivity.Location = New System.Drawing.Point(18, 470)
        Me.txtActivity.Multiline = True
        Me.txtActivity.Name = "txtActivity"
        Me.txtActivity.ReadOnly = True
        Me.txtActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtActivity.Size = New System.Drawing.Size(616, 100)
        Me.txtActivity.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(18, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Books"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Members"
        '
        'dgvMembers
        '
        Me.dgvMembers.AllowUserToAddRows = False
        Me.dgvMembers.AllowUserToDeleteRows = False
        Me.dgvMembers.AllowUserToResizeRows = False
        Me.dgvMembers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMembers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(135, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMembers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMembers.EnableHeadersVisualStyles = False
        Me.dgvMembers.GridColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvMembers.Location = New System.Drawing.Point(18, 270)
        Me.dgvMembers.MultiSelect = False
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.ReadOnly = True
        Me.dgvMembers.RowHeadersVisible = False
        Me.dgvMembers.RowTemplate.Height = 28
        Me.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMembers.Size = New System.Drawing.Size(616, 180)
        Me.dgvMembers.TabIndex = 1
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AllowUserToResizeRows = False
        Me.dgvBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(135, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooks.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBooks.EnableHeadersVisualStyles = False
        Me.dgvBooks.GridColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvBooks.Location = New System.Drawing.Point(18, 40)
        Me.dgvBooks.MultiSelect = False
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowHeadersVisible = False
        Me.dgvBooks.RowTemplate.Height = 28
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(616, 200)
        Me.dgvBooks.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1128, 780)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virtual Library"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBookAuthor As TextBox
    Friend WithEvents btnAddBook As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents btnRegisterMember As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBorrowBook As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBorrowMember As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnShowAll As Button
    Friend WithEvents btnShowAvailable As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents txtActivity As TextBox
End Class
