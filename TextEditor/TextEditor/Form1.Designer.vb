<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ToolStrip1 = New ToolStrip()
        tbrClear = New ToolStripButton()
        tbrRed = New ToolStripButton()
        tbrBlue = New ToolStripButton()
        tbrUpperCase = New ToolStripButton()
        tbrLowerCase = New ToolStripButton()
        tbrHelpAbout = New ToolStripButton()
        StatusStrip1 = New StatusStrip()
        sspStatus = New ToolStripStatusLabel()
        txtEdit = New TextBox()
        ToolStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {tbrClear, tbrRed, tbrBlue, tbrUpperCase, tbrLowerCase, tbrHelpAbout})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(584, 25)
        ToolStrip1.Stretch = True
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' tbrClear
        ' 
        tbrClear.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbrClear.Image = CType(resources.GetObject("tbrClear.Image"), Image)
        tbrClear.ImageTransparentColor = Color.Magenta
        tbrClear.Name = "tbrClear"
        tbrClear.Size = New Size(23, 22)
        tbrClear.Text = "ToolStripButton1"
        ' 
        ' tbrRed
        ' 
        tbrRed.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbrRed.Image = CType(resources.GetObject("tbrRed.Image"), Image)
        tbrRed.ImageTransparentColor = Color.Magenta
        tbrRed.Name = "tbrRed"
        tbrRed.Size = New Size(23, 22)
        tbrRed.Text = "ToolStripButton2"
        tbrRed.ToolTipText = "Red" & vbCrLf
        ' 
        ' tbrBlue
        ' 
        tbrBlue.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbrBlue.Image = CType(resources.GetObject("tbrBlue.Image"), Image)
        tbrBlue.ImageTransparentColor = Color.Magenta
        tbrBlue.Name = "tbrBlue"
        tbrBlue.Size = New Size(23, 22)
        tbrBlue.Text = "ToolStripButton3"
        tbrBlue.ToolTipText = "Blue"
        ' 
        ' tbrUpperCase
        ' 
        tbrUpperCase.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbrUpperCase.Image = CType(resources.GetObject("tbrUpperCase.Image"), Image)
        tbrUpperCase.ImageTransparentColor = Color.Magenta
        tbrUpperCase.Name = "tbrUpperCase"
        tbrUpperCase.Size = New Size(23, 22)
        tbrUpperCase.Text = "ToolStripButton4"
        tbrUpperCase.ToolTipText = "Upper Case"
        ' 
        ' tbrLowerCase
        ' 
        tbrLowerCase.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbrLowerCase.Image = CType(resources.GetObject("tbrLowerCase.Image"), Image)
        tbrLowerCase.ImageTransparentColor = Color.Magenta
        tbrLowerCase.Name = "tbrLowerCase"
        tbrLowerCase.Size = New Size(23, 22)
        tbrLowerCase.Text = "ToolStripButton5"
        tbrLowerCase.ToolTipText = "tbrLowerCase"
        ' 
        ' tbrHelpAbout
        ' 
        tbrHelpAbout.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbrHelpAbout.Image = CType(resources.GetObject("tbrHelpAbout.Image"), Image)
        tbrHelpAbout.ImageTransparentColor = Color.Magenta
        tbrHelpAbout.Name = "tbrHelpAbout"
        tbrHelpAbout.Size = New Size(23, 22)
        tbrHelpAbout.Text = "ToolStripButton6"
        tbrHelpAbout.ToolTipText = "About"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {sspStatus})
        StatusStrip1.Location = New Point(0, 399)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(584, 22)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' sspStatus
        ' 
        sspStatus.Name = "sspStatus"
        sspStatus.Size = New Size(39, 17)
        sspStatus.Text = "Ready"
        ' 
        ' txtEdit
        ' 
        txtEdit.Dock = DockStyle.Fill
        txtEdit.Location = New Point(0, 25)
        txtEdit.Multiline = True
        txtEdit.Name = "txtEdit"
        txtEdit.ScrollBars = ScrollBars.Vertical
        txtEdit.Size = New Size(584, 374)
        txtEdit.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 421)
        Controls.Add(txtEdit)
        Controls.Add(StatusStrip1)
        Controls.Add(ToolStrip1)
        Name = "Form1"
        Text = "Text Editor"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tbrClear As ToolStripButton
    Friend WithEvents tbrRed As ToolStripButton
    Friend WithEvents tbrBlue As ToolStripButton
    Friend WithEvents tbrUpperCase As ToolStripButton
    Friend WithEvents tbrLowerCase As ToolStripButton
    Friend WithEvents tbrHelpAbout As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sspStatus As ToolStripStatusLabel
    Friend WithEvents txtEdit As TextBox

End Class
