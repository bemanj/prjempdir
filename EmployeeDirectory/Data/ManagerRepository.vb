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

        ' **** START : FIX INVALID ORACLE ID *** ' 
        ' **** COMMENTED CODES BELOW *** ' 
        'If String.IsNullOrWhiteSpace(EmployeeInfo.TB_OracleID.Text) Then
        '    EmployeeInfo.Lbl_OracleID.ForeColor = Color.Red()
        '    MgrValidate = 1
        'Else
        '    EmployeeInfo.Lbl_OracleID.ForeColor = Color.Black
        'End If
        ' **** END  : FIX INVALID ORACLE ID *** ' 

        If String.IsNullOrWhiteSpace(EmployeeInfo.FirstNameTextBox.Text) Then
            EmployeeInfo.FirstNameLabel.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.FirstNameLabel.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.LastNameTextBox.Text) Then
            EmployeeInfo.LastNameLabel.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.LastNameLabel.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.MiddleNameTextBox.Text) Then
            EmployeeInfo.MiddleNameLabel.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.MiddleNameLabel.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.GenderComboBox.Text) Then
            EmployeeInfo.GenderLabel.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.GenderLabel.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TeamComboBox.Text) Then
            EmployeeInfo.Lbl_team.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_team.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.LocalManagerComboBox.Text) Then
            EmployeeInfo.Lbl_localMgr.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_localMgr.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.OnboardingTicketTextBox.Text) Then
            EmployeeInfo.Lbl_ObTicket.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            EmployeeInfo.Lbl_ObTicket.ForeColor = Color.Black
        End If

        If Not String.IsNullOrEmpty(EmployeeInfo.OfficeEmailTextBox.Text) Then
            If ValidateOfficeEmail(EmployeeInfo.OfficeEmailTextBox.Text) = False Then
                MgrValidate = 2
                EmployeeInfo.OfficeEmailLabel.ForeColor = Color.Red
            Else
                EmployeeInfo.OfficeEmailLabel.ForeColor = Color.Black
                'MessageBox.Show("Email is not valid, Please check your email address.", "EMAIL INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            EmployeeInfo.OfficeEmailLabel.ForeColor = Color.Black
        End If

        If Not String.IsNullOrEmpty(EmployeeInfo.PersonalEmailTextBox.Text) Then
            If ValidateOfficeEmail(EmployeeInfo.PersonalEmailTextBox.Text) = False Then
                MgrValidate = 2
                EmployeeInfo.PersonalEmailLabel.ForeColor = Color.Red
            Else
                EmployeeInfo.PersonalEmailLabel.ForeColor = Color.Black
                'MessageBox.Show("Email is not valid, Please check your email address.", "EMAIL INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            EmployeeInfo.PersonalEmailLabel.ForeColor = Color.Black
        End If

        ' **** START : FIX INVALID ORACLE ID *** ' 
        If String.IsNullOrWhiteSpace(EmployeeInfo.OracleIDTextBox.Text) Then
            EmployeeInfo.OracleIDLabel.ForeColor = Color.Red()
            MgrValidate = 1
        Else
            If UserAccount.IsEdit = False Then 'This will add insert Oracle ID'
                Dim _EmpEditService = New EmpEditService()
                Dim _tempSelectedID = _EmpEditService.SelectEmpFromList(EmployeeInfo.OracleIDTextBox.Text)
                If Not _tempSelectedID Is Nothing Then
                    EmployeeInfo.OracleIDLabel.ForeColor = Color.Red()
                    MgrValidate = 3
                End If
            End If
        End If
        ' **** END  : FIX INVALID ORACLE ID *** ' 

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

    Public Function ValidateOfficeEmail(ByVal EmailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        'Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        'If email.IsMatch(EmailAddress) Then
        '    Return True
        'Else
        '    Return False
        'End If
        Try
            Dim vEmailAddress As New System.Net.Mail.MailAddress(EmailAddress)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Sub ClearMgrValidate()
        EmployeeInfo.OracleIDLabel.ForeColor = Color.Black
        EmployeeInfo.LastNameLabel.ForeColor = Color.Black
        EmployeeInfo.FirstNameLabel.ForeColor = Color.Black
        EmployeeInfo.MiddleNameLabel.ForeColor = Color.Black
        EmployeeInfo.GenderLabel.ForeColor = Color.Black
        EmployeeInfo.OfficeEmailLabel.ForeColor = Color.Black
        EmployeeInfo.Lbl_team.ForeColor = Color.Black
        EmployeeInfo.Lbl_localMgr.ForeColor = Color.Black
        EmployeeInfo.Lbl_ObTicket.ForeColor = Color.Black

    End Sub

    Public Sub CheckDupOracleID()
        EmployeeInfo.OracleIDLabel.ForeColor = Color.Red()
    End Sub

End Class
