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

    Private Shared _UserType As Integer
    Public Shared Property UserType() As Integer
        Get
            Return _UserType
        End Get
        Set(ByVal value As Integer)
            _UserType = value
        End Set
    End Property

    Private Shared _UserName As String
    Public Shared Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
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



End Class
