Public Class EntityBase
    Implements IEntity

    Private _id As Integer
    Public Property Id() As Integer Implements IEntity.Id
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

End Class
