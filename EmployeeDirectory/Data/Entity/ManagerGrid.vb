Public Class ManagerGrid
    Inherits BASD.Helper.EntityBase

    Private _OracleID As Long
    Public Property OracleID() As Long
        Get
            Return _OracleID
        End Get
        Set(ByVal value As Long)
            _OracleID = value
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

    Private _TeamName As String
    Public Property TeamName() As String
        Get
            Return _TeamName
        End Get
        Set(ByVal value As String)
            _TeamName = value
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

    Private _LastAccessedBy As Long
    Public Property LastAccessedBy() As Long
        Get
            Return _LastAccessedBy
        End Get
        Set(ByVal value As Long)
            _LastAccessedBy = value
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

End Class
