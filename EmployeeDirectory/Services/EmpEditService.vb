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
            .TB_Position.Text = Employee.Position               ' Add New Field
            .TB_LastName.Text = Employee.LastName
            .TB_FirstName.Text = Employee.FirstName
            .TB_MiddleName.Text = Employee.MiddleName
            .DT_Birth.Value = CType(Employee.Birthday, String)  ' Add New Field
            .TB_PersonalEmail.Text = Employee.PersonalEmail     ' Change Field Name
            .TB_MobileNo.Text = CType(Employee.MobileNo, String)
            .TB_Landline.Text = Employee.PhoneExtension
            .TB_HomeAddLine1.Text = Employee.HomeAddress1
            .TB_HomeAddLine2.Text = Employee.HomeAddress2
            .MB_Zipcode.Text = CType(Employee.ZipCode, String)  ' Add New Field
            .MB_PhoneExtension.Text = CType(Employee.PhoneExtension, String)   ' Add New Field
            .TB_OfficeEmail.Text = Employee.OfficeEmail         ' Add New Field
            .TB_Entity.Text = Employee.Entity                   ' Add New Field
            .TB_Division.Text = Employee.Division
            .TB_Department.Text = Employee.Department
            .TB_USMgr.Text = Employee.USManager
            .TB_OnboardingTkt.Text = Employee.OnboardingTicket
            .TB_Recruiter.Text = Employee.Recruiter

            '.TB_StartDate.Text = IIf(Employee.StartDate.HasValue, CType(Employee.StartDate.Value, String), String.Empty)
            '.TB_SFCDate.Text = CType(Employee.SFCDate, String)
            .TB_AddressLine1.Text = Employee.SiteAddress1
            .TB_AddressLine2.Text = Employee.SiteAddress2
            .TB_SiteCity.Text = Employee.SiteCityName           ' Add New Field
            .TB_SiteRegion.Text = Employee.SiteRegionName       ' Add New Field
            .TB_SiteCountry.Text = Employee.SiteCountry         ' Add New Field
            .TB_Floor.Text = Employee.Floor
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


            If Employee.LocalManagerID = 2 Then
                .CB_LocalMgr.SelectedItem = "Rebazar Borromeo"
            End If
            If Employee.SiteID = 1 Then
                .CB_Site.Text = "Alorica Center"
                .TB_AddressLine1.Text = "MJ Corporate Plaza, 2310 Pasong Tamo Extension, "
                .TB_AddressLine2.Text = "Brgy Magallanes, Makati City 1231"
            End If
            If Employee.TeamID = 4 Then
                .CB_Team.Text = "BASD"
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


            If Employee.Gender = "M" Then
                .CB_Gender.SelectedItem = "Male"
            Else
                .CB_Gender.SelectedItem = "Female"
            End If



        End With
    End Sub
End Class
