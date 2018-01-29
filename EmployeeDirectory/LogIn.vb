Public Class LogIn

    Private _LoginRepository As New LoginRepository
    Private _LoginView As New LoginView
    Private mg As New ManagerGrid
    Private mR As New ManagerRepository
    Private dt As New DataTable
    Private ls As New List(Of ManagerGrid)
    Private _LogInService As New LogInService

    Private Sub SignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignIn_Btn.Click
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
                Me.Hide()
                ''''' ***** LMRS START: Code to display Manager's Name ***** '''''
                Main.Label_ManagerName.Text = (_LoginViewTemp.LastName & ", " & _LoginViewTemp.FirstName & " " & _LoginViewTemp.MiddleName)
                ''''' ***** LMRS END: Code to display Manager's Name ***** '''''
                Main.Show()
                dt.Clear()

                'Main.TB_MgrV_OracleID.Focus()
                'mg.OracleID = CurrentUser
                'mg.SFC = False

                ''ls = mR.GetGridListData(mg)                                     '   - get list from db
                ''dt = Main.ConvertToDataTable(ls)                                     '   - converts list to datatable to enable sorting
                ''Main.DataGridViewEmployee.AutoGenerateColumns = True
                'Main.DataGridViewEmployee.DataSource = mR.GetGridListData(mg) 'dt
                ''Main.DataGridViewEmployee.Item(0, 0).Selected = False                '   - to remove highlighted item upon initial loading
                'Main.ToolStripStatusLabelUser.Text = "Current User: " & _LoginView.FirstName & " " & _LoginView.LastName
            ElseIf CurrentUserType = 3 Then 'USER'
                Me.Hide()
                EmployeeInfo.Show()
                EmployeeInfo.EmployeeInfo_Load(e, e)
                EmployeeInfo.Btn_Cancel.Hide()
            Else
                RecorNotFound.Show()
                RecorNotFound.Label2.Text = "PLEASE CONTACT ADMIN"
            End If
        End If
        'If Username.Text = "user" And UsernamePassword.Text = "user" Then
        '    Me.Hide()
        '    EmployeeInfo.Show()
        'ElseIf (Username.Text = "manager" And UsernamePassword.Text = "manager") Then
        '    Me.Hide()
        '    Main.Show()
        '    Main.Main_Load(e, e)
        'ElseIf (Username.Text = "admin" And UsernamePassword.Text = "admin") Then
        '    Me.Hide()
        '    admin.Show()
        'ElseIf Username.Text = "notfounduser" And UsernamePassword.Text = "notfounduser" Then
        '    RecorNotFound.Show()
        '    RecorNotFound.Label2.Text = "PLEASE CONTACT YOUR MANAGER"
        'ElseIf Username.Text = "notfoundmanager" And UsernamePassword.Text = "notfoundmanager" Then
        '    RecorNotFound.Show()
        '    RecorNotFound.Label2.Text = "PLEASE CONTACT ADMIN"
        'End If
    End Sub

    Public Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Username.Clear()
        UsernamePassword.Clear()
        Username.Focus()
    End Sub

    'Private Sub LogIn_Load()
    '    Throw New NotImplementedException
    'End Sub

    '***** Will perform Submit Button when Enter is pressed *******
    Private Sub LoginTextBoxes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Username.KeyPress, UsernamePassword.KeyPress

        If sender.GetType() = GetType(TextBox) Then
            If CType(sender, TextBox).Name = "NameTextBox" Then
                NameTextBoxKeyPress()
            End If
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.SignIn_Click(sender, e)
        End If
    End Sub

    Private Sub NameTextBoxKeyPress()

    End Sub

End Class
