<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TB_MgrV_LastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_MgrV_FirstName = New System.Windows.Forms.TextBox()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.AddEmployeeButton = New System.Windows.Forms.Button()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.EmployeeIncButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.InactiveButton = New System.Windows.Forms.Button()
        Me.EmployeeListLabel = New System.Windows.Forms.Label()
        Me.ActiveButton = New System.Windows.Forms.Button()
        Me.MainStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.UserToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ManagerNameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainStatusStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_MgrV_LastName
        '
        Me.TB_MgrV_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_MgrV_LastName.Location = New System.Drawing.Point(64, 263)
        Me.TB_MgrV_LastName.Name = "TB_MgrV_LastName"
        Me.TB_MgrV_LastName.Size = New System.Drawing.Size(150, 20)
        Me.TB_MgrV_LastName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'TB_MgrV_FirstName
        '
        Me.TB_MgrV_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_MgrV_FirstName.Location = New System.Drawing.Point(246, 263)
        Me.TB_MgrV_FirstName.Name = "TB_MgrV_FirstName"
        Me.TB_MgrV_FirstName.Size = New System.Drawing.Size(150, 20)
        Me.TB_MgrV_FirstName.TabIndex = 3
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.AllowUserToOrderColumns = True
        Me.EmployeeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(64, 339)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(1133, 320)
        Me.EmployeeDataGridView.TabIndex = 10
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchButton.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(413, 257)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(80, 29)
        Me.SearchButton.TabIndex = 11
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'AddEmployeeButton
        '
        Me.AddEmployeeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddEmployeeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddEmployeeButton.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEmployeeButton.ForeColor = System.Drawing.Color.White
        Me.AddEmployeeButton.Location = New System.Drawing.Point(1077, 304)
        Me.AddEmployeeButton.Name = "AddEmployeeButton"
        Me.AddEmployeeButton.Size = New System.Drawing.Size(120, 29)
        Me.AddEmployeeButton.TabIndex = 13
        Me.AddEmployeeButton.Text = "Add Employee"
        Me.AddEmployeeButton.UseVisualStyleBackColor = False
        '
        'LogOutButton
        '
        Me.LogOutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogOutButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutButton.ForeColor = System.Drawing.Color.White
        Me.LogOutButton.Location = New System.Drawing.Point(1136, 12)
        Me.LogOutButton.Name = "LogOutButton"
        Me.LogOutButton.Size = New System.Drawing.Size(120, 38)
        Me.LogOutButton.TabIndex = 89
        Me.LogOutButton.Text = "LOGOUT"
        Me.LogOutButton.UseVisualStyleBackColor = False
        '
        'EmployeeIncButton
        '
        Me.EmployeeIncButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EmployeeIncButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmployeeIncButton.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIncButton.ForeColor = System.Drawing.Color.White
        Me.EmployeeIncButton.Location = New System.Drawing.Point(64, 665)
        Me.EmployeeIncButton.Name = "EmployeeIncButton"
        Me.EmployeeIncButton.Size = New System.Drawing.Size(245, 29)
        Me.EmployeeIncButton.TabIndex = 90
        Me.EmployeeIncButton.Text = "EMPLOYEE INCOMPLETE DATA"
        Me.EmployeeIncButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(1136, 56)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(120, 38)
        Me.CloseButton.TabIndex = 91
        Me.CloseButton.Text = " CLOSE"
        Me.CloseButton.UseVisualStyleBackColor = False
        Me.CloseButton.Visible = False
        '
        'InactiveButton
        '
        Me.InactiveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InactiveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InactiveButton.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InactiveButton.ForeColor = System.Drawing.Color.White
        Me.InactiveButton.Location = New System.Drawing.Point(1116, 665)
        Me.InactiveButton.Name = "InactiveButton"
        Me.InactiveButton.Size = New System.Drawing.Size(80, 29)
        Me.InactiveButton.TabIndex = 14
        Me.InactiveButton.Text = "INACTIVE"
        Me.InactiveButton.UseVisualStyleBackColor = False
        '
        'EmployeeListLabel
        '
        Me.EmployeeListLabel.AutoSize = True
        Me.EmployeeListLabel.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeListLabel.ForeColor = System.Drawing.Color.Maroon
        Me.EmployeeListLabel.Location = New System.Drawing.Point(67, 304)
        Me.EmployeeListLabel.Name = "EmployeeListLabel"
        Me.EmployeeListLabel.Size = New System.Drawing.Size(164, 26)
        Me.EmployeeListLabel.TabIndex = 92
        Me.EmployeeListLabel.Text = "Active Employees"
        '
        'ActiveButton
        '
        Me.ActiveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActiveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ActiveButton.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveButton.ForeColor = System.Drawing.Color.White
        Me.ActiveButton.Location = New System.Drawing.Point(1030, 665)
        Me.ActiveButton.Name = "ActiveButton"
        Me.ActiveButton.Size = New System.Drawing.Size(80, 29)
        Me.ActiveButton.TabIndex = 93
        Me.ActiveButton.Text = "ACTIVE"
        Me.ActiveButton.UseVisualStyleBackColor = False
        '
        'MainStatusStrip
        '
        Me.MainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripStatusLabel})
        Me.MainStatusStrip.Location = New System.Drawing.Point(0, 740)
        Me.MainStatusStrip.Name = "MainStatusStrip"
        Me.MainStatusStrip.Size = New System.Drawing.Size(1264, 22)
        Me.MainStatusStrip.TabIndex = 94
        Me.MainStatusStrip.Text = "StatusStrip1"
        '
        'UserToolStripStatusLabel
        '
        Me.UserToolStripStatusLabel.Name = "UserToolStripStatusLabel"
        Me.UserToolStripStatusLabel.Size = New System.Drawing.Size(79, 17)
        Me.UserToolStripStatusLabel.Text = "Current User: "
        '
        'ManagerNameLabel
        '
        Me.ManagerNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManagerNameLabel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ManagerNameLabel.Location = New System.Drawing.Point(0, 215)
        Me.ManagerNameLabel.Name = "ManagerNameLabel"
        Me.ManagerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ManagerNameLabel.Size = New System.Drawing.Size(1264, 19)
        Me.ManagerNameLabel.TabIndex = 0
        Me.ManagerNameLabel.Text = "Label_ManagerName"
        Me.ManagerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.alorica_banner1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1264, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Corbel", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1264, 49)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ALORICA EMPLOYEE DIRECTORY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1264, 762)
        Me.Controls.Add(Me.MainStatusStrip)
        Me.Controls.Add(Me.ActiveButton)
        Me.Controls.Add(Me.EmployeeListLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ManagerNameLabel)
        Me.Controls.Add(Me.EmployeeIncButton)
        Me.Controls.Add(Me.LogOutButton)
        Me.Controls.Add(Me.InactiveButton)
        Me.Controls.Add(Me.AddEmployeeButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TB_MgrV_FirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_MgrV_LastName)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 758)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IT APP DEV EMPLOYEE DIRECTORY"
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainStatusStrip.ResumeLayout(False)
        Me.MainStatusStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_MgrV_LastName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_MgrV_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents AddEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents LogOutButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeIncButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents InactiveButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeListLabel As System.Windows.Forms.Label
    Friend WithEvents ActiveButton As System.Windows.Forms.Button
    Friend WithEvents MainStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents UserToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ManagerNameLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
