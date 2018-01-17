Public Class EmployeeInfo

    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LogIn.Username.Text = "user" And LogIn.UsernamePassword.Text = "user" Then
            TB_StartDate.Enabled = False
            TB_OnboardingTkt.Enabled = False
            TB_SeatNo.Enabled = False
            TB_Floor.Enabled = False
            ' ComboBox3.Enabled = False
            TB_USMgr.Enabled = False
            CB_LocalMgr.Enabled = False
            TB_Team.Enabled = False
            TB_Recruiter.Enabled = False
            TB_SFCDate.Enabled = False
            CB_SFC.Enabled = False
            Button3.Hide()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        LogIn.Show()
        LogIn.LogIn_Load(e, e)
        LogIn.Username.Clear()
        LogIn.UsernamePassword.Clear()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class