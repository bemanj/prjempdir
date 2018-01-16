Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient

Public Class EmployeeRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetData(ByVal entity As IEntity) As BASD.Helper.IEntity
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@OracleID", entity.Id))

        Dim _tempEmployeeList = MyBase.List("[uspGetEmployee]", _tempParamList.ToArray())

        Return _tempEmployeeList.SingleMapToEntity(Of Employee)().SingleOrDefault()

    End Function

    Public Overrides Function GetListData(ByVal entity As IEntity) As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@ManagerID", entity.Id))

        Dim _tempEmployeeList = MyBase.List("[uspGetEmployeeList]", Nothing)
        Return _tempEmployeeList.SingleMapToEntity(Of Employee)()
    End Function
    'sofie
    Public Overrides Function InsertData(ByVal entity As BASD.Helper.IEntity) As Integer
        Dim _emp = CType(entity, Employee)


        Dim _tempParamList = New List(Of SqlParameter)()
        With _tempParamList
            .Add(New SqlParameter("@OracleID", entity.Id))  'change entity.id to _emp.
            .Add(New SqlParameter("@Title", _emp.EmpTitle))
            .Add(New SqlParameter("@LastName", _emp.LastName))
            .Add(New SqlParameter("@FirstName", _emp.FirstName))
            .Add(New SqlParameter("@MiddleName", _emp.MiddleName))
            .Add(New SqlParameter("@HomeAddress1", _emp.HomeAddress1))
            .Add(New SqlParameter("@HomeAddress2", _emp.HomeAddress2))
            .Add(New SqlParameter("@Gender", _emp.Gender))
            .Add(New SqlParameter("@EmailAddress", _emp.EmailAdd))
            .Add(New SqlParameter("@MobileNo", _emp.MobileNo))
            .Add(New SqlParameter("@PhoneExtension", _emp.PhoneExt))
            .Add(New SqlParameter("@NCOGroup", _emp.NCOGroupID))
            .Add(New SqlParameter("@Division", _emp.Division))
            .Add(New SqlParameter("@Department", _emp.Department))
            .Add(New SqlParameter("@Entity", _emp.Entity))
            .Add(New SqlParameter("@TeamID", _emp.Team))
            .Add(New SqlParameter("@LocalManagerID", _emp.LocalManager))
            .Add(New SqlParameter("@USManager", _emp.USManager))
            .Add(New SqlParameter("@SiteID", _emp.Site))
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
            '.Add(New SqlParameter("@UserType", _emp.UserType))
        End With


        Return 0
    End Function

End Class
