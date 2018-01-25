Public Class Employee
    Inherits BASD.Helper.EntityBase

    'Employee Information

    'Sprint 2: Change to LONG
    Private _OracleID As Long
    Public Property OracleID() As Long
        Get
            Return _OracleID
        End Get
        Set(ByVal value As Long)
            _OracleID = value
        End Set
    End Property

    Private _Title As String
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _Position As String
    Public Property Position() As String
        Get
            Return _Position
        End Get
        Set(ByVal value As String)
            _Position = value
        End Set
    End Property

    Private _LastName As String
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property

    Private _FirstName As String
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property

    Private _MiddleName As String
    Public Property MiddleName() As String
        Get
            Return _MiddleName
        End Get
        Set(ByVal value As String)
            _MiddleName = value
        End Set
    End Property

    Private _HomeAddress1 As String
    Public Property HomeAddress1() As String
        Get
            Return _HomeAddress1
        End Get
        Set(ByVal value As String)
            _HomeAddress1 = value
        End Set
    End Property

    Private _HomeAddress2 As String
    Public Property HomeAddress2() As String
        Get
            Return _HomeAddress2
        End Get
        Set(ByVal value As String)
            _HomeAddress2 = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _CityId As Integer
    Public Property CityId() As Integer
        Get
            Return _CityId
        End Get
        Set(ByVal value As Integer)
            _CityId = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _CityName As String
    Public Property CityName() As String
        Get
            Return _CityName
        End Get
        Set(ByVal value As String)
            _CityName = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _ZipCode As Integer
    Public Property ZipCode() As Integer
        Get
            Return _ZipCode
        End Get
        Set(ByVal value As Integer)
            _ZipCode = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _RegionId As Integer
    Public Property RegionId() As Integer
        Get
            Return _RegionId
        End Get
        Set(ByVal value As Integer)
            _RegionId = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _RegionName As String
    Public Property RegionName() As String
        Get
            Return _RegionName
        End Get
        Set(ByVal value As String)
            _RegionName = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _Country As String
    Public Property Country() As String
        Get
            Return _Country
        End Get
        Set(ByVal value As String)
            _Country = value
        End Set
    End Property

    Private _Gender As String
    Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            _Gender = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _Birthday As DateTime?
    Public Property Birthday() As DateTime?
        Get
            Return _Birthday
        End Get
        Set(ByVal value As DateTime?)
            _Birthday = value
        End Set
    End Property

    'Sprint 2: Change Field Name
    Private _PersonalEmail As String
    Public Property PersonalEmail() As String
        Get
            Return _PersonalEmail
        End Get
        Set(ByVal value As String)
            _PersonalEmail = value
        End Set
    End Property

    Private _MobileNo As Long
    Public Property MobileNo() As Long
        Get
            Return _MobileNo
        End Get
        Set(ByVal value As Long)
            _MobileNo = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _LandlineNo As String
    Public Property LandlineNo() As String
        Get
            Return _LandlineNo
        End Get
        Set(ByVal value As String)
            _LandlineNo = value
        End Set
    End Property

    Private _PhoneExtension As Long
    Public Property PhoneExtension() As Long
        Get
            Return _PhoneExtension
        End Get
        Set(ByVal value As Long)
            _PhoneExtension = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _OfficeEmail As String
    Public Property OfficeEmail() As String
        Get
            Return _OfficeEmail
        End Get
        Set(ByVal value As String)
            _OfficeEmail = value
        End Set
    End Property

    Private _NCOGroup As String
    Public Property NCOGroup() As String
        Get
            Return _NCOGroup
        End Get
        Set(ByVal value As String)
            _NCOGroup = value
        End Set
    End Property

    Private _Division As String
    Public Property Division() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property

    Private _Department As String
    Public Property Department() As String
        Get
            Return _Department
        End Get
        Set(ByVal value As String)
            _Department = value
        End Set
    End Property

    Private _Entity As String
    Public Property Entity() As String
        Get
            Return _Entity
        End Get
        Set(ByVal value As String)
            _Entity = value
        End Set
    End Property

    'Office Information
    Private _TeamID As Integer
    Public Property TeamID() As Integer
        Get
            Return _TeamID
        End Get
        Set(ByVal value As Integer)
            _TeamID = value
        End Set
    End Property

    'Sprint 2: New Field
    Private _TeamName As String
    Public Property TeamName() As String
        Get
            Return _TeamName
        End Get
        Set(ByVal value As String)
            _TeamName = value
        End Set
    End Property

    Private _LocalManagerID As Long
    Public Property LocalManagerID() As Long
        Get
            Return _LocalManagerID
        End Get
        Set(ByVal value As Long)
            _LocalManagerID = value
        End Set
    End Property

    Private _Mgr_Last_Name As String
    Public Property Mgr_Last_Name() As String
        Get
            If (_Mgr_Last_Name Is Nothing) Then
                Return String.Empty

            End If
            Return _Mgr_Last_Name
        End Get
        Set(ByVal value As String)
            _Mgr_Last_Name = value
        End Set
    End Property

    Private _Mgr_First_Name As String
    Public Property Mgr_First_Name() As String
        Get
            If (_Mgr_First_Name Is Nothing) Then
                Return String.Empty

            End If
            Return _Mgr_First_Name
        End Get
        Set(ByVal value As String)
            _Mgr_First_Name = value
        End Set
    End Property

    Private _USManager As String
    Public Property USManager() As String
        Get
            Return _USManager
        End Get
        Set(ByVal value As String)
            _USManager = value
        End Set
    End Property

    Private _SiteID As Integer
    Public Property SiteID() As Integer
        Get
            Return _SiteID
        End Get
        Set(ByVal value As Integer)
            _SiteID = value
        End Set
    End Property

    Private _SiteName As String
    Public Property SiteName() As String
        Get
            Return _SiteName
        End Get
        Set(ByVal value As String)
            _SiteName = value
        End Set
    End Property

    Private _SiteFloor As String
    Public Property SiteFloor() As String
        Get
            Return _SiteFloor
        End Get
        Set(ByVal value As String)
            _SiteFloor = value
        End Set
    End Property

    Private _SiteAddress1 As String
    Public Property SiteAddress1() As String
        Get
            Return _SiteAddress1
        End Get
        Set(ByVal value As String)
            _SiteAddress1 = value
        End Set
    End Property

    Private _SiteAddress2 As String
    Public Property SiteAddress2() As String
        Get
            Return _SiteAddress2
        End Get
        Set(ByVal value As String)
            _SiteAddress2 = value
        End Set
    End Property

    Private _SiteCityID As Integer
    Public Property SiteCityID() As Integer
        Get
            Return _SiteCityID
        End Get
        Set(ByVal value As Integer)
            _SiteCityID = value
        End Set
    End Property

    Private _SiteCityName As String
    Public Property SiteCityName() As String
        Get
            Return _SiteCityName
        End Get
        Set(ByVal value As String)
            _SiteCityName = value
        End Set
    End Property

    Private _SiteZipCode As Integer
    Public Property SiteZipCode() As Integer
        Get
            Return _SiteZipCode
        End Get
        Set(ByVal value As Integer)
            _SiteZipCode = value
        End Set
    End Property

    Private _SiteRegionID As Integer
    Public Property SiteRegionID() As Integer
        Get
            Return _SiteRegionID
        End Get
        Set(ByVal value As Integer)
            _SiteRegionID = value
        End Set
    End Property

    Private _SiteRegionName As String
    Public Property SiteRegionName() As String
        Get
            Return _SiteRegionName
        End Get
        Set(ByVal value As String)
            _SiteRegionName = value
        End Set
    End Property

    Private _SiteCountry As String
    Public Property SiteCountry() As String
        Get
            Return _SiteCountry
        End Get
        Set(ByVal value As String)
            _SiteCountry = value
        End Set
    End Property

    Private _Floor As String
    Public Property Floor() As String
        Get
            Return _Floor
        End Get
        Set(ByVal value As String)
            _Floor = value
        End Set
    End Property

    Private _SeatNumber As String
    Public Property SeatNumber() As String
        Get
            Return _SeatNumber
        End Get
        Set(ByVal value As String)
            _SeatNumber = value
        End Set
    End Property

    Private _OnboardingTicket As String
    Public Property OnboardingTicket() As String
        Get
            Return _OnboardingTicket
        End Get
        Set(ByVal value As String)
            _OnboardingTicket = value
        End Set
    End Property

    Private _StartDate As DateTime?
    Public Property StartDate() As DateTime?
        Get
            Return _StartDate
        End Get
        Set(ByVal value As DateTime?)
            _StartDate = value
        End Set
    End Property

    Private _Shift As String
    Public Property Shift() As String
        Get
            Return _Shift
        End Get
        Set(ByVal value As String)
            _Shift = value
        End Set
    End Property

    Private _PCName As String
    Public Property PCName() As String
        Get
            Return _PCName
        End Get
        Set(ByVal value As String)
            _PCName = value
        End Set
    End Property

    Private _MercuryID As String
    Public Property MercuryID() As String
        Get
            Return _MercuryID
        End Get
        Set(ByVal value As String)
            _MercuryID = value
        End Set
    End Property

    Private _IDCreated As Boolean
    Public Property IDCreated() As Boolean
        Get
            Return _IDCreated
        End Get
        Set(ByVal value As Boolean)
            _IDCreated = value
        End Set
    End Property

    Private _OraclePRDID As String
    Public Property OraclePRDID() As String
        Get
            Return _OraclePRDID
        End Get
        Set(ByVal value As String)
            _OraclePRDID = value
        End Set
    End Property

    Private _EISID As String
    Public Property EISID() As String
        Get
            Return _EISID
        End Get
        Set(ByVal value As String)
            _EISID = value
        End Set
    End Property

    Private _InsightID As String
    Public Property InsightID() As String
        Get
            Return _InsightID
        End Get
        Set(ByVal value As String)
            _InsightID = value
        End Set
    End Property

    Private _EGSPremID As String
    Public Property EGSPremID() As String
        Get
            Return _EGSPremID
        End Get
        Set(ByVal value As String)
            _EGSPremID = value
        End Set
    End Property

    Private _ElsevierID As String
    Public Property ElsevierID() As String
        Get
            Return _ElsevierID
        End Get
        Set(ByVal value As String)
            _ElsevierID = value
        End Set
    End Property

    Private _GITHubID As String
    Public Property GITHubID() As String
        Get
            Return _GITHubID
        End Get
        Set(ByVal value As String)
            _GITHubID = value
        End Set
    End Property

    Private _SFC As Boolean
    Public Property SFC() As Boolean
        Get
            Return _SFC
        End Get
        Set(ByVal value As Boolean)
            _SFC = value
        End Set
    End Property

    Private _SFCDate As DateTime?
    Public Property SFCDate() As DateTime?
        Get
            Return _SFCDate
        End Get
        Set(ByVal value As DateTime?)
            _SFCDate = value
        End Set
    End Property

    Private _Recruiter As String
    Public Property Recruiter() As String
        Get
            Return _Recruiter
        End Get
        Set(ByVal value As String)
            _Recruiter = value
        End Set
    End Property


    Private _CreateTS As DateTime?
    Public Property CreateTS() As DateTime?
        Get
            Return _CreateTS
        End Get
        Set(ByVal value As DateTime?)
            _CreateTS = value
        End Set
    End Property

    Private _UpdateTS As DateTime?
    Public Property UpdateTS() As DateTime?
        Get
            Return _UpdateTS
        End Get
        Set(ByVal value As DateTime?)
            _UpdateTS = value
        End Set
    End Property


    'User Type

    Private _UserType As Integer
    Public Property UserType() As Integer
        Get
            Return _UserType
        End Get
        Set(ByVal value As Integer)
            _UserType = value
        End Set
    End Property

    Private _Status As Integer
    Public Property Status() As Integer
        Get
            Return _Status
        End Get
        Set(ByVal value As Integer)
            _Status = value
        End Set
    End Property

    Private _LastLogin As DateTime
    Public Property LastLogin() As DateTime
        Get
            Return _LastLogin
        End Get
        Set(ByVal value As DateTime)
            _LastLogin = value
        End Set
    End Property

    Private _ExpirationDate As Integer
    Public Property ExpirationDate() As Integer
        Get
            Return _ExpirationDate
        End Get
        Set(ByVal value As Integer)
            _ExpirationDate = value
        End Set
    End Property

    Private _LastAccessedBy As Long
    Public Property LastAccessedBy() As Long
        Get
            Return _LastAccessedBy
        End Get
        Set(ByVal value As Long)
            _LastAccessedBy = value
        End Set
    End Property

End Class
