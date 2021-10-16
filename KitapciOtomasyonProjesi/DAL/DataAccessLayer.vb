Public MustInherit Class DataAccessLayer(Of T)

    Public MustOverride Function Save(ByVal instance As T) As Integer

    Public MustOverride Function Update(ByVal instance As T) As Integer

    Public MustOverride Function Delete(ByVal instanceId As Object) As Integer

    Public MustOverride Function List() As List(Of T)
End Class
