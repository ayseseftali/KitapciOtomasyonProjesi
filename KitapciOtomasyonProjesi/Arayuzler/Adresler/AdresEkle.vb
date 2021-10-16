Public Class AdresEkle
    Private Sub AdresEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim adres As Adresler = New Adresler
        adres.Cadde = txtCadde.Text
        adres.Sokak = txtSokak.Text
        adres.Mahalle = txtMahalle.Text
        adres.BinaNo = Convert.ToInt32(txtBinaNo.Text)
        adres.Kat = Convert.ToInt32(txtKat.Text)
        adres.DaireNo = Convert.ToInt32(txtDaireNo.Text)
        adres.PostaKodu = txtPostaKodu.Text
        adres.Ilce = txtIlce.Text
        adres.Il = txtIl.Text

        Dim adDal As AdreslerDal = New AdreslerDal
        adDal.Save(adres)

        MessageBox.Show("Adresiniz Başarıyla Kaydedilmiştir...")

        txtCadde.Text = ""
        txtSokak.Text = ""
        txtMahalle.Text = ""
        txtBinaNo.Text = ""
        txtKat.Text = ""
        txtDaireNo.Text = ""
        txtPostaKodu.Text = ""
        txtIlce.Text = ""
        txtIl.Text = ""
    End Sub
End Class