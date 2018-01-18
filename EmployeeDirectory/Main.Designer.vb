<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TB_MgrV_LastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_MgrV_FirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_MgrV_MiddleIn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_MgrV_OracleID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewEmployee = New System.Windows.Forms.DataGridView()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.Btn_EmpInc = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_MgrV_LastName
        '
        Me.TB_MgrV_LastName.Location = New System.Drawing.Point(80, 304)
        Me.TB_MgrV_LastName.Name = "TB_MgrV_LastName"
        Me.TB_MgrV_LastName.Size = New System.Drawing.Size(150, 21)
        Me.TB_MgrV_LastName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'TB_MgrV_FirstName
        '
        Me.TB_MgrV_FirstName.Location = New System.Drawing.Point(262, 304)
        Me.TB_MgrV_FirstName.Name = "TB_MgrV_FirstName"
        Me.TB_MgrV_FirstName.Size = New System.Drawing.Size(150, 21)
        Me.TB_MgrV_FirstName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(439, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "M.I."
        '
        'TB_MgrV_MiddleIn
        '
        Me.TB_MgrV_MiddleIn.Location = New System.Drawing.Point(442, 304)
        Me.TB_MgrV_MiddleIn.Name = "TB_MgrV_MiddleIn"
        Me.TB_MgrV_MiddleIn.Size = New System.Drawing.Size(20, 21)
        Me.TB_MgrV_MiddleIn.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Oracle ID"
        '
        'TB_MgrV_OracleID
        '
        Me.TB_MgrV_OracleID.Location = New System.Drawing.Point(80, 256)
        Me.TB_MgrV_OracleID.Name = "TB_MgrV_OracleID"
        Me.TB_MgrV_OracleID.Size = New System.Drawing.Size(100, 21)
        Me.TB_MgrV_OracleID.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(285, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(608, 49)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ALORICA EMPLOYEE DIRECTORY"
        '
        'DataGridViewEmployee
        '
        Me.DataGridViewEmployee.AllowUserToAddRows = False
        Me.DataGridViewEmployee.AllowUserToDeleteRows = False
        Me.DataGridViewEmployee.AllowUserToOrderColumns = True
        Me.DataGridViewEmployee.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEmployee.Location = New System.Drawing.Point(80, 339)
        Me.DataGridViewEmployee.Name = "DataGridViewEmployee"
        Me.DataGridViewEmployee.ReadOnly = True
        Me.DataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEmployee.Size = New System.Drawing.Size(995, 442)
        Me.DataGridViewEmployee.TabIndex = 10
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Search.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.Location = New System.Drawing.Point(726, 304)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(80, 29)
        Me.Btn_Search.TabIndex = 11
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Edit
        '
        Me.Btn_Edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Edit.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Edit.Location = New System.Drawing.Point(812, 304)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(80, 29)
        Me.Btn_Edit.TabIndex = 12
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = False
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Add.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.Location = New System.Drawing.Point(898, 304)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(80, 29)
        Me.Btn_Add.TabIndex = 13
        Me.Btn_Add.Text = "Add New"
        Me.Btn_Add.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(984, 304)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 29)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(994, 787)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 29)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "NEXT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(908, 787)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 29)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "PREVIOUS"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLogOut.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogOut.Location = New System.Drawing.Point(1032, 12)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(120, 38)
        Me.BtnLogOut.TabIndex = 89
        Me.BtnLogOut.Text = "LOGOUT"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'Btn_EmpInc
        '
        Me.Btn_EmpInc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_EmpInc.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EmpInc.Location = New System.Drawing.Point(81, 787)
        Me.Btn_EmpInc.Name = "Btn_EmpInc"
        Me.Btn_EmpInc.Size = New System.Drawing.Size(245, 29)
        Me.Btn_EmpInc.TabIndex = 90
        Me.Btn_EmpInc.Text = "EMPLOYEE INCOMPLETE DATA"
        Me.Btn_EmpInc.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.alorica_banner1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1164, 163)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 862)
        Me.Controls.Add(Me.Btn_EmpInc)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.DataGridViewEmployee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TB_MgrV_OracleID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_MgrV_MiddleIn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_MgrV_FirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_MgrV_LastName)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "IT APP DEV EMPLOYEE DIRECTORY"
        CType(Me.DataGridViewEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_MgrV_LastName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_MgrV_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_MgrV_MiddleIn As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_MgrV_OracleID As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Btn_Edit As System.Windows.Forms.Button
    Friend WithEvents Btn_Add As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents Btn_EmpInc As System.Windows.Forms.Button

End Class
