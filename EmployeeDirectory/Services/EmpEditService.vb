Public Class EmpEditService

    Private _EmployeeRepository As New EmployeeRepository
    Private _Employee As New Employee

    'Public Sub New()
    '    _
    'End Sub

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

    'Public Sub PopulateFields(ByVal owner As EmployeeInfo)

    '    owner.SFCComboBox.Items.Clear()
    '    owner.SFCComboBox.Items.Add("Yes")
    '    owner.SFCComboBox.Items.Add("No")

    '    With owner
    '        .OracleIDTextBox.Text = CType(Employee.OracleID, String)
    '        .JobTitleTextBox.Text = Employee.Title
    '        .PositionTextBox.Text = Employee.Position                               ' Add New Field
    '        .LastNameTextBox.Text = Employee.LastName
    '        .FirstNameTextBox.Text = Employee.FirstName
    '        .MiddleNameTextBox.Text = Employee.MiddleName
    '        If Employee.Birthday.HasValue Then                                  ' 2018-01-29 6PM PUSH
    '            .BirthDatePicker.Value = CType(Employee.Birthday, Date)                ' Add New Field
    '            EmployeeInfo.ResetDatePicker(EmployeeInfo.BirthDatePicker)
    '        Else
    '            EmployeeInfo.ClearDatePicker(EmployeeInfo.BirthDatePicker)
    '        End If                                                              ' 2018-01-29 6PM PUSH
    '        .PersonalEmailTextBox.Text = Employee.PersonalEmail                     ' Change Field Name
    '        If Employee.MobileNo > 0 Then
    '            .MobileNoTextBox.Text = CType(Employee.MobileNo, String)
    '        End If
    '        .LandlineTextBox.Text = Employee.LandlineNo
    '        .HomeAdd1TextBox.Text = Employee.HomeAddress1
    '        .HomeAdd2TextBox.Text = Employee.HomeAddress2
    '        If Employee.ZipCode > 0 Then
    '            .ZipCodeTextBox.Text = CType(Employee.ZipCode, String)                  ' Add New Field
    '        End If
    '        If Employee.PhoneExtension > 0 Then
    '            .PhoneExtensionTextBox.Text = CType(Employee.PhoneExtension, String)    ' Add New Field
    '        End If
    '        .OfficeEmailTextBox.Text = Employee.OfficeEmail                         ' Add New Field
    '        .EntityTextBox.Text = Employee.Entity                                   ' Add New Field
    '        .DivisionTextBox.Text = Employee.Division
    '        .DepartmentTextBox.Text = Employee.Department
    '        .USManagerTextBox.Text = Employee.USManager
    '        .OnboardingTicketTextBox.Text = Employee.OnboardingTicket
    '        .RecruiterTextBox.Text = Employee.Recruiter
    '        If Employee.StartDate.HasValue Then                                 ' 2018-01-29 6PM PUSH
    '            .StartDatePicker.Value = CType(Employee.StartDate, Date)         ' 2018-01-26 11PM PUSH
    '        End If
    '        If Employee.SFCDate.HasValue Then                                   ' 2018-01-29 6PM PUSH
    '            .SFCDatePicker.Value = CType(Employee.SFCDate, Date)             ' 2018-01-26 11PM PUSH
    '        End If                                                              ' 2018-01-29 6PM PUSH
    '        .SFCComboBox.SelectedItem = Employee.SFC

    '        .SiteAdd1TextBox.Text = Employee.SiteAddress1
    '        .SiteAdd2TextBox.Text = Employee.SiteAddress2
    '        .SiteCityTextBox.Text = Employee.SiteCityName           ' Add New Field
    '        .SiteRegionTextBox.Text = Employee.SiteRegionName       ' Add New Field
    '        .SiteCountryTextBox.Text = Employee.SiteCountry         ' Add New Field

    '        .SeatNoTextBox.Text = Employee.SeatNumber
    '        .PCNameTextbox.Text = Employee.PCName
    '        .MercuryIDTextbox.Text = Employee.MercuryID
    '        .EISIDTextbox.Text = Employee.EISID
    '        .OraclePRDTextbox.Text = Employee.OraclePRDID
    '        .InsightIDTextbox.Text = Employee.InsightID
    '        .NCOGrpIDTextbox.Text = Employee.NCOGroup
    '        .EGSPREMIDTextbox.Text = Employee.EGSPremID
    '        .ElsevierIDTextbox.Text = Employee.ElsevierID
    '        .GithubIDTextbox.Text = Employee.GITHubID
    '        .GenderComboBox.Text = Employee.Gender
    '        .CountryComboBox.Text = Employee.Country
    '        .ShiftComboBox.Text = Employee.Shift

    '        .LocalManagerComboBox.Text = SetListName(EmployeeInfo.LocalManagerComboBox, Employee.LocalManagerID)

    '        Dim _site As New Site()
    '        _site = SetSiteDetails(EmployeeInfo.SiteComboBox, Employee.SiteID)
    '        If _site IsNot Nothing Then
    '            .SiteComboBox.Text = _site.SiteName
    '            .SiteCityTextBox.Text = _site.SiteCityName
    '            .SiteCountryTextBox.Text = _site.SiteCountry
    '            .SiteRegionTextBox.Text = _site.SiteRegionName
    '            .SiteAdd1TextBox.Text = _site.SiteAddress1
    '            .SiteAdd2TextBox.Text = _site.SiteAddress2

    '            If _site.SiteZipCode = 0 Then
    '                .SiteZipCodeTextBox.Text = ""
    '            Else
    '                .SiteZipCodeTextBox.Text = _site.SiteZipCode
    '            End If

    '        End If
    '        If Not Employee.Floor = String.Empty Then
    '            .FloorComboBox.Text = Employee.Floor.Trim()
    '        End If

    '        .TeamComboBox.Text = SetListName(EmployeeInfo.TeamComboBox, Employee.TeamID)
    '        If Employee.RegionID > 0 Then
    '            .RegionComboBox.Text = SetListName(EmployeeInfo.RegionComboBox, Employee.RegionID)
    '        End If
    '        If Employee.CityID > 0 Then
    '            .CityComboBox.Text = SetListName(EmployeeInfo.CityComboBox, Employee.CityID)
    '        End If

    '        If Employee.IDCreated = False Then
    '            .IDCreatedComboBox.SelectedItem = "No"
    '        Else
    '            .IDCreatedComboBox.SelectedItem = "Yes"
    '        End If

    '        If Employee.SFC = False Then
    '            .SFCComboBox.SelectedItem = "No"
    '        Else
    '            .SFCComboBox.SelectedItem = "Yes"
    '        End If
    '    End With

    'End Sub

    
    '*** B KABAHAR - 1/26
    '*** BK START OF CHANGE
    Public Sub ProtectFields(ByVal owner As EmployeeInfo)
        With owner
            .OracleIDTextBox.Enabled = False
            .JobTitleTextBox.Enabled = False
            .PositionTextBox.Enabled = False
            .PhoneExtensionTextBox.Enabled = False
            .OfficeEmailTextBox.Enabled = False
            .TeamComboBox.Enabled = False
            .LocalManagerComboBox.Enabled = False
            .SiteCityTextBox.Enabled = False
            .SiteRegionTextBox.Enabled = False
            .SiteCountryTextBox.Enabled = False
            .SiteComboBox.Enabled = False
            .SiteAdd1TextBox.Enabled = False
            .SiteAdd2TextBox.Enabled = False
            .FloorComboBox.Enabled = False
            .SeatNoTextBox.Enabled = False
            .OnboardingTicketTextBox.Enabled = False
            .RecruiterTextBox.Enabled = False
            .SFCComboBox.Enabled = False
            .SFCDatePicker.Enabled = False
            .IDCreatedComboBox.Enabled = False
            .ShiftComboBox.Enabled = False
            .MercuryIDTextbox.Enabled = False
            .EISIDTextbox.Enabled = False
            .OraclePRDTextbox.Enabled = False
        End With

    End Sub
    '*** BK END OF CHANGE

    'Public Sub SetSelectedValue(ByVal comboBox As ComboBox, ByVal value As Integer)

    '    Dim _list As List(Of DropDownList)
    '    _list = comboBox.DataSource

    '    comboBox.SelectedItem = _list.Where(Function(x) x.ListID = value).FirstOrDefault()


    'End With
    'End Sub
End Class
