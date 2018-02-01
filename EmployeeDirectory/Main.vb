Imports System.Data.SqlClient
Imports System.Configuration
Imports System.ComponentModel

Public Class Main
    Dim eR As New EmployeeRepository
    Dim mR As New ManagerRepository
    Dim _EmpEditService As New EmpEditService
    Public Sfc As Boolean
    Public Add As Boolean


    Dim emp As New Employee
    Dim _LoginView As New LoginView
    Dim mg As New ManagerGrid

    Dim dt As New DataTable
    Dim ls As New List(Of ManagerGrid)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Public Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TB_MgrV_OracleID.Focus()
        'mg.OracleID = CurrentUser
        'mg.SFC = False
        'ReloadDataGridWithSort()
        'If DataGridViewEmployee.Rows.Count <> 0 Then
        '    DataGridViewEmployee.Item(0, 0).Selected = False                '   - to remove highlighted item upon initial loading
        'End If

        ButtonActive_Click(e, e)
        If CurrentUserType = 2 Then          
            ToolStripStatusLabelUser.Text = "Current User: " & _LoginView.FirstName & " " & _LoginView.LastName
        Else
            ToolStripStatusLabelUser.Text = "Current User: Admin"
            Label_ManagerName.Text = "Hello Admin!"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
        Add = True
        EmployeeInfo.TB_OracleID.Enabled = True
        EmployeeInfo.IsEdit = False
        EmployeeInfo.Btn_RevertClear.Text = "Clear"
        '***** START: VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
        'EmployeeInfo.BlackLabel()
        '***** END  : VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
        EmployeeInfo.ShowDialog()
        EmployeeInfo.EmployeeInfo_Load(e, e)
        EmployeeInfo.TB_OracleID.Focus()
        'Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EmployeeInfo.Show()
        Me.Hide()
    End Sub

    Public Sub BtnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogOut.Click
        BtnClose.Hide()                
        Me.Hide()
        LogIn.Show()
        LogIn.UsernamePassword.Clear()
        LogIn.Username.Clear()
        LogIn.Username.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EmpInc.Click
        Me.Hide()
        incomplete.Show()
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub DataGridViewEmployee_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewEmployee.CellDoubleClick
        If Not e.RowIndex = -1 Then                                                                                                                 '   - to handle index out of range error
            Try
                Dim _tempSelectedRow = Me._EmpEditService.SelectEmpFromList(CLng(Me.DataGridViewEmployee.SelectedRows(0).Cells("OracleID").Value)) '- set SelectionSet property to FullRowSelect
                EmployeeInfo.EmpEditService.Employee = _tempSelectedRow
                EmployeeInfo.IsEdit = True
                EmployeeInfo.Btn_RevertClear.Text = "Revert"
                '***** START: VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
                'EmployeeInfo.BlackLabel()
                '***** END  : VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
                EmployeeInfo.TB_OracleID.Enabled = False
                'Me.Hide()
                EmployeeInfo.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

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

    Public Sub ButtonSFC_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSFC.Click
        Sfc = True
        LabelSFC.Text = "SFC Employees"
        mg.OracleID = CurrentUser
        mg.SFC = True
        ReloadDataGridWithSort()
    End Sub

    Public Sub ButtonActive_Click(sender As System.Object, e As System.EventArgs) Handles ButtonActive.Click
        Sfc = False
        LabelSFC.Text = "Current Employees"
        mg.OracleID = CurrentUser
        mg.SFC = False
        'DataGridViewEmployee.DataSource = mR.GetGridListData(mg)
        ReloadDataGridWithSort()
    End Sub

    Public Sub ReloadDataGridWithSort()
        ls = mR.GetGridListData(mg)                                               '   - get list from db
        dt = ConvertToDataTable(ls)                                               '   - converts list to datatable to enable sorting
        DataGridViewEmployee.DataSource = dt
        Me.DataGridViewEmployee.Columns("SFC").Visible = False
        If DataGridViewEmployee.Rows.Count <> 0 Then
            DataGridViewEmployee.Item(0, 0).Selected = False                '   - to remove highlighted item upon initial loading
        End If
    End Sub

End Class
