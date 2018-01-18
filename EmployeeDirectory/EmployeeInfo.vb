﻿Public Class EmployeeInfo

    Private _isEdit As Boolean
    Public Property IsEdit() As Boolean
        Get
            Return _isEdit
        End Get
        Set(ByVal value As Boolean)
            _isEdit = value
        End Set
    End Property


    Private _empinfo As EmployeeRepository
    Public Property EmpInfo() As EmployeeRepository
        Get
            Return _empinfo
        End Get
        Set(ByVal value As EmployeeRepository)
            _empinfo = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        _empinfo = New EmployeeRepository()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

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

    'Private _isEdit As Boolean
    'Public Property IsEdit() As Boolean
    '    Get
    '        Return _isEdit
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _isEdit = value
    '    End Set
    'End Property

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

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
    '    Me.Close()
    '    Main.Show()
    'End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        LogIn.Show()
        LogIn.LogIn_Load(e, e)
        LogIn.Username.Clear()
        LogIn.UsernamePassword.Clear()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Save.Click

        Dim _emp As New Employee

        With _emp
            'Hardcoded
            .TeamID = 4 'BASD
            .SiteID = 1
            .LocalManagerID = 2 'Reb
            'MASKED
            If Not TB_MobileNo.Text = String.Empty Then
                .MobileNo = TB_MobileNo.Text
            End If

            'TEXTBOX
            .OracleID = TB_OracleID.Text
            .LastName = TB_LastName.Text
            .FirstName = TB_FirstName.Text
            .MiddleName = TB_MiddleIn.Text
            .HomeAddress1 = TB_HomeAddLine1.Text
            .HomeAddress2 = TB_HomeAddLine2.Text
            .EmailAddress = TB_EmailAddress.Text
            .Floor = TB_SeatNo.Text
            .SeatNumber = TB_SeatNo.Text
            .OnboardingTicket = TB_OnboardingTkt.Text
            If Not TB_StartDate.Text = String.Empty Then
                .StartDate = TB_StartDate.Text
            End If
            If Not TB_SFCDate.Text = String.Empty Then
                .SFCDate = TB_SFCDate.Text
            End If
            .Recruiter = TB_Recruiter.Text
            .Division = TB_Division.Text
            .Department = TB_Department.Text
            .Entity = TB_Entity.Text
            .Shift = TB_Shift.Text
            .SiteAddress1 = TB_AddressLine1.Text
            .SiteAddress2 = TB_AddressLine2.Text
            .OraclePRDID = TB_OraclePRD.Text
            .MercuryID = TB_MercuryID.Text
            .NCOGroup = TB_NCOGrpID.Text
            .EISID = TB_EISID.Text
            .PCName = TB_PCName.Text
            .InsightID = TB_InsightID.Text
            .EGSPremID = TB_EGSPREMID.Text
            .ElsevierID = TB_ElsevierID.Text
            .GITHubID = TB_GithubID.Text

            'COMBOBOX
            .Gender = CB_Gender.Text
            '.LocalManagerID = CB_Site.Text
            '.SiteID = CB_Site.Text

            .SFC = GetComboValue(CB_SFC)
            .IDCreated = GetComboValue(CB_IDCreated)

        End With

        If Me.IsEdit = True Then
            _empinfo.UpdateData(_emp)
        Else
            _empinfo.InsertData(_emp)
            Clearfields()
        End If
    End Sub

    Public Function GetComboValue(ByRef cbox As ComboBox) As Boolean

        If CType(cbox, ComboBox).Text = "Yes" Then
            Return 1
        Else
            Return 0
        End If

    End Function


    Private Sub Btn_RevertClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RevertClear.Click
        ClearFields()
    End Sub

    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        Me.Hide()
        ClearFields()
        Main.Show()
    End Sub

    Private Sub ClearFields()

        For Each _control In Me.Controls

            If _control.GetType() = GetType(TextBox) Then
                CType(_control, TextBox).Clear()
            ElseIf _control.GetType() = GetType(MaskedTextBox) Then
                CType(_control, MaskedTextBox).Clear()
            ElseIf _control.GetType() = GetType(ComboBox) Then
                CType(_control, ComboBox).SelectedIndex = -1
            End If

            If _control.GetType() = GetType(TabControl) Then
                For Each _TabPage As TabPage In CType(_control, TabControl).TabPages
                    For Each _item In _TabPage.Controls
                        If _item.GetType() = GetType(TextBox) Then
                            CType(_item, TextBox).Clear()
                        ElseIf _item.GetType() = GetType(MaskedTextBox) Then
                            CType(_item, MaskedTextBox).Clear()
                        ElseIf _item.GetType() = GetType(ComboBox) Then
                            CType(_item, ComboBox).SelectedIndex = -1
                        End If
                    Next
                Next
            End If

        Next

    End Sub
End Class