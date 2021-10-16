Imports System.Data.SqlClient

Public Class MusteriGuncelle
    Dim msDal As MusterilerDal = New MusterilerDal

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader
    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim musteri As Musteriler = CType(lstMusteriler.SelectedItem, Musteriler)

        musteri.Id = musteri.Id
        musteri.MusteriAdi = txtAd.Text
        musteri.MusteriSoyadi = txtSoyad.Text
        musteri.MusteriCinsiyet = cbCinsiyet.Text
        musteri.MusteriEPosta = txtEposta.Text
        musteri.MusteriTelefon = mtxtTelefon.Text

        msDal.Update(musteri)

        MessageBox.Show("Müşteriniz Başarıyla Güncellenmiştir ...")

        txtAd.Clear()
        txtSoyad.Clear()
        txtEposta.Clear()
        cbCinsiyet.SelectedIndex = 0
        mtxtTelefon.Clear()

        lstMusteriler.DataSource = msDal.List()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub

    Private Sub MusteriGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstMusteriler.DataSource = msDal.List()
        cbCinsiyet.SelectedIndex = 0
    End Sub

    Private Sub lstMusteriler_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMusteriler.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If (lstMusteriler.SelectedItem Is Nothing) Then
            MessageBox.Show("Lütfen Güncellemek İstediğiniz Müşteriyi ListBox'tan Seçiniz !!!")
            Return
        End If

        Dim seciliMusteri As Musteriler = CType(lstMusteriler.SelectedItem, Musteriler)
        Dim secilenId As Integer = seciliMusteri.Id

        cmd = New SqlCommand("Select * From Musteriler Where MusteriID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilenId)

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                txtAd.Text = reader("MusteriAdi").ToString()
                txtSoyad.Text = reader("MusteriSoyadi").ToString()
                cbCinsiyet.Text = reader("MusteriCinsiyet").ToString()
                txtEposta.Text = reader("MusteriEPosta").ToString()
                mtxtTelefon.Text = reader("MusteriTelefon").ToString()
            End While
        End If
        reader.Close()
        cnn.Close()
    End Sub
End Class