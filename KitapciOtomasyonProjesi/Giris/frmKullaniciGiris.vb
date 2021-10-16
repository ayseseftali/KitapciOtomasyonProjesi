Imports System.Data
Imports System.Data.SqlClient

Public Class frmKullaniciGiris
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

        cmd = New SqlCommand("Select * From Calisanlar C where C.Eposta = @kullaniciAdi and C.Sifre = @sifre", cnn)
        cmd.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text)
        cmd.Parameters.AddWithValue("@sifre", txtKullaniciSifresi.Text)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                Dim cl As Calisanlar = New Calisanlar
                cl.Id = Convert.ToInt32(reader("CalisanID").ToString)
                cl.Pozisyon = reader("Pozisyon").ToString()
                If (cl.Pozisyon.ToUpper <> "YÖNETİCİ") Then
                    Me.Close()
                    Dim yeniKullaniciArayuzu As KullaniciArayuzu = New KullaniciArayuzu
                    yeniKullaniciArayuzu.Show()
                    MessageBox.Show("Hoşgeldiniz!", "Giriş Başarılı!")
                    Dim frm As frmMain = CType(Application.OpenForms("frmMain"), frmMain)
                    frm.YazarlarToolStripMenuItem.Enabled = True
                    frm.YazarlarıListeleToolStripMenuItem.Enabled = True
                    frm.ŞubelerToolStripMenuItem.Enabled = True
                    frm.ŞubeleriListeleToolStripMenuItem.Enabled = True
                    frm.KitaplarToolStripMenuItem.Enabled = True
                    frm.KitaplarıListeleToolStripMenuItem.Enabled = True
                    frm.YayınEvleriToolStripMenuItem.Enabled = True
                    frm.YayınEvleriListeleToolStripMenuItem.Enabled = True
                    frm.KategorilerToolStripMenuItem.Enabled = True
                    frm.KategorileriListeleToolStripMenuItem.Enabled = True
                    frm.AdreslerToolStripMenuItem.Enabled = True
                    frm.AdresleriListeleToolStripMenuItem.Enabled = True
                    frm.ÇalışanlarToolStripMenuItem.Enabled = True
                    frm.ÇalışanlarıListeleToolStripMenuItem.Enabled = True
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