Public Class YazarlarListele
    Dim yzDal As YazarlarDal = New YazarlarDal

    Private Sub YazarlarListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwYazarlar.DataSource = yzDal.List()
    End Sub
End Class