Public Class EmployeeInfo

    Private HasError As Boolean
    Private ErrorMessage As String
    Private LogoutAction As Boolean

    'Private ClickSave As Boolean
    'Public Revert As Boolean
    'Private SFCDateEmpty As Integer
    'Dim mR As New ManagerRepository
    'Private _managerValidate As Integer = 0
    'Public EmpValidate As Integer = 0


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        _empinfo = New EmployeeRepository()
        _empEditService = New EmpEditService()
        _emp = New Employee
        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "PROPERTIES"

    Private _empinfo As New EmployeeRepository
    Public Property EmpInfo() As EmployeeRepository
        Get
            Return _empinfo
        End Get
        Set(ByVal value As EmployeeRepository)
            _empinfo = value
        End Set
    End Property

    Private _empEditService As EmpEditService
    Public Property EmpEditService() As EmpEditService
        Get
            Return _empEditService
        End Get
        Set(ByVal value As EmpEditService)
            _empEditService = value
        End Set
    End Property

    Private _emp As Employee
    Public Property Emp() As Employee
        Get
            Return _emp
        End Get
        Set(ByVal value As Employee)
            _emp = value
        End Set
    End Property

#End Region


#Region "SUB ROUTINES"
    Private Sub LogoutEmployeeInfo()
        'ValidateClear()
        'ClearMgrValidate()

        Select Case UserAccount.UserType
            'Case 1
            Case 2
                Main.Dispose()
                Me.Dispose()
            Case 3
                Me.Dispose()
        End Select
        LogIn.Show()
    End Sub

    Private Sub CloseEmployeeInfo()
        'ClearFields()
        'ValidateClear()
        'ClearMgrValidate()
        Select Case UserAccount.UserType
            Case 2
                Main.Show()
                Me.Dispose()
            Case 3
                Application.Exit()
        End Select
        
    End Sub

    Public Sub EmployeeUserForm()
        UserAccount.IsEdit = True

        Cancel_Button.Hide()
        OracleIDTextBox.Enabled = False
        JobTitleTextBox.Enabled = False
        PositionTextBox.Enabled = False
        PhoneExtensionTextBox.Enabled = False
        OfficeEmailTextBox.Enabled = False
        TeamComboBox.Enabled = False
        LocalManagerComboBox.Enabled = False
        SiteComboBox.Enabled = False
        FloorComboBox.Enabled = False
        SeatNoTextBox.Enabled = False
        OnboardingTicketTextBox.Enabled = False
        RecruiterTextBox.Enabled = False
        SFCComboBox.Enabled = False
        SFCDatePicker.Enabled = False
        StartDatePicker.Enabled = False
        IDCreatedComboBox.Enabled = False
        ShiftComboBox.Enabled = False
        MercuryIDTextbox.Enabled = False
        EISIDTextbox.Enabled = False
        OraclePRDTextbox.Enabled = False
        SaveButton.Location = New Point(910, 626)
        RevertClearButton.Location = New Point(1036, 626)

    End Sub

    Public Sub ValidateEmployee()
        'EmpValidate = 0

        ValidateRequiredFields(OracleIDTextBox, OracleIDLabel, False)

        ValidateRequiredFields(LastNameTextBox, LastNameLabel, True)

        ValidateRequiredFields(FirstNameTextBox, FirstNameLabel, True)

        ValidateRequiredFields(MiddleNameTextBox, MiddleNameLabel, True)

        ValidateRequiredFields(GenderComboBox, GenderLabel, True)

        ValidateRequiredFields(BirthDatePicker, BirthDateLabel, True)

        ValidateRequiredFields(PersonalEmailTextBox, PersonalEmailLabel, True)

        ValidateRequiredFields(MobileNoTextBox, MobileNoLabel, False)

        ValidateRequiredFields(HomeAdd1TextBox, HomeAdd1Label, True)

        ValidateRequiredFields(HomeAdd2TextBox, HomeAdd2Label, True)

        ValidateRequiredFields(CityComboBox, CityLabel, True)

        ValidateRequiredFields(RegionComboBox, RegionLabel, True)

        ValidateRequiredFields(CountryComboBox, CountryLabel, True)

        ValidateRequiredFields(ZipCodeTextBox, ZipCodeLabel, False)

        If EmpEditService.ValidateEmail(PersonalEmailTextBox.Text) Then
            PersonalEmailLabel.ForeColor = Color.Black
        Else
            HasError = True
            ErrorMessage = MessageEmailError
            PersonalEmailLabel.ForeColor = Color.Red
        End If

        'If Not String.IsNullOrEmpty(PersonalEmailTextBox.Text) Then
        '    If EmpEditService.ValidateEmail(PersonalEmailTextBox.Text) = False Then
        '        HasError = True
        '        ErrorMessage = MessageEmailError
        '        'EmpValidate = 2
        '        PersonalEmailLabel.ForeColor = Color.Red
        '    Else
        '        PersonalEmailLabel.ForeColor = Color.Black
        '    End If
        'End If
    End Sub

    '### IDEA NI BENEDICT KABAHAR
    '### ValidateTextBox(TextBoxName, LabelName, True) True if string validation
    Public Sub ValidateRequiredFields(ByVal ObjectValue As Object, ByVal LabelName As Label, ByVal IsString As Boolean)

        'EmpValidate = 0
        If String.IsNullOrWhiteSpace(ObjectValue.Text) Then
            LabelName.ForeColor = Color.Red
            HasError = True
            ErrorMessage = MessageRequiredFields
            'EmpValidate = 1
        Else
            If IsString Then
                LabelName.ForeColor = Color.Black
            Else
                LabelName.ForeColor = Color.Blue
            End If
        End If

        'Return EmpValidate
    End Sub

    Private Sub ValidateClear()
        OracleIDLabel.ForeColor = Color.Black
        LastNameLabel.ForeColor = Color.Black
        FirstNameLabel.ForeColor = Color.Black
        MiddleNameLabel.ForeColor = Color.Black
        GenderLabel.ForeColor = Color.Black
        BirthDateLabel.ForeColor = Color.Black
        PersonalEmailLabel.ForeColor = Color.Black
        MobileNoLabel.ForeColor = Color.Blue
        HomeAdd1Label.ForeColor = Color.Black
        HomeAdd2Label.ForeColor = Color.Black
        CityLabel.ForeColor = Color.Black
        ZipCodeLabel.ForeColor = Color.Blue
        RegionLabel.ForeColor = Color.Black
        CountryLabel.ForeColor = Color.Black
    End Sub

    Private Sub GetFieldTextValues()

        With _emp
            .OracleID = Trim(OracleIDTextBox.Text)
            .Title = Trim(JobTitleTextBox.Text)
            .Position = Trim(PositionTextBox.Text)
            .LastName = Trim(LastNameTextBox.Text)
            .FirstName = Trim(FirstNameTextBox.Text)
            .MiddleName = Trim(MiddleNameTextBox.Text)
            .PersonalEmail = Trim(PersonalEmailTextBox.Text)

            If Not Trim(BirthDatePicker.Text) = String.Empty Then
                .Birthday = CType(BirthDatePicker.Value, Date)
            Else
                .Birthday = Nothing
            End If

            If Not MobileNoTextBox.Text = String.Empty Then
                .MobileNo = CType(Trim(MobileNoTextBox.Text), Long)
            Else
                .MobileNo = Nothing
            End If

            .HomeAddress1 = Trim(HomeAdd1TextBox.Text)
            .HomeAddress2 = Trim(HomeAdd2TextBox.Text)

            If Not ZipCodeTextBox.Text = String.Empty Then
                .ZipCode = Trim(ZipCodeTextBox.Text)
            Else
                .ZipCode = Nothing
            End If
            If Not PhoneExtensionTextBox.Text = String.Empty Then
                .PhoneExtension = Trim(PhoneExtensionTextBox.Text)
            Else
                .PhoneExtension = Nothing
            End If

            .LandlineNo = Trim(LandlineTextBox.Text)

            .OfficeEmail = Trim(OfficeEmailTextBox.Text)
            .Entity = Trim(EntityTextBox.Text)
            .Division = Trim(DivisionTextBox.Text)
            .Department = Trim(DepartmentTextBox.Text)
            .USManager = Trim(USManagerTextBox.Text)
            .OnboardingTicket = Trim(OnboardingTicketTextBox.Text)
            .Recruiter = Trim(RecruiterTextBox.Text)
            If Not Trim(StartDatePicker.Text) = String.Empty Then
                .StartDate = CType(StartDatePicker.Value, Date)
            Else
                .StartDate = Nothing
            End If
            .SFC = GetComboValue(SFCComboBox)
            If Not SFCDatePicker.Text = String.Empty Then
                .SFCDate = CType(SFCDatePicker.Value, Date)
            End If
            If SFCComboBox.SelectedItem = "No" Or IsNothing(SFCComboBox.SelectedItem) Then
                .SFCDate = Nothing
            End If

            .SeatNumber = Trim(SeatNoTextBox.Text)
            .LastAccessedBy = UserAccount.UserID

            .Shift = Trim(ShiftComboBox.Text)
            .PCName = Trim(PCNameTextbox.Text)
            .MercuryID = Trim(MercuryIDTextbox.Text)
            .EISID = Trim(EISIDTextbox.Text)
            .OraclePRDID = Trim(OraclePRDTextbox.Text)
            .InsightID = Trim(InsightIDTextbox.Text)
            .NCOGroup = Trim(NCOGrpIDTextbox.Text)
            .EGSPremID = Trim(EGSPREMIDTextbox.Text)
            .ElsevierID = Trim(ElsevierIDTextbox.Text)
            .GITHubID = Trim(GithubIDTextbox.Text)

            .Gender = GenderComboBox.Text
            .IDCreated = GetComboValue(IDCreatedComboBox)
            .Country = CountryComboBox.Text
            .CityName = CityComboBox.Text
            If CityComboBox.SelectedItem IsNot Nothing Then
                .CityID = CType(CityComboBox.SelectedItem, DropDownList).ListID
            End If
            .RegionName = RegionComboBox.Text
            If RegionComboBox.SelectedItem IsNot Nothing Then
                .RegionID = CType(RegionComboBox.SelectedItem, DropDownList).ListID
            End If
            .TeamName = TeamComboBox.Text
            If TeamComboBox.SelectedItem IsNot Nothing Then
                .TeamID = CType(TeamComboBox.SelectedItem, DropDownList).ListID
            End If
            If LocalManagerComboBox.SelectedItem IsNot Nothing Then
                .LocalManagerID = CType(LocalManagerComboBox.SelectedItem, DropDownList).ListID
            End If
            .SiteName = SiteComboBox.Text
            If SiteComboBox.SelectedItem IsNot Nothing Then
                .SiteID = CType(SiteComboBox.SelectedItem, Site).SiteID
            End If
            .Floor = FloorComboBox.Text
        End With

    End Sub

    Private Sub PopulateFields()

        With Me
            .OracleIDTextBox.Text = CType(_emp.OracleID, String)
            .JobTitleTextBox.Text = _emp.Title
            .PositionTextBox.Text = _emp.Position
            .LastNameTextBox.Text = _emp.LastName
            .FirstNameTextBox.Text = _emp.FirstName
            .MiddleNameTextBox.Text = _emp.MiddleName
            If _emp.Birthday.HasValue Then
                .BirthDatePicker.Value = CType(_emp.Birthday, Date)
                .ResetDatePicker(.BirthDatePicker)
            Else
                '.BirthDatePicker.MaxDate = DateTime.Today.AddYears(-18)
                .BirthDatePicker.MaxDate = DateTime.Now.AddYears(-18)
                '.BirthDatePicker.Format = DateTimePickerFormat.Short
                '.BirthDatePicker.Value = CType("01/01/1753", Date)
                .ClearDatePicker(.BirthDatePicker)
            End If
            .PersonalEmailTextBox.Text = _emp.PersonalEmail
            If _emp.MobileNo > 0 Then
                .MobileNoTextBox.Text = CType(_emp.MobileNo, String)
            Else
                .MobileNoTextBox.Text = String.Empty
            End If
            .LandlineTextBox.Text = _emp.LandlineNo
            .HomeAdd1TextBox.Text = _emp.HomeAddress1
            .HomeAdd2TextBox.Text = _emp.HomeAddress2
            If _emp.ZipCode > 0 Then
                .ZipCodeTextBox.Text = CType(_emp.ZipCode, String)
            Else
                .ZipCodeTextBox.Text = String.Empty
            End If
            If _emp.PhoneExtension > 0 Then
                .PhoneExtensionTextBox.Text = CType(_emp.PhoneExtension, String)
            Else
                .PhoneExtensionTextBox.Text = String.Empty
            End If
            .OfficeEmailTextBox.Text = _emp.OfficeEmail
            .EntityTextBox.Text = _emp.Entity
            .DivisionTextBox.Text = _emp.Division
            .DepartmentTextBox.Text = _emp.Department
            .USManagerTextBox.Text = _emp.USManager
            .OnboardingTicketTextBox.Text = _emp.OnboardingTicket
            .RecruiterTextBox.Text = _emp.Recruiter
            If _emp.StartDate.HasValue Then
                .StartDatePicker.Value = CType(_emp.StartDate, Date)
                .ResetDatePicker(.StartDatePicker)
            Else
                .ClearDatePicker(.StartDatePicker)
            End If

            .SFCComboBox.SelectedItem = _emp.SFC
            .SiteAdd1TextBox.Text = _emp.SiteAddress1
            .SiteAdd2TextBox.Text = _emp.SiteAddress2
            .SiteCityTextBox.Text = _emp.SiteCityName
            .SiteRegionTextBox.Text = _emp.SiteRegionName
            .SiteCountryTextBox.Text = _emp.SiteCountry

            .SeatNoTextBox.Text = _emp.SeatNumber
            .PCNameTextbox.Text = _emp.PCName
            .MercuryIDTextbox.Text = _emp.MercuryID
            .EISIDTextbox.Text = _emp.EISID
            .OraclePRDTextbox.Text = _emp.OraclePRDID
            .InsightIDTextbox.Text = _emp.InsightID
            .NCOGrpIDTextbox.Text = _emp.NCOGroup
            .EGSPREMIDTextbox.Text = _emp.EGSPremID
            .ElsevierIDTextbox.Text = _emp.ElsevierID
            .GithubIDTextbox.Text = _emp.GITHubID
            .GenderComboBox.Text = _emp.Gender
            .CountryComboBox.Text = _emp.Country
            .ShiftComboBox.Text = _emp.Shift

            .LocalManagerComboBox.Text = SetListName(.LocalManagerComboBox, _emp.LocalManagerID)

            Dim _site As New Site()
            _site = SetSiteDetails(.SiteComboBox, _emp.SiteID)
            If _site IsNot Nothing Then
                .SiteComboBox.Text = _site.SiteName
                .SiteCityTextBox.Text = _site.SiteCityName
                .SiteCountryTextBox.Text = _site.SiteCountry
                .SiteRegionTextBox.Text = _site.SiteRegionName
                .SiteAdd1TextBox.Text = _site.SiteAddress1
                .SiteAdd2TextBox.Text = _site.SiteAddress2

                If _site.SiteZipCode = 0 Then
                    .SiteZipCodeTextBox.Text = ""
                Else
                    .SiteZipCodeTextBox.Text = _site.SiteZipCode
                End If

            End If
            If Not _emp.Floor = String.Empty Then
                .FloorComboBox.Text = _emp.Floor.Trim()
            End If

            .TeamComboBox.Text = SetListName(.TeamComboBox, _emp.TeamID)
            If _emp.RegionID > 0 Then
                .RegionComboBox.Text = SetListName(.RegionComboBox, _emp.RegionID)
            End If
            If _emp.CityID > 0 Then
                .CityComboBox.Text = SetListName(.CityComboBox, _emp.CityID)
            End If

            If _emp.IDCreated = False Then
                .IDCreatedComboBox.SelectedItem = "No"
            Else
                .IDCreatedComboBox.SelectedItem = "Yes"
            End If

            If _emp.SFC = False Then
                .SFCComboBox.SelectedItem = "No"
                .ClearDatePicker(.SFCDatePicker)
            Else
                .SFCComboBox.SelectedItem = "Yes"
                .SFCDatePicker.Value = CType(_emp.SFCDate, Date)
                .ResetDatePicker(.SFCDatePicker)
            End If

            'If _emp.SFCDate.HasValue Then
            '    .SFCDatePicker.Value = CType(_emp.SFCDate, Date)
            '    .ResetDatePicker(.SFCDatePicker)
            'Else
            '    .ClearDatePicker(.SFCDatePicker)
            'End If
        End With

    End Sub

    Private Sub EnableDisableSFCDate()

        If SFCComboBox.Text = "No" Then
            ClearDatePicker(SFCDatePicker)
            SFCDatePicker.Enabled = False
            'SFCDateEmpty = 0
        ElseIf SFCComboBox.Text = "Yes" Then
            If Emp.SFC = False Then
                SFCDatePicker.Value = DateTime.Now
            Else
                ResetDatePicker(SFCDatePicker)
            End If
            SFCDatePicker.Enabled = True

        End If

    End Sub

    Private Sub PopulateList(ByRef cbox As ComboBox, ByVal spname As String)
        Dim _library As New LibraryRespository
        Dim _dropdown As New DropDownList()

        cbox.DataSource = New BindingSource(_library.GetListData(spname), Nothing)

        cbox.DisplayMember = "ListName"
        cbox.ValueMember = "ListID"

    End Sub

    Private Sub PopulateSiteList()
        Dim _library As New LibraryRespository
        Dim _dropdown As New DropDownList()

        SiteComboBox.DataSource = New BindingSource(_library.GetListData(), Nothing)
        SiteComboBox.DisplayMember = "SiteName"
        SiteComboBox.ValueMember = "SiteID"

    End Sub

    Private Sub PopulateCity(ByRef cbox As ComboBox, ByVal param As Integer)

        Dim _library As New LibraryRespository
        Dim _dropdown As New DropDownList()

        cbox.DataSource = New BindingSource(_library.GetListData(param), Nothing)

        cbox.DisplayMember = "ListName"
        cbox.ValueMember = "ListID"

    End Sub

    Private Sub PopulateShiftList()

        ShiftComboBox.Items.Clear()
        ShiftComboBox.Items.Add("8am - 5pm")
        ShiftComboBox.Items.Add("1pm - 10pm")
        ShiftComboBox.Items.Add("3pm - 12am")

    End Sub

    Private Function GetComboValue(ByRef cbox As ComboBox) As Boolean

        If CType(cbox, ComboBox).Text = "Yes" Then
            Return 1
        Else
            Return 0
        End If

    End Function

    Public Sub ResetDatePicker(ByVal dtPicker As Object)
        With dtPicker
            .Format = DateTimePickerFormat.Short
            '.Enabled = True
        End With
    End Sub

    Public Sub ClearDatePicker(ByVal dtPicker As Object)
        With dtPicker
            '.Value = "1/1/1753"
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = " "
        End With
    End Sub

    Private Sub ClearFields()

        For Each _control In Me.Controls

            If _control.GetType() = GetType(TextBox) Then
                CType(_control, TextBox).Clear()
            ElseIf _control.GetType() = GetType(MaskedTextBox) Then
                CType(_control, MaskedTextBox).Clear()
            ElseIf _control.GetType() = GetType(ComboBox) Then
                CType(_control, ComboBox).SelectedIndex = -1
            ElseIf _control.GetType() = GetType(DateTimePicker) Then
                'CType(_control, DateTimePicker).Value = "02/11/2018"
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
                            'CType(_item, DateTimePicker).Enabled = False
                        End If
                    Next
                Next
            End If

        Next

        OracleIDTextBox.Focus()

    End Sub

    Public Sub GetExistingData()
        _emp = _empEditService.SelectEmpFromList(UserAccount.SelectedOracleID)
        PopulateFields()
    End Sub

    Private Sub AddEmployeeForm()

        'BirthDatePicker.Value = Date.Today.AddYears(-18)
        'SFCDatePicker.Value = DateTime.Now
        'StartDatePicker.Value = DateTime.Now

        'RegionComboBox.Text = SetListName(RegionComboBox, 1)
        'BirthDatePicker.MaxDate = DateTime.Today.AddYears(-18)
        BirthDatePicker.MaxDate = DateTime.Now.AddYears(-18)

        'BirthDatePicker.Value = CType("01/01/1753", Date)

        SFCDatePicker.Enabled = False
        ClearDatePicker(BirthDatePicker)
        ClearDatePicker(StartDatePicker)
        ClearDatePicker(SFCDatePicker)

        OracleIDTextBox.Enabled = True
        RevertClearButton.Text = "Clear"
        OracleIDTextBox.Focus()
    End Sub


    Private Sub ValidateManager()
        ValidateRequiredFields(FirstNameTextBox, FirstNameLabel, True)
        ValidateRequiredFields(LastNameTextBox, LastNameLabel, True)
        ValidateRequiredFields(MiddleNameTextBox, MiddleNameLabel, True)
        ValidateRequiredFields(GenderComboBox, GenderLabel, True)
        ValidateRequiredFields(LocalManagerComboBox, LocalManagerLabel, True)
        ValidateRequiredFields(OnboardingTicketTextBox, OnboardingTicketLabel, True)

        If EmpEditService.ValidateEmail(OfficeEmailTextBox.Text) Then
            OfficeEmailLabel.ForeColor = Color.Black
        Else
            HasError = True
            ErrorMessage = MessageEmailError
            OfficeEmailLabel.ForeColor = Color.Red
        End If

        If EmpEditService.ValidateEmail(PersonalEmailTextBox.Text) Then
            PersonalEmailLabel.ForeColor = Color.Black
        Else
            HasError = True
            ErrorMessage = MessageEmailError
            PersonalEmailLabel.ForeColor = Color.Red
        End If

        If String.IsNullOrWhiteSpace(OracleIDTextBox.Text) Then
            OracleIDLabel.ForeColor = Color.Red()
            HasError = True
            ErrorMessage = MessageRequiredFields
        Else
            If Not UserAccount.IsEdit Then 'This will insert Oracle ID'
                Dim _EmpEditService = New EmpEditService()
                Dim _tempSelectedID = _EmpEditService.SelectEmpFromList(OracleIDTextBox.Text)
                If Not _tempSelectedID Is Nothing Then
                    OracleIDLabel.ForeColor = Color.Red()
                    HasError = True
                    ErrorMessage = MessageDuplicateOracleID
                Else
                    OracleIDLabel.ForeColor = Color.Blue()
                End If
            Else
                OracleIDLabel.ForeColor = Color.Blue()
            End If
        End If
    End Sub

    Public Sub ClearMgrValidate()
        OracleIDLabel.ForeColor = Color.Blue
        LastNameLabel.ForeColor = Color.Black
        FirstNameLabel.ForeColor = Color.Black
        MiddleNameLabel.ForeColor = Color.Black
        GenderLabel.ForeColor = Color.Black
        OfficeEmailLabel.ForeColor = Color.Black
        PersonalEmailLabel.ForeColor = Color.Black
        TeamLabel.ForeColor = Color.Black
        LocalManagerLabel.ForeColor = Color.Black
        OnboardingTicketLabel.ForeColor = Color.Black
    End Sub

    Public Sub CheckDupOracleID()
        OracleIDLabel.ForeColor = Color.Red()
    End Sub

#End Region

    Private Sub EmployeeInfo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Select Case UserAccount.UserType
        '    Case 2
        'Select Case MessageBox.Show("Are you sure?", "WARNING!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        '    Case vbYes
        '        Application.Exit()
        '    Case vbNo
        '        MsgBox("No")
        'End Select

        If Not LogoutAction Then
            CloseEmployeeInfo()
        End If

        '    Case 3
        'LogoutEmployeeInfo()
        'End Select
        'ClearFields()
        'ValidateClear()
        'ClearMgrValidate()
        'Main.Show()
        'Me.Close()
    End Sub


    Public Sub EmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogoutAction = False
        HasError = False
        ErrorMessage = ""
        PopulateList(LocalManagerComboBox, "[uspGetAllManager]")
        PopulateList(RegionComboBox, "[uspGetAllRegion]")
        PopulateList(TeamComboBox, "[uspGetTeamList]")
        PopulateSiteList()
        PopulateShiftList()
        ClearFields()

        Select Case UserAccount.UserType
            'Case 1
            Case 2
                If UserAccount.IsEdit = True Then
                    OracleIDTextBox.Enabled = False
                    GetExistingData()
                    EnableDisableSFCDate()
                Else
                    AddEmployeeForm()
                End If
            Case 3
                GetExistingData()
                EmployeeUserForm()
        End Select

    End Sub

    Private Sub LogoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutButton.Click
        LogoutAction = True
        LogoutEmployeeInfo()
        'ValidateClear()
        'ClearMgrValidate()
        'LogIn.Show()

        'Select Case UserAccount.UserType
        '    'Case 1
        '    Case 2
        '        Main.Dispose()
        '        Me.Close()
        '    Case 3
        '        Me.Close()
        'End Select
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim retvalue As Integer
        HasError = False
        ErrorMessage = ""
        'ClickSave = True   -- FOR FURTHER INVESTIGATION

        'GetFieldTextValues() -- MOVED AFTER ALL VALIDATIONS PASSED

        Select Case UserAccount.UserType
            Case 1
                ValidateManager()
                'EmpValidate = 1
            Case 2
                ValidateManager()
                'EmpValidate = 1
            Case 3
                ValidateEmployee()
                '_managerValidate = 1
        End Select


        'If ClickSave = True And SFCComboBox.Text = "Yes" Then
        '    ClickSave = False
        'If SFCComboBox.Text = "Yes" Then
        '    If String.IsNullOrWhiteSpace(SFCDatePicker.Text) Then
        '        SFCDateEmpty = 1
        '    Else
        '        SFCDateEmpty = 0
        '    End If
        'End If

        'If EmpInfo.EmpValidate = 0 Or _managerValidate = 0 And SFCDateEmpty = 0 Then
        'If EmpValidate = 0 Or _managerValidate = 0 Or HasError Then

        '    GetFieldTextValues()
        '    If UserAccount.IsEdit = True Then
        '        _empinfo.UpdateData(_emp)
        '        _empEditService.Employee = _emp
        '        PopulateFields()
        '        ValidateClear()
        '        ClearMgrValidate()
        '        Main.ReloadDataGridWithSort()
        '    Else
        '        _emp.UserType = 3


        '        retvalue = _empinfo.InsertData(_emp)        'fix to avoid error on duplicate Oracle ID's
        '        If retvalue = 0 Then
        '            ClearFields()
        '        ElseIf retvalue = -1 Then
        '            CheckDupOracleID()
        '        End If

        '        ValidateClear()
        '        ClearMgrValidate()
        '        Main.ReloadDataGridWithSort()
        '    End If

        'ElseIf _managerValidate = 3 Then
        '    MessageBox.Show(MessageDuplicateOracleID, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        'ElseIf EmpValidate = 2 Or _managerValidate = 2 Then

        '    MessageBox.Show(MessageEmailError, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        'ElseIf SFCDateEmpty = 1 Then
        '    MessageBox.Show(MessageSFCError, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'Else
        '    MessageBox.Show(MessageRequiredFields, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        'End If

        If HasError Then
            MessageBox.Show(ErrorMessage, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            GetFieldTextValues()
            If UserAccount.IsEdit = True Then
                _empinfo.UpdateData(_emp)
                _empEditService.Employee = _emp
                PopulateFields()
                ValidateClear()
                ClearMgrValidate()
                Main.ReloadDataGridWithSort()
            Else
                _emp.UserType = 3


                retvalue = _empinfo.InsertData(_emp)        'fix to avoid error on duplicate Oracle ID's
                If retvalue = 0 Then
                    ClearFields()
                ElseIf retvalue = -1 Then
                    CheckDupOracleID()
                End If

                ValidateClear()
                ClearMgrValidate()
                Main.ReloadDataGridWithSort()
            End If
        End If
    End Sub

    Private Sub RevertClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevertClearButton.Click
        If UserAccount.IsEdit = True Then
            ValidateClear()
            ClearMgrValidate()
            PopulateFields()
            OracleIDTextBox.Focus()
        Else
            ClearFields()
            OracleIDTextBox.Focus()
            ValidateClear()
            ClearMgrValidate()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'CloseEmployeeInfo()
        'ClearFields()
        'ValidateClear()
        'ClearMgrValidate()
        'Main.Show()
        Me.Close()
    End Sub

    Private Sub SFCComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFCComboBox.SelectedIndexChanged
        EnableDisableSFCDate()
    End Sub

    Private Sub BirthDatePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthDatePicker.ValueChanged
        ResetDatePicker(BirthDatePicker)
    End Sub

    Private Sub StartDatePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartDatePicker.ValueChanged
        ResetDatePicker(StartDatePicker)
    End Sub

    Private Sub SFCDatePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFCDatePicker.ValueChanged
        ResetDatePicker(SFCDatePicker)
    End Sub

    Private Sub SiteComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SiteComboBox.SelectedValueChanged
        Dim _site As New Site
        Dim _flr As String = "n/a"

        FloorComboBox.Items.Clear()
        _site = CType(SiteComboBox.SelectedItem, Site)

        If SiteComboBox.SelectedIndex > -1 Then
            With _site
                SiteAdd1TextBox.Text = .SiteAddress1
                SiteAdd2TextBox.Text = .SiteAddress2
                SiteCityTextBox.Text = .SiteCityName
                SiteZipCodeTextBox.Text = .SiteZipCode
                SiteRegionTextBox.Text = .SiteRegionName
                SiteCountryTextBox.Text = .SiteCountry
            End With
            If _site.SiteFloor IsNot Nothing Then
                _flr = CType(SiteComboBox.SelectedItem, Site).SiteFloor
            End If
        End If

        Dim _flrArr As String()

        _flrArr = _flr.Split(",")
        For i = 0 To _flrArr.Length - 1
            FloorComboBox.Items.Add(_flrArr(i).Trim())
        Next
    End Sub

    Private Sub RegionComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegionComboBox.SelectedValueChanged
        Dim _id As Integer

        If RegionComboBox.SelectedIndex > -1 Then
            _id = CType(RegionComboBox.SelectedItem, DropDownList).ListID
            PopulateCity(CityComboBox, _id)
        Else
            PopulateCity(CityComboBox, 1)
        End If
    End Sub

#Region "Commented Out in Employee Info"
    '_managerValidate = 0
    '        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
    '    FirstNameLabel.ForeColor = Color.Red()
    '    '_managerValidate = 1
    '    HasError = True
    '    ErrorMessage = MessageRequiredFields
    'Else
    '    FirstNameLabel.ForeColor = Color.Black
    'End If

    'If String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
    '    LastNameLabel.ForeColor = Color.Red()
    '    '_managerValidate = 1
    '    HasError = True
    '    ErrorMessage = MessageRequiredFields
    'Else
    '    LastNameLabel.ForeColor = Color.Black
    'End If

    'If String.IsNullOrWhiteSpace(MiddleNameTextBox.Text) Then
    '    MiddleNameLabel.ForeColor = Color.Red()
    '    '_managerValidate = 1
    '    HasError = True
    '    ErrorMessage = MessageRequiredFields
    'Else
    '    MiddleNameLabel.ForeColor = Color.Black
    'End If

    'If String.IsNullOrWhiteSpace(GenderComboBox.Text) Then
    '    GenderLabel.ForeColor = Color.Red()
    '    '_managerValidate = 1
    '    HasError = True
    '    ErrorMessage = MessageRequiredFields
    'Else
    '    GenderLabel.ForeColor = Color.Black
    'End If

    'If String.IsNullOrWhiteSpace(TeamComboBox.Text) Then
    '    TeamLabel.ForeColor = Color.Red()
    '    '_managerValidate = 1
    '    HasError = True
    '    ErrorMessage = MessageRequiredFields
    'Else
    '    TeamLabel.ForeColor = Color.Black
    'End If

    'If String.IsNullOrWhiteSpace(LocalManagerComboBox.Text) Then
    '    LocalManagerLabel.ForeColor = Color.Red()
    '    '_managerValidate = 1
    '    HasError = True
    '    ErrorMessage = MessageRequiredFields
    'Else
    '    LocalManagerLabel.ForeColor = Color.Black
    'End If

    'If String.IsNullOrWhiteSpace(OnboardingTicketTextBox.Text) Then
    '    OnboardingTicketLabel.ForeColor = Color.Red()
    '    '_managerValidate = 1
    '    HasError = True
    '    ErrorMessage = MessageRequiredFields
    'Else
    '    OnboardingTicketLabel.ForeColor = Color.Black
    'End If

    'If Not String.IsNullOrEmpty(OfficeEmailTextBox.Text) Then
    '    'If ValidateOfficeEmail(OfficeEmailTextBox.Text) = False Then
    '    If EmpEditService.ValidateEmail(OfficeEmailTextBox.Text) Then
    '        '_managerValidate = 2
    '        OfficeEmailLabel.ForeColor = Color.Black
    '    Else
    '        HasError = True
    '        ErrorMessage = MessageEmailError
    '        OfficeEmailLabel.ForeColor = Color.Red
    '    End If
    'Else
    '    OfficeEmailLabel.ForeColor = Color.Black
    'End If

    'If Not String.IsNullOrEmpty(PersonalEmailTextBox.Text) Then
    '    If ValidateOfficeEmail(PersonalEmailTextBox.Text) = False Then
    '        '_managerValidate = 2
    '        HasError = True
    '        ErrorMessage = MessageEmailError
    '        PersonalEmailLabel.ForeColor = Color.Red
    '    Else
    '        PersonalEmailLabel.ForeColor = Color.Black
    '    End If
    'Else
    '    PersonalEmailLabel.ForeColor = Color.Black
    'End If

    ' **** START : FIX INVALID ORACLE ID *** ' 
    'If String.IsNullOrWhiteSpace(OracleIDTextBox.Text) Then
    '    OracleIDLabel.ForeColor = Color.Red()
    '    '_managerValidate = 1
    '    HasError = True
    '    ErrorMessage = MessageRequiredFields
    'Else
    '    If Not UserAccount.IsEdit Then 'This will insert Oracle ID'
    '        Dim _EmpEditService = New EmpEditService()
    '        Dim _tempSelectedID = _EmpEditService.SelectEmpFromList(OracleIDTextBox.Text)
    '        If Not _tempSelectedID Is Nothing Then
    '            OracleIDLabel.ForeColor = Color.Red()
    '            '_managerValidate = 3
    '            HasError = True
    '            ErrorMessage = MessageDuplicateOracleID
    '        Else
    '            OracleIDLabel.ForeColor = Color.Blue()
    '        End If
    '    Else
    '        OracleIDLabel.ForeColor = Color.Blue()
    '    End If
    'End If
    ' **** END  : FIX INVALID ORACLE ID *** ' 

#End Region

    'Public Function ValidateOfficeEmail(ByVal EmailAddress) As Boolean
    '    Try
    '        Dim vEmailAddress As New System.Net.Mail.MailAddress(EmailAddress)
    '    Catch ex As Exception
    '        Return False
    '    End Try
    '    Return True
    'End Function



    '*************** masked textbox handling **************
    Private Sub OracleIDTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OracleIDTextBox.KeyDown
        If e.KeyCode = Keys.Space Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub MobileNoTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MobileNoTextBox.KeyDown
        If e.KeyCode = Keys.Space Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub PhoneExtensionTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PhoneExtensionTextBox.KeyDown
        If e.KeyCode = Keys.Space Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ZipCodeTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ZipCodeTextBox.KeyDown
        If e.KeyCode = Keys.Space Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub OracleIDTextBox_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OracleIDTextBox.MouseDown
        If OracleIDTextBox.Text = Nothing Then
            OracleIDTextBox.Select(0, 0)
        End If
    End Sub

    Private Sub MobileNoTextBox_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MobileNoTextBox.MouseDown
        If MobileNoTextBox.Text = Nothing Then
            MobileNoTextBox.Select(0, 0)
        End If
    End Sub

    Private Sub ZipCodeTextBox_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ZipCodeTextBox.MouseDown
        If ZipCodeTextBox.Text = Nothing Then
            ZipCodeTextBox.Select(0, 0)
        End If
    End Sub

    Private Sub PhoneExtensionTextBox_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PhoneExtensionTextBox.MouseDown
        If PhoneExtensionTextBox.Text = Nothing Then
            PhoneExtensionTextBox.Select(0, 0)
        End If
    End Sub
End Class
