Imports System.Data
Imports System.Data.SqlClient

Public Class frmYoneticiGirisi
    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Me.Close()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Select * From Calisanlar C where C.Eposta = @yoneticiAdi and C.Sifre = @sifre", cnn)
        cmd.Parameters.AddWithValue("@yoneticiAdi", txtYoneticiAdi.Text)
        cmd.Parameters.AddWithValue("@sifre", txtYoneticiSifresi.Text)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                Dim cl As Calisanlar = New Calisanlar
                cl.Id = Convert.ToInt32(reader("CalisanID").ToString)
                cl.Pozisyon = reader("Pozisyon").ToString()
                If (cl.Pozisyon.ToUpper = "YÖNETİCİ") Then
                    Me.Close()
                    Dim yeniYoneticiArayuzu As YöneticiArayuzu = New YöneticiArayuzu
                    yeniYoneticiArayuzu.Show()
                    MessageBox.Show("Hoşgeldiniz!", "Giriş Başarılı!")
                    Dim frm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                    frm.YazarlarToolStripMenuItem.Enabled = True
                    frm.YazarlarıListeleToolStripMenuItem.Enabled = True
                    frm.YazarEkleToolStripMenuItem.Enabled = True
                    frm.YazarGüncelleToolStripMenuItem.Enabled = True
                    frm.YazarSilToolStripMenuItem.Enabled = True
                    frm.ŞubelerToolStripMenuItem.Enabled = True
                    frm.ŞubeleriListeleToolStripMenuItem.Enabled = True
                    frm.ŞubeEkleToolStripMenuItem.Enabled = True
                    frm.ŞubeGüncelleToolStripMenuItem.Enabled = True
                    frm.ŞubeSilToolStripMenuItem.Enabled = True
                    frm.KitaplarToolStripMenuItem.Enabled = True
                    frm.KitaplarıListeleToolStripMenuItem.Enabled = True
                    frm.KitapEkleToolStripMenuItem.Enabled = True
                    frm.KitapGüncelleToolStripMenuItem.Enabled = True
                    frm.KitapSilToolStripMenuItem.Enabled = True
                    frm.YayınEvleriToolStripMenuItem.Enabled = True
                    frm.YayınEvleriListeleToolStripMenuItem.Enabled = True
                    frm.YayınEviEkleToolStripMenuItem.Enabled = True
                    frm.YayınEviGüncelleToolStripMenuItem.Enabled = True
                    frm.YayınEviSilToolStripMenuItem.Enabled = True
                    frm.KategorilerToolStripMenuItem.Enabled = True
                    frm.KategorileriListeleToolStripMenuItem.Enabled = True
                    frm.KategoriEkleToolStripMenuItem.Enabled = True
                    frm.KategoriGüncelleToolStripMenuItem.Enabled = True
                    frm.KategoriSilToolStripMenuItem.Enabled = True
                    frm.AdreslerToolStripMenuItem.Enabled = True
                    frm.AdresleriListeleToolStripMenuItem.Enabled = True
                    frm.AdresEkleToolStripMenuItem.Enabled = True
                    frm.AdresGüncelleToolStripMenuItem.Enabled = True
                    frm.AdresSilToolStripMenuItem.Enabled = True
                    frm.ÇalışanlarToolStripMenuItem.Enabled = True
                    frm.ÇalışanlarıListeleToolStripMenuItem.Enabled = True
                    frm.ÇalışanEkleToolStripMenuItem.Enabled = True
                    frm.ÇalışanGüncelleToolStripMenuItem.Enabled = True
                    frm.ÇalışanSilToolStripMenuItem.Enabled = True
                    frm.MüşterilerToolStripMenuItem.Enabled = True
                    frm.MüşterileriListeleToolStripMenuItem.Enabled = True
                    frm.MüşteriEkleToolStripMenuItem.Enabled = True
                    frm.MüşteriGüncelleToolStripMenuItem.Enabled = True
                    frm.MüşteriSilToolStripMenuItem.Enabled = True
                    frm.SatışToolStripMenuItem.Enabled = True
                    frm.RaporToolStripMenuItem.Enabled = True
                    frm.AyarlarToolStripMenuItem.Enabled = True
                    frm.EkranAyarlarıToolStripMenuItem.Enabled = True
                Else
                    MessageBox.Show("Lütfen Kullanıcı Adını Ve Şifreyi Kontrol Ediniz!!")
                End If
            End While
        End If
        reader.Close()
        cnn.Close()
    End Sub
End Class