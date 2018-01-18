Public Class EmployeeInfo

    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'disabled fields
        'If LogIn.Username.Text = "user" And LogIn.UsernamePassword.Text = "user" Then
        '    TB_StartDate.Enabled = False
        '    TB_OnboardingTkt.Enabled = False
        '    TB_SeatNo.Enabled = False
        '    TB_Floor.Enabled = False
        '    ' ComboBox3.Enabled = False
        '    TB_USMgr.Enabled = False
        '    CB_LocalMgr.Enabled = False
        '    TB_Team.Enabled = False
        '    TB_Recruiter.Enabled = False
        '    TB_SFCDate.Enabled = False
        '    CB_SFC.Enabled = False
        '    Button3.Hide()
        'End If

        If _isEdit Then
            _EmpEditService.PopulateFields(Me)
        End If
    End Sub

    Private _isEdit As Boolean
    Public Property IsEdit() As Boolean
        Get
            Return _isEdit
        End Get
        Set(ByVal value As Boolean)
            _isEdit = value
        End Set
    End Property

    Private _EmpEditService As EmpEditService
    Public Property EmpEditService() As EmpEditService
        Get
            Return _EmpEditService
        End Get
        Set(ByVal value As EmpEditService)
            _EmpEditService = value
        End Set
    End Property

    Public Sub New()

        InitializeComponent()

        _EmpEditService = New EmpEditService()

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