Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient

Public Class EmployeeRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetData(ByVal entity As IEntity) As BASD.Helper.IEntity
        Dim _employee = CType(entity, Employee)

        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@OracleID", _employee.OracleID))
        '_tempParamList.Add(New SqlParameter("@OracleID", Employee.OracleID))

        Dim _tempEmployeeList = MyBase.List("[uspGetEmployee]", _tempParamList.ToArray())

        Return _tempEmployeeList.SingleMapToEntity(Of Employee)().SingleOrDefault()

    End Function

    Public Overloads Function GetListData(ByVal entity As Employee) As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@ManagerID", entity.LocalManagerID))
        Dim _tempEmployeeList = MyBase.List("[uspGetEmployeeList]", _tempParamList.ToArray())
        Return _tempEmployeeList.SingleMapToEntity(Of Employee)().ToList
    End Function

    'Public Overrides Function GetListData(ByVal entity As IEntity) As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
    '    Dim _tempParamList = New List(Of SqlParameter)()
    '    _tempParamList.Add(New SqlParameter("@ManagerID", entity.Id))

    '    Dim _tempEmployeeList = MyBase.List("[uspGetEmployeeList]", Nothing)
    '    Return _tempEmployeeList.SingleMapToEntity(Of Employee)()
    'End Function
End Class
