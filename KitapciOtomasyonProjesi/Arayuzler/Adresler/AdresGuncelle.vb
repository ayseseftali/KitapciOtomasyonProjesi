Imports System.Data.SqlClient

Public Class AdresGuncelle

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Dim adDal As AdreslerDal = New AdreslerDal

    Private Sub AdresGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdreslerFill()
    End Sub

    Private Sub AdreslerFill()
        lstAdresler.DataSource = adDal.List()
    End Sub

    Private Sub lstAdresler_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAdresler.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If (lstAdresler.SelectedItem Is Nothing) Then
            MessageBox.Show("Lütfen Güncellemek İstediğiniz Adresi ListBox'tan Seçiniz !!!")
            Return
        End If

        Dim seciliAdres As Adresler = CType(lstAdresler.SelectedItem, Adresler)
        Dim secilenId As Integer = seciliAdres.Id
        cmd = New SqlCommand("Select * From Adresler Where AdresID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilenId)
        reader = cmd.ExecuteReader
        If reader.HasRows Then

            While reader.Read
                txtCadde.Text = reader("Cadde").ToString
                txtSokak.Text = reader("Sokak").ToString
                txtMahalle.Text = reader("Mahalle").ToString
                txtBinaNo.Text = reader("BinaNo").ToString
                txtKat.Text = reader("Kat").ToString
                txtDaireNo.Text = reader("DaireNo").ToString
                txtIlce.Text = reader("Ilce").ToString
                txtIl.Text = reader("Il").ToString
                txtPostaKodu.Text = reader("PostaKodu").ToString

            End While

        End If

        reader.Close()
        cnn.Close()

    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim adres As Adresler = CType(lstAdresler.SelectedItem, Adresler)

        adres.Id = adres.Id
        adres.Cadde = txtCadde.Text
        adres.Sokak = txtSokak.Text
        adres.Mahalle = txtMahalle.Text
        adres.BinaNo = Convert.ToInt32(txtBinaNo.Text)
        adres.Kat = Convert.ToInt32(txtKat.Text)
        adres.DaireNo = Convert.ToInt32(txtDaireNo.Text)
        adres.Ilce = txtIlce.Text
        adres.Il = txtIl.Text
        adres.PostaKodu = txtPostaKodu.Text

        adDal.Update(adres)

        MessageBox.Show("Verileriniz Başarıyla Güncellenmiştir ...")

        txtCadde.Clear()
        txtSokak.Clear()
        txtMahalle.Clear()
        txtBinaNo.Clear()
        txtKat.Clear()
        txtDaireNo.Clear()
        txtIlce.Clear()
        txtIl.Clear()
        txtPostaKodu.Clear()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class