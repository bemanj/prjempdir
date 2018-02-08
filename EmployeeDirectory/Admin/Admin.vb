Public Class Admin

    Private Sub Btn_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Logout.Click
        Main.BtnClose.Hide()
        LogIn.UsernameTextBox.Clear()
        LogIn.PasswordTextBox.Clear()
        Me.Close()
        LogIn.Show()
        LogIn.UsernameTextBox.Focus()
    End Sub

    Private Sub ButtonGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGridView.Click
        Me.Hide()
        Main.Show()
        Main.BtnClose.Show()
        Main.UserToolStripStatusLabel.Text = "Current User: Admin"
        Main.ManagerNameLabel.Text = "Hello Admin!"
        Main.ActiveButton_Click(e, e)
    End Sub
End Class