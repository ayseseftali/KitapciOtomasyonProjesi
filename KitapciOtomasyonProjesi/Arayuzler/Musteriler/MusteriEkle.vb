Public Class MusteriEkle
    Private Sub MusteriEkle_Load(sender As Object, e As EventArgs)
        cbCinsiyet.SelectedIndex = 0
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim musteri As Musteriler = New Musteriler
        musteri.MusteriAdi = txtAd.Text
        musteri.MusteriSoyadi = txtSoyad.Text
        musteri.MusteriCinsiyet = cbCinsiyet.Text
        musteri.MusteriTelefon = mtxtTelefon.Text
        musteri.MusteriEPosta = txtEposta.Text

        Dim msDal As MusterilerDal = New MusterilerDal
        msDal.Save(musteri)
        MessageBox.Show("Verileriniz Başarıyla Kaydedilmiştir ...")
        txtAd.Clear()
        txtSoyad.Text = ""
        cbCinsiyet.SelectedIndex = 0
        mtxtTelefon.Clear()
        txtEposta.Clear()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class