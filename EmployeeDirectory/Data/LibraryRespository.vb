Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient

Public Class LibraryRespository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("EmployeeDirectoryConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overloads Function GetListData(ByVal spname As String) As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        
        Dim _tempTeamList = MyBase.List(spname, Nothing)
        Return _tempTeamList.SingleMapToEntity(Of DropDownList)().ToList


    End Function

End Class
