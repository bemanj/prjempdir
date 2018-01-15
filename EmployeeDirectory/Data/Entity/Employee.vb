Public Class Employee
    Inherits BASD.Helper.EntityBase

    'Employee Information
    Private _EmpTitle As String
    Public Property EmpTitle() As String
        Get
            Return _EmpTitle
        End Get
        Set(ByVal value As String)
            _EmpTitle = value
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

    Private _EmailAdd As String
    Public Property EmailAdd() As String
        Get
            Return _EmailAdd
        End Get
        Set(ByVal value As String)
            _EmailAdd = value
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

    Private _PhoneExt As Decimal
    Public Property PhoneExt() As Decimal
        Get
            Return _PhoneExt
        End Get
        Set(ByVal value As Decimal)
            _PhoneExt = value
        End Set
    End Property

    'Office Information
    Private _Team As Integer
    Public Property Team() As Integer
        Get
            Return _Team
        End Get
        Set(ByVal value As Integer)
            _Team = value
        End Set
    End Property

    Private _LocalManager As Integer
    Public Property LocalManager() As Integer
        Get
            Return _LocalManager
        End Get
        Set(ByVal value As Integer)
            _LocalManager = value
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

    Private _Site As Integer
    Public Property Site() As Integer
        Get
            Return _Site
        End Get
        Set(ByVal value As Integer)
            _Site = value
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

    Private _StartDate As DateTime
    Public Property StartDate() As DateTime
        Get
            Return _StartDate
        End Get
        Set(ByVal value As DateTime)
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

    Private _SFCDate As DateTime
    Public Property SFCDate() As DateTime
        Get
            Return _SFCDate
        End Get
        Set(ByVal value As DateTime)
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

    Private _OfficeAddLine1 As String
    Public Property OfficeAddLine1() As String
        Get
            Return _OfficeAddLine1
        End Get
        Set(ByVal value As String)
            _OfficeAddLine1 = value
        End Set
    End Property

    Private _OfficeAddLine2 As String
    Public Property OfficeAddLine2() As String
        Get
            Return _OfficeAddLine2
        End Get
        Set(ByVal value As String)
            _OfficeAddLine2 = value
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

    Private _NCOGroupID As String
    Public Property NCOGroupID() As String
        Get
            Return _NCOGroupID
        End Get
        Set(ByVal value As String)
            _NCOGroupID = value
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

End Class
