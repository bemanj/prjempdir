Public Class RecorNotFound

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LogIn.Show()
        Me.Hide()
        LogIn.LogIn_Load(e, e)
    End Sub

    Private Sub RecorNotFound_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        LogIn.Show()
        Me.Hide()
        LogIn.LogIn_Load(e, e)
    End Sub

End Class