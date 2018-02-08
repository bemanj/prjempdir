Imports System.ComponentModel

Public Class Main

    Dim mR As New ManagerRepository
    Dim _EmpEditService As New EmpEditService           'rename to standard, dependcy inject, private
    Public IsSFC As Boolean 'private


    Dim _LoginView As New LoginView
    Dim mg As New ManagerGrid

    Dim dt As New DataTable
    Dim ls As New List(Of ManagerGrid)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "SUB ROUTINES"
    Public Sub ReloadDataGridWithSort()
        ls = mR.GetGridListData(mg)                                               '   - get list from db
        dt = ConvertToDataTable(ls)                                               '   - converts list to datatable to enable sorting
        EmployeeDataGridView.DataSource = dt
        Me.EmployeeDataGridView.Columns("SFC").Visible = False
        If EmployeeDataGridView.Rows.Count <> 0 Then
            EmployeeDataGridView.Item(0, 0).Selected = False                '   - to remove highlighted item upon initial loading
        End If
    End Sub

    Public Shared Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim dt As New DataTable()
        For i As Integer = 0 To properties.Count - 1
            Dim [property] As PropertyDescriptor = properties(i)
            dt.Columns.Add([property].Name, [property].PropertyType)
        Next
        Dim values As Object() = New Object(properties.Count - 1) {}
        For Each item As T In list
            For i As Integer = 0 To values.Length - 1
                values(i) = properties(i).GetValue(item)
            Next
            dt.Rows.Add(values)
        Next
        Return dt
    End Function

    Public Sub ShowActiveEmployees()
        IsSFC = False
        EmployeeListLabel.Text = "Active Employees"
        mg.OracleID = UserAccount.UserID
        mg.SFC = False
        ReloadDataGridWithSort()
    End Sub
#End Region

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Public Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ShowActiveEmployees()
        ActiveButton.Focus()

        If UserAccount.UserType = 2 Then
            UserToolStripStatusLabel.Text = "Current User: " & _LoginView.FirstName & " " & _LoginView.LastName
            ManagerNameLabel.Text = ("Employee(s) under " & UserAccount.UserName)
            UserToolStripStatusLabel.Text = "Current User: " & UserAccount.UserName
            ShowActiveEmployees()
        Else
            UserToolStripStatusLabel.Text = "Current User: Admin"
            ManagerNameLabel.Text = "Hello Admin!"
        End If
    End Sub

    Private Sub AddEmployeeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeeButton.Click
        'EmployeeInfo.OracleIDTextBox.Enabled = True
        'EmployeeInfo.IsEdit = False
        'EmployeeInfo.RevertClearButton.Text = "Clear"
        'EmployeeInfo.OracleIDTextBox.Focus()
        UserAccount.IsEdit = False
        Me.Hide()
        EmployeeInfo.ShowDialog()
        'EmployeeInfo.EmployeeInfo_Load(e, e)

    End Sub

    Public Sub BtnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogOut.Click
        BtnClose.Hide()
        Me.Hide()
        LogIn.Show()
        LogIn.PasswordTextBox.Clear()
        LogIn.UsernameTextBox.Clear()
        LogIn.UsernameTextBox.Focus()
    End Sub

    Private Sub Btn_EmpInc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EmpInc.Click
        Threading.Thread.Sleep(2000)
        Dim webAddress As String = "http://mnl02s55581d1:3030/index.html"
        Process.Start(webAddress)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub EmployeeDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellDoubleClick
        If Not e.RowIndex = -1 Then                                                                                                                 '   - to handle index out of range error
            Try
                Dim _tempSelectedRow = Me._EmpEditService.SelectEmpFromList(CLng(Me.EmployeeDataGridView.SelectedRows(0).Cells("OracleID").Value)) '- set SelectionSet property to FullRowSelect
                'EmployeeInfo.EmpEditService.Employee = _tempSelectedRow
                EmployeeInfo.emp = _tempSelectedRow
                UserAccount.IsEdit = True
                EmployeeInfo.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub InactiveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InactiveButton.Click
        IsSFC = True
        EmployeeListLabel.Text = "Inactive Employees"
        mg.OracleID = UserAccount.UserID
        mg.SFC = True
        ReloadDataGridWithSort()
    End Sub

    Public Sub ActiveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveButton.Click
        ShowActiveEmployees()
    End Sub
End Class
