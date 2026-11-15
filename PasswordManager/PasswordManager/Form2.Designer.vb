<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormView
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtKeywordSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvCredentials = New System.Windows.Forms.DataGridView()
        Me.cmbFilters = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkViewByFilter = New System.Windows.Forms.CheckBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.pnlRightControls = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvCredentials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContainer.SuspendLayout()
        Me.pnlRightControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(20, 20, 20)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 60
        Me.pnlHeader.Name = "pnlHeader"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(255, 135, 0)
        Me.lblTitle.Location = New System.Drawing.Point(25, 15)
        Me.lblTitle.Text = "🔐 View Stored Credentials"
        '
        'pnlContainer
        '
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(28, 28, 28)
        Me.pnlContainer.Padding = New System.Windows.Forms.Padding(25)
        Me.pnlContainer.Controls.Add(Me.dgvCredentials)
        Me.pnlContainer.Controls.Add(Me.pnlRightControls)
        '
        'dgvCredentials
        '
        Me.dgvCredentials.AllowUserToAddRows = False
        Me.dgvCredentials.AllowUserToDeleteRows = False
        Me.dgvCredentials.AllowUserToResizeRows = False
        Me.dgvCredentials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCredentials.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 24)
        Me.dgvCredentials.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCredentials.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCredentials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(36, 36, 36)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(255, 135, 0)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCredentials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30)
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(255, 135, 0)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCredentials.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCredentials.EnableHeadersVisualStyles = False
        Me.dgvCredentials.GridColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.dgvCredentials.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCredentials.Margin = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.dgvCredentials.ReadOnly = True
        Me.dgvCredentials.RowHeadersVisible = False
        Me.dgvCredentials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'pnlRightControls
        '
        Me.pnlRightControls.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRightControls.Width = 250
        Me.pnlRightControls.BackColor = System.Drawing.Color.FromArgb(18, 18, 18)
        Me.pnlRightControls.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlRightControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRightControls.Controls.Add(Me.Label1)
        Me.pnlRightControls.Controls.Add(Me.txtKeywordSearch)
        Me.pnlRightControls.Controls.Add(Me.btnSearch)
        Me.pnlRightControls.Controls.Add(Me.chkViewByFilter)
        Me.pnlRightControls.Controls.Add(Me.cmbFilters)
        Me.pnlRightControls.Controls.Add(Me.Label2)
        Me.pnlRightControls.Controls.Add(Me.btnEdit)
        Me.pnlRightControls.Controls.Add(Me.btnDelete)
        Me.pnlRightControls.Controls.Add(Me.btnBack)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Text = "Enter Keyword:"
        '
        'txtKeywordSearch
        '
        Me.txtKeywordSearch.BackColor = System.Drawing.Color.FromArgb(32, 32, 32)
        Me.txtKeywordSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeywordSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtKeywordSearch.ForeColor = System.Drawing.Color.White
        Me.txtKeywordSearch.Location = New System.Drawing.Point(10, 35)
        Me.txtKeywordSearch.Width = 210
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(255, 135, 0)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(10, 70)
        Me.btnSearch.Size = New System.Drawing.Size(210, 30)
        Me.btnSearch.Text = "Search"
        '
        'chkViewByFilter
        '
        Me.chkViewByFilter.AutoSize = True
        Me.chkViewByFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.chkViewByFilter.ForeColor = System.Drawing.Color.Gainsboro
        Me.chkViewByFilter.Location = New System.Drawing.Point(10, 120)
        Me.chkViewByFilter.Text = "Filter by Tag:"
        '
        'cmbFilters
        '
        Me.cmbFilters.BackColor = System.Drawing.Color.FromArgb(32, 32, 32)
        Me.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFilters.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFilters.ForeColor = System.Drawing.Color.White
        Me.cmbFilters.Location = New System.Drawing.Point(10, 145)
        Me.cmbFilters.Width = 210
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(10, 175)
        Me.Label2.Text = "(optional)"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(50, 50, 50)
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnEdit.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEdit.Location = New System.Drawing.Point(10, 230)
        Me.btnEdit.Size = New System.Drawing.Size(210, 35)
        Me.btnEdit.Text = "Edit"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(10, 275)
        Me.btnDelete.Size = New System.Drawing.Size(210, 35)
        Me.btnDelete.Text = "Delete"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(50, 50, 50)
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnBack.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBack.Location = New System.Drawing.Point(10, 320)
        Me.btnBack.Size = New System.Drawing.Size(210, 35)
        Me.btnBack.Text = "Back"
        '
        'FormView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(18, 18, 18)
        Me.ClientSize = New System.Drawing.Size(880, 540)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Credentials"
        CType(Me.dgvCredentials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlRightControls.ResumeLayout(False)
        Me.pnlRightControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtKeywordSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvCredentials As DataGridView
    Friend WithEvents cmbFilters As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkViewByFilter As CheckBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents pnlRightControls As Panel
    Friend WithEvents btnBack As Button
End Class
