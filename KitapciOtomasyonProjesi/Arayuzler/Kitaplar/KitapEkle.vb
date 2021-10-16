Imports System.Data.SqlClient

Public Class KitapEkle
    Private Sub KitapEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YayinEviFill()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub YayinEviFill()
        cbYayinEviID.Items.Clear()

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select * From YayinEvleri", cnn)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim ye As YayinEvi = New YayinEvi
                ye.Id = Convert.ToInt32(reader("YayinEviID").ToString())
                ye.YayinEviAdi = reader("YayinEviAdi").ToString()
                ye.AdresID = Convert.ToInt32(reader("AdresID").ToString())

                cbYayinEviID.Items.Add(ye)
            End While
        End If

        cbYayinEviID.SelectedIndex = 0
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim kitap As Kitaplar = New Kitaplar

        kitap.KitapAdi = txtKitapAdi.Text
        kitap.YayinTarihi = Convert.ToDateTime(txtYayinTarihi.Text)
        kitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text)
        Dim secilenYayinEvi As YayinEvi = CType(cbYayinEviID.SelectedItem, YayinEvi)
        kitap.YayinEviID = secilenYayinEvi.Id
        kitap.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text)

        Dim kpDal As KitaplarDal = New KitaplarDal
        kpDal.Save(kitap)

        MessageBox.Show("Kitabınız Başarıyla Kaydedilmiştir ...")

        txtKitapAdi.Clear()
        txtYayinTarihi.Clear()
        txtSayfaSayisi.Clear()
        cbYayinEviID.SelectedIndex = 0
        txtSatisFiyati.Clear()

    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class