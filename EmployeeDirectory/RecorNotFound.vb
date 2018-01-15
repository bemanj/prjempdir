Public Class RecorNotFound

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LogIn.Show()
        Me.Hide()
        LogIn.Username.Text = " "
        LogIn.UsernamePassword.Text = ""
    End Sub
End Class