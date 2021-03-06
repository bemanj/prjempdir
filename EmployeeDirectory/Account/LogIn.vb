﻿Public Class LogIn
    Private _loginService As LogInService
    Private HasError As Boolean
    Private ErrorMessage As String

#Region "CONSTRUCTOR"
    Public Sub New()

        InitializeComponent()
        _loginService = New LogInService()
    End Sub
#End Region

#Region "SUB ROUTINES"
    Private Sub clearAndFocus()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        UsernameTextBox.Focus()
    End Sub

    Private Sub validateLogin()
        HasError = False
        ErrorMessage = ""

        If UsernameTextBox.Text = Nothing Or
            PasswordTextBox.Text = Nothing Then

            HasError = True
            ErrorMessage = MessageLoginError

        ElseIf Not IsNumeric(UsernameTextBox.Text) Then
            HasError = True
            ErrorMessage = MessageUserNotFound
        Else
            Dim tempLoginView = _loginService.SelectUser(UsernameTextBox.Text, PasswordTextBox.Text)

            If IsNothing(tempLoginView) Or
                IsDBNull(tempLoginView) Then

                HasError = True
                ErrorMessage = MessageUserNotFound
            Else
                UserAccount.UserID = tempLoginView.OracleID
                UserAccount.UserType = tempLoginView.UserType
                UserAccount.UserName = tempLoginView.LastName & ", " & tempLoginView.FirstName & " " & tempLoginView.MiddleName
            End If
        End If
    End Sub

    Private Sub SignIn()
        validateLogin()

        If HasError Then
            MessageBox.Show(ErrorMessage, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clearAndFocus()
        Else
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
                    MessageBox.Show(MessageUserNotFound, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    clearAndFocus()
            End Select
        End If
    End Sub
#End Region


    Public Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearAndFocus()
    End Sub

    Private Sub SignInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignInButton.Click
        SignIn()
    End Sub

    '***** Will perform Submit Button when Enter is pressed *******
    Private Sub LoginTextBoxes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress, PasswordTextBox.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SignIn()
        End If
    End Sub

    Private Sub LogIn_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
