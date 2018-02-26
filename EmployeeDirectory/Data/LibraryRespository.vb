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

    Public Overloads Function GetListData() As System.Collections.Generic.IEnumerable(Of IEntity)

        Dim _tempTeamList = MyBase.List("[uspGetSiteList]", Nothing)
        Return _tempTeamList.SingleMapToEntity(Of Site)().ToList

    End Function

    Public Overloads Function GetListData(ByVal _id As Integer) As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)

        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@RegionId", _id))

        Dim _tempCityList = MyBase.List("[uspGetCityRegion]", _tempParamList.ToArray())
        Return _tempCityList.SingleMapToEntity(Of DropDownList)().ToList

    End Function


End Class
