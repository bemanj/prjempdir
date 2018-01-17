Public Class Main


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim _listEmployee As List(Of Class1)

        _listEmployee = New List(Of Class1)
        _listEmployee = New List(Of Class1)
        _listEmployee.Add(New Class1() With { _
                          .oracleid = "4313131", _
                          .lastname = "Soltes"
                          })

        DataGridViewEmployee.AutoGenerateColumns = False
        DataGridViewEmployee.DataSource = _listEmployee


        DataGridViewEmployee.Columns(0).DataPropertyName = "oracleid"
        DataGridViewEmployee.Columns(1).DataPropertyName = "lastname"


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
        EmployeeInfo.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewEmployee.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click
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
End Class
