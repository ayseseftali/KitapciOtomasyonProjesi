Public Class Kategoriler
    Inherits Entity

    Dim str As String = Nothing

    Public Property KategoriAdi As String
        Get
            Return str
        End Get
        Set
            str = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return (Me.KategoriAdi)
    End Function
End Class
