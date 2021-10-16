Imports System.Data.SqlClient

Public Class CalisanEkle

    Private Sub CalisanEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbCinsiyet.SelectedIndex = 0
        SubeFill()
        AdresFill()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub SubeFill()
        cbSubeSec.Items.Clear()

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select * From Subeler", cnn)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim sb As Subeler = New Subeler
                sb.Id = Convert.ToInt32(reader("SubeID").ToString())
                sb.SubeAdi = reader("SubeAdi").ToString()
                sb.AdresID = Convert.ToInt32(reader("AdresID").ToString())

                cbSubeSec.Items.Add(sb)
            End While
        End If

        cbSubeSec.SelectedIndex = 0
        reader.Close()
        cnn.Close()

    End Sub

    Private Sub AdresFill()
        cbAdresID.Items.Clear()

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select * From Adresler", cnn)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim ad As Adresler = New Adresler
                ad.Id = Convert.ToInt32(reader("AdresID").ToString())
                ad.Il = reader("Il").ToString()
                ad.Ilce = reader("Ilce").ToString()

                cbAdresID.Items.Add(ad)
            End While
        End If
        cbAdresID.SelectedIndex = 0
        reader.Close()
        cnn.Close()
    End Sub

    Dim fotoAdresi As String = ""

    Private Sub btnResimEkle_Click(sender As Object, e As EventArgs) Handles btnResimEkle.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*"
            dlg.Title = "Çalışan Resmi Seçimi"
            If dlg.ShowDialog() = DialogResult.OK Then
                fotoAdresi = dlg.FileName.ToString()
                pbFoto.ImageLocation = fotoAdresi
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Dim calisan As Calisanlar = New Calisanlar
        calisan.CalisanAd = txtAd.Text
        calisan.CalisanSoyad = txtSoyad.Text
        calisan.Cinsiyet = cbCinsiyet.Text
        calisan.Telefon = mtxtTelefon.Text
        calisan.Eposta = txtEposta.Text
        calisan.Pozisyon = txtPozisyon.Text
        Dim secilenAdres As Adresler = CType(cbAdresID.SelectedItem, Adresler)
        calisan.AdresID = secilenAdres.Id
        Dim secilenSube As Subeler = CType(cbSubeSec.SelectedItem, Subeler)
        calisan.SubeID = secilenSube.Id
        Dim dosyaAdi As String = (Guid.NewGuid.ToString.Substring(0, 6).ToUpper + ".jpg")
        ' Fotoraf ismim _ifrelenmi_ olarak 6 karakter b�y�k + .jpg uzant1l1 gelecektir ... (�r : L13E12.jpg)
        If (Not (pbFoto.Image) Is Nothing) Then
            Dim savePath As String = ("..\..\Images\" + dosyaAdi)
            pbFoto.Image.Save(savePath)
            calisan.Fotograf = savePath
        Else
            MessageBox.Show("Lütfen Forma Bir Fotoraf Sürükleyiniz !!!")
            Return
        End If

        calisan.Sifre = txtSifre.Text
        Dim clDal As CalisanlarDal = New CalisanlarDal
        clDal.Save(calisan)
        MessageBox.Show("Verileriniz Başarıyla Kaydedilmiştir ...")
        txtAd.Clear()
        txtSoyad.Text = ""
        cbCinsiyet.SelectedIndex = 0
        mtxtTelefon.Clear()
        txtEposta.Clear()
        txtPozisyon.Clear()
        cbAdresID.SelectedIndex = 0
        cbSubeSec.SelectedIndex = 0
        pbFoto.Image = Nothing
        txtSifre.Clear()
    End Sub

    Private Sub btnYeniAdresEkle_Click(sender As Object, e As EventArgs) Handles btnYeniAdresEkle.Click
        Me.Close()
        Dim yeniAdresler As AdresEkle = New AdresEkle
        yeniAdresler.Show()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class