Public Class Satis
    Inherits Entity

    Dim _satisID As Integer = Nothing
    Dim _subeID As Integer = Nothing
    Dim _kitapID As Integer = Nothing
    Dim _satisSayisi As Integer = Nothing
    Dim _satisTarihi As DateTime = Nothing
    Dim _toplamTutarı As Decimal = Nothing
    Dim _musteriID As Integer = Nothing

    Public Property SatisID As Integer
        Get
            Return _satisID
        End Get
        Set(value As Integer)
            _satisID = value
        End Set
    End Property

    Public Property SubeID As Integer
        Get
            Return _subeID
        End Get
        Set(value As Integer)
            _subeID = value
        End Set
    End Property

    Public Property KitapID As Integer
        Get
            Return _kitapID
        End Get
        Set(value As Integer)
            _kitapID = value
        End Set
    End Property

    Public Property SatisSayisi As Integer
        Get
            Return _satisSayisi
        End Get
        Set(value As Integer)
            _satisSayisi = value
        End Set
    End Property

    Public Property SatisTarihi As DateTime
        Get
            Return _satisTarihi
        End Get
        Set(value As DateTime)
            _satisTarihi = value
        End Set
    End Property

    Public Property ToplamTutar As Decimal
        Get
            Return _toplamTutarı
        End Get
        Set(value As Decimal)
            _toplamTutarı = value
        End Set
    End Property

    Public Property MusteriID As Integer
        Get
            Return _musteriID
        End Get
        Set(value As Integer)
            _musteriID = value
        End Set
    End Property
End Class
