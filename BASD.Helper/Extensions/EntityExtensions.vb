Imports System.Runtime.CompilerServices
Imports System.Data.SqlClient
Imports System.Reflection
Imports System
Imports System.Windows.Forms

Public Module EntityExtensions

    <Extension()>
    Public Sub MapParameters(ByVal command As SqlCommand, ByVal paramList As SqlParameter())
        If paramList Is Nothing Then Return
        If paramList.Length = 0 Then Return
        If command.CommandType <> CommandType.StoredProcedure Then Throw New Exception("Cannot derive parameters, stored procedure is required.")
        SqlCommandBuilder.DeriveParameters(command)
        For Each parameter As SqlParameter In command.Parameters
            If (parameter.Direction = ParameterDirection.Input) OrElse (parameter.Direction = ParameterDirection.InputOutput) Then
                Dim param = paramList.Where(Function(x) x.ParameterName = parameter.ParameterName).FirstOrDefault()
                parameter.Value = If(param IsNot Nothing, param.Value, Nothing)
            End If
        Next
    End Sub

    <Extension()>
    Public Function SingleMapToEntity(Of T As New)(ByVal table As DataTable) As List(Of T)
        Dim _targetType As Type = GetType(T)
        Dim _columns As DataColumn() = table.Columns.Cast(Of DataColumn)().ToArray()
        Dim _list As List(Of T) = New List(Of T)()
        For Each dr As DataRow In table.Rows
            Dim _data As T = New T()
            For Each col As DataColumn In _columns
                Dim _info As PropertyInfo = _targetType.GetProperty(col.ColumnName) '_targetType.GetProperty(If(_columns.First().Equals(col), "Id", col.ColumnName))
                If _info IsNot Nothing Then
                    Dim _value As Object = Nothing
                    If dr(col.ColumnName).[GetType]() = GetType(DateTime) AndAlso _info.PropertyType = GetType(String) Then
                        _value = String.Format("{0: " & System.Configuration.ConfigurationManager.AppSettings("AppDateFormat").ToString() & "}", dr(col.ColumnName))
                    Else
                        _value = If(dr(col.ColumnName).[GetType]() = GetType(DBNull), Nothing, dr(col.ColumnName))
                    End If
                    _info.SetValue(_data, IIf(dr(col.ColumnName).GetType() = GetType(DBNull), Nothing, _value), Nothing)
                    '_info.SetValue(_data, If(dr(col.ColumnName).GetType() = GetType(DBNull), Nothing, _value))
                End If
            Next

            _list.Add(_data)
        Next

        Return _list
    End Function

    <Extension()>
    Public Function SingleMapToEntity(Of T As New)(ByVal table As DataTable, ByVal primaryKey As String) As List(Of T)
        Dim _targetType As Type = GetType(T)
        Dim _columns As DataColumn() = table.Columns.Cast(Of DataColumn)().ToArray()
        Dim _list As List(Of T) = New List(Of T)()
        For Each dr As DataRow In table.Rows
            Dim _data As T = New T()
            For Each col As DataColumn In _columns
                Dim _info As PropertyInfo = _targetType.GetProperty(If(primaryKey.Equals(col.ColumnName), "Id", col.ColumnName))
                If _info IsNot Nothing Then
                    Dim _value As Object = Nothing
                    If dr(col.ColumnName).[GetType]() = GetType(DateTime) AndAlso _info.PropertyType = GetType(String) Then
                        _value = String.Format("{0: " & System.Configuration.ConfigurationManager.AppSettings("AppDateFormat").ToString() & "}", dr(col.ColumnName))

                    ElseIf Not _info.PropertyType = GetType(String) Then
                        _value = Convert.ChangeType(dr(col.ColumnName), _info.PropertyType)
                        '    _value = CDate(dr(col.ColumnName))
                        'ElseIf _info.PropertyType = GetType(Boolean) Then
                        '    _value = CBool(dr(col.ColumnName))
                    Else
                        _value = If(dr(col.ColumnName).[GetType]() = GetType(DBNull), Nothing, dr(col.ColumnName))
                    End If

                    _info.SetValue(_data, IIf(dr(col.ColumnName).GetType() = GetType(DBNull), Nothing, CType(_value, Object)), Nothing)
                End If
            Next

            _list.Add(_data)
        Next

        Return _list
    End Function

    <Extension()>
    Public Function Encrypt(ByVal inString As String, Optional ByVal provider As BASDCryptoProvider = BASDCryptoProvider.Trides) As String

        Dim _crypto As New BaseCrypto(provider)
        Return _crypto.EncryptString(inString)

    End Function

    <Extension()>
    Public Function Decrypt(ByVal inString As String, Optional ByVal provider As BASDCryptoProvider = BASDCryptoProvider.Trides) As String

        Dim _crypto As New BaseCrypto(provider)
        Return _crypto.DecryptString(inString)

    End Function

    <Extension()>
    Public Function DataGridRowToDataSet(ByVal dataGridRow As System.Windows.Forms.DataGridViewRow) As DataSet
        Dim _tempDataSet As New DataSet
        Dim _tempDataTable As New DataTable
        Dim _tempDataRow As DataRow

        '_tempDataSet.Tables.Add(New DataTable("Table"))

        For Each column As DataGridViewColumn In dataGridRow.DataGridView.Columns
            _tempDataTable.Columns.Add(New DataColumn(column.Name))
        Next

        _tempDataRow = _tempDataTable.NewRow()

        For Each column As DataColumn In _tempDataRow.Table.Columns
            _tempDataRow(column.ColumnName) = dataGridRow.Cells(column.ColumnName).Value
        Next
        _tempDataTable.Rows.Add(_tempDataRow)
        _tempDataSet.Tables.Add(_tempDataTable)
        Return _tempDataSet

    End Function

    '<Extension()>
    'Function EntityToSingleMap(ByVal entities As IEnumerable(Of IEntity), ByVal tableType As TableType) As DataTable
    '    Dim dt As DataTable = New DataTable()
    '    Dim dataColumns = tableType.GetDataTableColumns()
    '    dt.Columns.AddRange(dataColumns)
    '    For Each entity In entities
    '        Dim dataRow = dt.NewRow()
    '        For Each column As DataColumn In dataColumns
    '            dataRow(column.ColumnName) = entity.GetType().GetProperty(column.ColumnName).GetValue(entity, Nothing)
    '        Next

    '        If dt.Rows.IndexOf(dataRow) = -1 Then dt.Rows.Add(dataRow)
    '    Next

    '    Return dt
    'End Function

    '<Extension()>
    'Private Function GetDataTableColumns(ByVal tableType As TableType) As DataColumn()
    '    If tableType = tableType.TopTask Then Return New DataColumn() {New DataColumn("top_task_no"), New DataColumn("budget_centre"), New DataColumn("biennium"), New DataColumn("category"), New DataColumn("programme"), New DataColumn("priority"), New DataColumn("output"), New DataColumn("deliverable"), New DataColumn("products_and_services"), New DataColumn("planned_cost"), New DataColumn("created_by")}
    '    If tableType = tableType.LowerTask Then Return New DataColumn() {New DataColumn("top_task_id"), New DataColumn("lower_task_no"), New DataColumn("lower_task_name"), New DataColumn("partner"), New DataColumn("donors"), New DataColumn("other_donor"), New DataColumn("ccs_strategic_priority"), New DataColumn("assistance_type"), New DataColumn("target_country"), New DataColumn("target_date"), New DataColumn("cross_cutting_programmes"), New DataColumn("estimate_cost"), New DataColumn("notes"), New DataColumn("created_by")}
    '    If tableType = tableType.TaskLinkage Then
    '        Return New DataColumn() {New DataColumn("task_linkage_id"), New DataColumn("lower_task_id"), New DataColumn("linkage_type"), New DataColumn("linkage_group_id"), New DataColumn("linkage_id"), New DataColumn("created_by"), New DataColumn("updated_by"), New DataColumn("action")}
    '    End If

    '    Return New DataColumn() {}
    'End Function
End Module
