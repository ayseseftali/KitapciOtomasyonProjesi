Public Class Kitaplar
    Inherits Entity

    Dim str As String = Nothing
    Dim _IdSayfaSayisi As Integer = Nothing
    Dim _IdYayinEviID As Integer = Nothing
    Dim Time As DateTime = Nothing
    Dim fiyat As Decimal = Nothing

    Public Property KitapAdi As String
        Get
            Return str
        End Get
        Set
            str = Value
        End Set
    End Property

    Public Property YayinTarihi As DateTime
        Get
            Return Time
        End Get
        Set
            Time = Value
        End Set
    End Property

    Public Property SayfaSayisi As Integer
        Get
            Return _IdSayfaSayisi
        End Get
        Set
            _IdSayfaSayisi = Value
        End Set
    End Property

    Public Property YayinEviID As Integer
        Get
            Return _IdYayinEviID
        End Get
        Set
            _IdYayinEviID = Value
        End Set
    End Property

    Public Property SatisFiyati As Decimal
        Get
            Return fiyat
        End Get
        Set
            fiyat = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return (Me.KitapAdi)
    End Function
End Class
