Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class IncompleteEmployeesRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetDataTable(ByVal entity As IEntity) As DataTable 'System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _employee = CType(entity, IncompleteEmployeesGrid)
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@LocalManagerID", _employee.OracleID))
        Dim _tempIncompleteList = MyBase.List("[uspGetIncompleteEmployees]", _tempParamList.ToArray())

        Return _tempIncompleteList
    End Function
End Class

