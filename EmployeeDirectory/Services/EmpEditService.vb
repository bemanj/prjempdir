Imports System.Text.RegularExpressions

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

    Public Function ValidateEmail(ByVal EmailAddress) As Boolean
        Try
            'Dim vEmailAddress As New System.Net.Mail.MailAddress(EmailAddress)
            'If Not String.IsNullOrEmpty(EmailAddress) Then
            '    Dim vEmailAddress As New System.Net.Mail.MailAddress(EmailAddress)
            'End If
            Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
            If email.IsMatch(EmailAddress) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
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
