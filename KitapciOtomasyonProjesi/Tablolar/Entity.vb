Imports KitapciOtomasyonProjesi

Public Class Entity
    Implements IEntity

    Private _id As Integer

    Public Property Id As Integer Implements IEntity.Id
        Get
            Return Me._id
        End Get
        Set
            Me._id = Value
        End Set
    End Property
End Class
