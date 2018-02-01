Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class ManagerRepository
    Inherits BaseRepository

    Public MgrValidate As Integer = 0

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub



    'DELETED BY RAINIER FOR TESTING
    'RAINIER 01/24/2017
    'Public Overrides Function GetData(ByVal entity As IEntity) As BASD.Helper.IEntity
    '    Dim _tempParamList = New List(Of SqlParameter)()
    '    _tempParamList.Add(New SqlParameter("@ManagerID", entity.Id))

    '    Dim _tempManagerList = MyBase.List("[uspGetManager]", _tempParamList.ToArray())

    '    Return _tempManagerList.SingleMapToEntity(Of Employee)().SingleOrDefault()

    'End Function

    Public Overrides Function GetListData() As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _tempManagerList = MyBase.List("uspGetManagerList", Nothing)
        Return _tempManagerList.SingleMapToEntity(Of Employee)()
    End Function

    Public Function GetGridListData(ByVal entity As IEntity) As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _employee = CType(entity, ManagerGrid)
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@LocalManagerID", _employee.OracleID))
        _tempParamList.Add(New SqlParameter("@SFC", _employee.SFC))
        Dim _tempManagerList = MyBase.List("[uspGetMgrGridView]", _tempParamList.ToArray())
        Return (_tempManagerList.SingleMapToEntity(Of ManagerGrid)().ToList)
    End Function

    Public Sub ValidateManager()
        ' **** START : VALIDATE AND REQUIRED FIELDS FOR MANAGER ***** '

        '  EmployeeInfo.Lbl_OracleID.ForeColor = Color.Black
        ' EmployeeInfo.Team_Label.ForeColor = Color.Black
        'EmployeeInfo.LocMgr_Label.ForeColor = Color.Black
        'EmployeeInfo.OnbTkt_Label.ForeColor = Color.Black
        'EmployeeInfo.OffEmail_Label.ForeColor = Color.Black

        ' ***** END : VALIDATE AND REQUIRED FIELDS FOR MANAGER/USER ***** '
        MgrValidate = 0

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_OracleID.Text) Then
            EmployeeInfo.Lbl_OracleID.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_OracleID.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_FirstName.Text) Then
            EmployeeInfo.Lbl_FirstName.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_FirstName.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_LastName.Text) Then
            EmployeeInfo.Lbl_LastName.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_LastName.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_MiddleName.Text) Then
            EmployeeInfo.Lbl_MiddleName.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_MiddleName.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.CB_Gender.Text) Then
            EmployeeInfo.Lbl_Gender.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_Gender.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.CB_Team.Text) Then
            EmployeeInfo.Lbl_team.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_team.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.CB_LocalMgr.Text) Then
            EmployeeInfo.Lbl_localMgr.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_localMgr.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_OnboardingTkt.Text) Then
            EmployeeInfo.Lbl_ObTicket.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_ObTicket.ForeColor = Color.Black
        End If

        If Not String.IsNullOrEmpty(EmployeeInfo.TB_OfficeEmail.Text) Then
            If ValidateOfficeEmail(EmployeeInfo.TB_OfficeEmail.Text) = False Then
                MgrValidate = 2
                EmployeeInfo.lbl_OfficeEmail.ForeColor = Color.Red
            Else
                EmployeeInfo.lbl_OfficeEmail.ForeColor = Color.Black
                'MessageBox.Show("Email is not valid, Please check your email address.", "EMAIL INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            EmployeeInfo.lbl_OfficeEmail.ForeColor = Color.Black
        End If

        If Not String.IsNullOrEmpty(EmployeeInfo.TB_PersonalEmail.Text) Then
            If ValidateOfficeEmail(EmployeeInfo.TB_PersonalEmail.Text) = False Then
                MgrValidate = 2
                EmployeeInfo.Lbl_EAdd.ForeColor = Color.Red
            Else
                EmployeeInfo.Lbl_EAdd.ForeColor = Color.Black
                'MessageBox.Show("Email is not valid, Please check your email address.", "EMAIL INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            EmployeeInfo.Lbl_EAdd.ForeColor = Color.Black
        End If

        'If EmployeeInfo.TB_OracleID = Nothing Then
        '    IsMgrError = True 
        '    Lbl_OracleID.ForeColor = Color.Red
        '    _empinfo.EmpValidate = 3
        'End If
        'If _emp.TeamName = String.Empty Then
        '    IsMgrError = True
        '    Team_Label.ForeColor = Color.Red
        '    _empinfo.EmpValidate = 3
        'End If
        'If _emp.LocalManagerID = Nothing Then
        '    IsMgrError = True
        '    LocMgr_Label.ForeColor = Color.Red
        '    _empinfo.EmpValidate = 3
        'End If
        'If _emp.OnboardingTicket = String.Empty Then
        '    IsMgrError = True
        '    OnbTkt_Label.ForeColor = Color.Red
        '    _empinfo.EmpValidate = 3
        'End If
        'If _empinfo.ValidateEmail(_emp.OfficeEmail) = False Then
        '    IsOffEmailError = True
        '    OffEmail_Label.ForeColor = Color.Red
        '    _empinfo.EmpValidate = 3
        'End If
    End Sub

    Public Function ValidateOfficeEmail(EmailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(EmailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ClearMgrValidate()
        EmployeeInfo.Lbl_OracleID.ForeColor = Color.Black
        EmployeeInfo.Lbl_LastName.ForeColor = Color.Black
        EmployeeInfo.Lbl_FirstName.ForeColor = Color.Black
        EmployeeInfo.Lbl_MiddleName.ForeColor = Color.Black
        EmployeeInfo.Lbl_Gender.ForeColor = Color.Black
        EmployeeInfo.lbl_OfficeEmail.ForeColor = Color.Black
        EmployeeInfo.Lbl_team.ForeColor = Color.Black
        EmployeeInfo.Lbl_localMgr.ForeColor = Color.Black
        EmployeeInfo.Lbl_ObTicket.ForeColor = Color.Black

    End Sub
End Class
