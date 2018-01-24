Public Class EntityBase
    Implements IEntity

    Private _id As Int64
    Public Property Id() As Int64 Implements IEntity.Id
        Get
            Return _id
        End Get
        Set(ByVal value As Int64)
            _id = value
        End Set
    End Property

End Class
