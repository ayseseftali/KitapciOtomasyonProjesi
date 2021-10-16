Public Class MusterileriListele

    Dim msDal As MusterilerDal = New MusterilerDal
    Private Sub MusterileriListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Private Sub Fill()
        lstwMusteriler.Items.Clear()

        Dim musteriler As List(Of Musteriler) = msDal.List()

        For Each ms As Musteriler In musteriler
            Dim li As ListViewItem = New ListViewItem
            li.Tag = ms
            li.Text = ms.Id.ToString

            li.SubItems.Add(ms.MusteriAdi)
            li.SubItems.Add(ms.MusteriSoyadi)
            li.SubItems.Add(ms.MusteriCinsiyet)
            li.SubItems.Add(ms.MusteriEPosta)
            li.SubItems.Add(ms.MusteriTelefon)

            lstwMusteriler.Items.Add(li)
        Next
        toolStripStatusLabelVeriler.Text = lstwMusteriler.Items.Count.ToString() + " adet müşteriniz listelenmiştir..."
    End Sub

End Class