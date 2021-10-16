Public Class AdresListele

    Private Sub AdresListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Dim adDal As AdreslerDal = New AdreslerDal

    Private Sub Fill()
        lstwAdresler.Items.Clear()

        Dim adresler As List(Of Adresler) = adDal.List

        For Each ad As Adresler In adresler
            Dim li As ListViewItem = New ListViewItem
            li.Tag = ad
            li.Text = ad.Id.ToString
            li.SubItems.Add(ad.Cadde)
            li.SubItems.Add(ad.Sokak)
            li.SubItems.Add(ad.Mahalle)
            li.SubItems.Add(ad.BinaNo.ToString)
            li.SubItems.Add(ad.Kat.ToString)
            li.SubItems.Add(ad.DaireNo.ToString)
            li.SubItems.Add(ad.Ilce)
            li.SubItems.Add(ad.Il)
            li.SubItems.Add(ad.PostaKodu)
            lstwAdresler.Items.Add(li)
        Next
        ToolStripStatusLabelVeriler.Text = (lstwAdresler.Items.Count.ToString() + " adet adresiniz listelenmiştir ...")
    End Sub
End Class