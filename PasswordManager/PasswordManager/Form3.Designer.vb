<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnTestPassword = New System.Windows.Forms.Button()
        Me.lblTagline = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.pnlChilds = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(255, 102, 0)
        Me.pnlHeader.Controls.Add(Me.lblAppTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1280, 120)
        Me.pnlHeader.TabIndex = 1
        '
        'lblAppTitle
        '
        Me.lblAppTitle.AutoSize = True
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI Black", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppTitle.ForeColor = System.Drawing.Color.White
        Me.lblAppTitle.Location = New System.Drawing.Point(40, 25)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(280, 51)
        Me.lblAppTitle.TabIndex = 0
        Me.lblAppTitle.Text = "🔐 LockBitDB"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.lblSubtitle.Location = New System.Drawing.Point(45, 85)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(245, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Your Encrypted Digital Vault Suite"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(18, 18, 18)
        Me.pnlMain.Controls.Add(Me.btnAdd)
        Me.pnlMain.Controls.Add(Me.btnView)
        Me.pnlMain.Controls.Add(Me.btnTestPassword)
        Me.pnlMain.Controls.Add(Me.lblTagline)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMain.Location = New System.Drawing.Point(0, 120)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(250, 560)
        Me.pnlMain.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(255, 102, 0)
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(25, 120)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(200, 45)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "➕  Add New Credential"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.btnView.FlatAppearance.BorderSize = 0
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(25, 180)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(200, 45)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "📂  View Credentials"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnTestPassword
        '
        Me.btnTestPassword.BackColor = System.Drawing.Color.FromArgb(255, 153, 51)
        Me.btnTestPassword.FlatAppearance.BorderSize = 0
        Me.btnTestPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!)
        Me.btnTestPassword.ForeColor = System.Drawing.Color.White
        Me.btnTestPassword.Location = New System.Drawing.Point(25, 240)
        Me.btnTestPassword.Name = "btnTestPassword"
        Me.btnTestPassword.Size = New System.Drawing.Size(200, 45)
        Me.btnTestPassword.TabIndex = 2
        Me.btnTestPassword.Text = "🧠  Test Password"
        Me.btnTestPassword.UseVisualStyleBackColor = False
        '
        'lblTagline
        '
        Me.lblTagline.AutoSize = True
        Me.lblTagline.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTagline.ForeColor = System.Drawing.Color.FromArgb(255, 102, 0)
        Me.lblTagline.Location = New System.Drawing.Point(20, 40)
        Me.lblTagline.Name = "lblTagline"
        Me.lblTagline.Size = New System.Drawing.Size(208, 25)
        Me.lblTagline.TabIndex = 3
        Me.lblTagline.Text = "Manage • Protect • Secure"
        '
        'pnlChilds
        '
        Me.pnlChilds.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
        Me.pnlChilds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChilds.Location = New System.Drawing.Point(250, 120)
        Me.pnlChilds.Name = "pnlChilds"
        Me.pnlChilds.Size = New System.Drawing.Size(1030, 560)
        Me.pnlChilds.TabIndex = 3
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(25, 25, 25)
        Me.pnlFooter.Controls.Add(Me.lblVersion)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 680)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1280, 40)
        Me.pnlFooter.TabIndex = 2
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblVersion.ForeColor = System.Drawing.Color.DimGray
        Me.lblVersion.Location = New System.Drawing.Point(15, 12)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(188, 15)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "v1.0 — LockBitDB Secure Manager"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(15, 15, 15)
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pnlChilds)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFooter)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LockBitDB — Secure Password Vault"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnTestPassword As Button
    Friend WithEvents lblTagline As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblVersion As Label
    Friend WithEvents pnlChilds As Panel
End Class
