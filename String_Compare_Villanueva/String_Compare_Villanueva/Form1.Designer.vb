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
        Button1 = New Button()
        Button2 = New Button()
        txtName1 = New TextBox()
        txtName2 = New TextBox()
        btnStringCompare = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(518, 108)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 60)
        Button1.TabIndex = 0
        Button1.Text = "Or Check"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(518, 189)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 66)
        Button2.TabIndex = 1
        Button2.Text = "And Check"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtName1
        ' 
        txtName1.Location = New Point(308, 128)
        txtName1.Name = "txtName1"
        txtName1.Size = New Size(164, 23)
        txtName1.TabIndex = 2
        ' 
        ' txtName2
        ' 
        txtName2.Location = New Point(287, 212)
        txtName2.Name = "txtName2"
        txtName2.Size = New Size(185, 23)
        txtName2.TabIndex = 3
        ' 
        ' btnStringCompare
        ' 
        btnStringCompare.Location = New Point(518, 301)
        btnStringCompare.Name = "btnStringCompare"
        btnStringCompare.Size = New Size(166, 70)
        btnStringCompare.TabIndex = 4
        btnStringCompare.Text = "String Compare"
        btnStringCompare.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnStringCompare)
        Controls.Add(txtName2)
        Controls.Add(txtName1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents btnStringCompare As Button

End Class
