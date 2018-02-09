Public Class UserAccount

    Private Shared _UserID As Long
    Public Shared Property UserID() As Long
        Get
            Return _UserID
        End Get
        Set(ByVal value As Long)
            _UserID = value
        End Set
    End Property

    Private Shared _userType As Integer
    Public Shared Property UserType() As Integer
        Get
            Return _userType
        End Get
        Set(ByVal value As Integer)
            _userType = value
        End Set
    End Property

    Private Shared _userName As String
    Public Shared Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property

    Private Shared _isEdit As Boolean
    Public Shared Property IsEdit() As Boolean
        Get
            Return _isEdit
        End Get
        Set(ByVal value As Boolean)
            _isEdit = value
        End Set
    End Property


    Private Shared _selectedOracleID As Long
    Public Shared Property SelectedOracleID() As Long
        Get
            Return _selectedOracleID
        End Get
        Set(ByVal value As Long)
            _selectedOracleID = value
        End Set
    End Property
End Class
