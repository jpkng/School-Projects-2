<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStrengthTester
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents accentBarTop As Panel
    Friend WithEvents accentBarBottom As Panel
    Friend WithEvents lblHint As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTestPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents pbStrength As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStrengthTier As Label
    Friend WithEvents lblTimeToCrack As Label
    Friend WithEvents txtExplanation As TextBox
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExplain As Button
    Friend WithEvents Label4 As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTestPassword = New System.Windows.Forms.TextBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.pbStrength = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStrengthTier = New System.Windows.Forms.Label()
        Me.lblTimeToCrack = New System.Windows.Forms.Label()
        Me.txtExplanation = New System.Windows.Forms.TextBox()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExplain = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.accentBarBottom = New System.Windows.Forms.Panel()
        Me.accentBarTop = New System.Windows.Forms.Panel()
        Me.panelHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.lblTitle)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(820, 80)
        Me.panelHeader.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(30, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(329, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🔒 Password Strength Tester"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.pnlContent.Controls.Add(Me.Label1)
        Me.pnlContent.Controls.Add(Me.txtTestPassword)
        Me.pnlContent.Controls.Add(Me.chkShowPassword)
        Me.pnlContent.Controls.Add(Me.pbStrength)
        Me.pnlContent.Controls.Add(Me.Label2)
        Me.pnlContent.Controls.Add(Me.lblStrengthTier)
        Me.pnlContent.Controls.Add(Me.lblTimeToCrack)
        Me.pnlContent.Controls.Add(Me.txtExplanation)
        Me.pnlContent.Controls.Add(Me.btnEvaluate)
        Me.pnlContent.Controls.Add(Me.btnClear)
        Me.pnlContent.Controls.Add(Me.btnExplain)
        Me.pnlContent.Controls.Add(Me.Label4)
        Me.pnlContent.Controls.Add(Me.lblHint)
        Me.pnlContent.Controls.Add(Me.accentBarBottom)
        Me.pnlContent.Controls.Add(Me.accentBarTop)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 80)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(30, 20, 30, 20)
        Me.pnlContent.Size = New System.Drawing.Size(820, 380)
        Me.pnlContent.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(40, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter password to test:"
        '
        'txtTestPassword
        '
        Me.txtTestPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtTestPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTestPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTestPassword.ForeColor = System.Drawing.Color.White
        Me.txtTestPassword.Location = New System.Drawing.Point(230, 38)
        Me.txtTestPassword.Name = "txtTestPassword"
        Me.txtTestPassword.Size = New System.Drawing.Size(360, 25)
        Me.txtTestPassword.TabIndex = 1
        Me.txtTestPassword.UseSystemPasswordChar = True
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.ForeColor = System.Drawing.Color.Silver
        Me.chkShowPassword.Location = New System.Drawing.Point(230, 68)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(118, 21)
        Me.chkShowPassword.TabIndex = 2
        Me.chkShowPassword.Text = "Show Password"
        '
        'pbStrength
        '
        Me.pbStrength.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pbStrength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbStrength.Location = New System.Drawing.Point(230, 110)
        Me.pbStrength.Name = "pbStrength"
        Me.pbStrength.Size = New System.Drawing.Size(360, 20)
        Me.pbStrength.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(40, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password Strength:"
        '
        'lblStrengthTier
        '
        Me.lblStrengthTier.AutoSize = True
        Me.lblStrengthTier.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblStrengthTier.ForeColor = System.Drawing.Color.White
        Me.lblStrengthTier.Location = New System.Drawing.Point(230, 136)
        Me.lblStrengthTier.Name = "lblStrengthTier"
        Me.lblStrengthTier.Size = New System.Drawing.Size(35, 19)
        Me.lblStrengthTier.TabIndex = 5
        Me.lblStrengthTier.Text = "N/A"
        '
        'lblTimeToCrack
        '
        Me.lblTimeToCrack.AutoSize = True
        Me.lblTimeToCrack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblTimeToCrack.ForeColor = System.Drawing.Color.Gray
        Me.lblTimeToCrack.Location = New System.Drawing.Point(230, 158)
        Me.lblTimeToCrack.Name = "lblTimeToCrack"
        Me.lblTimeToCrack.Size = New System.Drawing.Size(223, 15)
        Me.lblTimeToCrack.TabIndex = 6
        Me.lblTimeToCrack.Text = "Estimated time-to-crack will appear here."
        '
        'txtExplanation
        '
        Me.txtExplanation.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExplanation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtExplanation.ForeColor = System.Drawing.Color.White
        Me.txtExplanation.Location = New System.Drawing.Point(230, 190)
        Me.txtExplanation.Multiline = True
        Me.txtExplanation.Name = "txtExplanation"
        Me.txtExplanation.ReadOnly = True
        Me.txtExplanation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExplanation.Size = New System.Drawing.Size(360, 120)
        Me.txtExplanation.TabIndex = 7
        '
        'btnEvaluate
        '
        Me.btnEvaluate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEvaluate.FlatAppearance.BorderSize = 0
        Me.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnEvaluate.ForeColor = System.Drawing.Color.White
        Me.btnEvaluate.Location = New System.Drawing.Point(620, 35)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(130, 32)
        Me.btnEvaluate.TabIndex = 8
        Me.btnEvaluate.Text = "Analyze"
        Me.btnEvaluate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(620, 75)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 32)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Back"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExplain
        '
        Me.btnExplain.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnExplain.FlatAppearance.BorderSize = 0
        Me.btnExplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExplain.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExplain.ForeColor = System.Drawing.Color.White
        Me.btnExplain.Location = New System.Drawing.Point(620, 190)
        Me.btnExplain.Name = "btnExplain"
        Me.btnExplain.Size = New System.Drawing.Size(130, 48)
        Me.btnExplain.TabIndex = 10
        Me.btnExplain.Text = "Online vs Offline Cracking"
        Me.btnExplain.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(30, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Notice: Time-to-crack figures are rough estimations for guidance only."
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lblHint.ForeColor = System.Drawing.Color.Silver
        Me.lblHint.Location = New System.Drawing.Point(230, 320)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(358, 15)
        Me.lblHint.TabIndex = 12
        Me.lblHint.Text = "Tip: Strong passwords combine length (≥12) with varied characters."
        '
        'accentBarBottom
        '
        Me.accentBarBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.accentBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.accentBarBottom.Location = New System.Drawing.Point(30, 357)
        Me.accentBarBottom.Name = "accentBarBottom"
        Me.accentBarBottom.Size = New System.Drawing.Size(760, 3)
        Me.accentBarBottom.TabIndex = 13
        '
        'accentBarTop
        '
        Me.accentBarTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.accentBarTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.accentBarTop.Location = New System.Drawing.Point(30, 20)
        Me.accentBarTop.Name = "accentBarTop"
        Me.accentBarTop.Size = New System.Drawing.Size(760, 4)
        Me.accentBarTop.TabIndex = 14
        '
        'FormStrengthTester
        '
        Me.AcceptButton = Me.btnEvaluate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(820, 460)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.panelHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormStrengthTester"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Strength Tester"
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
