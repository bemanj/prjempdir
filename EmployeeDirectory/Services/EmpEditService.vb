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
            .TB_OracleID.Text = Employee.OracleID
            .TB_LastName.Text = Employee.LastName
            .TB_FirstName.Text = Employee.FirstName
            .TB_FirstName.Text = Employee.FirstName
            .TB_Title.Text = Employee.Title
            .TB_MiddleName.Text = Employee.MiddleName
            .TB_EmailAddress.Text = Employee.PersonalEmail
            .TB_MobileNo.Text = Employee.MobileNo
            .TB_HomeAddLine1.Text = Employee.HomeAddress1
            .TB_Landline.Text = Employee.PhoneExtension
            .TB_HomeAddLine2.Text = Employee.HomeAddress2
            .CB_Team.Text = Employee.TeamName
            .CB_LocalMgr.Text = Employee.Mgr_Last_Name.Trim & ", " & Employee.Mgr_First_Name
            .TB_USMgr.Text = Employee.USManager
            .CB_Site.Text = Employee.SiteName
            .CB_Site.SelectedItem = Employee.SiteID
            .TB_Floor.Text = Employee.Floor
            .TB_SeatNo.Text = Employee.SeatNumber
            .TB_OnboardingTkt.Text = Employee.OnboardingTicket
            .TB_StartDate.Text = Employee.StartDate
            .CB_SFC.Text = Employee.SFC
            .TB_SFCDate.Text = Employee.SFCDate
            .TB_Recruiter.Text = Employee.Recruiter
            .TB_Division.Text = Employee.Division
            .TB_Department.Text = Employee.Department
            .TB_Entity.Text = Employee.Entity
            .CB_WorkSched.Text = Employee.Shift
            .TB_AddressLine1.Text = Employee.SiteAddress1
            .TB_AddressLine2.Text = Employee.SiteAddress2
            .TB_OraclePRD.Text = Employee.OraclePRDID
            .TB_MercuryID.Text = Employee.MercuryID
            .TB_NCOGrpID.Text = Employee.NCOGroup
            .TB_EISID.Text = Employee.EISID
            .TB_PCName.Text = Employee.PCName
            .TB_InsightID.Text = Employee.InsightID
            .TB_EGSPREMID.Text = Employee.EGSPremID
            .TB_ElsevierID.Text = Employee.ElsevierID
            .TB_GithubID.Text = Employee.GITHubID
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
