Public Class frmMain

#Region "Linkler"

#Region "GirişEkranı"
    Private Sub KullanıcıGirişiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KullanıcıGirişiToolStripMenuItem.Click
        frmKullaniciGiris.MdiParent = Me
        frmKullaniciGiris.Show()
    End Sub

    Private Sub YöneticiGirişiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YöneticiGirişiToolStripMenuItem.Click
        frmYoneticiGirisi.MdiParent = Me
        frmYoneticiGirisi.Show()
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Application.Exit()
    End Sub

#End Region

#Region "Çalışanlar"
    Private Sub ÇalışanlarıListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇalışanlarıListeleToolStripMenuItem.Click
        CalisanlarıListele.MdiParent = Me
        CalisanlarıListele.Show()
    End Sub

    Private Sub ÇalışanEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇalışanEkleToolStripMenuItem.Click
        CalisanEkle.MdiParent = Me
        CalisanEkle.Show()
    End Sub

    Private Sub ÇalışanGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇalışanGüncelleToolStripMenuItem.Click
        CalisanGuncelle.MdiParent = Me
        CalisanGuncelle.Show()
    End Sub

    Private Sub ÇalışanSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇalışanSilToolStripMenuItem.Click
        CalisanSil.MdiParent = Me
        CalisanSil.Show()
    End Sub

#End Region

#Region "Yazarlar"
    Private Sub YazarlarıListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YazarlarıListeleToolStripMenuItem.Click
        YazarlarListele.MdiParent = Me
        YazarlarListele.Show()

    End Sub

    Private Sub YazarEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YazarEkleToolStripMenuItem.Click
        YazarEkle.MdiParent = Me
        YazarEkle.Show()
    End Sub

    Private Sub YazarGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YazarGüncelleToolStripMenuItem.Click
        YazarGuncelle.MdiParent = Me
        YazarGuncelle.Show()
    End Sub

    Private Sub YazarSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YazarSilToolStripMenuItem.Click
        YazarSil.MdiParent = Me
        YazarSil.Show()
    End Sub
#End Region

#Region "Şubeler"
    Private Sub ŞubeleriListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞubeleriListeleToolStripMenuItem.Click
        SubelerListele.MdiParent = Me
        SubelerListele.Show()
    End Sub

    Private Sub ŞubeEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞubeEkleToolStripMenuItem.Click
        SubeEkle.MdiParent = Me
        SubeEkle.Show()
    End Sub

    Private Sub ŞubeGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞubeGüncelleToolStripMenuItem.Click
        SubeGuncelle.MdiParent = Me
        SubeGuncelle.Show()
    End Sub

    Private Sub ŞubeSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ŞubeSilToolStripMenuItem.Click
        SubeSil.MdiParent = Me
        SubeSil.Show()
    End Sub
#End Region

#Region "Kitaplar"

    Private Sub KitaplarıListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KitaplarıListeleToolStripMenuItem.Click
        KitaplarıListele.MdiParent = Me
        KitaplarıListele.Show()
    End Sub

    Private Sub KitapEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KitapEkleToolStripMenuItem.Click
        KitapEkle.MdiParent = Me
        KitapEkle.Show()
    End Sub

    Private Sub KitapGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KitapGüncelleToolStripMenuItem.Click
        KitapGuncelle.MdiParent = Me
        KitapGuncelle.Show()
    End Sub

    Private Sub KitapSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KitapSilToolStripMenuItem.Click
        KitapSil.MdiParent = Me
        KitapSil.Show()
    End Sub
#End Region

#Region "YayınEvleri"


    Private Sub YayınEvleriListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YayınEvleriListeleToolStripMenuItem.Click
        YayinEvleriListele.MdiParent = Me
        YayinEvleriListele.Show()
    End Sub

    Private Sub YayınEviEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YayınEviEkleToolStripMenuItem.Click
        YayinEviEkle.MdiParent = Me
        YayinEviEkle.Show()
    End Sub

    Private Sub YayınEviGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YayınEviGüncelleToolStripMenuItem.Click
        YayinEviGuncelle.MdiParent = Me
        YayinEviGuncelle.Show()
    End Sub

    Private Sub YayınEviSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YayınEviSilToolStripMenuItem.Click
        YayinEviSil.MdiParent = Me
        YayinEviSil.Show()
    End Sub

#End Region

#Region "Kategoriler"

    Private Sub KategorileriListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategorileriListeleToolStripMenuItem.Click
        KategorileriListele.MdiParent = Me
        KategorileriListele.Show()
    End Sub

    Private Sub KategoriEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriEkleToolStripMenuItem.Click
        KategoriEkle.MdiParent = Me
        KategoriEkle.Show()
    End Sub

    Private Sub KategoriGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriGüncelleToolStripMenuItem.Click
        KategoriGuncelle.MdiParent = Me
        KategoriGuncelle.Show()
    End Sub

    Private Sub KategoriSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriSilToolStripMenuItem.Click
        KategoriSil.MdiParent = Me
        KategoriSil.Show()
    End Sub


#End Region

#Region "Adresler"
    Private Sub AdresleriListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdresleriListeleToolStripMenuItem.Click
        AdresListele.MdiParent = Me
        AdresListele.Show()
    End Sub

    Private Sub AdresEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdresEkleToolStripMenuItem.Click
        AdresEkle.MdiParent = Me
        AdresEkle.Show()
    End Sub

    Private Sub AdresGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdresGüncelleToolStripMenuItem.Click
        AdresGuncelle.MdiParent = Me
        AdresGuncelle.Show()
    End Sub

    Private Sub AdresSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdresSilToolStripMenuItem.Click
        AdresSil.MdiParent = Me
        AdresSil.Show()
    End Sub


#End Region

#Region "Satış"
    Private Sub SatışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatışToolStripMenuItem.Click
        SatisEkrani.MdiParent = Me
        SatisEkrani.Show()
    End Sub
#End Region

#Region "Müşteriler"
    Private Sub MüşterileriListeleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşterileriListeleToolStripMenuItem.Click
        MusterileriListele.MdiParent = Me
        MusterileriListele.Show()
    End Sub

    Private Sub MüşteriEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriEkleToolStripMenuItem.Click
        MusteriEkle.MdiParent = Me
        MusteriEkle.Show()
    End Sub

    Private Sub MüşteriGüncelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriGüncelleToolStripMenuItem.Click
        MusteriGuncelle.MdiParent = Me
        MusteriGuncelle.Show()
    End Sub

    Private Sub MüşteriSilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriSilToolStripMenuItem.Click
        MusteriSil.MdiParent = Me
        MusteriSil.Show()
    End Sub
#End Region

#Region "Rapor"
    Private Sub RaporToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaporToolStripMenuItem.Click
        Rapor.MdiParent = Me
        Rapor.Show()
    End Sub
#End Region

#Region "Ayarlar"
    Private Sub BasamaklaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasamaklaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub DikeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DikeyToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub YatayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YatayToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
#End Region

#End Region

End Class
