﻿Public Class admin

    Private Sub Btn_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Logout.Click
        Main.BtnClose.Hide()
        LogIn.Username.Clear()
        LogIn.UsernamePassword.Clear()
        Me.Close()
        LogIn.Show()
        LogIn.Username.Focus()
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