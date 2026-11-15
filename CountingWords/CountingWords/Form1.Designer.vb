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
        txtWords = New TextBox()
        Label1 = New Label()
        radCountChars = New RadioButton()
        radCountWords = New RadioButton()
        Label2 = New Label()
        lblResults = New Label()
        btnShowMe = New Button()
        SuspendLayout()
        ' 
        ' txtWords
        ' 
        txtWords.Location = New Point(8, 32)
        txtWords.Multiline = True
        txtWords.Name = "txtWords"
        txtWords.ScrollBars = ScrollBars.Vertical
        txtWords.Size = New Size(400, 217)
        txtWords.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter some text on this box"
        ' 
        ' radCountChars
        ' 
        radCountChars.AutoSize = True
        radCountChars.Checked = True
        radCountChars.Location = New Point(18, 255)
        radCountChars.Name = "radCountChars"
        radCountChars.Size = New Size(55, 19)
        radCountChars.TabIndex = 2
        radCountChars.TabStop = True
        radCountChars.Text = "Chars"
        radCountChars.UseVisualStyleBackColor = True
        ' 
        ' radCountWords
        ' 
        radCountWords.AutoSize = True
        radCountWords.Location = New Point(79, 255)
        radCountWords.Name = "radCountWords"
        radCountWords.Size = New Size(59, 19)
        radCountWords.TabIndex = 3
        radCountWords.Text = "Words"
        radCountWords.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(144, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 4
        Label2.Text = "The Results are: "
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Location = New Point(242, 253)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(0, 15)
        lblResults.TabIndex = 5
        ' 
        ' btnShowMe
        ' 
        btnShowMe.Location = New Point(321, 249)
        btnShowMe.Name = "btnShowMe"
        btnShowMe.Size = New Size(75, 23)
        btnShowMe.TabIndex = 6
        btnShowMe.Text = "Show Me!"
        btnShowMe.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 273)
        Controls.Add(btnShowMe)
        Controls.Add(lblResults)
        Controls.Add(Label2)
        Controls.Add(radCountWords)
        Controls.Add(radCountChars)
        Controls.Add(Label1)
        Controls.Add(txtWords)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtWords As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents radCountChars As RadioButton
    Friend WithEvents radCountWords As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents btnShowMe As Button

End Class
