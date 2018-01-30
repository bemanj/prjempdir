Public Class LogIn

    Private _LoginRepository As New LoginRepository
    Private _LoginView As New LoginView
    Private mg As New ManagerGrid
    Private mR As New ManagerRepository
    Private dt As New DataTable
    Private ls As New List(Of ManagerGrid)
    Private _LogInService As New LogInService

    Private Sub SignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignIn_Btn.Click
        'Dim _LoginViewTemp = _LogInService.SelectUser(Username.Text, UsernamePassword.Text)
        If Username.Text = Nothing Or
            Not IsNumeric(Username.Text) Then

            MsgBox("Invalid/Blank UserName")
            Username.Clear()
            UsernamePassword.Clear()

        ElseIf UsernamePassword.Text = Nothing Then
            MsgBox("Blank Password")
        Else
            Dim _LoginViewTemp = _LogInService.SelectUser(Username.Text, UsernamePassword.Text)

            If IsNothing(_LoginViewTemp) Or
                IsDBNull(_LoginViewTemp) Then
                RecorNotFound.Show()
                RecorNotFound.Label2.Text = "PLEASE CONTACT YOUR MANAGER"
            Else
                CurrentUser = _LoginViewTemp.OracleID
                CurrentUserType = _LoginViewTemp.UserType
                If CurrentUserType = 1 Then     'ADMIN'
                    Me.Hide()
                    admin.Show()
                ElseIf CurrentUserType = 2 Then 'MANAGER'
                    EmployeeInfo.TB_SiteZip.Enabled = False
                    Me.Hide()
                    ''''' ***** LMRS START: Code to display Manager's Name ***** '''''
                    Main.Label_ManagerName.Text = (_LoginViewTemp.LastName & ", " & _LoginViewTemp.FirstName & " " & _LoginViewTemp.MiddleName)
                    ''''' ***** LMRS END: Code to display Manager's Name ***** '''''
                    Main.Show()
                    Main.ToolStripStatusLabelUser.Text = "Current User: " & _LoginViewTemp.FirstName & " " & _LoginViewTemp.LastName
                    dt.Clear()
                    Main.ButtonActive_Click(e, e)

                ElseIf CurrentUserType = 3 Then 'USER'
                    Me.Hide()
                    EmployeeInfo.IsEdit = True
                    EmployeeInfo.Show()
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
                    RecorNotFound.Show()
                    RecorNotFound.Label2.Text = "PLEASE CONTACT ADMIN"
                End If
            End If
        End If
    End Sub

    Public Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Username.Clear()
        UsernamePassword.Clear()
        Username.Focus()
    End Sub

    '***** Will perform Submit Button when Enter is pressed *******
    Private Sub LoginTextBoxes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Username.KeyPress, UsernamePassword.KeyPress
        'If sender.GetType() = GetType(TextBox) Then
        '    If CType(sender, TextBox).Name = "NameTextBox" Then
        '        NameTextBoxKeyPress()
        '    End If
        'End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.SignIn_Click(sender, e)
        End If
    End Sub

    'Private Sub NameTextBoxKeyPress()

    'End Sub

End Class
