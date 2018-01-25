Public Class DropDownList
    Inherits BASD.Helper.EntityBase

    Private _listID As Integer
    Public Property ListID() As Integer
        Get
            Return _listID
        End Get
        Set(ByVal value As Integer)
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
