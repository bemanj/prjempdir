Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq

Public MustInherit Class BaseRepository
    Inherits BaseADO
    Implements IRepository

    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString)
    End Sub

    Public Overridable Sub DeleteData(ByVal entity As IEntity) Implements IRepository.DeleteData

        Throw New NotImplementedException()
    End Sub

    Public Overridable Function GetDataTable(ByVal entity As IEntity) As DataTable Implements IRepository.GetDataTable
        Throw New NotImplementedException()
    End Function

    Public Overridable Function GetData(ByVal entity As IEntity) As IEntity Implements IRepository.GetData

        Throw New NotImplementedException()

    End Function

    Public Overridable Function InsertData(ByVal entity As IEntity) As Integer Implements IRepository.InsertData

        Throw New NotImplementedException()

    End Function

    Public Overridable Function GetListData() As System.Collections.Generic.IEnumerable(Of IEntity) Implements IRepository.GetListData

        Throw New NotImplementedException()

    End Function

    ' New Overload Function, with Parameter
    Public Overridable Function GetListData(ByVal entity As IEntity) As System.Collections.Generic.IEnumerable(Of IEntity) Implements IRepository.GetListData

        Throw New NotImplementedException()

    End Function

    Public Overridable Sub UpdateData(ByVal updateEntity As System.Data.SqlClient.SqlParameter, ByVal entity As IEntity) Implements IRepository.UpdateData

        Throw New NotImplementedException()

    End Sub

    Public Overridable Function UpdateData(ByVal entity As IEntity)

        Throw New NotImplementedException()

    End Function

End Class
