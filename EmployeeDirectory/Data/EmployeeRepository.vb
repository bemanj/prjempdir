Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class EmployeeRepository
    Inherits BaseRepository
    Public EmpValidate As Integer = 0


    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetData(ByVal entity As IEntity) As BASD.Helper.IEntity
        Dim _employee = CType(entity, Employee)

        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@OracleID", _employee.OracleID))

        Dim _tempEmployeeList = MyBase.List("[uspGetEmployeeRec]", _tempParamList.ToArray())

        Return _tempEmployeeList.SingleMapToEntity(Of Employee)().SingleOrDefault()

    End Function

    Public Overrides Function GetListData(ByVal entity As IEntity) As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _employee = CType(entity, Employee)
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@LocalManagerID", _employee.LocalManagerID))
        Dim _tempEmployeeList = MyBase.List("[uspGetEmployeeList]", _tempParamList.ToArray())
        Return _tempEmployeeList.SingleMapToEntity(Of Employee)().ToList
    End Function
    'Public Overrides Function GetListData(ByVal entity As IEntity) As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
    '    Dim _tempParamList = New List(Of SqlParameter)()
    '    _tempParamList.Add(New SqlParameter("@ManagerID", entity.Id))

    '    '    Dim _tempEmployeeList = MyBase.List("[uspGetEmployeeList]", Nothing)
    '    '    Return _tempEmployeeList.SingleMapToEntity(Of Employee)()
    '    'End Function
    '    Dim _tempEmployeeList = MyBase.List("[uspGetEmployeeList]", Nothing)
    '    Return _tempEmployeeList.SingleMapToEntity(Of Employee)()
    'End Function
    'sofie
    Public Overrides Function InsertData(ByVal entity As BASD.Helper.IEntity) As Integer
        Dim _tempParamList = New List(Of SqlParameter)()

        _tempParamList = MoveParamaters(entity)

        Dim x = MyBase.Update("[uspInsertEmployee]", _tempParamList.ToArray())

        If CInt(x) > 0 Then
            MessageBox.Show("Employee Added.")
        End If

        Return 0
    End Function

    Public Overrides Function UpdateData(ByVal entity As BASD.Helper.IEntity) As Object
        Dim _tempParamList = New List(Of SqlParameter)()

        _tempParamList = MoveParamaters(entity)

        Dim x = MyBase.Update("[uspUpdateEmployeeRec]", _tempParamList.ToArray())

        If CInt(x) > 0 Then
            MessageBox.Show("Employee Updated.")
        End If

        Return 0
    End Function

    Public Function MoveParamaters(ByVal _emp As Employee) As List(Of SqlParameter)
        Dim _tempParamList = New List(Of SqlParameter)()
        With _tempParamList
            .Add(New SqlParameter("@OracleID", _emp.OracleID))
            .Add(New SqlParameter("@Password", _emp.OracleID))
            .Add(New SqlParameter("@Title", _emp.Title))
            .Add(New SqlParameter("@Position", _emp.Position))
            .Add(New SqlParameter("@LastName", _emp.LastName))
            .Add(New SqlParameter("@FirstName", _emp.FirstName))
            .Add(New SqlParameter("@MiddleName", _emp.MiddleName))
            .Add(New SqlParameter("@HomeAddress1", _emp.HomeAddress1))
            .Add(New SqlParameter("@HomeAddress2", _emp.HomeAddress2))
            .Add(New SqlParameter("@CityID", _emp.CityID))
            .Add(New SqlParameter("@ZipCode", _emp.ZipCode))
            .Add(New SqlParameter("@RegionID", _emp.RegionID))
            .Add(New SqlParameter("@Country", _emp.Country))
            .Add(New SqlParameter("@Gender", _emp.Gender))
            .Add(New SqlParameter("@Birthday", _emp.Birthday))
            .Add(New SqlParameter("@PersonalEmail", _emp.PersonalEmail))
            .Add(New SqlParameter("@MobileNo", _emp.MobileNo))
            .Add(New SqlParameter("@LandlineNo", _emp.LandlineNo))
            .Add(New SqlParameter("@PhoneExtension", _emp.PhoneExtension))
            .Add(New SqlParameter("@OfficeEmail", _emp.OfficeEmail))
            .Add(New SqlParameter("@NCOGroup", _emp.NCOGroup))
            .Add(New SqlParameter("@Division", _emp.Division))
            .Add(New SqlParameter("@Department", _emp.Department))
            .Add(New SqlParameter("@Entity", _emp.Entity))
            .Add(New SqlParameter("@TeamID", _emp.TeamID))
            .Add(New SqlParameter("@LocalManagerID", _emp.LocalManagerID))
            .Add(New SqlParameter("@USManager", _emp.USManager))
            .Add(New SqlParameter("@SiteID", _emp.SiteID))
            .Add(New SqlParameter("@Floor", _emp.Floor))
            .Add(New SqlParameter("@SeatNumber", _emp.SeatNumber))
            .Add(New SqlParameter("@OnboardingTicket", _emp.OnboardingTicket))
            .Add(New SqlParameter("@StartDate", _emp.StartDate))
            .Add(New SqlParameter("@Shift", _emp.Shift))
            .Add(New SqlParameter("@PCName", _emp.PCName))
            .Add(New SqlParameter("@MercuryID", _emp.MercuryID))
            .Add(New SqlParameter("@IDCreated", _emp.IDCreated))
            .Add(New SqlParameter("@OraclePRDID", _emp.OraclePRDID))
            .Add(New SqlParameter("@EISID", _emp.EISID))
            .Add(New SqlParameter("@InsightID", _emp.InsightID))
            .Add(New SqlParameter("@EGSPremID", _emp.EGSPremID))
            .Add(New SqlParameter("@ElsevierID", _emp.ElsevierID))
            .Add(New SqlParameter("@GITHubID", _emp.GITHubID))
            .Add(New SqlParameter("@SFC", _emp.SFC))
            .Add(New SqlParameter("@SFCDate", _emp.SFCDate))
            .Add(New SqlParameter("@Recruiter", _emp.Recruiter))
            .Add(New SqlParameter("@UserType", _emp.UserType))
            .Add(New SqlParameter("@Status", _emp.Status))
            .Add(New SqlParameter("@LastLogin", _emp.LastLogin))
            .Add(New SqlParameter("@ExpirationDate", _emp.ExpirationDate))
            .Add(New SqlParameter("@LastAccessedBy", _emp.LastAccessedBy))
        End With

        Return _tempParamList

    End Function

    Public Sub Validate()
        EmpValidate = 0
        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_OracleID.Text) Then
            EmployeeInfo.Lbl_OracleID.ForeColor = Color.Red()
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_OracleID.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_LastName.Text) Then
            EmployeeInfo.Lbl_LastName.ForeColor = Color.Red()
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_LastName.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_FirstName.Text) Then
            EmployeeInfo.Lbl_FirstName.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_FirstName.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_MiddleName.Text) Then
            EmployeeInfo.Lbl_MiddleName.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_MiddleName.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.CB_Gender.Text) Then
            EmployeeInfo.Lbl_Gender.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_Gender.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.DT_Birth.Text) Then
            EmployeeInfo.Lbl_BirthDate.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_BirthDate.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_PersonalEmail.Text) Then
            EmployeeInfo.Lbl_EAdd.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_EAdd.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_MobileNo.Text) Then
            EmployeeInfo.Lbl_MobileNo.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_MobileNo.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_HomeAddLine1.Text) Then
            EmployeeInfo.Lbl_HomeAdd1.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_HomeAdd1.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.TB_HomeAddLine2.Text) Then
            EmployeeInfo.Lbl_HomeAdd2.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_HomeAdd2.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.CB_City.Text) Then
            EmployeeInfo.Lbl_City.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_City.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.CB_Region.Text) Then
            EmployeeInfo.Lbl_Region.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_Region.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.CB_Country.Text) Then
            EmployeeInfo.Lbl_Country.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_Country.ForeColor = Color.Black
        End If

        If String.IsNullOrWhiteSpace(EmployeeInfo.MB_Zipcode.Text) Then
            EmployeeInfo.Lbl_Zip.ForeColor = Color.Red
            EmpValidate = 1
        Else
            EmployeeInfo.Lbl_Zip.ForeColor = Color.Black
        End If

        If Not String.IsNullOrEmpty(EmployeeInfo.TB_PersonalEmail.Text) Then
            If ValidateEmail(EmployeeInfo.TB_PersonalEmail.Text) = False Then
                EmpValidate = 2
                'MessageBox.Show("Email is not valid, Please check your email address.", "EMAIL INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Public Sub ValidateClear()
        EmployeeInfo.Lbl_OracleID.ForeColor = Color.Black
        EmployeeInfo.Lbl_LastName.ForeColor = Color.Black
        EmployeeInfo.Lbl_FirstName.ForeColor = Color.Black
        EmployeeInfo.Lbl_MiddleName.ForeColor = Color.Black
        EmployeeInfo.Lbl_Gender.ForeColor = Color.Black
        EmployeeInfo.Lbl_BirthDate.ForeColor = Color.Black
        EmployeeInfo.Lbl_EAdd.ForeColor = Color.Black
        EmployeeInfo.Lbl_MobileNo.ForeColor = Color.Black
        EmployeeInfo.Lbl_HomeAdd1.ForeColor = Color.Black
        EmployeeInfo.Lbl_HomeAdd2.ForeColor = Color.Black
        EmployeeInfo.Lbl_City.ForeColor = Color.Black
        EmployeeInfo.Lbl_Zip.ForeColor = Color.Black
        EmployeeInfo.Lbl_Region.ForeColor = Color.Black
        EmployeeInfo.Lbl_Country.ForeColor = Color.Black
    End Sub

    Public Function ValidateEmail(EmailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
