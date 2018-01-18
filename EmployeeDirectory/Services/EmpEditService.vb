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

    Public Function SelectEmpFromList(ByVal OracleID As Integer) As Employee

        Return _EmployeeRepository.GetData(New Employee() With {.OracleID = OracleID})

    End Function

    Public Sub PopulateFields(ByVal owner As EmployeeInfo)

        With owner
            .TB_OracleID.Text = Employee.OracleID
            .TB_LastName.Text = Employee.LastName
            .TB_FirstName.Text = Employee.FirstName
            .TB_FirstName.Text = Employee.FirstName
            .TB_Title.Text = Employee.Title
            .TB_MiddleIn.Text = Employee.MiddleName
            .CB_Gender.Text = Employee.Gender
            .TB_EmailAddress.Text = Employee.EmailAddress
            .TB_MobileNo.Text = Employee.MobileNo
            .TB_HomeAddLine1.Text = Employee.HomeAddress1
            .TB_PhoneExt.Text = Employee.PhoneExtension
            .TB_HomeAddLine2.Text = Employee.HomeAddress2
            '.TB_Team.Text = Employee.TeamID
            '.CB_LocalMgr.Text = Employee.LocalManagerID
            .TB_USMgr.Text = Employee.USManager
            '.CB_Site.Text = Employee.SiteID
            .CB_Site.SelectedItem = Employee.SiteID
            .TB_Floor.Text = Employee.Floor
            .TB_SeatNo.Text = Employee.SeatNumber
            .TB_OnboardingTkt.Text = Employee.OnboardingTicket
            .TB_StartDate.Text = Employee.StartDate
            .CB_SFC.Text = Employee.SFC
            .TB_SFCDate.Text = Employee.SFCDate
            .TB_Recruiter.Text = Employee.Recruiter
            '.CB_IDCreated.Text = Employee.IDCreated
            .TB_Division.Text = Employee.Division
            .TB_Department.Text = Employee.Department
            .TB_Entity.Text = Employee.Entity
            .TB_Shift.Text = Employee.Shift
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

        End With
    End Sub
End Class
