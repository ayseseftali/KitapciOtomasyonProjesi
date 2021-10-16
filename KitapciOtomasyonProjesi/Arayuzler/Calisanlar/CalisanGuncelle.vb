Imports System.Data.SqlClient

Public Class CalisanGuncelle
    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub CalisanGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalisanlarFill()

        cbCinsiyet.SelectedIndex = 0
        SubeFill()
        AdresFill()
    End Sub

    Dim clDal As CalisanlarDal = New CalisanlarDal

    Private Sub CalisanlarFill()
        lstCalisanlar.Items.Clear()
        lstCalisanlar.DataSource = clDal.List()
    End Sub

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

    Dim str As String = ""

    Private Sub lstCalisanlar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCalisanlar.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If (lstCalisanlar.SelectedItem Is Nothing) Then
            MessageBox.Show("Lütfen Güncellemek İstediğiniz Ürünü ListBox'tan Seçiniz !!!")
            Return
        End If

        Dim seciliKategori As Calisanlar = CType(lstCalisanlar.SelectedItem, Calisanlar)
        Dim secilenId As Integer = seciliKategori.Id

        cmd = New SqlCommand("Select * From Calisanlar Where CalisanID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilenId)

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                txtAd.Text = reader("CalisanAd").ToString()
                txtSoyad.Text = reader("CalisanSoyad").ToString()
                cbCinsiyet.Text = reader("Cinsiyet").ToString()
                mtxtTelefon.Text = reader("Telefon").ToString()
                txtEposta.Text = reader("EPosta").ToString()
                txtPozisyon.Text = reader("Pozisyon").ToString()

                str = reader("Fotograf").ToString()
                txtSifre.Text = reader("Sifre").ToString()
            End While
            pbFoto.Image = Image.FromFile(str)
        End If
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim calisan As Calisanlar = CType(lstCalisanlar.SelectedItem, Calisanlar)

        calisan.Id = calisan.Id
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

        Dim dosyaAdi As String = Guid.NewGuid().ToString().Substring(0, 6).ToUpper() + ".jpg"
        'Fotograf ismim şifrelenmiş olarak 6 karakter büyük + .jpg uzantılı gelecektir ... (ör: L13E12.jpg)

        If (Not (pbFoto.Image) Is Nothing) Then
            Dim savePath As String = "..\\..\\Images\\" + dosyaAdi

            pbFoto.Image.Save(savePath)
            calisan.Fotograf = savePath
        Else
            MessageBox.Show("Lütfen Forma Bir Fotoğraf Sürükleyiniz !!!")
            Return
        End If
        calisan.Sifre = txtSifre.Text

        clDal.Update(calisan)

        MessageBox.Show("Verileriniz Başarıyla Güncellenmiştir ...")

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
        Dim yeniAdresEkle As AdresEkle = New AdresEkle
        yeniAdresEkle.Show()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class