<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncompleteEmployees
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IncompleteEmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmployeeListLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncompleteEmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.alorica_banner1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(895, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'IncompleteEmployeeDataGridView
        '
        Me.IncompleteEmployeeDataGridView.AllowUserToAddRows = False
        Me.IncompleteEmployeeDataGridView.AllowUserToDeleteRows = False
        Me.IncompleteEmployeeDataGridView.AllowUserToOrderColumns = True
        Me.IncompleteEmployeeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IncompleteEmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.IncompleteEmployeeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IncompleteEmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncompleteEmployeeDataGridView.Location = New System.Drawing.Point(61, 220)
        Me.IncompleteEmployeeDataGridView.Name = "IncompleteEmployeeDataGridView"
        Me.IncompleteEmployeeDataGridView.ReadOnly = True
        Me.IncompleteEmployeeDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IncompleteEmployeeDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncompleteEmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.IncompleteEmployeeDataGridView.Size = New System.Drawing.Size(772, 375)
        Me.IncompleteEmployeeDataGridView.TabIndex = 11
        '
        'EmployeeListLabel
        '
        Me.EmployeeListLabel.AutoSize = True
        Me.EmployeeListLabel.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeListLabel.ForeColor = System.Drawing.Color.Maroon
        Me.EmployeeListLabel.Location = New System.Drawing.Point(56, 191)
        Me.EmployeeListLabel.Name = "EmployeeListLabel"
        Me.EmployeeListLabel.Size = New System.Drawing.Size(350, 26)
        Me.EmployeeListLabel.TabIndex = 93
        Me.EmployeeListLabel.Text = "List of Employees with Incomplete Data"
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(713, 31)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(120, 38)
        Me.CloseButton.TabIndex = 95
        Me.CloseButton.Text = " CLOSE"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'IncompleteEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 648)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.EmployeeListLabel)
        Me.Controls.Add(Me.IncompleteEmployeeDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "IncompleteEmployees"
        Me.Text = "IncompleteEmployees"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncompleteEmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents IncompleteEmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeeListLabel As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
