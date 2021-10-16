Imports System.Data.SqlClient

Public Class KategoriGuncelle
    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub

    Private Sub btnGuncelle_Click(sender As Object, e As EventArgs) Handles btnGuncelle.Click
        Dim kategori As Kategoriler = CType(lstKategoriler.SelectedItem, Kategoriler)

        kategori.Id = kategori.Id
        kategori.KategoriAdi = txtKategori.Text

        kateDal.Update(kategori)

        MessageBox.Show("Kategoriniz Başarıyla Güncellenmiştir ...")
        txtKategori.Clear()
    End Sub

    Private Sub lstKategoriler_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKategoriler.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If lstKategoriler.SelectedItem Is Nothing Then
            MessageBox.Show("Lütfen Güncellemek İstediğiniz Kategoriyi ListBox'tan Seçiniz !!!")
            Return
        End If

        Dim seciliKategori As Kategoriler = CType(lstKategoriler.SelectedItem, Kategoriler)
        Dim secilenId As Integer = seciliKategori.Id

        cmd = New SqlCommand("Select * From Kategoriler Where KategoriID = @id", cnn)

        cmd.Parameters.AddWithValue("@id", secilenId)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                txtKategori.Text = reader("KategoriAdi").ToString()
            End While
        End If
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub KategoriGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kategoriFill()
    End Sub

    Dim kateDal As KategorilerDal = New KategorilerDal
    Private Sub kategoriFill()
        lstKategoriler.DataSource = kateDal.List()
    End Sub
End Class