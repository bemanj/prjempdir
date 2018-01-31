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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TB_MgrV_LastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_MgrV_FirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_MgrV_OracleID = New System.Windows.Forms.TextBox()
        Me.DataGridViewEmployee = New System.Windows.Forms.DataGridView()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.Btn_EmpInc = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ButtonSFC = New System.Windows.Forms.Button()
        Me.LabelSFC = New System.Windows.Forms.Label()
        Me.ButtonActive = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label_ManagerName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_MgrV_LastName
        '
        Me.TB_MgrV_LastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_MgrV_LastName.Location = New System.Drawing.Point(80, 263)
        Me.TB_MgrV_LastName.Name = "TB_MgrV_LastName"
        Me.TB_MgrV_LastName.Size = New System.Drawing.Size(150, 20)
        Me.TB_MgrV_LastName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'TB_MgrV_FirstName
        '
        Me.TB_MgrV_FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_MgrV_FirstName.Location = New System.Drawing.Point(262, 263)
        Me.TB_MgrV_FirstName.Name = "TB_MgrV_FirstName"
        Me.TB_MgrV_FirstName.Size = New System.Drawing.Size(150, 20)
        Me.TB_MgrV_FirstName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Oracle ID"
        '
        'TB_MgrV_OracleID
        '
        Me.TB_MgrV_OracleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TB_MgrV_OracleID.Location = New System.Drawing.Point(80, 215)
        Me.TB_MgrV_OracleID.Name = "TB_MgrV_OracleID"
        Me.TB_MgrV_OracleID.Size = New System.Drawing.Size(100, 20)
        Me.TB_MgrV_OracleID.TabIndex = 7
        '
        'DataGridViewEmployee
        '
        Me.DataGridViewEmployee.AllowUserToAddRows = False
        Me.DataGridViewEmployee.AllowUserToDeleteRows = False
        Me.DataGridViewEmployee.AllowUserToOrderColumns = True
        Me.DataGridViewEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewEmployee.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewEmployee.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewEmployee.Location = New System.Drawing.Point(80, 339)
        Me.DataGridViewEmployee.Name = "DataGridViewEmployee"
        Me.DataGridViewEmployee.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEmployee.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewEmployee.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEmployee.Size = New System.Drawing.Size(1145, 442)
        Me.DataGridViewEmployee.TabIndex = 10
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Search.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.Location = New System.Drawing.Point(429, 257)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(80, 29)
        Me.Btn_Search.TabIndex = 11
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Add
        '
        Me.Btn_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Add.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Location = New System.Drawing.Point(1145, 304)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(80, 29)
        Me.Btn_Add.TabIndex = 13
        Me.Btn_Add.Text = "Add New"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLogOut.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogOut.Location = New System.Drawing.Point(1182, 12)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(120, 38)
        Me.BtnLogOut.TabIndex = 89
        Me.BtnLogOut.Text = "LOGOUT"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'Btn_EmpInc
        '
        Me.Btn_EmpInc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_EmpInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_EmpInc.Enabled = False
        Me.Btn_EmpInc.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EmpInc.Location = New System.Drawing.Point(81, 787)
        Me.Btn_EmpInc.Name = "Btn_EmpInc"
        Me.Btn_EmpInc.Size = New System.Drawing.Size(245, 29)
        Me.Btn_EmpInc.TabIndex = 90
        Me.Btn_EmpInc.Text = "EMPLOYEE INCOMPLETE DATA"
        Me.Btn_EmpInc.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(1182, 56)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(120, 38)
        Me.BtnClose.TabIndex = 91
        Me.BtnClose.Text = " CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        Me.BtnClose.Visible = False
        '
        'ButtonSFC
        '
        Me.ButtonSFC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSFC.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSFC.Location = New System.Drawing.Point(1145, 787)
        Me.ButtonSFC.Name = "ButtonSFC"
        Me.ButtonSFC.Size = New System.Drawing.Size(80, 29)
        Me.ButtonSFC.TabIndex = 14
        Me.ButtonSFC.Text = "SFC"
        Me.ButtonSFC.UseVisualStyleBackColor = False
        '
        'LabelSFC
        '
        Me.LabelSFC.AutoSize = True
        Me.LabelSFC.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSFC.ForeColor = System.Drawing.Color.Maroon
        Me.LabelSFC.Location = New System.Drawing.Point(83, 304)
        Me.LabelSFC.Name = "LabelSFC"
        Me.LabelSFC.Size = New System.Drawing.Size(175, 26)
        Me.LabelSFC.TabIndex = 92
        Me.LabelSFC.Text = "Current Employees"
        '
        'ButtonActive
        '
        Me.ButtonActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonActive.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActive.Location = New System.Drawing.Point(1059, 787)
        Me.ButtonActive.Name = "ButtonActive"
        Me.ButtonActive.Size = New System.Drawing.Size(80, 29)
        Me.ButtonActive.TabIndex = 93
        Me.ButtonActive.Text = "ACTIVE"
        Me.ButtonActive.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 840)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1314, 22)
        Me.StatusStrip1.TabIndex = 94
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelUser
        '
        Me.ToolStripStatusLabelUser.Name = "ToolStripStatusLabelUser"
        Me.ToolStripStatusLabelUser.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabelUser.Text = "Current User: "
        '
        'Label_ManagerName
        '
        Me.Label_ManagerName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_ManagerName.AutoSize = True
        Me.Label_ManagerName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_ManagerName.Location = New System.Drawing.Point(576, 217)
        Me.Label_ManagerName.Name = "Label_ManagerName"
        Me.Label_ManagerName.Size = New System.Drawing.Size(158, 19)
        Me.Label_ManagerName.TabIndex = 0
        Me.Label_ManagerName.Text = "Label_ManagerName"
        Me.Label_ManagerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.alorica_banner1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1314, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(360, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(608, 49)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ALORICA EMPLOYEE DIRECTORY"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1314, 862)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ButtonActive)
        Me.Controls.Add(Me.LabelSFC)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label_ManagerName)
        Me.Controls.Add(Me.Btn_EmpInc)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.ButtonSFC)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.DataGridViewEmployee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TB_MgrV_OracleID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_MgrV_FirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_MgrV_LastName)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1330, 900)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IT APP DEV EMPLOYEE DIRECTORY"
        CType(Me.DataGridViewEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_MgrV_LastName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_MgrV_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_MgrV_OracleID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Btn_Add As System.Windows.Forms.Button
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents Btn_EmpInc As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents ButtonSFC As System.Windows.Forms.Button
    Friend WithEvents LabelSFC As System.Windows.Forms.Label
    Friend WithEvents ButtonActive As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label_ManagerName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
