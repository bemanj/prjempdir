<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordReset
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
        Me.ResetAllButton = New System.Windows.Forms.Button()
        Me.ResetSelectedButton = New System.Windows.Forms.Button()
        Me.EmpNamesLabel = New System.Windows.Forms.Label()
        Me.PasswordResetGrid = New System.Windows.Forms.DataGridView()
        Me.PasswordResetLabel = New System.Windows.Forms.Label()
        Me.PasswordResetHeader = New System.Windows.Forms.PictureBox()
        CType(Me.PasswordResetGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordResetHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResetAllButton
        '
        Me.ResetAllButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResetAllButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetAllButton.ForeColor = System.Drawing.Color.White
        Me.ResetAllButton.Location = New System.Drawing.Point(409, 239)
        Me.ResetAllButton.Name = "ResetAllButton"
        Me.ResetAllButton.Size = New System.Drawing.Size(194, 38)
        Me.ResetAllButton.TabIndex = 165
        Me.ResetAllButton.Text = "RESET ALL"
        Me.ResetAllButton.UseVisualStyleBackColor = False
        '
        'ResetSelectedButton
        '
        Me.ResetSelectedButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResetSelectedButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetSelectedButton.ForeColor = System.Drawing.Color.White
        Me.ResetSelectedButton.Location = New System.Drawing.Point(409, 186)
        Me.ResetSelectedButton.Name = "ResetSelectedButton"
        Me.ResetSelectedButton.Size = New System.Drawing.Size(194, 38)
        Me.ResetSelectedButton.TabIndex = 164
        Me.ResetSelectedButton.Text = "RESET SELECTED"
        Me.ResetSelectedButton.UseVisualStyleBackColor = False
        '
        'EmpNamesLabel
        '
        Me.EmpNamesLabel.AutoSize = True
        Me.EmpNamesLabel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.EmpNamesLabel.ForeColor = System.Drawing.Color.Maroon
        Me.EmpNamesLabel.Location = New System.Drawing.Point(30, 162)
        Me.EmpNamesLabel.Name = "EmpNamesLabel"
        Me.EmpNamesLabel.Size = New System.Drawing.Size(130, 19)
        Me.EmpNamesLabel.TabIndex = 163
        Me.EmpNamesLabel.Text = "Employee Names"
        '
        'PasswordResetGrid
        '
        Me.PasswordResetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PasswordResetGrid.Location = New System.Drawing.Point(30, 186)
        Me.PasswordResetGrid.Name = "PasswordResetGrid"
        Me.PasswordResetGrid.Size = New System.Drawing.Size(362, 230)
        Me.PasswordResetGrid.TabIndex = 162
        '
        'PasswordResetLabel
        '
        Me.PasswordResetLabel.AutoSize = True
        Me.PasswordResetLabel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordResetLabel.Location = New System.Drawing.Point(248, 124)
        Me.PasswordResetLabel.Name = "PasswordResetLabel"
        Me.PasswordResetLabel.Size = New System.Drawing.Size(144, 19)
        Me.PasswordResetLabel.TabIndex = 161
        Me.PasswordResetLabel.Text = "PASSWORD RESET"
        '
        'PasswordResetHeader
        '
        Me.PasswordResetHeader.Image = Global.WindowsApplication1.My.Resources.Resources.alorica1
        Me.PasswordResetHeader.Location = New System.Drawing.Point(-3, -1)
        Me.PasswordResetHeader.Name = "PasswordResetHeader"
        Me.PasswordResetHeader.Size = New System.Drawing.Size(655, 110)
        Me.PasswordResetHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PasswordResetHeader.TabIndex = 160
        Me.PasswordResetHeader.TabStop = False
        '
        'PasswordReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 450)
        Me.Controls.Add(Me.ResetAllButton)
        Me.Controls.Add(Me.ResetSelectedButton)
        Me.Controls.Add(Me.EmpNamesLabel)
        Me.Controls.Add(Me.PasswordResetGrid)
        Me.Controls.Add(Me.PasswordResetLabel)
        Me.Controls.Add(Me.PasswordResetHeader)
        Me.Name = "PasswordReset"
        Me.Text = "ADMIN: PASSWORD RESET"
        CType(Me.PasswordResetGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordResetHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ResetAllButton As System.Windows.Forms.Button
    Friend WithEvents ResetSelectedButton As System.Windows.Forms.Button
    Friend WithEvents EmpNamesLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordResetGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PasswordResetLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordResetHeader As System.Windows.Forms.PictureBox
End Class
