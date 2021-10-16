Imports System.Data.SqlClient

Public Class YöneticiArayuzu

    Dim clDal As CalisanlarDal = New CalisanlarDal
    Dim kpDal As KitaplarDal = New KitaplarDal

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd, cmd2 As SqlCommand
    Private reader As SqlDataReader

    Private Sub YöneticiArayuzu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalisanFill()

        KitapFill()
    End Sub

    Private Sub KitapFill()
        lstwKitaplar.Items.Clear()

        Dim kitaplar As List(Of Kitaplar) = kpDal.List

        For Each kp As Kitaplar In kitaplar
            Dim li As ListViewItem = New ListViewItem

            li.Tag = kp
            li.Text = kp.Id.ToString()

            li.SubItems.Add(kp.KitapAdi)
            li.SubItems.Add(kp.YayinTarihi.ToString())
            li.SubItems.Add(kp.SayfaSayisi.ToString())
            li.SubItems.Add(kp.YayinEviID.ToString())
            li.SubItems.Add(kp.SatisFiyati.ToString())

            lstwKitaplar.Items.Add(li)

        Next
    End Sub

    Private Sub CalisanFill()
        lstwCalisanlar.Items.Clear()

        Dim calisanlar As List(Of Calisanlar) = clDal.List

        For Each cl As Calisanlar In calisanlar
            Dim li As ListViewItem = New ListViewItem

            li.Tag = cl
            li.Text = cl.Id.ToString()

            li.SubItems.Add(cl.CalisanAd)
            li.SubItems.Add(cl.CalisanSoyad)
            li.SubItems.Add(cl.Cinsiyet)
            li.SubItems.Add(cl.Telefon)
            li.SubItems.Add(cl.Eposta)
            li.SubItems.Add(cl.Pozisyon)
            li.SubItems.Add(cl.AdresID.ToString())
            li.SubItems.Add(cl.SubeID.ToString())


            lstwCalisanlar.Items.Add(li)
        Next

    End Sub

    Private Sub lstwCalisanlar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstwCalisanlar.SelectedIndexChanged
        If lstwCalisanlar.SelectedItems.Count > 0 Then
            CalisanGetir()

            CalisanAdresGetir()

            CalisanSubeGetir()
        End If
    End Sub

    Private Sub CalisanSubeGetir()
        txtSubeCadde.Clear()
        txtSubeSokak.Clear()
        txtSubeMahalle.Clear()
        txtSubeBinaNo.Clear()
        txtSubeKat.Clear()
        txtSubeDaireNo.Clear()
        txtSubeIlce.Clear()
        txtSubeIl.Clear()
        txtSubePostaKodu.Clear()
        txtSubeAdi.Clear()

        Dim secilicalisan As ListViewItem = CType(lstwCalisanlar.SelectedItems(0), ListViewItem)
        Dim secilicalisanID As Integer = Convert.ToInt32(secilicalisan.SubItems(0).Text)
        cmd = New SqlCommand("Select * From Adresler where AdresID in(Select AdresID From Subeler where SubeID = (Select SubeID From Calisanlar where CalisanID = @id))", cnn)
        cmd.Parameters.AddWithValue("@id", secilicalisanID.ToString())

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    txtSubeCadde.Text = reader("Cadde").ToString()
                    txtSubeSokak.Text = reader("Sokak").ToString()
                    txtSubeMahalle.Text = reader("Mahalle").ToString()
                    txtSubeBinaNo.Text = reader("BinaNo").ToString()
                    txtSubeKat.Text = reader("Kat").ToString()
                    txtSubeDaireNo.Text = reader("DaireNo").ToString()
                    txtSubeIlce.Text = reader("Ilce").ToString()
                    txtSubeIl.Text = reader("Il").ToString()
                    txtSubePostaKodu.Text = reader("PostaKodu").ToString()
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        cmd2 = New SqlCommand("Select * From Subeler where SubeID in(Select SubeID From Calisanlar where CalisanID = @id)", cnn)
        cmd2.Parameters.AddWithValue("@id", secilicalisanID.ToString())

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd2.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    txtSubeAdi.Text = reader("SubeAdi").ToString()
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CalisanAdresGetir()
        txtCadde.Clear()
        txtSokak.Clear()
        txtMahalle.Clear()
        txtBinaNo.Clear()
        txtKat.Clear()
        txtDaireNo.Clear()
        txtIlce.Clear()
        txtIl.Clear()
        txtPostaKodu.Clear()

        Dim secilicalisan As ListViewItem = CType(lstwCalisanlar.SelectedItems(0), ListViewItem)
        Dim secilicalisanID As Integer = Convert.ToInt32(secilicalisan.SubItems(0).Text)
        cmd = New SqlCommand("Select * From Adresler where AdresID in(Select AdresID From Calisanlar where CalisanID = @id)", cnn)
        cmd.Parameters.AddWithValue("@id", secilicalisanID.ToString())

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    txtCadde.Text = reader("Cadde").ToString()
                    txtSokak.Text = reader("Sokak").ToString()
                    txtMahalle.Text = reader("Mahalle").ToString()
                    txtBinaNo.Text = reader("BinaNo").ToString()
                    txtKat.Text = reader("Kat").ToString()
                    txtDaireNo.Text = reader("DaireNo").ToString()
                    txtIlce.Text = reader("Ilce").ToString()
                    txtIl.Text = reader("Il").ToString()
                    txtPostaKodu.Text = reader("PostaKodu").ToString()
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub


    Dim str As String

    Private Sub txtCalisanAra_TextChanged(sender As Object, e As EventArgs) Handles txtCalisanAra.TextChanged
        lstwCalisanlar.Items.Clear()

        cmd = New SqlCommand("Select * From Calisanlar where CalisanAd Like '%" + txtCalisanAra.Text + "%'", cnn)

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim li As ListViewItem = New ListViewItem

                li.Text = reader("CalisanID").ToString()

                li.SubItems.Add(reader("CalisanAd").ToString())
                li.SubItems.Add(reader("CalisanSoyad").ToString())
                li.SubItems.Add(reader("Cinsiyet").ToString())
                li.SubItems.Add(reader("Telefon").ToString())
                li.SubItems.Add(reader("EPosta").ToString())
                li.SubItems.Add(reader("Pozisyon").ToString())
                li.SubItems.Add(reader("AdresID").ToString())
                li.SubItems.Add(reader("SubeID").ToString())

                lstwCalisanlar.Items.Add(li)
            End While
        End If
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        CalisanFill()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Dim yeniCalisanSil As CalisanSil = New CalisanSil
        yeniCalisanSil.Show()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim yeniCalisanGuncelle As CalisanGuncelle = New CalisanGuncelle
        yeniCalisanGuncelle.Show()
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        Dim yeniCalisanEkle As CalisanEkle = New CalisanEkle
        yeniCalisanEkle.Show()
    End Sub

    Private Sub CalisanGetir()
        txtAd.Clear()
        txtSoyad.Clear()
        txtCinsiyet.Clear()
        txtEposta.Clear()
        mtxtTelefon.Clear()
        txtPozisyon.Clear()
        pbFoto.Image = Nothing

        Dim secilicalisan As ListViewItem = CType(lstwCalisanlar.SelectedItems(0), ListViewItem)
        Dim secilicalisanID As Integer = Convert.ToInt32(secilicalisan.SubItems(0).Text)
        cmd = New SqlCommand("Select * From Calisanlar where CalisanID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilicalisanID.ToString())

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    txtAd.Text = reader("CalisanAd").ToString()
                    txtSoyad.Text = reader("CalisanSoyad").ToString()
                    txtCinsiyet.Text = reader("Cinsiyet").ToString()
                    txtEposta.Text = reader("EPosta").ToString()
                    mtxtTelefon.Text = reader("Telefon").ToString()
                    txtPozisyon.Text = reader("Pozisyon").ToString()
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        cmd = New SqlCommand("cl_calisanlarResim", cnn)
        cmd.Parameters.AddWithValue("@id", secilicalisanID.ToString())
        cmd.CommandType = CommandType.StoredProcedure

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    str = reader("Fotograf").ToString()
                End While
                pbFoto.Image = Image.FromFile(str)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub lstwKitaplar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstwKitaplar.SelectedIndexChanged
        If lstwKitaplar.SelectedItems.Count > 0 Then
            KategoriGetir()

            YayinEvleriGetir()

            YazarlarGetir()

            SubelerGetir()
        End If
    End Sub

    Private Sub SubelerGetir()
        lstwAdetler.Items.Clear()

        Dim seciliurun As ListViewItem = CType(lstwKitaplar.SelectedItems(0), ListViewItem)
        Dim seciliurunID As Integer = Convert.ToInt32(seciliurun.SubItems(0).Text)
        cmd = New SqlCommand("Select * From Subeler where SubeID in(Select SubeID From KitaplarSubeler where KitapID = (Select KitapID From Kitaplar where KitapID = @id))", cnn)
        cmd.Parameters.AddWithValue("@id", seciliurunID.ToString())

        cmd2 = New SqlCommand("Select Adet From KitaplarSubeler where KitapID = (Select KitapID From Kitaplar where KitapID = @id)", cnn)
        cmd2.Parameters.AddWithValue("@id", seciliurunID.ToString())

        Dim li As ListViewItem = New ListViewItem

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    li.Text = reader("SubeID").ToString()
                    li.SubItems.Add(reader("SubeAdi").ToString())
                    lstwAdetler.Items.Add(li)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd2.ExecuteReader()
            Dim sayac As Integer = 0

            If reader.HasRows Then
                While reader.Read
                    li.SubItems.Add(reader("Adet").ToString())
                    lstwAdetler.Items(sayac).SubItems.Add(li.Text)
                    sayac = sayac + 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub YazarlarGetir()
        lstwYazarlar.Items.Clear()

        Dim seciliurun As ListViewItem = CType(lstwKitaplar.SelectedItems(0), ListViewItem)
        Dim seciliurunID As Integer = Convert.ToInt32(seciliurun.SubItems(0).Text)

        cmd = New SqlCommand("Select * From Yazarlar where YazarID in(Select YazarID From KitaplarYazarlar where KitapID = (Select KitapID From Kitaplar where KitapID = @id))", cnn)
        cmd.Parameters.AddWithValue("@id", seciliurunID.ToString())

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    Dim li As ListViewItem = New ListViewItem

                    li.Text = reader("YazarID").ToString()
                    li.SubItems.Add(reader("YazarAdi").ToString())
                    li.SubItems.Add(reader("YazarSoyadi").ToString())

                    lstwYazarlar.Items.Add(li)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub YayinEvleriGetir()
        txtYayınEviAdi.Clear()
        txtYayinEviCadde.Clear()
        txtYayinEviSokak.Clear()
        txtYayinEviMahalle.Clear()
        txtYayinEviBinaNo.Clear()
        txtYayinEviKat.Clear()
        txtYayinEviDaireNo.Clear()
        txtYayinEviIlce.Clear()
        txtYayinEviIl.Clear()
        txtYayinEviPostaKodu.Clear()

        Dim seciliurun As ListViewItem = CType(lstwKitaplar.SelectedItems(0), ListViewItem)
        Dim seciliurunID As Integer = Convert.ToInt32(seciliurun.SubItems(0).Text)

        cmd = New SqlCommand("Select * From YayinEvleri where YayinEviID in(Select YayinEviID From Kitaplar where KitapID = @id)", cnn)
        cmd.Parameters.AddWithValue("@id", seciliurunID.ToString())

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    txtYayınEviAdi.Text = reader("YayinEviAdi").ToString()
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        cmd2 = New SqlCommand("Select * From Adresler where AdresID in (Select AdresID From YayinEvleri where YayinEviID in (Select YayinEviID From Kitaplar where KitapID = @id))", cnn)
        cmd2.Parameters.AddWithValue("@id", seciliurunID.ToString())

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd2.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    txtYayinEviCadde.Text = reader("Cadde").ToString()
                    txtYayinEviSokak.Text = reader("Sokak").ToString()
                    txtYayinEviMahalle.Text = reader("Mahalle").ToString()
                    txtYayinEviBinaNo.Text = reader("BinaNo").ToString()
                    txtYayinEviKat.Text = reader("Kat").ToString()
                    txtYayinEviDaireNo.Text = reader("DaireNo").ToString()
                    txtYayinEviIlce.Text = reader("Ilce").ToString()
                    txtYayinEviIl.Text = reader("Il").ToString()
                    txtYayinEviPostaKodu.Text = reader("PostaKodu").ToString()
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtKitapAra_TextChanged(sender As Object, e As EventArgs) Handles txtKitapAra.TextChanged
        lstwKitaplar.Items.Clear()

        cmd = New SqlCommand("Select * From Kİtaplar where KitapAdi Like '%" + txtKitapAra.Text + "%'", cnn)

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim li As ListViewItem = New ListViewItem

                li.Text = reader("KitapID").ToString()
                li.SubItems.Add(reader("KitapAdi").ToString())
                li.SubItems.Add(reader("YayinTarihi").ToString())
                li.SubItems.Add(reader("SayfaSayisi").ToString())
                li.SubItems.Add(reader("YayinEviID").ToString())
                li.SubItems.Add(reader("SatisFiyati").ToString())

                lstwKitaplar.Items.Add(li)
            End While
        End If
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnKitapEkle_Click(sender As Object, e As EventArgs) Handles btnKitapEkle.Click
        Dim yeniKitaplarEkle As KitapEkle = New KitapEkle
        yeniKitaplarEkle.Show()
    End Sub

    Private Sub btnKitapGuncelle_Click(sender As Object, e As EventArgs) Handles btnKitapGuncelle.Click
        Dim yeniKitaplarGuncelle As KitapGuncelle = New KitapGuncelle
        yeniKitaplarGuncelle.Show()
    End Sub

    Private Sub btnKitapSil_Click(sender As Object, e As EventArgs) Handles btnKitapSil.Click
        Dim yeniKitaplarSil As KitapSil = New KitapSil
        yeniKitaplarSil.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        KitapFill()
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Me.Close()
    End Sub

    Private Sub btnKategoriyiSil_Click(sender As Object, e As EventArgs) Handles btnKategoriyiSil.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Delete From KitaplarKategoriler where KitapID = @kitapId and KategoriID = (Select KategoriID From Kategoriler where KategoriAdi = @kategoriAdi)", cnn)
        cmd.Parameters.AddWithValue("@kitapId", Convert.ToInt32(lstwKitaplar.SelectedItems(0).Text))
        cmd.Parameters.AddWithValue("@kategoriAdi", lstKategoriler.SelectedItem)

        cmd.ExecuteNonQuery()
        cnn.Close()

        KategoriGetir()
    End Sub

    Private Sub btnKategoriEkle_Click(sender As Object, e As EventArgs) Handles btnKategoriEkle.Click
        My.Settings.KitapId = lstwKitaplar.SelectedItems(0).SubItems(0).Text
        My.Settings.Save()
        Dim yeniKitaplarKategoriler As KitaplarKategoriler = New KitaplarKategoriler
        yeniKitaplarKategoriler.Show()
    End Sub

    Private Sub btnYazariSil_Click(sender As Object, e As EventArgs) Handles btnYazariSil.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Delete From KitaplarYazarlar where KitapID = @kitapId and YazarID = @yazarId", cnn)
        cmd.Parameters.AddWithValue("@kitapId", Convert.ToInt32(lstwKitaplar.SelectedItems(0).Text))
        cmd.Parameters.AddWithValue("@yazarId", Convert.ToInt32(lstwYazarlar.SelectedItems(0).Text))

        cmd.ExecuteNonQuery()

        cnn.Close()

        YazarlarGetir()

    End Sub

    Private Sub btnYazarEkle_Click(sender As Object, e As EventArgs) Handles btnYazarEkle.Click
        My.Settings.KitapId = lstwKitaplar.SelectedItems(0).SubItems(0).Text
        My.Settings.Save()
        Dim yeniKitaplarYazarlar As KitapYazarlar = New KitapYazarlar
        yeniKitaplarYazarlar.Show()
    End Sub

    Private Sub btnSubelereAdetEkle_Click(sender As Object, e As EventArgs) Handles btnSubelereAdetEkle.Click
        My.Settings.KitapId = lstwKitaplar.SelectedItems(0).SubItems(0).Text
        My.Settings.Save()
        Dim yeniKitaplarSubeler As KitaplarŞubeler = New KitaplarŞubeler
        yeniKitaplarSubeler.Show()
    End Sub

    Private Sub btnAdetSayisiniGuncelle_Click(sender As Object, e As EventArgs) Handles btnAdetSayisiniGuncelle.Click
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            cmd = New SqlCommand("Update KitaplarSubeler Set Adet = @adet where ID = (Select ID From KitaplarSubeler where SubeID = @subeId and KitapID = @kitapId)", cnn)
            cmd.Parameters.AddWithValue("@adet", txtAdet.Text)
            cmd.Parameters.AddWithValue("@kitapId", Convert.ToInt32(lstwKitaplar.SelectedItems(0).Text))
            cmd.Parameters.AddWithValue("@SubeId", Convert.ToInt32(lstwAdetler.SelectedItems(0).Text))

            cmd.ExecuteNonQuery()

            cnn.Close()
            SubelerGetir()
        Catch ex As Exception
            MessageBox.Show("Lütfen Kitap Seçiniz - Şube Bilgilerinizi Seçiniz - Adet Giriniz ve Butona Basınız!!!")
        End Try
    End Sub

    Private Sub KategoriGetir()
        lstKategoriler.Items.Clear()
        Dim seciliurun As ListViewItem = CType(lstwKitaplar.SelectedItems(0), ListViewItem)
        Dim seciliurunID As Integer = Convert.ToInt32(seciliurun.SubItems(0).Text)
        cmd = New SqlCommand("Select KategoriAdi From Kategoriler where KategoriID in(Select KategoriID From KitaplarKategoriler where KitapID = (Select KitapID From Kitaplar where KitapID = @id))", cnn)
        cmd.Parameters.AddWithValue("@id", seciliurunID.ToString())

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    lstKategoriler.Items.Add(reader("KategoriAdi").ToString())
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub


End Class