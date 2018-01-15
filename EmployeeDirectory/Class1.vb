Public Class Class1

    Private _oracleid As String
    Public Property oracleid() As String
        Get
            Return _oracleid
        End Get
        Set(ByVal value As String)
            _oracleid = value
        End Set
    End Property


    Private _lastname As String
    Public Property lastname() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property


End Class
