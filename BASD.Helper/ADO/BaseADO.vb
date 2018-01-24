Imports System.Data.SqlClient
Imports System.Data
Imports System.Linq

Public MustInherit Class BaseADO

    Dim _sqlConnection As SqlConnection
    'Dim _sqlCommand As SqlCommand
    'Dim _sqlParameters As SqlParameter()

    Public Sub New(ByVal connectionString As String)
        If connectionString = Nothing Or
            connectionString = String.Empty Then
            Throw New DataException("Connection string is required when using ADO.")
        End If

        _sqlConnection = New SqlConnection(connectionString)

        If Not Me._sqlConnection.State = ConnectionState.Open Then
            Me._sqlConnection.Open()
        End If
    End Sub

    Protected Sub Execute(ByVal procedure As String, Optional ByVal param As Object() = Nothing)
        If Me._sqlConnection IsNot Nothing Then
            Using sqlCommand As SqlCommand = New SqlCommand(procedure, Me._sqlConnection)
                sqlCommand.CommandType = CommandType.StoredProcedure
                If param.Length > 0 Then sqlCommand.MapParameters(CType(param, SqlParameter()))
                sqlCommand.ExecuteNonQuery()
            End Using
        Else
            Throw New Exception("Database connection is not defined.")
        End If
    End Sub


    Protected Function Aggregate(ByVal procedure As String, Optional ByVal param As Object() = Nothing) As DataSet
        If Me._sqlConnection IsNot Nothing Then
            Using sqlCommand As SqlCommand = New SqlCommand(procedure, Me._sqlConnection)
                Using sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(sqlCommand)
                    Dim dataSet As DataSet = New DataSet()
                    sqlCommand.CommandType = CommandType.StoredProcedure
                    If param IsNot Nothing Then
                        If param.Length > 0 Then sqlCommand.MapParameters(CType(param, SqlParameter()))

                    End If
                    sqlDataAdapter.Fill(dataSet)
                    If dataSet IsNot Nothing Then Return dataSet
                    Return New DataSet()
                End Using
            End Using
        Else
            Throw New Exception("Database connection is not defined.")
        End If
    End Function
    Protected Function List(ByVal procedure As String, Optional ByVal param As Object() = Nothing) As DataTable
        If Me._sqlConnection IsNot Nothing Then
            Using sqlCommand As SqlCommand = New SqlCommand(procedure, Me._sqlConnection)
                Using sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(sqlCommand)
                    Dim dataSet As DataSet = New DataSet()
                    sqlCommand.CommandType = CommandType.StoredProcedure
                    If param IsNot Nothing Then
                        If param.Length > 0 Then sqlCommand.MapParameters(CType(param, SqlParameter()))

                    End If
                    sqlDataAdapter.Fill(dataSet)
                    If dataSet IsNot Nothing Then Return dataSet.Tables(0)
                    Return New DataTable()
                End Using
            End Using
        Else
            Throw New Exception("Database connection is not defined.")
        End If
    End Function

    Protected Function Update(ByVal procedure As String, ByVal param As Object()) As Object
        If Me._sqlConnection IsNot Nothing Then
            Using sqlCommand As SqlCommand = New SqlCommand(procedure, Me._sqlConnection)
                sqlCommand.CommandType = CommandType.StoredProcedure
                If param IsNot Nothing Then
                    If param.Length > 0 Then sqlCommand.MapParameters(CType(param, SqlParameter()))

                End If
                Return sqlCommand.ExecuteScalar()
            End Using
        Else
            Throw New Exception("Database connection is not defined.")
        End If
    End Function

    

    'Protected ReadOnly Property ADOCommand As SqlCommand
    '    Get
    '        Return _sqlCommand
    '    End Get
    'End Property

    'Protected Overridable Sub OpenCommand(ByVal cmdText As String, ByVal commandType As CommandType)
    '    Me._sqlCommand = New SqlCommand(cmdText, Me._sqlConnection)
    '    Me._sqlCommand.CommandType = commandType
    'End Sub

    'Protected Overridable Sub OpenConnection()
    '    If Not Me._sqlCommand.Connection.State = ConnectionState.Open Then
    '        Me._sqlCommand.Connection.Open()
    '    End If
    'End Sub

    'Protected Overridable Sub CloseConnection()

    '    If Me._sqlCommand.Connection.State = ConnectionState.Open Then
    '        Me._sqlCommand.Connection.Close()
    '    End If
    'End Sub

    'Private Function getDBType(ByVal value As Object) As Object
    '    If String.IsNullOrEmpty(Convert.ToString(value)) Or
    '        IsNothing(value) Then
    '        Return IIf(GetType(String) = value.GetType(), CType(DBNull.Value.ToString, Object), DBNull.Value)

    '    Else
    '        If value.GetType() = GetType(Int64) Then
    '            Return Convert.ToInt64(value)
    '        ElseIf value.GetType() = GetType(Boolean) Then
    '            Return Convert.ToBoolean(value)
    '        ElseIf value.GetType() = GetType(DateTime) Or
    '            value.GetType() = GetType(Date) Then
    '            Return Convert.ToDateTime(value)
    '        ElseIf value.GetType() = GetType(Decimal) Then
    '            Return Convert.ToDecimal(value)
    '        ElseIf value.GetType() = GetType(Double) Then
    '            Return Convert.ToDouble(value)
    '        ElseIf value.GetType() = GetType(Int16) Or
    '            value.GetType() = GetType(Int32) Then
    '            Return Convert.ToInt16(value)
    '        ElseIf value.GetType() = GetType(Single) Then
    '            Return Convert.ToSingle(value)
    '        ElseIf Not value.GetType() = GetType(SByte) And Not value.GetType() = GetType(Byte) Then
    '            Return value
    '        Else
    '            Return Convert.ToByte(value)
    '        End If

    '    End If

    'End Function

    'Protected Overridable Sub SetupParameter(ByVal sqlParameter As SqlParameter())
    '    Dim tempSqlParameters As SqlParameter()

    '    If Not sqlParameter.Length = 0 Then

    '        tempSqlParameters = sqlParameter.Select(Function(x) _
    '                                                New SqlParameter() With {.ParameterName = x.ParameterName, _
    '                                                .Value = x.Value, _
    '                                                .DbType = getDBType(x.Value)}).ToArray()

    '        Me._sqlParameters = tempSqlParameters
    '    End If

    'End Sub

    'Protected Overloads Overrides Sub Finalize()

    '    If Me._sqlCommand.Connection.State = ConnectionState.Open Then
    '        Me._sqlCommand.Connection.Close()
    '    End If

    '    MyBase.Finalize()
    'End Sub

End Class
