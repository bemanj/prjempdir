Public Class IncompleteEmployees

    Private _incompleteEmployeesRepository As IncompleteEmployeesRepository
    Private _incompleteEmployeesGrid As IncompleteEmployeesGrid
    Private _dataTable As DataTable


#Region "CONSTRUCTOR"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _incompleteEmployeesRepository = New IncompleteEmployeesRepository
        _incompleteEmployeesGrid = New IncompleteEmployeesGrid
        _dataTable = New DataTable

    End Sub
#End Region

#Region "SUB ROUTINES"
    Public Sub ShowIncompleteEmployees()
        _incompleteEmployeesGrid.OracleID = UserAccount.UserID
        _dataTable = _incompleteEmployeesRepository.GetDataTable(_incompleteEmployeesGrid)                                                '   - get dtatable from db 
        IncompleteEmployeeDataGridView.DataSource = _dataTable

        If IncompleteEmployeeDataGridView.Rows.Count <> 0 Then
            IncompleteEmployeeDataGridView.Item(0, 0).Selected = False                '   - to remove highlighted item upon initial loading
        End If

    End Sub

#End Region

    Private Sub IncompleteEmployees_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub IncompleteEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowIncompleteEmployees()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Dispose()
    End Sub

    Private Sub IncompleteEmployeeDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles IncompleteEmployeeDataGridView.CellDoubleClick
        If Not e.RowIndex = -1 Then                                                                                                                 '   - to handle index out of range error
            Try
                UserAccount.SelectedOracleID = CLng(Me.IncompleteEmployeeDataGridView.SelectedRows(0).Cells("OracleID").Value)
                UserAccount.IsEdit = True
                EmployeeInfo.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class