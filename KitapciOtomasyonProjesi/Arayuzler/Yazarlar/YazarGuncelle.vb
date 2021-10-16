Imports System.Data.SqlClient

Public Class YazarGuncelle
    Dim yzDal As YazarlarDal = New YazarlarDal

    Private Sub YazarGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstYazarlar.DataSource = yzDal.List()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub lstYazarlar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstYazarlar.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If lstYazarlar.SelectedItem Is Nothing Then
            MessageBox.Show("Lütfen Güncellemek İstediğiniz Yazarı ListBox'tan Seçiniz !!!")
            Return
        End If

        Dim seciliYazar As Yazarlar = CType(lstYazarlar.SelectedItem, Yazarlar)
        Dim secilenId As Integer = seciliYazar.Id

        cmd = New SqlCommand("Select * From Yazarlar where YazarID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilenId)

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                txtYazarAdi.Text = reader("YazarAdi").ToString()
                txtYazarSoyadi.Text = reader("YazarSoyadi").ToString()
            End While
        End If

        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnYazarGüncelle_Click(sender As Object, e As EventArgs) Handles btnYazarGüncelle.Click
        Dim yazar As Yazarlar = CType(lstYazarlar.SelectedItem, Yazarlar)

        yazar.Id = yazar.Id
        yazar.YazarAdi = txtYazarAdi.Text
        yazar.YazarSoyadi = txtYazarSoyadi.Text

        yzDal.Update(yazar)

        MessageBox.Show("Yazarınız Başarıyla Güncellenmiştir...")

        txtYazarAdi.Clear()
        txtYazarSoyadi.Clear()
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class