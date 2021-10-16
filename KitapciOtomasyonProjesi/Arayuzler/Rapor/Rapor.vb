Imports System.Data.SqlClient

Public Class Rapor

    Private Sub Rapor_Load(sender As Object, e As EventArgs) Handles MyBase.Load      
        SubeFiil()
        KitapFill()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd, cmd2 As SqlCommand
    Private reader, reader2 As SqlDataReader
    Private Sub SubeFiil()
        cbSube.Items.Clear()

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

                cbSube.Items.Add(sb)
            End While
        End If

        cbSube.SelectedIndex = 0
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub KitapFill()
        cbKitap.Items.Clear()

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select * From Kitaplar", cnn)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim kp As Kitaplar = New Kitaplar
                kp.Id = Convert.ToInt32(reader("KitapID").ToString())
                kp.KitapAdi = reader("KitapAdi").ToString()
                kp.YayinEviID = Convert.ToInt32(reader("YayinEviID").ToString())

                cbKitap.Items.Add(kp)
            End While
        End If

        cbKitap.SelectedIndex = 0
        reader.Close()
        cnn.Close()
    End Sub

    Dim satislar As List(Of Satis) = New List(Of Satis)
    Dim RaporlananToplamTutar As Double = 0
    Dim RaporlananSatisSayisi As Integer = 0
    Dim RaporlananMusteriSayisi As Integer = 0
    Dim RaporlananMusteriID As Integer = 0
   
    Private Sub btnTarihSR_Click(sender As Object, e As EventArgs) Handles btnTarihSR.Click
        lstwRaporlar.Items.Clear()
        satislar.Clear()
        RaporlananToplamTutar = 0
        RaporlananSatisSayisi = 0
        RaporlananMusteriSayisi = 0
        RaporlananMusteriID = 0

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select * From Satis where Format(SatisTarihi, 'yyyy-MM-dd') = @SatisTarihi", cnn)
        cmd.Parameters.AddWithValue("@SatisTarihi", Format(Convert.ToDateTime(dateSatisTarihi.Text), "yyyy-MM-dd").ToString())
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim st As Satis = New Satis
                st.Id = Convert.ToInt32(reader("SatisID").ToString())
                st.KitapID = Convert.ToInt32(reader("KitapID").ToString())
                st.MusteriID = Convert.ToInt32(reader("MusteriID").ToString())
                st.SatisSayisi = Convert.ToInt32(reader("SatisSayisi").ToString())
                st.SatisTarihi = Convert.ToDateTime(reader("SatisTarihi").ToString())
                st.SubeID = Convert.ToInt32(reader("SubeID").ToString())
                st.ToplamTutar = Convert.ToDecimal(reader("ToplamTutar").ToString())

                satislar.Add(st)
            End While
        End If

        For Each satis As Satis In satislar
            Dim li As ListViewItem = New ListViewItem
            li.Tag = satis
            li.Text = satis.Id.ToString

            li.SubItems.Add(satis.SubeID.ToString)
            li.SubItems.Add(satis.KitapID.ToString)
            li.SubItems.Add(satis.MusteriID.ToString)
            li.SubItems.Add(satis.SatisSayisi.ToString)
            li.SubItems.Add(satis.SatisTarihi.ToString)
            li.SubItems.Add(satis.ToplamTutar.ToString)

            RaporlananToplamTutar += Convert.ToDouble(satis.ToplamTutar)
            RaporlananSatisSayisi += Convert.ToInt32(satis.SatisSayisi)

            If RaporlananMusteriID.ToString() <> satis.MusteriID.ToString() Then
                RaporlananMusteriSayisi += 1
            End If

            RaporlananMusteriID = Convert.ToInt32(satis.MusteriID)
            lstwRaporlar.Items.Add(li)
        Next

        reader.Close()
        cnn.Close()

        txtToplamTutar.Text = RaporlananToplamTutar.ToString()
        txtSatisSayisi.Text = RaporlananSatisSayisi.ToString()
        txtMusteriSayisi.Text = RaporlananMusteriSayisi.ToString()
    End Sub

    Dim subelerID As Integer = 0
    Private Sub btnSubeSR_Click(sender As Object, e As EventArgs) Handles btnSubeSR.Click
        lstwRaporlar.Items.Clear()
        satislar.Clear()
        RaporlananToplamTutar = 0
        RaporlananSatisSayisi = 0
        RaporlananMusteriSayisi = 0
        RaporlananMusteriID = 0

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select SubeID From Subeler where SubeAdi = @SubeAdi", cnn)
        cmd.Parameters.AddWithValue("@SubeAdi", cbSube.Text)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                subelerID = Convert.ToInt32(reader("SubeID").ToString())
            End While
        End If

        reader.Close()

        cmd2 = New SqlCommand("Select * From Satis where SubeID = @SubeID", cnn)
        cmd2.Parameters.AddWithValue("@SubeID", subelerID)
        reader2 = cmd2.ExecuteReader()

        If reader2.HasRows Then
            While reader2.Read
                Dim st As Satis = New Satis
                st.Id = Convert.ToInt32(reader2("SatisID").ToString())
                st.KitapID = Convert.ToInt32(reader2("KitapID").ToString())
                st.MusteriID = Convert.ToInt32(reader2("MusteriID").ToString())
                st.SatisSayisi = Convert.ToInt32(reader2("SatisSayisi").ToString())
                st.SatisTarihi = Convert.ToDateTime(reader2("SatisTarihi").ToString())
                st.SubeID = Convert.ToInt32(reader2("SubeID").ToString())
                st.ToplamTutar = Convert.ToDecimal(reader2("ToplamTutar").ToString())

                satislar.Add(st)
            End While
        End If

        For Each satis As Satis In satislar
            Dim li As ListViewItem = New ListViewItem
            li.Tag = satis
            li.Text = satis.Id.ToString

            li.SubItems.Add(satis.SubeID.ToString)
            li.SubItems.Add(satis.KitapID.ToString)
            li.SubItems.Add(satis.MusteriID.ToString)
            li.SubItems.Add(satis.SatisSayisi.ToString)
            li.SubItems.Add(satis.SatisTarihi.ToString)
            li.SubItems.Add(satis.ToplamTutar.ToString)

            RaporlananToplamTutar += Convert.ToDouble(satis.ToplamTutar)
            RaporlananSatisSayisi += Convert.ToInt32(satis.SatisSayisi)

            If RaporlananMusteriID.ToString() <> satis.MusteriID.ToString() Then
                RaporlananMusteriSayisi += 1
            End If

            RaporlananMusteriID = Convert.ToInt32(satis.MusteriID)
            lstwRaporlar.Items.Add(li)
        Next

        reader2.Close()
        cnn.Close()

        txtToplamTutar.Text = RaporlananToplamTutar.ToString()
        txtSatisSayisi.Text = RaporlananSatisSayisi.ToString()
        txtMusteriSayisi.Text = RaporlananMusteriSayisi.ToString()
    End Sub

    Dim kitaplarID As Integer = 0
    Private Sub btnKitapSR_Click(sender As Object, e As EventArgs) Handles btnKitapSR.Click
        lstwRaporlar.Items.Clear()
        satislar.Clear()
        RaporlananToplamTutar = 0
        RaporlananSatisSayisi = 0
        RaporlananMusteriSayisi = 0
        RaporlananMusteriID = 0

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select KitapID From Kitaplar where KitapAdi = @KitapAdi", cnn)
        cmd.Parameters.AddWithValue("@KitapAdi", cbKitap.Text)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                kitaplarID = Convert.ToInt32(reader("KitapID").ToString())
            End While
        End If

        reader.Close()

        cmd2 = New SqlCommand("Select * From Satis where KitapID = @KitapID", cnn)
        cmd2.Parameters.AddWithValue("@KitapID", kitaplarID)
        reader2 = cmd2.ExecuteReader()

        If reader2.HasRows Then
            While reader2.Read
                Dim st As Satis = New Satis
                st.Id = Convert.ToInt32(reader2("SatisID").ToString())
                st.KitapID = Convert.ToInt32(reader2("KitapID").ToString())
                st.MusteriID = Convert.ToInt32(reader2("MusteriID").ToString())
                st.SatisSayisi = Convert.ToInt32(reader2("SatisSayisi").ToString())
                st.SatisTarihi = Convert.ToDateTime(reader2("SatisTarihi").ToString())
                st.SubeID = Convert.ToInt32(reader2("SubeID").ToString())
                st.ToplamTutar = Convert.ToDecimal(reader2("ToplamTutar").ToString())

                satislar.Add(st)
            End While
        End If

        For Each satis As Satis In satislar
            Dim li As ListViewItem = New ListViewItem
            li.Tag = satis
            li.Text = satis.Id.ToString

            li.SubItems.Add(satis.SubeID.ToString)
            li.SubItems.Add(satis.KitapID.ToString)
            li.SubItems.Add(satis.MusteriID.ToString)
            li.SubItems.Add(satis.SatisSayisi.ToString)
            li.SubItems.Add(satis.SatisTarihi.ToString)
            li.SubItems.Add(satis.ToplamTutar.ToString)

            RaporlananToplamTutar += Convert.ToDouble(satis.ToplamTutar)
            RaporlananSatisSayisi += Convert.ToInt32(satis.SatisSayisi)

            If RaporlananMusteriID.ToString() <> satis.MusteriID.ToString() Then
                RaporlananMusteriSayisi += 1
            End If

            RaporlananMusteriID = Convert.ToInt32(satis.MusteriID)
            lstwRaporlar.Items.Add(li)
        Next

        reader2.Close()
        cnn.Close()

        txtToplamTutar.Text = RaporlananToplamTutar.ToString()
        txtSatisSayisi.Text = RaporlananSatisSayisi.ToString()
        txtMusteriSayisi.Text = RaporlananMusteriSayisi.ToString()
    End Sub
End Class