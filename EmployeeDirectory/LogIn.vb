Public Class LogIn

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Username.Text = "user" And UsernamePassword.Text = "user" Then
            Me.Hide()
            EmployeeInfo.Show()
        ElseIf (Username.Text = "manager" And UsernamePassword.Text = "manager") Then
            Me.Hide()
            Main.Show()
        ElseIf (Username.Text = "admin" And UsernamePassword.Text = "admin") Then
            Me.Hide()
            admin.Show()
        ElseIf Username.Text = "notfounduser" And UsernamePassword.Text = "notfounduser" Then
            RecorNotFound.Show()
            RecorNotFound.Label2.Text = "PLEASE CONTACT YOUR MANAGER"
        ElseIf Username.Text = "notfoundmanager" And UsernamePassword.Text = "notfoundmanager" Then
            RecorNotFound.Show()
            RecorNotFound.Label2.Text = "PLEASE CONTACT ADMIN"
        End If

    End Sub

    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
