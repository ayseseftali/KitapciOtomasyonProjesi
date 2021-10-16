Public Class Adresler
    Inherits Entity

    Dim strcadde As String = Nothing
    Dim strsokak As String = Nothing
    Dim strmahalle As String = Nothing
    Dim strilce As String = Nothing
    Dim stril As String = Nothing
    Dim _idbinano As Integer = Nothing
    Dim _idkat As Integer = Nothing
    Dim _iddaireno As Integer = Nothing
    Dim _idpostakodu As Integer = Nothing

    Public Property Cadde As String
        Get
            Return strcadde
        End Get
        Set
            strcadde = Value
        End Set
    End Property

    Public Property Sokak As String
        Get
            Return strsokak
        End Get
        Set
            strsokak = Value
        End Set
    End Property

    Public Property Mahalle As String
        Get
            Return strmahalle
        End Get
        Set
            strmahalle = Value
        End Set
    End Property

    Public Property BinaNo As Integer
        Get
            Return _idbinano
        End Get
        Set
            _idbinano = Value
        End Set
    End Property

    Public Property Kat As Integer
        Get
            Return _idkat
        End Get
        Set
            _idkat = Value
        End Set
    End Property

    Public Property DaireNo As Integer
        Get
            Return _iddaireno
        End Get
        Set
            _iddaireno = Value
        End Set
    End Property

    Public Property Ilce As String
        Get
            Return strilce
        End Get
        Set
            strilce = Value
        End Set
    End Property

    Public Property Il As String
        Get
            Return stril
        End Get
        Set
            stril = Value
        End Set
    End Property

    Public Property PostaKodu As String
        Get
            Return _idpostakodu
        End Get
        Set
            _idpostakodu = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return ("ID:" + Me.Id.ToString() + ("-" + Me.Il + "-" + Me.Ilce))
    End Function
End Class
