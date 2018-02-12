Public Class EmployeeInfo

    Private ClickSave As Boolean
    'Public Revert As Boolean
    Dim SFCDateEmpty As Integer
    Private BirthChange As Boolean = False
    Dim mR As New ManagerRepository

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        _empinfo = New EmployeeRepository()

        _EmpEditService = New EmpEditService()

        _emp = New Employee

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "PROPERTIES"
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

    Private _empinfo As New EmployeeRepository
    Public Property EmpInfo() As EmployeeRepository
        Get
            Return _empinfo
        End Get
        Set(ByVal value As EmployeeRepository)
            _empinfo = value
        End Set
    End Property

    Private _EmpEditService As EmpEditService
    Public Property EmpEditService() As EmpEditService
        Get
            Return _EmpEditService
        End Get
        Set(ByVal value As EmpEditService)
            _EmpEditService = value
        End Set
    End Property

    Private _emp As Employee
    Public Property emp() As Employee
        Get
            Return _emp
        End Get
        Set(ByVal value As Employee)
            _emp = value
        End Set
    End Property

#End Region
   
    

#Region "SUB ROUTINES"

    
    Public Sub EmployeeUserForm()
        '_EmpEditService.ProtectFields(Me)
        '_emp = _EmpEditService.SelectEmpFromList(CLng(UserAccount.UserID))        
        'EmpEditService.Employee = _emp

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
    End Sub

    Private Sub GetFieldTextValues()

        With _emp
            .OracleID = OracleIDTextBox.Text
            .Title = JobTitleTextBox.Text
            .Position = PositionTextBox.Text
            .LastName = LastNameTextBox.Text
            .FirstName = FirstNameTextBox.Text
            .MiddleName = MiddleNameTextBox.Text
            .PersonalEmail = PersonalEmailTextBox.Text
            If BirthChange = True Then
                .Birthday = CType(BirthDatePicker.Value, Date)
            Else
                .Birthday = Nothing
            End If

            If Not MobileNoTextBox.Text = String.Empty Then
                .MobileNo = CType(MobileNoTextBox.Text, Long)
            Else
                .MobileNo = Nothing
            End If

            .HomeAddress1 = HomeAdd1TextBox.Text
            .HomeAddress2 = HomeAdd2TextBox.Text

            If Not ZipCodeTextBox.Text = String.Empty Then
                .ZipCode = ZipCodeTextBox.Text
            Else
                .ZipCode = Nothing
            End If
            If Not PhoneExtensionTextBox.Text = String.Empty Then
                .PhoneExtension = PhoneExtensionTextBox.Text
            Else
                .PhoneExtension = Nothing
            End If

            If Not LandlineTextBox.Text = String.Empty Then
                .LandlineNo = LandlineTextBox.Text
            End If

            .OfficeEmail = OfficeEmailTextBox.Text
            .Entity = EntityTextBox.Text
            .Division = DivisionTextBox.Text
            .Department = DepartmentTextBox.Text
            .USManager = USManagerTextBox.Text
            .OnboardingTicket = OnboardingTicketTextBox.Text
            .Recruiter = RecruiterTextBox.Text
            If Not StartDatePicker.Text = String.Empty Then
                .StartDate = CType(StartDatePicker.Value, Date)
            End If
            .SFC = GetComboValue(SFCComboBox)
            If Not SFCDatePicker.Text = String.Empty Then
                .SFCDate = CType(SFCDatePicker.Value, Date)
            End If
            If SFCComboBox.SelectedItem = "No" Or IsNothing(SFCComboBox.SelectedItem) Then
                .SFCDate = Nothing
            End If

            .SeatNumber = SeatNoTextBox.Text
            .LastAccessedBy = UserAccount.UserID

            .Shift = ShiftComboBox.Text
            .PCName = PCNameTextbox.Text
            .MercuryID = MercuryIDTextbox.Text
            .EISID = EISIDTextbox.Text
            .OraclePRDID = OraclePRDTextbox.Text
            .InsightID = InsightIDTextbox.Text
            .NCOGroup = NCOGrpIDTextbox.Text
            .EGSPremID = EGSPREMIDTextbox.Text
            .ElsevierID = ElsevierIDTextbox.Text
            .GITHubID = GithubIDTextbox.Text

            .Shift = ShiftComboBox.Text
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
                .ClearDatePicker(.BirthDatePicker)
            End If
            .PersonalEmailTextBox.Text = _emp.PersonalEmail
            If _emp.MobileNo > 0 Then
                .MobileNoTextBox.Text = CType(_emp.MobileNo, String)
            End If
            .LandlineTextBox.Text = _emp.LandlineNo
            .HomeAdd1TextBox.Text = _emp.HomeAddress1
            .HomeAdd2TextBox.Text = _emp.HomeAddress2
            If _emp.ZipCode > 0 Then
                .ZipCodeTextBox.Text = CType(_emp.ZipCode, String)
            End If
            If _emp.PhoneExtension > 0 Then
                .PhoneExtensionTextBox.Text = CType(_emp.PhoneExtension, String)
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
            Else
                .SFCComboBox.SelectedItem = "Yes"
            End If

            If _emp.SFCDate.HasValue Then
                .SFCDatePicker.Value = CType(_emp.SFCDate, Date)
                .ResetDatePicker(.SFCDatePicker)
            Else
                .ClearDatePicker(.SFCDatePicker)
            End If
        End With

    End Sub

    Private Sub EnableDisableSFCDate()

        If SFCComboBox.Text = "No" Then
            ClearDatePicker(SFCDatePicker)
            SFCDatePicker.Enabled = False
            SFCDateEmpty = 0
        ElseIf SFCComboBox.Text = "Yes" Then
            If emp.SFC = False Then
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

        _emp = _EmpEditService.SelectEmpFromList(UserAccount.SelectedOracleID)
        PopulateFields()
     
    End Sub

    Private Sub AddEmployeeForm()

        'BirthDatePicker.Value = Date.Today.AddYears(-18)
        'SFCDatePicker.Value = DateTime.Now
        'StartDatePicker.Value = DateTime.Now

        RegionComboBox.Text = SetListName(RegionComboBox, 1)
        BirthDatePicker.MaxDate = Date.Today.AddYears(-18)
        BirthChange = False
        SFCDatePicker.Enabled = False
        ClearDatePicker(BirthDatePicker)
        ClearDatePicker(StartDatePicker)
        ClearDatePicker(SFCDatePicker)

        OracleIDTextBox.Enabled = True
        RevertClearButton.Text = "Clear"
        OracleIDTextBox.Focus()
    End Sub
#End Region

    Private Sub EmployeeInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub


    Public Sub EmployeeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        _empinfo.ValidateClear()
        mR.ClearMgrValidate()
        LogIn.Show()

        Select Case UserAccount.UserType
            'Case 1
            Case 2
                Main.Dispose()
                Me.Close()
            Case 3
                Me.Close()
        End Select
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Dim retvalue As Integer
        ClickSave = True
        IsMgrError = False
        IsOffEmailError = False

        GetFieldTextValues()

        'If UserAccount.UserType = 3 Then
        '    _empinfo.Validate()
        '    mR.MgrValidate = 1
        'End If

        'If UserAccount.UserType = 1 Or UserAccount.UserType = 2 Then
        '    mR.ValidateManager()
        '    EmpInfo.EmpValidate = 1
        'End If

        Select Case UserAccount.UserType
            Case 1
                mR.ValidateManager()
                EmpInfo.EmpValidate = 1
            Case 2
                mR.ValidateManager()
                EmpInfo.EmpValidate = 1
            Case 3
                EmpInfo.Validate()
                mR.ManagerValidate = 1
        End Select


        If ClickSave = True And SFCComboBox.Text = "Yes" Then
            ClickSave = False
            If String.IsNullOrWhiteSpace(SFCDatePicker.Text) Then
                SFCDateEmpty = 1

            Else
                SFCDateEmpty = 0
            End If
        End If

        If EmpInfo.EmpValidate = 0 Or mR.ManagerValidate = 0 And SFCDateEmpty = 0 Then
            If UserAccount.IsEdit = True Then
                _empinfo.UpdateData(_emp)
                _EmpEditService.Employee = _emp
                PopulateFields()
                EmpInfo.ValidateClear()
                mR.ClearMgrValidate()
                Main.ReloadDataGridWithSort()
            Else
                '*** SET DEFAULT VALUES DURING ADD ***'
                _emp.UserType = 3


                retvalue = _empinfo.InsertData(_emp)        'fix to avoid error on duplicate Oracle ID's
                If retvalue = 0 Then
                    ClearFields()
                ElseIf retvalue = -1 Then
                    mR.CheckDupOracleID()
                End If

                EmpInfo.ValidateClear()
                mR.ClearMgrValidate()
                Main.ReloadDataGridWithSort()
            End If

        ElseIf mR.ManagerValidate = 3 Then
            MessageBox.Show("Oracle ID already exists.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf EmpInfo.EmpValidate = 2 Or mR.ManagerValidate = 2 Then

            MessageBox.Show("Email is not valid, Please check your email address.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf SFCDateEmpty = 1 Then
            MessageBox.Show("Please enter SFC date.", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Please fill up required field/s", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub RevertClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevertClearButton.Click
        'Revert = True

        If UserAccount.IsEdit = True Then
            EmpInfo.ValidateClear()
            mR.ClearMgrValidate()
            PopulateFields()
            OracleIDTextBox.Focus()
            'ClearDatePicker(SFCDatePicker)
            Debug.Print("Chenes: " & SFCDatePicker.Value.ToString) 'chenes
            'If SFCDateEmpty = 1 Then
            '    ResetDatePicker(SFCDatePicker)
            'End If
        Else
            ClearFields()
            OracleIDTextBox.Focus()
            EmpInfo.ValidateClear()
            mR.ClearMgrValidate()
        End If
        'ResetDatePicker(StartDatePicker)
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        ClearFields()
        EmpInfo.ValidateClear()
        mR.ClearMgrValidate()
        Main.Show()
        Me.Close()
    End Sub

    
    Private Sub SFCComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SFCComboBox.SelectedIndexChanged

        EnableDisableSFCDate()

    End Sub


    Private Sub BirthDatePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthDatePicker.ValueChanged
        ResetDatePicker(BirthDatePicker)
        BirthChange = True
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
End Class