Public Class admin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.BtnClose.Hide()
        LogIn.Show()
        LogIn.Username.Text = ""
        LogIn.UsernamePassword.Text = ""
        LogIn.Username.Focus()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Main.Show()
        Main.Main_Load(e, e)
        Main.BtnClose.Show()
    End Sub
End Class