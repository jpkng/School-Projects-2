<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblHint As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTag = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.panelHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.lblTitle)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(720, 72)
        Me.panelHeader.TabIndex = 100
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(22, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(252, 30)
        Me.lblTitle.TabIndex = 101
        Me.lblTitle.Text = "➕ Add New Credential"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.Label1)
        Me.pnlContent.Controls.Add(Me.txtKeyword)
        Me.pnlContent.Controls.Add(Me.Label2)
        Me.pnlContent.Controls.Add(Me.txtUsername)
        Me.pnlContent.Controls.Add(Me.Label3)
        Me.pnlContent.Controls.Add(Me.txtPassword)
        Me.pnlContent.Controls.Add(Me.Label4)
        Me.pnlContent.Controls.Add(Me.txtTag)
        Me.pnlContent.Controls.Add(Me.btnAdd)
        Me.pnlContent.Controls.Add(Me.btnBack)
        Me.pnlContent.Controls.Add(Me.lblHint)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 72)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(26)
        Me.pnlContent.Size = New System.Drawing.Size(720, 358)
        Me.pnlContent.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(60, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Keyword"
        '
        'txtKeyword
        '
        Me.txtKeyword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeyword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtKeyword.ForeColor = System.Drawing.Color.White
        Me.txtKeyword.Location = New System.Drawing.Point(60, 55)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(450, 25)
        Me.txtKeyword.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(60, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username / E-mail"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(60, 120)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(450, 25)
        Me.txtUsername.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(60, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(60, 185)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(450, 25)
        Me.txtPassword.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(60, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tag"
        '
        'txtTag
        '
        Me.txtTag.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTag.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTag.ForeColor = System.Drawing.Color.White
        Me.txtTag.FormattingEnabled = True
        Me.txtTag.Items.AddRange(New Object() {"Social", "Entertainment", "Office Work", "Banking", "Others"})
        Me.txtTag.Location = New System.Drawing.Point(60, 250)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(220, 25)
        Me.txtTag.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(540, 55)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 40)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "➕  Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(540, 105)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 40)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "←  Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblHint.Location = New System.Drawing.Point(60, 305)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(333, 15)
        Me.lblHint.TabIndex = 110
        Me.lblHint.Text = "Tip: Use a unique keyword and a strong password (≥12 chars)."
        '
        'FormAdd
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(720, 430)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.panelHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Credential"
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtKeyword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtTag As ComboBox
    Friend WithEvents Label4 As Label
End Class
