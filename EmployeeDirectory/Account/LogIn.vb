Public Class LogIn

    'Private _LoginRepository As New LoginRepository
    'Private loginView As New LoginView
    ' Private mg As New ManagerGrid
    'Private _managerRepository As ManagerRepository
    'Private dt As New DataTable
    ' Private ls As New List(Of ManagerGrid)
    Private _loginService As LogInService

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '_managerRepository = New ManagerRepository()
        _loginService = New LogInService()
    End Sub

    Private Sub SignInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInButton.Click
        
        'Dim _LoginViewTemp = _LogInService.SelectUser(Username.Text, UsernamePassword.Text)
        'If Username.Text = Nothing Or              '***BUG FIXED - jlavares 01/31/2018*****
        '    Not IsNumeric(Username.Text) Then      ' - changed to create generic message for scty purpose

        '    MsgBox("Invalid/Blank UserName")
        '    Username.Clear()
        '    UsernamePassword.Clear()

        'ElseIf UsernamePassword.Text = Nothing Then
        '    MsgBox("Blank Password")

        Dim tempCharCount As Long = 0                          '***BUG FIXED - jlavares 02/1/2018*****
        Dim tempPasswordCharCount As Long = 0                       ' - changed to handle data value overflow
        tempCharCount = UsernameTextBox.Text.Length                   ' - change the msgbox title and add new message
        tempPasswordCharCount = PasswordTextBox.Text.Length

        If UsernameTextBox.Text = Nothing Or
            PasswordTextBox.Text = Nothing Then

            MessageBox.Show(MessageRequiredFields, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clearAndFocus()
        ElseIf Not IsNumeric(UsernameTextBox.Text) Or
            tempCharCount > 10 Or
            tempPasswordCharCount > 10 Then

            MessageBox.Show("Invalid UserName or Password", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clearAndFocus()
        Else
            Dim tempLoginView = _loginService.SelectUser(UsernameTextBox.Text, PasswordTextBox.Text)

            If IsNothing(tempLoginView) Or
                IsDBNull(tempLoginView) Then
                RecorNotFound.ShowDialog()
                RecorNotFound.Label2.Text = "PLEASE CONTACT YOUR MANAGER"
            Else
                CurrentUser = tempLoginView.OracleID
                CurrentUserType = tempLoginView.UserType
                If CurrentUserType = 1 Then     'ADMIN'
                    Me.Hide()
                    Admin.Show()
                ElseIf CurrentUserType = 2 Then 'MANAGER'
                    Me.Hide()
                    Main.Show()

                    ''FOR TRANSFER IN DESIGNATED FORM BY: RAIN AND BERT 2018
                    EmployeeInfo.TB_SiteZip.Enabled = False
                    ''''' ***** LMRS START: Code to display Manager's Name ***** '''''
                    Main.ManagerNameLabel.Text = (tempLoginView.LastName & ", " & tempLoginView.FirstName & " " & tempLoginView.MiddleName)
                    ''''' ***** LMRS END: Code to display Manager's Name ***** '''''
                    Main.ToolStripStatusLabelUser.Text = "Current User: " & tempLoginView.FirstName & " " & tempLoginView.LastName
                    'dt.Clear()
                    Main.ButtonActive_Click(e, e)

                ElseIf CurrentUserType = 3 Then 'USER'
                    Me.Hide()
                    EmployeeInfo.Show()

                    'FOR TRANSFER IN DESIGNATED FORM BY: RAIN AND BERT 2018
                    EmployeeInfo.IsEdit = True
                    EmployeeInfo.EmployeeInfo_Load(e, e)
                    EmployeeInfo.Btn_Cancel.Hide()
                    EmployeeInfo.TB_OracleID.Enabled = False
                    EmployeeInfo.TB_Title.Enabled = False
                    EmployeeInfo.TB_Position.Enabled = False
                    EmployeeInfo.MB_PhoneExtension.Enabled = False
                    EmployeeInfo.TB_OfficeEmail.Enabled = False
                    EmployeeInfo.CB_Team.Enabled = False
                    EmployeeInfo.CB_LocalMgr.Enabled = False
                    EmployeeInfo.CB_Site.Enabled = False
                    'EmployeeInfo.TB_AddressLine1.Enabled = False
                    'EmployeeInfo.TB_AddressLine2.Enabled = False
                    'EmployeeInfo.TB_SiteCity.Enabled = False
                    'EmployeeInfo.TB_SiteZip.Enabled = False
                    'EmployeeInfo.TB_SiteRegion.Enabled = False
                    'EmployeeInfo.TB_SiteCountry.Enabled = False
                    EmployeeInfo.TB_Floor.Enabled = False
                    EmployeeInfo.TB_SeatNo.Enabled = False
                    EmployeeInfo.TB_OnboardingTkt.Enabled = False
                    EmployeeInfo.TB_Recruiter.Enabled = False
                    EmployeeInfo.CB_SFC.Enabled = False
                    EmployeeInfo.DT_SFCDate.Enabled = False
                    EmployeeInfo.CB_IDCreated.Enabled = False
                    EmployeeInfo.CB_Shift.Enabled = False
                    EmployeeInfo.TB_MercuryID.Enabled = False
                    EmployeeInfo.TB_EISID.Enabled = False
                    EmployeeInfo.TB_OraclePRD.Enabled = False
                Else
                    RecorNotFound.ShowDialog()
                    RecorNotFound.Label2.Text = "PLEASE CONTACT ADMIN"
                End If
            End If
        End If
    End Sub

    Public Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearAndFocus()
    End Sub

    '***** Will perform Submit Button when Enter is pressed *******
    Private Sub LoginTextBoxes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress, PasswordTextBox.KeyPress
        'If sender.GetType() = GetType(TextBox) Then
        '    If CType(sender, TextBox).Name = "NameTextBox" Then
        '        NameTextBoxKeyPress()
        '    End If
        'End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.SignInButton_Click(sender, e)
        End If
    End Sub

    'Private Sub NameTextBoxKeyPress()

    'End Sub

    Private Sub clearAndFocus()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        UsernameTextBox.Focus()
    End Sub

End Class
