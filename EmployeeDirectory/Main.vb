Imports System.Data.SqlClient
Imports System.Configuration

Public Class Main
    Dim eR As New EmployeeRepository
    Dim emp As New Employee
    Dim _EmpEditService As New EmpEditService

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LogIn.Username.Text = "manager" Then
            Me.Text = "Hello Manager!"
            emp.LocalManagerID = 1 'this will serve as the local manager ID
            DataGridViewEmployee.DataSource = eR.GetListData(emp)
        End If

        'Dim _listEmployee As List(Of Class1)

        '_listEmployee = New List(Of Class1)
        '_listEmployee = New List(Of Class1)
        '_listEmployee.Add(New Class1() With { _
        '                  .oracleid = "4313131", _
        '                  .lastname = "Soltes"
        '                  })

        'DataGridViewEmployee.AutoGenerateColumns = False
        'DataGridViewEmployee.DataSource = _listEmployee


        'DataGridViewEmployee.Columns(0).DataPropertyName = "oracleid"
        'DataGridViewEmployee.Columns(1).DataPropertyName = "lastname"


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
        EmployeeInfo.Show()
        Me.Hide()
    End Sub




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        LogIn.Show()
        LogIn.Username.Text = " "
        LogIn.UsernamePassword.Text = ""
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EmpInc.Click
        Me.Hide()
        incomplete.Show()
    End Sub

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click
        Me.Hide()

        Try
            Dim _tempSelectedRow = Me._EmpEditService.SelectEmpFromList(CInt(Me.DataGridViewEmployee.SelectedRows(0).Cells("OracleID").Value))
            EmployeeInfo.EmpEditService.Employee = _tempSelectedRow
            EmployeeInfo.IsEdit = True
            EmployeeInfo.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
