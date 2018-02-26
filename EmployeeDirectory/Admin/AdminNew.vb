Public Class AdminNew

    Private Sub EmployeeDirButton_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeDirButton.Click
        Main.Show()
    End Sub

    Private Sub AdminMainLogoutButton_Click(sender As System.Object, e As System.EventArgs) Handles AdminMainLogoutButton.Click
        Main.Dispose()
        Me.Dispose()
        LogIn.Show()
    End Sub

    Private Sub AddNewSiteButton_Click(sender As System.Object, e As System.EventArgs) Handles AddNewSiteButton.Click
        AloricaSite.Show()
    End Sub

    Private Sub PasswordResetButton_Click(sender As System.Object, e As System.EventArgs) Handles PasswordResetButton.Click
        PasswordReset.Show()
    End Sub
End Class