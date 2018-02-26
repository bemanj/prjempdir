<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminNew
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
        Me.AdminMainLogoutButton = New System.Windows.Forms.Button()
        Me.AddNewSiteButton = New System.Windows.Forms.Button()
        Me.PasswordResetButton = New System.Windows.Forms.Button()
        Me.EmployeeDirButton = New System.Windows.Forms.Button()
        Me.WelcomeAdminLabel = New System.Windows.Forms.Label()
        Me.AdminMainFooter = New System.Windows.Forms.PictureBox()
        Me.AdminMainHeader = New System.Windows.Forms.PictureBox()
        CType(Me.AdminMainFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminMainHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminMainLogoutButton
        '
        Me.AdminMainLogoutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AdminMainLogoutButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminMainLogoutButton.ForeColor = System.Drawing.Color.White
        Me.AdminMainLogoutButton.Location = New System.Drawing.Point(207, 283)
        Me.AdminMainLogoutButton.Name = "AdminMainLogoutButton"
        Me.AdminMainLogoutButton.Size = New System.Drawing.Size(223, 33)
        Me.AdminMainLogoutButton.TabIndex = 18
        Me.AdminMainLogoutButton.Text = "LOGOUT"
        Me.AdminMainLogoutButton.UseVisualStyleBackColor = False
        '
        'AddNewSiteButton
        '
        Me.AddNewSiteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddNewSiteButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewSiteButton.ForeColor = System.Drawing.Color.White
        Me.AddNewSiteButton.Location = New System.Drawing.Point(207, 203)
        Me.AddNewSiteButton.Name = "AddNewSiteButton"
        Me.AddNewSiteButton.Size = New System.Drawing.Size(223, 33)
        Me.AddNewSiteButton.TabIndex = 17
        Me.AddNewSiteButton.Text = "ADD NEW ALORICA SITE"
        Me.AddNewSiteButton.UseVisualStyleBackColor = False
        '
        'PasswordResetButton
        '
        Me.PasswordResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PasswordResetButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordResetButton.ForeColor = System.Drawing.Color.White
        Me.PasswordResetButton.Location = New System.Drawing.Point(207, 242)
        Me.PasswordResetButton.Name = "PasswordResetButton"
        Me.PasswordResetButton.Size = New System.Drawing.Size(223, 33)
        Me.PasswordResetButton.TabIndex = 16
        Me.PasswordResetButton.Text = "PASSWORD RESET"
        Me.PasswordResetButton.UseVisualStyleBackColor = False
        '
        'EmployeeDirButton
        '
        Me.EmployeeDirButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmployeeDirButton.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeDirButton.ForeColor = System.Drawing.Color.White
        Me.EmployeeDirButton.Location = New System.Drawing.Point(207, 164)
        Me.EmployeeDirButton.Name = "EmployeeDirButton"
        Me.EmployeeDirButton.Size = New System.Drawing.Size(223, 33)
        Me.EmployeeDirButton.TabIndex = 15
        Me.EmployeeDirButton.Text = "EMPLOYEE DIRECTORY"
        Me.EmployeeDirButton.UseVisualStyleBackColor = False
        '
        'WelcomeAdminLabel
        '
        Me.WelcomeAdminLabel.AutoSize = True
        Me.WelcomeAdminLabel.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeAdminLabel.Location = New System.Drawing.Point(248, 123)
        Me.WelcomeAdminLabel.Name = "WelcomeAdminLabel"
        Me.WelcomeAdminLabel.Size = New System.Drawing.Size(142, 19)
        Me.WelcomeAdminLabel.TabIndex = 14
        Me.WelcomeAdminLabel.Text = "WELCOME ADMIN!"
        '
        'AdminMainFooter
        '
        Me.AdminMainFooter.Image = Global.WindowsApplication1.My.Resources.Resources.alorica_login
        Me.AdminMainFooter.Location = New System.Drawing.Point(-9, 334)
        Me.AdminMainFooter.Name = "AdminMainFooter"
        Me.AdminMainFooter.Size = New System.Drawing.Size(655, 289)
        Me.AdminMainFooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AdminMainFooter.TabIndex = 13
        Me.AdminMainFooter.TabStop = False
        '
        'AdminMainHeader
        '
        Me.AdminMainHeader.Image = Global.WindowsApplication1.My.Resources.Resources.alorica1
        Me.AdminMainHeader.Location = New System.Drawing.Point(-9, -5)
        Me.AdminMainHeader.Name = "AdminMainHeader"
        Me.AdminMainHeader.Size = New System.Drawing.Size(655, 110)
        Me.AdminMainHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AdminMainHeader.TabIndex = 12
        Me.AdminMainHeader.TabStop = False
        '
        'AdminNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 618)
        Me.Controls.Add(Me.AdminMainLogoutButton)
        Me.Controls.Add(Me.AddNewSiteButton)
        Me.Controls.Add(Me.PasswordResetButton)
        Me.Controls.Add(Me.EmployeeDirButton)
        Me.Controls.Add(Me.WelcomeAdminLabel)
        Me.Controls.Add(Me.AdminMainFooter)
        Me.Controls.Add(Me.AdminMainHeader)
        Me.Name = "AdminNew"
        Me.Text = "Administrator"
        CType(Me.AdminMainFooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminMainHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminMainLogoutButton As System.Windows.Forms.Button
    Friend WithEvents AddNewSiteButton As System.Windows.Forms.Button
    Friend WithEvents PasswordResetButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeDirButton As System.Windows.Forms.Button
    Friend WithEvents WelcomeAdminLabel As System.Windows.Forms.Label
    Friend WithEvents AdminMainFooter As System.Windows.Forms.PictureBox
    Friend WithEvents AdminMainHeader As System.Windows.Forms.PictureBox
End Class
