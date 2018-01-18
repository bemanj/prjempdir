Imports System.Data.SqlClient
Imports System.Configuration

Public Class Main
    Dim eR As New EmployeeRepository
    Dim emp As New Employee
    Dim dt As New DataTable

    Public Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt.Clear()
        TB_MgrV_OracleID.Focus()
        If LogIn.Username.Text = "manager" Then
            Me.Text = "Hello Manager!"
            emp.LocalManagerID = 1 'this will serve as the local manager ID - for demo only
            DataGridViewEmployee.DataSource = eR.GetListData(emp)
        Else
            emp.LocalManagerID = 2 'this will serve as the admin ID - for demo only (sp used same for manager's)
            DataGridViewEmployee.DataSource = eR.GetListData(emp)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
        EmployeeInfo.IsEdit = False
        EmployeeInfo.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click
        EmployeeInfo.Show()
        Me.Hide()
    End Sub

    Public Sub BtnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogOut.Click
        Me.Hide()
        LogIn.Show()
        LogIn.LogIn_Load(e, e)
        LogIn.Username.Clear()
        LogIn.UsernamePassword.Clear()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EmpInc.Click
        Me.Hide()
        incomplete.Show()
    End Sub
End Class
