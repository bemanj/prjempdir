Public Class LogIn

    Private _LoginRepository As New LoginRepository
    Private _LoginView As New LoginView

    Public Property LoginView() As LoginView
        Get
            Return _LoginView
        End Get
        Set(ByVal value As LoginView)
            _LoginView = value
        End Set
    End Property

    Private Sub SignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignIn_Btn.Click
        _LoginView = SelectUser(Username.Text, UsernamePassword.Text)
        If IsNothing(_LoginView) Then
            RecorNotFound.Show()
            RecorNotFound.Label2.Text = "PLEASE CONTACT YOUR MANAGER"
        Else
            CurrentUser = _LoginView.OracleID
            CurrentUserType = _LoginView.UserType
            If _LoginView.UserType = 1 Then     'ADMIN'
                Me.Hide()
                admin.Show()
            ElseIf _LoginView.UserType = 2 Then 'MANAGER'
                Me.Hide()
                Main.Show()
                Main.Main_Load(e, e)
            ElseIf _LoginView.UserType = 3 Then 'USER'
                Me.Hide()
                EmployeeInfo.Show()
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

    Private Sub LogIn_Load()
        Throw New NotImplementedException
    End Sub

    Public Function SelectUser(ByVal OracleID As String, ByVal Password As String) As LoginView
        _LoginView.OracleID = CInt(OracleID)
        Return _LoginRepository.GetUserLogin(New LoginView() With {.OracleID = OracleID, .Password = Password})
    End Function

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
