Public Class Musteriler
    Inherits Entity

    Dim _musteriAdi As String = Nothing
    Dim _musteriSoyadi As String = Nothing
    Dim _musteriTelefon As String = Nothing
    Dim _musteriEPosta As String = Nothing
    Dim _musteriCinsiyet As String = Nothing


    Public Property MusteriAdi As String
        Get
            Return _musteriAdi
        End Get
        Set(value As String)
            _musteriAdi = value
        End Set
    End Property

    Public Property MusteriSoyadi As String
        Get
            Return _musteriSoyadi
        End Get
        Set(value As String)
            _musteriSoyadi = value
        End Set
    End Property

    Public Property MusteriTelefon As String
        Get
            Return _musteriTelefon
        End Get
        Set(value As String)
            _musteriTelefon = value
        End Set
    End Property

    Public Property MusteriEPosta As String
        Get
            Return _musteriEPosta
        End Get
        Set(value As String)
            _musteriEPosta = value
        End Set
    End Property

    Public Property MusteriCinsiyet As String
        Get
            Return _musteriCinsiyet
        End Get
        Set(value As String)
            _musteriCinsiyet = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return (Me.MusteriAdi + (" " + Me.MusteriSoyadi))
    End Function
End Class
