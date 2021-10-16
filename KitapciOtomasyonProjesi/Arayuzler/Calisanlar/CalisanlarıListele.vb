Imports System.Data.SqlClient

Public Class CalisanlarıListele
    Private Sub CalisanlarıListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Dim clDal As CalisanlarDal = New CalisanlarDal

    Private Sub Fill()
        lstwCalisanlar.Items.Clear()

        Dim calisanlar As List(Of Calisanlar) = clDal.List()

        For Each cl As Calisanlar In calisanlar
            Dim li As ListViewItem = New ListViewItem
            li.Tag = cl
            li.Text = cl.Id.ToString

            li.SubItems.Add(cl.CalisanAd)
            li.SubItems.Add(cl.CalisanSoyad)
            li.SubItems.Add(cl.Cinsiyet)
            li.SubItems.Add(cl.Telefon)
            li.SubItems.Add(cl.Eposta)
            li.SubItems.Add(cl.Pozisyon)
            li.SubItems.Add(cl.AdresID.ToString())
            li.SubItems.Add(cl.SubeID.ToString())
            li.SubItems.Add(cl.Sifre)

            lstwCalisanlar.Items.Add(li)
        Next
        toolStripStatusLabelVeriler.Text = lstwCalisanlar.Items.Count.ToString() + " adet çalışanınız listelenmiştir ..."
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Dim str As String

    Private Sub lstwCalisanlar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstwCalisanlar.SelectedIndexChanged
        If lstwCalisanlar.SelectedItems.Count > 0 Then
            Dim seciliurun As ListViewItem = CType(lstwCalisanlar.SelectedItems(0), ListViewItem)
            Dim seciliurunID As Integer = Convert.ToInt32(seciliurun.SubItems(0).Text)

            cmd = New SqlCommand("cl_calisanlarResim", cnn)
            cmd.Parameters.AddWithValue("@id", seciliurunID.ToString())
            cmd.CommandType = CommandType.StoredProcedure

            Dim calisanlar As List(Of Calisanlar) = New List(Of Calisanlar)

            Try
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If

                reader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read
                        Dim calisan As Calisanlar = New Calisanlar

                        str = reader("Fotograf").ToString()
                    End While
                    pbResim.Image = Image.FromFile(str)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cnn.Close()
            End Try
        End If
    End Sub
End Class