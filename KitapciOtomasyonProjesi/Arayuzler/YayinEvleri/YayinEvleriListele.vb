Public Class YayinEvleriListele
    Dim yeDal As YayinEviDal = New YayinEviDal
    Private Sub YayinEvleriListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwYayinEvleri.DataSource = yeDal.List()
    End Sub
End Class