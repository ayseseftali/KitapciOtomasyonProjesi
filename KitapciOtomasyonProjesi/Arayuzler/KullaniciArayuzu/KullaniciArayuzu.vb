Imports System.Data.SqlClient

Public Class KullaniciArayuzu

    Dim kpDal As KitaplarDal = New KitaplarDal
    Private Sub KullaniciArayuzu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Private Sub Fill()
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

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd, cmd2 As SqlCommand
    Private reader As SqlDataReader

    Private Sub txtKitapAra_TextChanged(sender As Object, e As EventArgs) Handles txtKitapAra.TextChanged
        lstwKitaplar.Items.Clear()

        cmd = New SqlCommand("Select * From Kitaplar where KitapAdi Like '%" + txtKitapAra.Text + "%'", cnn)

        Dim kitaplar As List(Of Kitaplar) = New List(Of Kitaplar)

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

        cmd2 = New SqlCommand("Select Adet From KitaplarSubeler where KitapID = (Select KİtapID From Kitaplar where KitapID = @id)", cnn)
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
                    sayac = (sayac + 1)
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
        txtCadde.Clear()
        txtSokak.Clear()
        txtMahalle.Clear()
        txtBinaNo.Clear()
        txtKat.Clear()
        txtDaireNo.Clear()
        txtIlce.Clear()
        txtIl.Clear()
        txtPostaKodu.Clear()

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

    Private Sub KategoriGetir()
        lstKategoriler.Items.Clear()

        Dim seciliurun As ListViewItem = CType(lstwKitaplar.SelectedItems(0), ListViewItem)
        Dim seciliurunID As Integer = Convert.ToInt32(seciliurun.SubItems(0).Text)
        cmd = New SqlCommand("Select KategoriAdi From Kategoriler where KategoriID in(Select KategoriID From KitaplarKategoriler where KitapID = (Select KitapID From Kitaplar where KİtapID = @id))", cnn)
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

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Me.Close()
    End Sub
End Class