Public Class YazarEkle

    Dim yzDal As YazarlarDal = New YazarlarDal
    Dim yazar As Yazarlar = New Yazarlar

    Private Sub btnYazarEkle_Click(sender As Object, e As EventArgs) Handles btnYazarEkle.Click
        Try
            If txtYazarAdi.Text <> " " Then
                yazar.YazarAdi = txtYazarAdi.Text
                yazar.YazarSoyadi = txtYazarSoyadi.Text

                yzDal.Save(yazar)

                MessageBox.Show("Yazarınız Başarılı Bir Şekilde Eklendi ...")

                txtYazarAdi.Clear()
                txtYazarSoyadi.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class