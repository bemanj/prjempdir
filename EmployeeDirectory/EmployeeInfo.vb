Public Class EmployeeInfo

    Private _isEdit As Boolean
    Public Property IsEdit() As Boolean
        Get
            Return _isEdit
        End Get
        Set(ByVal value As Boolean)
            _isEdit = value
        End Set
    End Property

    ' ***** START : VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
    Private _IsMgrError As Boolean
    Public Property IsMgrError() As Boolean
        Get
            Return _IsMgrError
        End Get
        Set(ByVal value As Boolean)
            _IsMgrError = value
        End Set
    End Property

    Private _IsOffEmailError As Boolean
    Public Property IsOffEmailError() As Boolean
        Get
            Return _IsOffEmailError
        End Get
        Set(ByVal value As Boolean)
            _IsOffEmailError = value
        End Set
    End Property
    ' ***** END : VALIDATION AND REQUIRED FIELDS FOR MANAGER *****

    Private _empinfo As New EmployeeRepository
    Public Property EmpInfo() As EmployeeRepository
        Get
            Return _empinfo
        End Get
        Set(ByVal value As EmployeeRepository)
            _empinfo = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        _empinfo = New EmployeeRepository()

        _EmpEditService = New EmpEditService()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub EmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '''' **** LMRS: Move Code from Constructor **** ''''
        '*** START OF CHANGE - BK
        '*** B KABAHAR - SPRINT 2
        If _isEdit = False Then

            ClearDatePicker(DT_Birth)
            ClearDatePicker(DT_SFCDate)
            ClearDatePicker(DT_StartDate)
            DT_SFCDate.Enabled = False
        End If
        '*** END - B KABAHAR SPRINT 2

        '*** B KABAHAR - 1/26
        '*** BK START OF CHANGE
        If CurrentUserType = 3 Then
            _EmpEditService.ProtectFields(Me)
        End If
        '*** BK END OF CHANGE
        '''' **** LMRS END: Move Code from Constructor **** ''''


        'disabled fields
        'If LogIn.Username.Text = "user" And LogIn.UsernamePassword.Text = "user" Then
        '    DT_StartDate.Enabled = False
        '    TB_OnboardingTkt.Enabled = False
        '    TB_SeatNo.Enabled = False
        '    TB_Floor.Enabled = False
        '    ' ComboBox3.Enabled = False
        '    TB_USMgr.Enabled = False
        '    CB_LocalMgr.Enabled = False
        '    CB_Team.Enabled = False
        '    TB_Recruiter.Enabled = False
        '    DT_SFCDate.Enabled = False
        '    CB_SFC.Enabled = False
        '    Btn_Cancel.Hide()
        'End If

        'TB_AddressLine1.Enabled = False
        'TB_AddressLine2.Enabled = False

        'If _isEdit Then
        '    _EmpEditService.PopulateFields(Me)
        '    TB_OracleID.Enabled = False
        'Else
        '    PopulateList(CB_City, "[uspGetAllCity]")
        '    PopulateList(CB_Region, "[uspGetAllRegion]")
        '    PopulateList(CB_Team, "[uspGetTeamList]")
        '    PopulateList(CB_LocalMgr, "[uspGetAllManager]")
        '    PopulateList(CB_Site, "[uspGetSiteList]")
        '    PopulateShiftList()
        'End If

        TB_AddressLine1.Enabled = False
        TB_AddressLine2.Enabled = False

        PopulateList(CB_LocalMgr, "[uspGetAllManager]")
        'PopulateList(CB_Site, "[uspGetSiteList]")
        PopulateList(CB_City, "[uspGetAllCity]")
        PopulateList(CB_Region, "[uspGetAllRegion]")
        PopulateList(CB_Team, "[uspGetTeamList]")
        PopulateSiteList()
        PopulateShiftList()

        ClearFields()

        If _isEdit Then
            _EmpEditService.PopulateFields(Me)
            ResetDatePicker(DT_Birth)               '2018-01-29 6PM PUSH
            ResetDatePicker(DT_SFCDate)             '2018-01-29 6PM PUSH
            ResetDatePicker(DT_StartDate)           '2018-01-29 6PM PUSH
        End If



    End Sub

    'Private _isEdit As Boolean
    'Public Property IsEdit() As Boolean
    '    Get
    '        Return _isEdit
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _isEdit = value
    '    End Set
    'End Property

    Private _EmpEditService As EmpEditService
    Public Property EmpEditService() As EmpEditService
        Get
            Return _EmpEditService
        End Get
        Set(ByVal value As EmpEditService)
            _EmpEditService = value
        End Set
    End Property



    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
    '    Me.Close()
    '    Main.Show()
    'End Sub

    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Me.Close()
    '    Main.Main_Load(e, e)
    '    Main.Show()

    'End Sub

    Private Sub Btn_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Logout.Click
        'Me.Hide() 
        '*********Change Me.Hide() to Me.Close() to fix the logout from manager to user vice versa since
        '*********It was loading the form of the initial login since it was only hidden.

        Me.Close()
        LogIn.Show()
        LogIn.LogIn_Load(e, e)
        LogIn.Username.Clear()
        LogIn.UsernamePassword.Clear()

    End Sub


    Private Sub Btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Save.Click

        '***** START: VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
        IsMgrError = False
        IsOffEmailError = False
        ' ***** END : VALIDATION AND REQUIRED FIELDS FOR MANAGER *****

        Dim _emp As New Employee

        With _emp
            'Temporary
            'If CB_Team.Text = "BASD" Then
            '    .TeamID = 4
            'End If
            'If CB_Site.Text = "Alorica Center" Then
            '    .SiteID = 1
            'End If
            'If CB_LocalMgr.Text = "Rebazar Borromeo" Then
            '    .LocalManagerID = 2
            'End If
            '.UserType 
            'If LogIn.Username.Text = "user" Then
            '    .UserType = 0
            'ElseIf LogIn.Username.Text = "manager" Then
            '    .UserType = 1
            'ElseIf LogIn.Username.Text = "admin" Then
            '    .UserType = 2
            'Else
            '    .UserType = 3
            'End If

            'TEXTBOX

            '***** START: VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
            If Not TB_OracleID.Text = String.Empty Then
                .OracleID = TB_OracleID.Text
            End If
            '.OracleID = TB_OracleID.Text
            ' **** END  : VALIDATION AND REQUIRED FIELDS FOR MANAGER *****

            .Title = TB_Title.Text
            .Position = TB_Position.Text
            .LastName = TB_LastName.Text
            .FirstName = TB_FirstName.Text
            .MiddleName = TB_MiddleName.Text
            If Not DT_Birth.Text = String.Empty Then
                .Birthday = CType(DT_Birth.Value, Date)

            End If
            .PersonalEmail = TB_PersonalEmail.Text
            If Not TB_MobileNo.Text = String.Empty Then
                .MobileNo = CType(TB_MobileNo.Text, Long)
            End If
            If Not TB_Landline.Text = String.Empty Then
                .LandlineNo = TB_Landline.Text
            End If
            .HomeAddress1 = TB_HomeAddLine1.Text
            .HomeAddress2 = TB_HomeAddLine2.Text
            If Not MB_Zipcode.Text = String.Empty Then
                .ZipCode = MB_Zipcode.Text
            End If
            If Not MB_PhoneExtension.Text = String.Empty Then
                .PhoneExtension = MB_PhoneExtension.Text
            End If

            .OfficeEmail = TB_OfficeEmail.Text
            .Entity = TB_Entity.Text
            .Division = TB_Division.Text
            .Department = TB_Department.Text
            .USManager = TB_USMgr.Text
            .OnboardingTicket = TB_OnboardingTkt.Text
            .Recruiter = TB_Recruiter.Text
            If Not DT_StartDate.Text = String.Empty Then
                .StartDate = CType(DT_StartDate.Value, Date)
            End If
            .SFC = GetComboValue(CB_SFC)
            If Not DT_SFCDate.Text = String.Empty Then
                .SFCDate = CType(DT_SFCDate.Value, Date)
            End If

            .SeatNumber = TB_SeatNo.Text

            .Shift = CB_Shift.Text
            .PCName = TB_PCName.Text
            .MercuryID = TB_MercuryID.Text
            .EISID = TB_EISID.Text
            .OraclePRDID = TB_OraclePRD.Text
            .InsightID = TB_InsightID.Text
            .NCOGroup = TB_NCOGrpID.Text
            .EGSPremID = TB_EGSPREMID.Text
            .ElsevierID = TB_ElsevierID.Text
            .GITHubID = TB_GithubID.Text
            '.Mgr_Last_Name = CB_LocalMgr.Text

            'COMBOBOX
            .Shift = CB_Shift.Text
            .Gender = CB_Gender.Text
            .IDCreated = GetComboValue(CB_IDCreated)
            '.LocalManagerID = CB_Site.Text
            '.SiteID = CB_Site.Text
            '.IDCreated = GetComboValue(CB_IDCreated)
            .Country = CB_Country.Text
            '*** SOF ADD DROPDPWN VALUES TO SAVE
            .CityName = CB_City.Text
            If CB_City.SelectedItem IsNot Nothing Then
                .CityID = CType(CB_City.SelectedItem, DropDownList).ListID
            End If
            .RegionName = CB_Region.Text
            If CB_Region.SelectedItem IsNot Nothing Then
                .RegionID = CType(CB_Region.SelectedItem, DropDownList).ListID
            End If
            .TeamName = CB_Team.Text
            If CB_Team.SelectedItem IsNot Nothing Then
                .TeamID = CType(CB_Team.SelectedItem, DropDownList).ListID
            End If
            If CB_LocalMgr.SelectedItem IsNot Nothing Then
                .LocalManagerID = CType(CB_LocalMgr.SelectedItem, DropDownList).ListID
            End If
            .SiteName = CB_Site.Text
            If CB_Site.SelectedItem IsNot Nothing Then
                .SiteID = CType(CB_Site.SelectedItem, Site).SiteID
            End If

            .Floor = TB_Floor.Text

        End With

        EmpInfo.Validate()

        If EmpInfo.EmpValidate = 0 Then
            If Me.IsEdit = True Then
                _empinfo.UpdateData(_emp)
                _EmpEditService.Employee = _emp
                _EmpEditService.PopulateFields(Me)
                EmpInfo.ValidateClear()
            Else
                '*** SET DEFAULT VALUES DURING ADD ***'
                _emp.UserType = 3
                '_emp.Status =
                '_emp.LastLogin =
                '_emp.ExpirationDate =
                '_emp.LastAccessedBy =
                _empinfo.InsertData(_emp)
                ClearFields()
                EmpInfo.ValidateClear()
            End If
        ElseIf EmpInfo.EmpValidate = 2 Then
            Lbl_EAdd.ForeColor = Color.Red
            MessageBox.Show("Email is not valid, Please check your email address.", "EMAIL INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'EmpInfo.EmpValidate = 0
        Else
            MessageBox.Show("Please fill up required fields", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'EmpInfo.EmpValidate = 0
        End If
    End Sub

    Public Function GetComboValue(ByRef cbox As ComboBox) As Boolean

        If CType(cbox, ComboBox).Text = "Yes" Then
            Return 1
        Else
            Return 0
        End If

    End Function


    Private Sub Btn_RevertClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RevertClear.Click
        ' ***** START : VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
        BlackLabel()
        ' ***** END   : VALIDATION AND REQUIRED FIELDS FOR MANAGER *****
        If _isEdit Then
            EmpInfo.ValidateClear()
            _EmpEditService.PopulateFields(Me)
            TB_OracleID.Focus()
        Else
            ClearFields()
            TB_OracleID.Focus()
            EmpInfo.ValidateClear()
        End If

    End Sub

    'Rojohn- Commented out this codes since it is redundant to the Logout button
    '  Private Sub EmployeeInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    Me.Hide()
    '   ClearFields()
    'Main.Main_Load(e, e)
    'Main.Show()
    ' End Sub


    Private Sub Btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click
        Me.Close()
        ClearFields()
        'Main.Main_Load(e, e)
        Main.Show()

    End Sub

    Private Sub ClearFields()
        '*** B KABAHAR SPRINT 2 CHANGE
        ' ADDED DATEPICKER IN THE LOOP
        For Each _control In Me.Controls

            If _control.GetType() = GetType(TextBox) Then
                CType(_control, TextBox).Clear()
            ElseIf _control.GetType() = GetType(MaskedTextBox) Then
                CType(_control, MaskedTextBox).Clear()
            ElseIf _control.GetType() = GetType(ComboBox) Then
                CType(_control, ComboBox).SelectedIndex = -1
            ElseIf _control.GetType() = GetType(DateTimePicker) Then
                CType(_control, DateTimePicker).Format = DateTimePickerFormat.Custom
                CType(_control, DateTimePicker).CustomFormat = " "
            End If

            If _control.GetType() = GetType(TabControl) Then
                For Each _TabPage As TabPage In CType(_control, TabControl).TabPages
                    For Each _item In _TabPage.Controls
                        If _item.GetType() = GetType(TextBox) Then
                            CType(_item, TextBox).Clear()
                        ElseIf _item.GetType() = GetType(MaskedTextBox) Then
                            CType(_item, MaskedTextBox).Clear()
                        ElseIf _item.GetType() = GetType(ComboBox) Then
                            CType(_item, ComboBox).SelectedIndex = -1
                        ElseIf _item.GetType() = GetType(DateTimePicker) Then
                            CType(_item, DateTimePicker).Format = DateTimePickerFormat.Custom
                            CType(_item, DateTimePicker).CustomFormat = " "
                        End If
                    Next
                Next
            End If

        Next

        '*** START OF CHANGE - BK
        '*** B KABAHAR - SPRINT 2
        TB_OracleID.Focus()
        '*** END - B KABAHAR SPRINT 2

    End Sub
    '*** START OF CHANGE - BK
    '*** B KABAHAR - SPRINT 2
    Private Sub CB_SFC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SFC.SelectedIndexChanged
        If CB_SFC.Text = "No" Then
            ClearDatePicker(DT_SFCDate)
            DT_SFCDate.Enabled = False
        ElseIf CB_SFC.Text = "Yes" Then
            ResetDatePicker(DT_SFCDate)
        End If

    End Sub

    Private Sub DT_Birth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_Birth.ValueChanged

        ResetDatePicker(DT_Birth)

    End Sub

    Private Sub TB_StartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_StartDate.ValueChanged

        ResetDatePicker(DT_StartDate)

    End Sub

    Private Sub ResetDatePicker(ByVal dtPicker As Object)
        With dtPicker
            .Format = DateTimePickerFormat.Short
            .Enabled = True
        End With
    End Sub

    Private Sub ClearDatePicker(ByVal dtPicker As Object)
        With dtPicker
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = " "
        End With
    End Sub

    Public Sub PopulateList(ByRef cbox As ComboBox, ByVal spname As String)
        Dim _library As New LibraryRespository
        Dim _dropdown As New DropDownList()

        cbox.DataSource = New BindingSource(_library.GetListData(spname), Nothing)
        cbox.DisplayMember = "ListName"
        cbox.ValueMember = "ListID"
    End Sub

    Public Sub PopulateSiteList()
        Dim _library As New LibraryRespository
        Dim _dropdown As New DropDownList()

        CB_Site.DataSource = New BindingSource(_library.GetListData(), Nothing)
        CB_Site.DisplayMember = "SiteName"
        CB_Site.ValueMember = "SiteID"

    End Sub

    Public Sub PopulateShiftList()
        CB_Shift.Items.Add("8am - 5pm")
        CB_Shift.Items.Add("1pm - 10pm")
        CB_Shift.Items.Add("4pm - 1am")
    End Sub

    Private Sub CB_Site_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Site.SelectedValueChanged

        Dim _site As New Site
        Dim _flr As String = "n/a"

        TB_Floor.Items.Clear()
        _site = CType(CB_Site.SelectedItem, Site)

        If CB_Site.SelectedIndex > -1 Then
            With _site
                TB_AddressLine1.Text = .SiteAddress1
                TB_AddressLine2.Text = .SiteAddress2
                TB_SiteCity.Text = .SiteCityName
                TB_SiteZipcode.Text = .SiteZipCode
                TB_SiteRegion.Text = .SiteRegionName
                TB_SiteCountry.Text = .SiteCountry
            End With
            If _site.SiteFloor IsNot Nothing Then
                _flr = CType(CB_Site.SelectedItem, Site).SiteFloor
            End If
        End If

        Dim _flrArr As String()

        _flrArr = _flr.Split(",")
        For i = 0 To _flrArr.Length - 1
            TB_Floor.Items.Add(_flrArr(i).Trim())
        Next
    End Sub

    'End Sub

    ' **** START : VALIDATE AND REQUIRED FIELDS FOR MANAGER ***** '
    Public Sub BlackLabel()
        OracleID_Label.ForeColor = Color.Black
        Team_Label.ForeColor = Color.Black
        LocMgr_Label.ForeColor = Color.Black
        OnbTkt_Label.ForeColor = Color.Black
        OffEmail_Label.ForeColor = Color.Black
    End Sub
    ' ***** END : VALIDATE AND REQUIRED FIELDS FOR MANAGER/USER ***** '

End Class