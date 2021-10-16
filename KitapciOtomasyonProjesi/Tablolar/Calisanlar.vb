Public Class Calisanlar
    Inherits Entity

    Dim strCalisanAd As String = Nothing
    Dim strCalisanSoyad As String = Nothing
    Dim strCinsiyet As String = Nothing
    Dim strTelefon As String = Nothing
    Dim strEposta As String = Nothing
    Dim strPozisyon As String = Nothing
    Dim strFotograf As String = Nothing
    Dim strSifre As String = Nothing

    Dim _IdAdresID As Integer = Nothing
    Dim _IdSubeID As Integer = Nothing

    Public Property CalisanAd As String
        Get
            Return strCalisanAd
        End Get
        Set
            strCalisanAd = Value
        End Set
    End Property

    Public Property CalisanSoyad As String
        Get
            Return strCalisanSoyad
        End Get
        Set
            strCalisanSoyad = Value
        End Set
    End Property

    Public Property Cinsiyet As String
        Get
            Return strCinsiyet
        End Get
        Set
            strCinsiyet = Value
        End Set
    End Property

    Public Property Telefon As String
        Get
            Return strTelefon
        End Get
        Set
            strTelefon = Value
        End Set
    End Property

    Public Property Eposta As String
        Get
            Return strEposta
        End Get
        Set
            strEposta = Value
        End Set
    End Property

    Public Property Pozisyon As String
        Get
            Return strPozisyon
        End Get
        Set
            strPozisyon = Value
        End Set
    End Property

    Public Property AdresID As Integer
        Get
            Return _IdAdresID
        End Get
        Set
            _IdAdresID = Value
        End Set
    End Property

    Public Property SubeID As Integer
        Get
            Return _IdSubeID
        End Get
        Set
            _IdSubeID = Value
        End Set
    End Property

    Public Property Fotograf As String
        Get
            Return strFotograf
        End Get
        Set
            strFotograf = Value
        End Set
    End Property

    Public Property Sifre As String
        Get
            Return strSifre
        End Get
        Set
            strSifre = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return (Me.CalisanAd + (" " + Me.CalisanSoyad))
    End Function

End Class
