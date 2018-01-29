Public Class admin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.BtnClose.Hide()
        LogIn.Username.Text = ""
        LogIn.UsernamePassword.Text = ""
        LogIn.Username.Focus()
        Me.Close()
    End Sub

    Private Sub ButtonGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGridView.Click
        Me.Hide()
        Main.Show()
        Main.BtnClose.Show()
        Main.ToolStripStatusLabelUser.Text = "Current User: Admin"
        Main.Label_ManagerName.Text = "Hello Admin!"
        Main.ButtonActive_Click(e, e)
    End Sub
End Class