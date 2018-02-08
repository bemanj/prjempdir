Public Class EmployeeInfoIncomplete

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        incomplete.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        LogIn.Show()
        LogIn.UsernameTextBox.Text = " "
        LogIn.PasswordTextBox.Text = ""
    End Sub
End Class