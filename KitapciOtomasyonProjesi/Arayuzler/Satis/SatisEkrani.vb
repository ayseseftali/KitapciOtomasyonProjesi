Imports System.Data.SqlClient

Public Class SatisEkrani
    Dim stDal As SatisDal = New SatisDal()
    Private Sub SatisEkrani_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
        SubeFiil()
        MusteriFill()
        KitapFill()
    End Sub

    Private Sub Fill()
        lstwSatislar.Items.Clear()

        Dim satislar As List(Of Satis) = stDal.List()

        For Each st As Satis In satislar
            Dim li As ListViewItem = New ListViewItem
            li.Tag = st
            li.Text = st.Id.ToString

            li.SubItems.Add(st.SubeID.ToString)
            li.SubItems.Add(st.KitapID.ToString)
            li.SubItems.Add(st.MusteriID.ToString)          
            li.SubItems.Add(st.SatisSayisi.ToString)
            li.SubItems.Add(st.SatisTarihi.ToString)           
            li.SubItems.Add(st.ToplamTutar.ToString)


            lstwSatislar.Items.Add(li)
        Next
        ToolStripStatusLabelVeriler.Text = lstwSatislar.Items.Count.ToString() + " adet satış listelenmiştir ..."
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub SubeFiil()
        cbSubeID.Items.Clear()

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

                cbSubeID.Items.Add(sb)
            End While
        End If

        cbSubeID.SelectedIndex = 0
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub MusteriFill()
        cbMusteriID.Items.Clear()

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select * From Musteriler", cnn)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim ms As Musteriler = New Musteriler
                ms.Id = Convert.ToInt32(reader("MusteriID").ToString())
                ms.MusteriAdi = reader("MusteriAdi").ToString()
                ms.MusteriSoyadi = reader("MusteriSoyadi").ToString()

                cbMusteriID.Items.Add(ms.Id.ToString())
            End While
        End If

        cbMusteriID.SelectedIndex = 0
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub KitapFill()
        cbKitapID.Items.Clear()

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

                cbKitapID.Items.Add(kp)
            End While
        End If

        cbKitapID.SelectedIndex = 0
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub cbKitapID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKitapID.SelectedIndexChanged
        txtFiyat.Text = ""
        reader.Close()
        cnn.Close()

        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        Dim seciliKitap As Kitaplar = CType(cbKitapID.SelectedItem, Kitaplar)
        Dim secilenId As Integer = seciliKitap.Id

        cmd = New SqlCommand("Select * From Kitaplar Where KitapID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilenId)

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                Dim kp As Kitaplar = New Kitaplar
                kp.Id = Convert.ToInt32(reader("KitapID").ToString())
                kp.KitapAdi = reader("KitapAdi").ToString()
                kp.YayinEviID = Convert.ToInt32(reader("YayinEviID").ToString())
                kp.SatisFiyati = Convert.ToDecimal(reader("SatisFiyati").ToString())

                txtFiyat.Text = kp.SatisFiyati.ToString()
            End While
        End If

        reader.Close()
        cnn.Close()
    End Sub

    'Dim dgwSatisID As Integer = 1
    Private Sub btnSatisEkle_Click(sender As Object, e As EventArgs) Handles btnSatisEkle.Click       
        If (txtSatisSayisi.Text = "") Then
            MessageBox.Show("Lütfen tüm alanları doldurunuz !!!")
            Return
        End If

        'Do While (dgwSatisID < dgwSatisListesi.Rows.Count)
        '    If dgwSatisID <> dgwSatisListesi.Rows(dgwSatisID).Cells(0).Value Then
        '        Exit Do
        '    End If

        '    dgwSatisID = dgwSatisID + 1
        'Loop

        dgwSatisListesi.Rows.Add(New String() {cbSubeID.Text, cbKitapID.Text, txtSatisSayisi.Text, dateSatisTarihi.Text, txtFiyat.Text, cbMusteriID.Text})
    End Sub

    Dim dgwSelectRow As Integer = -1
    Private Sub btnSatisGuncelle_Click(sender As Object, e As EventArgs) Handles btnSatisGuncelle.Click

        If (dgwSelectRow = -1) Then
            MessageBox.Show("Lütfen Güncellemek Veya Silmek İstediğiniz Kitabı ListBox'tan Seçiniz !!!")
            Return
        End If

        dgwSatisListesi.Rows.RemoveAt(Convert.ToInt32(dgwSatisListesi.CurrentCell.RowIndex))

        If (cbKitapID Is Nothing OrElse cbMusteriID Is Nothing OrElse cbSubeID Is Nothing OrElse txtSatisSayisi Is Nothing OrElse txtFiyat Is Nothing) Then
            MessageBox.Show("Lütfen tüm alanları doldurunuz !!!")
            Return
        End If

        dgwSatisListesi.Rows.Add(New String() {cbSubeID.Text, cbKitapID.Text, txtSatisSayisi.Text, dateSatisTarihi.Text, txtFiyat.Text, cbMusteriID.Text})

    End Sub

    Private Sub btnSatisSil_Click(sender As Object, e As EventArgs) Handles btnSatisSil.Click
        If (dgwSelectRow = -1) Then
            MessageBox.Show("Lütfen Güncellemek Veya Silmek İstediğiniz Kitabı ListBox'tan Seçiniz !!!")
            Return
        End If

        dgwSatisListesi.Rows.RemoveAt(Convert.ToInt32(dgwSatisListesi.CurrentCell.RowIndex))
    End Sub

    Private Sub btnSatinAl_Click(sender As Object, e As EventArgs) Handles btnSatinAl.Click
        Dim stDal As SatisDal = New SatisDal
        Dim satislar As Satis = New Satis
        Dim rowsCount As Integer = dgwSatisListesi.Rows.Count - 1
        Dim index As Integer = 0

        If rowsCount = -1 Then
            Return
        End If

        Do While (index < rowsCount)

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            cmd = New SqlCommand("Select * From Subeler where SubeAdi = @SubeAdi", cnn)
            cmd.Parameters.AddWithValue("@SubeAdi", dgwSatisListesi.Rows(index).Cells(0).Value)
            reader = cmd.ExecuteReader()

            Dim sb As Subeler = New Subeler
            If reader.HasRows Then
                While reader.Read
                    sb.Id = Convert.ToInt32(reader("SubeID").ToString())
                End While
            End If

            reader.Close()
            cnn.Close()

            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            cmd = New SqlCommand("Select * From Kitaplar where KitapAdi = @KitapAdi", cnn)
            cmd.Parameters.AddWithValue("@KitapAdi", dgwSatisListesi.Rows(index).Cells(1).Value)
            reader = cmd.ExecuteReader()

            Dim kp As Kitaplar = New Kitaplar
            If reader.HasRows Then
                While reader.Read
                    kp.Id = Convert.ToInt32(reader("KitapID").ToString())
                End While
            End If

            reader.Close()
            cnn.Close()

            satislar.SubeID = Convert.ToInt32(sb.Id.ToString())
            satislar.KitapID = Convert.ToInt32(kp.Id.ToString())
            satislar.SatisSayisi = Convert.ToInt32(dgwSatisListesi.Rows(index).Cells(2).Value)
            satislar.SatisTarihi = Convert.ToDateTime(dgwSatisListesi.Rows(index).Cells(3).Value)
            satislar.ToplamTutar = Convert.ToDecimal(dgwSatisListesi.Rows(index).Cells(4).Value)
            satislar.MusteriID = Convert.ToInt32(dgwSatisListesi.Rows(index).Cells(5).Value)

            stDal.Save(satislar)
            index = (index + 1)
        Loop

        Fill()
    End Sub

    Private Sub dgwSatisListesi_SelectionChanged(sender As Object, e As EventArgs) Handles dgwSatisListesi.SelectionChanged
        Dim dgwselect As DataGridViewSelectedRowCollection = dgwSatisListesi.SelectedRows
        dgwSelectRow = Convert.ToInt32(dgwSatisListesi.CurrentCell.RowIndex)
        If dgwselect.Count <> 0 Then
            cbSubeID.Text = dgwselect.Item(0).Cells(0).Value
            cbKitapID.Text = dgwselect.Item(0).Cells(1).Value
            txtSatisSayisi.Text = dgwselect.Item(0).Cells(2).Value
            dateSatisTarihi.Text = dgwselect.Item(0).Cells(3).Value
            txtFiyat.Text = dgwselect.Item(0).Cells(4).Value
            cbMusteriID.Text = dgwselect.Item(0).Cells(5).Value
        End If

    End Sub
End Class