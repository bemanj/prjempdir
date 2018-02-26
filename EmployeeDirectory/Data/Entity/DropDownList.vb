Public Class DropDownList
    Inherits BASD.Helper.EntityBase

    Private _listID As Int64
    Public Property ListID() As Int64
        Get
            Return _listID
        End Get
        Set(ByVal value As Int64)
            _listID = value
        End Set
    End Property


    Private _listName As String
    Public Property ListName() As String
        Get
            Return _listName
        End Get
        Set(ByVal value As String)
            _listName = value
        End Set
    End Property


End Class
