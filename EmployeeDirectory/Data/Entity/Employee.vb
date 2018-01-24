Public Class Employee
    Inherits BASD.Helper.EntityBase

    'Employee Information

    Private _OracleID As Int64
    Public Property OracleID() As Int64
        Get
            Return _OracleID
        End Get
        Set(ByVal value As Int64)
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

    Private _Gender As String
    Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            _Gender = value
        End Set
    End Property

    Private _EmailAddress As String
    Public Property EmailAddress() As String
        Get
            Return _EmailAddress
        End Get
        Set(ByVal value As String)
            _EmailAddress = value
        End Set
    End Property

    Private _MobileNo As Decimal
    Public Property MobileNo() As Decimal
        Get
            Return _MobileNo
        End Get
        Set(ByVal value As Decimal)
            _MobileNo = value
        End Set
    End Property

    Private _PhoneExtension As Decimal
    Public Property PhoneExtension() As Decimal
        Get
            Return _PhoneExtension
        End Get
        Set(ByVal value As Decimal)
            _PhoneExtension = value
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

    Private _TeamName As String
    Public Property TeamName() As String
        Get
            Return _TeamName
        End Get
        Set(ByVal value As String)
            _TeamName = value
        End Set
    End Property

    Private _LocalManagerID As Int64
    Public Property LocalManagerID() As Int64
        Get
            Return _LocalManagerID
        End Get
        Set(ByVal value As Int64)
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

    Private _IDCreated As Boolean
    Public Property IDCreated() As Boolean
        Get
            Return _IDCreated
        End Get
        Set(ByVal value As Boolean)
            _IDCreated = value
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

    Private _Shift As String
    Public Property Shift() As String
        Get
            Return _Shift
        End Get
        Set(ByVal value As String)
            _Shift = value
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

    'Access Information

    Private _OraclePRDID As String
    Public Property OraclePRDID() As String
        Get
            Return _OraclePRDID
        End Get
        Set(ByVal value As String)
            _OraclePRDID = value
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

    Private _NCOGroup As String
    Public Property NCOGroup() As String
        Get
            Return _NCOGroup
        End Get
        Set(ByVal value As String)
            _NCOGroup = value
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

    Private _PCName As String
    Public Property PCName() As String
        Get
            Return _PCName
        End Get
        Set(ByVal value As String)
            _PCName = value
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

End Class
