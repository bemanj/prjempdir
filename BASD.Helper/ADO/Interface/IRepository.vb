﻿Imports System.Data.SqlClient

Public Interface IRepository

    Function GetListData() As IEnumerable(Of IEntity)
    Function GetListData(ByVal entity As IEntity) As IEnumerable(Of IEntity) ' New Overload Function, with Parameter
    Function GetDataTable(ByVal entity As IEntity) As DataTable
    Function GetData(ByVal entity As IEntity) As IEntity
    Function InsertData(ByVal entity As IEntity) As Integer
    Sub UpdateData(ByVal updateEntity As SqlClient.SqlParameter, ByVal entity As IEntity)
    Sub DeleteData(ByVal entity As IEntity)

End Interface
