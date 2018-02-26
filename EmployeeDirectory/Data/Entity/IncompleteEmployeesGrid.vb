Public Class IncompleteEmployeesGrid
    Inherits BASD.Helper.EntityBase

    Private _oracleID As Long
    Public Property OracleID() As Long
        Get
            Return _oracleID
        End Get
        Set(ByVal value As Long)
            _oracleID = value
        End Set
    End Property

    Private _fullName As String
    Public Property FullName() As String
        Get
            Return _fullName
        End Get
        Set(ByVal value As String)
            _fullName = value
        End Set
    End Property

    Private _incompleteFields As String
    Public Property IncompleteFields() As String
        Get
            Return _incompleteFields
        End Get
        Set(ByVal value As String)
            _incompleteFields = value
        End Set
    End Property


End Class
