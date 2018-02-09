Public Class EmpEditService

    Private _EmployeeRepository As New EmployeeRepository
    Private _Employee As New Employee


    Public Property Employee() As Employee
        Get
            Return _Employee
        End Get
        Set(ByVal value As Employee)
            _Employee = value
        End Set
    End Property

    Public Function SelectEmpFromList(ByVal OracleID As Long) As Employee
        Return _EmployeeRepository.GetData(New Employee() With {.OracleID = OracleID})
    End Function

    ''*** B KABAHAR - 1/26
    ''*** BK START OF CHANGE
    'Public Sub ProtectFields(ByVal owner As EmployeeInfo)
    '    With owner
    '        .OracleIDTextBox.Enabled = False
    '        .JobTitleTextBox.Enabled = False
    '        .PositionTextBox.Enabled = False
    '        .PhoneExtensionTextBox.Enabled = False
    '        .OfficeEmailTextBox.Enabled = False
    '        .TeamComboBox.Enabled = False
    '        .LocalManagerComboBox.Enabled = False
    '        .SiteCityTextBox.Enabled = False
    '        .SiteRegionTextBox.Enabled = False
    '        .SiteCountryTextBox.Enabled = False
    '        .SiteComboBox.Enabled = False
    '        .SiteAdd1TextBox.Enabled = False
    '        .SiteAdd2TextBox.Enabled = False
    '        .FloorComboBox.Enabled = False
    '        .SeatNoTextBox.Enabled = False
    '        .OnboardingTicketTextBox.Enabled = False
    '        .RecruiterTextBox.Enabled = False
    '        .SFCComboBox.Enabled = False
    '        .SFCDatePicker.Enabled = False
    '        .IDCreatedComboBox.Enabled = False
    '        .ShiftComboBox.Enabled = False
    '        .MercuryIDTextbox.Enabled = False
    '        .EISIDTextbox.Enabled = False
    '        .OraclePRDTextbox.Enabled = False
    '    End With

    'End Sub
    '*** BK END OF CHANGE
End Class
