Public Class LogIn
    Private _loginService As LogInService

    Public Sub New()

        InitializeComponent()

        _loginService = New LogInService()
    End Sub

#Region "SUB ROUTINES"
    Private Sub clearAndFocus()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        UsernameTextBox.Focus()
    End Sub
#End Region

    Public Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearAndFocus()
    End Sub

    Private Sub SignInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInButton.Click
        Dim tempCharCount As Long = 0
        Dim tempPasswordCharCount As Long = 0
        tempCharCount = UsernameTextBox.Text.Length
        tempPasswordCharCount = PasswordTextBox.Text.Length

        If UsernameTextBox.Text = Nothing Or
            PasswordTextBox.Text = Nothing Then

            MessageBox.Show(MessageRequiredFields, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clearAndFocus()
        ElseIf Not IsNumeric(UsernameTextBox.Text) Then
            MessageBox.Show(MessageUserNotFound, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clearAndFocus()
        Else
            Dim tempLoginView = _loginService.SelectUser(UsernameTextBox.Text, PasswordTextBox.Text)

            If IsNothing(tempLoginView) Or
                IsDBNull(tempLoginView) Then
                MessageBox.Show(MessageUserNotFound, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                UserAccount.UserID = tempLoginView.OracleID
                UserAccount.UserType = tempLoginView.UserType
                UserAccount.UserName = tempLoginView.LastName & ", " & tempLoginView.FirstName & " " & tempLoginView.MiddleName

                Select Case UserAccount.UserType
                    Case 1
                        Admin.Show()
                        Me.Dispose()
                    Case 2
                        Main.Show()
                        Me.Dispose()
                    Case 3
                        UserAccount.SelectedOracleID = UserAccount.UserID
                        EmployeeInfo.Show()
                        Me.Dispose()
                    Case Else
                        RecorNotFound.ShowDialog()
                        RecorNotFound.Label2.Text = "PLEASE CONTACT ADMIN"
                End Select
            End If
        End If
    End Sub

    '***** Will perform Submit Button when Enter is pressed *******
    Private Sub LoginTextBoxes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress, PasswordTextBox.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.SignInButton_Click(sender, e)
        End If
    End Sub

    Private Sub LogIn_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
