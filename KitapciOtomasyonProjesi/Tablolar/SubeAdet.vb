Public Class SubeAdet
    Inherits Entity

    Dim str As String = Nothing
    Dim _Id As Integer = Nothing

    Public Property SubeAdi As String
        Get
            Return str
        End Get
        Set
            str = Value
        End Set
    End Property

    Public Property Adet As Integer
        Get
            Return _Id
        End Get
        Set
            _Id = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return (Me.SubeAdi)
    End Function
End Class
