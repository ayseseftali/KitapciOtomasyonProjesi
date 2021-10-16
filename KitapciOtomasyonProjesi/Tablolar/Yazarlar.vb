Public Class Yazarlar
    Inherits Entity

    Dim strYazarAdi As String = Nothing
    Dim strYazarSoyadi As String = Nothing

    Public Property YazarAdi As String
        Get
            Return strYazarAdi
        End Get
        Set
            strYazarAdi = Value
        End Set
    End Property

    Public Property YazarSoyadi As String
        Get
            Return strYazarSoyadi
        End Get
        Set
            strYazarSoyadi = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return (Me.YazarAdi + " " + Me.YazarSoyadi)
    End Function
End Class
