Imports System.ComponentModel

Public Class Main


    Private _managerRepository As ManagerRepository
    Private _loginView As LoginView
    Private _managerGrid As ManagerGrid
    Private _dataTable As DataTable
    'Dim _managerRepository As New ManagerRepository
    'Dim _EmpEditService As New EmpEditService           'rename to standard, dependency inject, private
    'Private IsSFC As Boolean 'private
    'Dim _loginView As New LoginView
    'Dim ls As New List(Of ManagerGrid)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        _managerRepository = New ManagerRepository
        _loginView = New LoginView
        _managerGrid = New ManagerGrid
        _dataTable = New DataTable
        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "SUB ROUTINES"
    Public Sub ReloadDataGridWithSort()
        'ls = mR.GetGridListData(mg)                                               '   - get list from db
        'dt = ConvertToDataTable(ls)                                               '   - converts list to datatable to enable sorting
        _dataTable = _managerRepository.GetDataTable(_managerGrid)                                                '   - get dtatable from db 
        EmployeeDataGridView.DataSource = _dataTable
        Me.EmployeeDataGridView.Columns("SFC").Visible = False

        If EmployeeDataGridView.Rows.Count <> 0 Then
            EmployeeDataGridView.Item(0, 0).Selected = False                '   - to remove highlighted item upon initial loading
        End If
    End Sub

    'Public Shared Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
    '    Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
    '    Dim dt As New DataTable()
    '    For i As Integer = 0 To properties.Count - 1
    '        Dim [property] As PropertyDescriptor = properties(i)
    '        dt.Columns.Add([property].Name, [property].PropertyType)
    '    Next
    '    Dim values As Object() = New Object(properties.Count - 1) {}
    '    For Each item As T In list
    '        For i As Integer = 0 To values.Length - 1
    '            values(i) = properties(i).GetValue(item)
    '        Next
    '        dt.Rows.Add(values)
    '    Next
    '    Return dt
    'End Function

    Public Sub ShowActiveEmployees()
        EmployeeListLabel.Text = "Active Employees"
        _managerGrid.OracleID = UserAccount.UserID
        _managerGrid.SFC = False
        ReloadDataGridWithSort()
    End Sub

    Public Sub ShowInActiveEmployees()
        EmployeeListLabel.Text = "Inactive Employees"
        _managerGrid.OracleID = UserAccount.UserID
        _managerGrid.SFC = True
        ReloadDataGridWithSort()
    End Sub

#End Region

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Public Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveButton.Focus()

        If UserAccount.UserType = 2 Then                    ' MANAGER
            CloseButton.Hide()
            ShowActiveEmployees()
        ElseIf UserAccount.UserType = 1 Then                ' ADMIN
            CloseButton.Show()
        End If

        UserToolStripStatusLabel.Text = "Current User: " & _loginView.FirstName & " " & _loginView.LastName
        ManagerNameLabel.Text = ("Employee(s) under " & UserAccount.UserName)
        UserToolStripStatusLabel.Text = "Current User: " & UserAccount.UserName
    End Sub

    Private Sub AddEmployeeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeeButton.Click
        UserAccount.IsEdit = False
        Me.Hide()
        EmployeeInfo.ShowDialog()
    End Sub

    Public Sub LogOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutButton.Click
        CloseButton.Hide()
        Me.Dispose()
        LogIn.Show()
    End Sub

    Private Sub EmployeeIncButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeIncButton.Click
        Threading.Thread.Sleep(2000)
        Dim webAddress As String = "http://mnl02s55581d1:3030/index.html"
        Process.Start(webAddress)
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Dispose()
        Admin.Show()
    End Sub

    Private Sub EmployeeDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellDoubleClick
        If Not e.RowIndex = -1 Then                                                                                                                 '   - to handle index out of range error
            Try
                UserAccount.SelectedOracleID = CLng(Me.EmployeeDataGridView.SelectedRows(0).Cells("OracleID").Value)
                UserAccount.IsEdit = True
                EmployeeInfo.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Public Sub InactiveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InactiveButton.Click
        ShowInActiveEmployees()
    End Sub

    Public Sub ActiveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveButton.Click
        ShowActiveEmployees()
    End Sub

End Class
