Public Class LoginView

    Inherits BASD.Helper.EntityBase

    ' Login Information '

    Private _OracleID As Long
    Public Property OracleID() As Long
        Get
            Return _OracleID
        End Get
        Set(ByVal value As Long)
            _OracleID = value
        End Set
    End Property

    Private _Password As String
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
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

    Private _UserType As Integer
    Public Property UserType() As Integer
        Get
            Return _UserType
        End Get
        Set(ByVal value As Integer)
            _UserType = value
        End Set
    End Property

    Private _OfficeEmail As String
    Public Property OfficeEmail() As String
        Get
            Return _OfficeEmail
        End Get
        Set(ByVal value As String)
            _OfficeEmail = value
        End Set
    End Property

    Private _CreateTS As String
    Public Property CreateTS() As String
        Get
            Return _CreateTS
        End Get
        Set(ByVal value As String)
            _CreateTS = value
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

    Private _ExpirationDate As DateTime
    Public Property ExpirationDate() As DateTime
        Get
            Return _ExpirationDate
        End Get
        Set(ByVal value As DateTime)
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
