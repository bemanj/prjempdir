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

    Public Sub PopulateFields(ByVal owner As EmployeeInfo)

        owner.CB_SFC.Items.Clear()
        owner.CB_SFC.Items.Add("Yes")
        owner.CB_SFC.Items.Add("No")

        With owner
            .TB_OracleID.Text = CType(Employee.OracleID, String)
            .TB_Title.Text = Employee.Title
            .TB_Position.Text = Employee.Position                               ' Add New Field
            .TB_LastName.Text = Employee.LastName
            .TB_FirstName.Text = Employee.FirstName
            .TB_MiddleName.Text = Employee.MiddleName
            If Employee.Birthday.HasValue Then                                  ' 2018-01-29 6PM PUSH
                .DT_Birth.Value = CType(Employee.Birthday, Date)                ' Add New Field
            End If                                                              ' 2018-01-29 6PM PUSH
            .TB_PersonalEmail.Text = Employee.PersonalEmail                     ' Change Field Name
            If Employee.MobileNo > 0 Then
                .TB_MobileNo.Text = CType(Employee.MobileNo, String)
            End If
            .TB_Landline.Text = Employee.LandlineNo
            .TB_HomeAddLine1.Text = Employee.HomeAddress1
            .TB_HomeAddLine2.Text = Employee.HomeAddress2
            If Employee.ZipCode > 0 Then
                .MB_Zipcode.Text = CType(Employee.ZipCode, String)                  ' Add New Field
            End If
            If Employee.PhoneExtension > 0 Then
                .MB_PhoneExtension.Text = CType(Employee.PhoneExtension, String)    ' Add New Field
            End If
            .TB_OfficeEmail.Text = Employee.OfficeEmail                         ' Add New Field
            .TB_Entity.Text = Employee.Entity                                   ' Add New Field
            .TB_Division.Text = Employee.Division
            .TB_Department.Text = Employee.Department
            .TB_USMgr.Text = Employee.USManager
            .TB_OnboardingTkt.Text = Employee.OnboardingTicket
            .TB_Recruiter.Text = Employee.Recruiter
            If Employee.StartDate.HasValue Then                                 ' 2018-01-29 6PM PUSH
                .DT_StartDate.Value = CType(Employee.StartDate, Date)         ' 2018-01-26 11PM PUSH
            End If
            If Employee.SFCDate.HasValue Then                                   ' 2018-01-29 6PM PUSH
                .DT_SFCDate.Value = CType(Employee.SFCDate, Date)             ' 2018-01-26 11PM PUSH
            End If                                                              ' 2018-01-29 6PM PUSH
            .TB_AddressLine1.Text = Employee.SiteAddress1
            .TB_AddressLine2.Text = Employee.SiteAddress2
            .TB_SiteCity.Text = Employee.SiteCityName           ' Add New Field
            .TB_SiteRegion.Text = Employee.SiteRegionName       ' Add New Field
            .TB_SiteCountry.Text = Employee.SiteCountry         ' Add New Field
            '.TB_Floor.Text = Employee.Floor
            .TB_SeatNo.Text = Employee.SeatNumber
            .TB_PCName.Text = Employee.PCName
            .TB_MercuryID.Text = Employee.MercuryID
            .TB_EISID.Text = Employee.EISID
            .TB_OraclePRD.Text = Employee.OraclePRDID
            .TB_InsightID.Text = Employee.InsightID
            .TB_NCOGrpID.Text = Employee.NCOGroup
            .TB_EGSPREMID.Text = Employee.EGSPremID
            .TB_ElsevierID.Text = Employee.ElsevierID
            .TB_GithubID.Text = Employee.GITHubID
            .CB_Gender.Text = Employee.Gender
            .CB_Country.Text = Employee.Country
            .CB_Shift.Text = Employee.Shift
            ' ****** NEEDS COMBO BOX LOGIC/HANDLING ******
            '.CB_City.Text = Employee.CityName
            '.CB_Region.Text = Employee.RegionName
            '.CB_Country.Text = Employee.Country
            '.CB_Team.Text = Employee.TeamName
            '.CB_LocalMgr.Text = Employee.Mgr_Last_Name.Trim & ", " & Employee.Mgr_First_Name
            '.CB_WorkSched.Text = Employee.Shift         ' Add New Field
            '.CB_SFC.Text = Employee.SFC
            '.CB_Site.Text = Employee.SiteName
            '.CB_Site.SelectedItem = Employee.SiteID


            'If Employee.LocalManagerID = 2 Then
            '    .CB_LocalMgr.SelectedItem = "Rebazar Borromeo"
            'End If
            'If Employee.Gender = "M" Then
            '    .CB_Gender.SelectedItem = "Male"
            'Else
            '    .CB_Gender.SelectedItem = "Female"
            'End If
            'If Employee.SiteID = 1 Then
            '    .CB_Site.Text = "Alorica Center"
            '    .TB_AddressLine1.Text = "MJ Corporate Plaza, 2310 Pasong Tamo Extension, "
            '    .TB_AddressLine2.Text = "Brgy Magallanes, Makati City 1231"
            'End If
            'If Employee.TeamID = 4 Then
            '    .CB_Team.Text = "BASD"
            'End If

            '*** SOF LOOKUP OF IDS

            .CB_LocalMgr.Text = SetListName(EmployeeInfo.CB_LocalMgr, Employee.LocalManagerID)

            Dim _site As New Site()
            _site = SetSiteDetails(EmployeeInfo.CB_Site, Employee.SiteID)
            If _site IsNot Nothing Then
                .CB_Site.Text = _site.SiteName
                .TB_SiteCity.Text = _site.SiteCityName
                .TB_SiteCountry.Text = _site.SiteCountry
                .TB_SiteRegion.Text = _site.SiteRegionName
                .TB_AddressLine1.Text = _site.SiteAddress1
                .TB_AddressLine2.Text = _site.SiteAddress2
                .TB_SiteZip.Text = _site.SiteZipCode
            End If
            If Not Employee.Floor = String.Empty Then
                .TB_Floor.Text = Employee.Floor.Trim()
            End If

            .CB_Team.Text = SetListName(EmployeeInfo.CB_Team, Employee.TeamID)
            If Employee.RegionID > 0 Then
                .CB_Region.Text = SetListName(EmployeeInfo.CB_Region, Employee.RegionID)
            End If
            If Employee.CityID > 0 Then
                .CB_City.Text = SetListName(EmployeeInfo.CB_City, Employee.CityID)
            End If

            If Employee.IDCreated = False Then
                .CB_IDCreated.SelectedItem = "No"
            Else
                .CB_IDCreated.SelectedItem = "Yes"
            End If

            If Employee.SFC = False Then
                .CB_SFC.SelectedItem = "No"
            Else
                .CB_SFC.SelectedItem = "Yes"
            End If

        End With

    End Sub

    '*** B KABAHAR - 1/26
    '*** BK START OF CHANGE
    Public Sub ProtectFields(ByVal owner As EmployeeInfo)
        With owner
            .TB_OracleID.Enabled = False
            .TB_Title.Enabled = False
            .TB_Position.Enabled = False
            .MB_PhoneExtension.Enabled = False
            .TB_OfficeEmail.Enabled = False
            .CB_Team.Enabled = False
            .CB_LocalMgr.Enabled = False
            .TB_SiteCity.Enabled = False
            .TB_SiteRegion.Enabled = False
            .TB_SiteCountry.Enabled = False
            .CB_Site.Enabled = False
            .TB_AddressLine1.Enabled = False
            .TB_AddressLine2.Enabled = False
            .TB_Floor.Enabled = False
            .TB_SeatNo.Enabled = False
            .TB_OnboardingTkt.Enabled = False
            .TB_Recruiter.Enabled = False
            .CB_SFC.Enabled = False
            .DT_SFCDate.Enabled = False
            .CB_IDCreated.Enabled = False
            .CB_Shift.Enabled = False
            .TB_MercuryID.Enabled = False
            .TB_EISID.Enabled = False
            .TB_OraclePRD.Enabled = False
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
