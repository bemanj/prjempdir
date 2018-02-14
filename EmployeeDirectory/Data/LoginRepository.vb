Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient

Public Class LoginRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetData(ByVal entity As IEntity) As BASD.Helper.IEntity
        Dim _login = CType(entity, LoginView)

        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@OracleId", _login.OracleID))
        _tempParamList.Add(New SqlParameter("@Password", _login.Password))

        Dim _tempLoginList = MyBase.List("[uspGetUserLogin]", _tempParamList.ToArray())

        Return _tempLoginList.SingleMapToEntity(Of LoginView)().SingleOrDefault()

    End Function

End Class
