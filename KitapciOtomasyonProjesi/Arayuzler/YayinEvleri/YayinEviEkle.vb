Public Class YayinEviEkle
    Dim adDal As AdreslerDal = New AdreslerDal

    Private Sub YayinEviEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbAdresID.DataSource = adDal.List()
    End Sub

    Dim yeDal As YayinEviDal = New YayinEviDal
    Dim yayinEvi As YayinEvi = New YayinEvi

    Private Sub btnYayinEviEkle_Click(sender As Object, e As EventArgs) Handles btnYayinEviEkle.Click
        Try
            If txtYayinEviAdi.Text <> " " Then
                yayinEvi.YayinEviAdi = txtYayinEviAdi.Text
                Dim adres As Adresler = CType(cbAdresID.SelectedItem, Adresler)
                yayinEvi.AdresID = adres.Id

                yeDal.Save(yayinEvi)

                MessageBox.Show("YayınEviniz Başarılı Bir Şekilde Eklendi...")

                cbAdresID.SelectedItem = 0
                txtYayinEviAdi.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class