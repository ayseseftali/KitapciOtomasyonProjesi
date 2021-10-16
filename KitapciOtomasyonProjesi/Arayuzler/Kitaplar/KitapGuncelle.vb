Imports System.Data.SqlClient

Public Class KitapGuncelle
    Dim kpDal As KitaplarDal = New KitaplarDal

    Private Sub KitapGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YayinEviFill()
        lstKitaplar.DataSource = kpDal.List()
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

    Private Sub lstKitaplar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKitaplar.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If (lstKitaplar.SelectedItem Is Nothing) Then
            MessageBox.Show("Lütfen Güncellemek İstediğiniz Kitabı ListBox'tan Seçiniz !!!")
            Return
        End If

        Dim seciliKitap As Kitaplar = CType(lstKitaplar.SelectedItem, Kitaplar)
        Dim secilenId As Integer = seciliKitap.Id

        cmd = New SqlCommand("Select * From Kitaplar Where KitapID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilenId)

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                txtKitapAdi.Text = reader("KitapAdi").ToString()
                txtYayinTarihi.Text = String.Format("{0:MM/dd/yyyy}", Convert.ToDateTime(reader("YayinTarihi")))
                txtSayfaSayisi.Text = reader("SayfaSayisi").ToString()
                txtSatisFiyati.Text = reader("SatisFiyati").ToString()
            End While
        End If
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim kitap As Kitaplar = CType(lstKitaplar.SelectedItem, Kitaplar)

        kitap.Id = kitap.Id
        kitap.KitapAdi = txtKitapAdi.Text
        kitap.YayinTarihi = Convert.ToDateTime(txtYayinTarihi.Text)
        kitap.SayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text)

        Dim secilenYayinEvi As YayinEvi = CType(cbYayinEviID.SelectedItem, YayinEvi)
        kitap.YayinEviID = secilenYayinEvi.Id

        kitap.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text)

        kpDal.Update(kitap)

        MessageBox.Show("Kitabınız Başarıyla Güncellenmiştir ...")

        txtKitapAdi.Clear()
        txtYayinTarihi.Clear()
        txtSayfaSayisi.Clear()
        cbYayinEviID.SelectedIndex = 0
        txtSatisFiyati.Clear()

        lstKitaplar.DataSource = kpDal.List()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class