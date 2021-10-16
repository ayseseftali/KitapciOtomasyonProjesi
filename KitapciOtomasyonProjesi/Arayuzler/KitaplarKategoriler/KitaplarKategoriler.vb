Imports System.Data.SqlClient

Public Class KitaplarKategoriler
    Dim ktDal As KategorilerDal = New KategorilerDal

    Private Sub KitaplarKategoriler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Private Sub Fill()
        lstwKategoriler.Items.Clear()

        Dim kategoriler As List(Of Kategoriler) = ktDal.List

        For Each kt As Kategoriler In kategoriler
            Dim li As ListViewItem = New ListViewItem

            li.Tag = kt
            li.Text = kt.Id.ToString()

            li.SubItems.Add(kt.KategoriAdi)

            lstwKategoriler.Items.Add(li)
        Next
    End Sub

    Private Sub btnKategoriEkle_Click(sender As Object, e As EventArgs) Handles btnKategoriEkle.Click
        Dim yeniKategorilerEkle As KategoriEkle = New KategoriEkle
        yeniKategorilerEkle.Show()
    End Sub

    Private Sub btnKategoriSil_Click(sender As Object, e As EventArgs) Handles btnKategoriSil.Click
        Dim yeniKategorilerSil As KategoriSil = New KategoriSil
        yeniKategorilerSil.Show()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Dim kitapId As Integer = Convert.ToInt32(My.Settings.KitapId)

    Private Sub btnSecimiOnayla_Click(sender As Object, e As EventArgs) Handles btnSecimiOnayla.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        cmd = New SqlCommand("Insert Into KitaplarKategoriler(KitapID, KategoriID) Values(@kitapId, @kategoriId)", cnn)
        cmd.Parameters.AddWithValue("@kitapId", kitapId)
        cmd.Parameters.AddWithValue("@kategoriId", Convert.ToInt32(lstwKategoriler.SelectedItems(0).Text))

        cmd.ExecuteNonQuery()

        cnn.Close()

        MessageBox.Show("Kategoriniz Başarıyla Eklenmiştir İlgili Kitabı Seçerek Görebilirsiniz...")
    End Sub

    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        Fill()
    End Sub
End Class