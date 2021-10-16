Public Class KategoriEkle
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim kategori As Kategoriler = New Kategoriler
        kategori.KategoriAdi = txtKategoriAdi.Text
        Dim kateDal As KategorilerDal = New KategorilerDal
        kateDal.Save(kategori)

        MessageBox.Show("Kategoriniz Başarıyla Kaydedilmiştir...")

        txtKategoriAdi.Clear()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class