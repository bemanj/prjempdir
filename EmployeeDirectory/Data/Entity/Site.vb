Public Class Site
    Inherits BASD.Helper.EntityBase

    Private _siteID As Int64
    Public Property SiteID() As Int64
        Get
            Return _siteID
        End Get
        Set(ByVal value As Int64)
            _siteID = value
        End Set
    End Property

    Private _sitename As String
    Public Property SiteName() As String
        Get
            Return _sitename
        End Get
        Set(ByVal value As String)
            _sitename = value
        End Set
    End Property

    Private _sitefloor As String
    Public Property SiteFloor() As String
        Get
            Return _sitefloor
        End Get
        Set(ByVal value As String)
            _sitefloor = value
        End Set
    End Property

    Private _siteAddress1 As String
    Public Property SiteAddress1() As String
        Get
            Return _siteAddress1
        End Get
        Set(ByVal value As String)
            _siteAddress1 = value
        End Set
    End Property

    Private _siteAddress2 As String
    Public Property SiteAddress2() As String
        Get
            Return _siteAddress2
        End Get
        Set(ByVal value As String)
            _siteAddress2 = value
        End Set
    End Property

    Private _siteCityName As String
    Public Property SiteCityName() As String
        Get
            Return _siteCityName
        End Get
        Set(ByVal value As String)
            _siteCityName = value
        End Set
    End Property

    Private _siteZipCode As Integer
    Public Property SiteZipCode() As Integer
        Get
            Return _siteZipCode
        End Get
        Set(ByVal value As Integer)
            _siteZipCode = value
        End Set
    End Property

    Private _siteRegionName As String
    Public Property SiteRegionName() As String
        Get
            Return _siteRegionName
        End Get
        Set(ByVal value As String)
            _siteRegionName = value
        End Set
    End Property

    Private _siteCountry As String
    Public Property SiteCountry() As String
        Get
            Return _siteCountry
        End Get
        Set(ByVal value As String)
            _siteCountry = value
        End Set
    End Property


End Class
