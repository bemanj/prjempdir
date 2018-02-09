Public Class Admin

    Private Sub LogoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutButton.Click
        Me.Dispose()
        LogIn.Show()
    End Sub

    Private Sub EmployeeDirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDirButton.Click
        Me.Dispose()
        Main.Show()
    End Sub
End Class