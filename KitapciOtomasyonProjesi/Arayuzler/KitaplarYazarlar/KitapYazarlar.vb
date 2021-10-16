Imports System.Data.SqlClient

Public Class KitapYazarlar

    Dim yzDal As YazarlarDal = New YazarlarDal
    Private Sub KitapYazarlar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Private Sub Fill()
        lstwYazarlar.Items.Clear()

        Dim yazarlar As List(Of Yazarlar) = yzDal.List()

        For Each yz As Yazarlar In yazarlar
            Dim li As ListViewItem = New ListViewItem

            li.Tag = yz
            li.Text = yz.Id.ToString()

            li.SubItems.Add(yz.YazarAdi)
            li.SubItems.Add(yz.YazarSoyadi)

            lstwYazarlar.Items.Add(li)
        Next
    End Sub

    Private Sub btnYazarEkle_Click(sender As Object, e As EventArgs) Handles btnYazarEkle.Click
        Dim yeniYazarlarEkle As YazarEkle = New YazarEkle
        yeniYazarlarEkle.Show()
    End Sub

    Private Sub btnYazarSil_Click(sender As Object, e As EventArgs) Handles btnYazarSil.Click
        Dim yeniYazarlarSil As YazarSil = New YazarSil
        yeniYazarlarSil.Show()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand

    Dim kitapId As Integer = Convert.ToInt32(My.Settings.KitapId)

    Private Sub btnSecimiOnayla_Click(sender As Object, e As EventArgs) Handles btnSecimiOnayla.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Insert Into KitaplarYazarlar(KitapID,YazarID) Values(@kitapId,@yazarId)", cnn)
        cmd.Parameters.AddWithValue("@kitapId", kitapId)
        cmd.Parameters.AddWithValue("@yazarId", Convert.ToInt32(lstwYazarlar.SelectedItems(0).Text))

        cmd.ExecuteNonQuery()
        cnn.Close()

        MessageBox.Show("Yazarınız Başarıyla Eklenmiştir İlgili Kitabı Seçerek Görebilirsiniz...")
    End Sub

    Private Sub btnSayfayıYenile_Click(sender As Object, e As EventArgs) Handles btnSayfayıYenile.Click
        Fill()
    End Sub
End Class