Public Class KitaplarıListele

    Dim kpDal As KitaplarDal = New KitaplarDal
    Private Sub KitaplarıListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwKitaplar.DataSource = kpDal.List()
    End Sub
End Class