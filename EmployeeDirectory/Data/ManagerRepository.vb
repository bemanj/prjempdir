Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class ManagerRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetListData() As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _tempManagerList = MyBase.List("uspGetManagerList", Nothing)
        Return _tempManagerList.SingleMapToEntity(Of Employee)()
    End Function

    Public Overrides Function GetDataTable(ByVal entity As IEntity) As DataTable 'System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _employee = CType(entity, ManagerGrid)
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@LocalManagerID", _employee.OracleID))
        _tempParamList.Add(New SqlParameter("@SFC", _employee.SFC))
        Dim _tempManagerList = MyBase.List("[uspGetMgrGridView]", _tempParamList.ToArray())
        'Return (_tempManagerList.SingleMapToEntity(Of ManagerGrid)().ToList)
        'Return (_tempManagerList.SingleMapToEntity(Of ManagerGrid)())

        Return _tempManagerList
    End Function
End Class
