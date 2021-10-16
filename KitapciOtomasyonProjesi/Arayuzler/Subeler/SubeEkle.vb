Public Class SubeEkle
    Dim adDal As AdreslerDal = New AdreslerDal
    Dim adres As Adresler = New Adresler

    Private Sub SubeEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAdresID.DataSource = adDal.List()
    End Sub

    Dim sbDal As SubelerDal = New SubelerDal
    Dim subeler As Subeler = New Subeler

    Private Sub btnSubeEkle_Click(sender As Object, e As EventArgs) Handles btnSubeEkle.Click
        Try
            If cbAdresID.Text <> " " AndAlso txtSubeAdi.Text <> " " Then
                subeler.SubeAdi = txtSubeAdi.Text
                adres = CType(cbAdresID.SelectedItem, Adresler)
                subeler.AdresID = adres.Id

                sbDal.Save(subeler)

                MessageBox.Show("Şubeniz Başarılı Bir Şekilde Eklendi...")

                cbAdresID.SelectedItem = 0
                txtSubeAdi.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class