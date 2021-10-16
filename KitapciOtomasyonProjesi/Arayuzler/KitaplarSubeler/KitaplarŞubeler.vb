Imports System.Data.SqlClient

Public Class KitaplarŞubeler
    Private Sub KitaplarŞubeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subeFill()
    End Sub

    Dim sbDal As SubelerDal = New SubelerDal

    Private Sub subeFill()
        cbSubeSec.Items.Clear()

        Dim subeler As List(Of Subeler) = sbDal.List

        For Each sb As Subeler In subeler
            cbSubeSec.DisplayMember = sb.SubeAdi
            cbSubeSec.ValueMember = sb.Id.ToString()

            cbSubeSec.Items.Add(sb)
        Next
        cbSubeSec.SelectedIndex = 0
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand

    Dim kitapId As Integer = Convert.ToInt32(My.Settings.KitapId)

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        Dim sube As Subeler = CType(cbSubeSec.SelectedItem, Subeler)
        Dim subeId As Integer = sube.Id

        cmd = New SqlCommand("Insert Into KitaplarSubeler(KitapID,SubeID,Adet) Values(@kitapId,@subeId,@adet)", cnn)
        cmd.Parameters.AddWithValue("@kitapId", kitapId)
        cmd.Parameters.AddWithValue("@subeId", subeId)
        cmd.Parameters.AddWithValue("@adet", txtAdetSayisi.Text)

        cmd.ExecuteNonQuery()

        cnn.Close()

        MessageBox.Show("Şubeniz Başarıyla Eklenmiştir İlgili Kitabı Seçerek Görebilirsiniz...")

        Temizle()
    End Sub

    Private Sub Temizle()
        cbSubeSec.SelectedIndex = 0
        txtAdetSayisi.Clear()
    End Sub
End Class