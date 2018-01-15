Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient

Public Class ManagerRepository
    Inherits BaseRepository


    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetData(ByVal entity As IEntity) As BASD.Helper.IEntity
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@ManagerID", entity.Id))

        Dim _tempManagerList = MyBase.List("[uspGetManager]", _tempParamList.ToArray())

        Return _tempManagerList.SingleMapToEntity(Of Employee)().SingleOrDefault()

    End Function

    Public Overrides Function GetListData() As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _tempManagerList = MyBase.List("uspGetManagerList", Nothing)
        Return _tempManagerList.SingleMapToEntity(Of Employee)()
    End Function

End Class
