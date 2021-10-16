Imports System.Data.SqlClient

Public Class YayinEviGuncelle
    Dim adDal As AdreslerDal = New AdreslerDal
    Dim yeDal As YayinEviDal = New YayinEviDal

    Private Sub YayinEviGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstYayinEvleri.DataSource = yeDal.List()
        cbAdresID.DataSource = adDal.List()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)
    Private cmd As SqlCommand
    Private reader As SqlDataReader

    Private Sub lstYayinEvleri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstYayinEvleri.SelectedIndexChanged
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If

        If lstYayinEvleri.SelectedItem Is Nothing Then
            MessageBox.Show("Lütfen Güncellemek İstediğiniz Yayın Evini ListBox'tan Seçiniz !!!")
            Return
        End If

        Dim seciliYayinEvi As YayinEvi = CType(lstYayinEvleri.SelectedItem, YayinEvi)
        Dim secilenId As Integer = seciliYayinEvi.Id

        cmd = New SqlCommand("Select * From YayinEvleri where YayinEviID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilenId)

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                txtYayinEviAdi.Text = reader("YayinEviAdi").ToString()
            End While
        End If
        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnYayinEviGuncelle_Click(sender As Object, e As EventArgs) Handles btnYayinEviGuncelle.Click
        Dim yayinEvi As YayinEvi = CType(lstYayinEvleri.SelectedItem, YayinEvi)

        yayinEvi.Id = yayinEvi.Id
        yayinEvi.YayinEviAdi = txtYayinEviAdi.Text

        Dim seciliAdres As Adresler = CType(cbAdresID.SelectedItem, Adresler)
        Dim secilenId As Integer = seciliAdres.Id
        yayinEvi.AdresID = secilenId

        yeDal.Update(yayinEvi)

        MessageBox.Show("YayinEviniz Başarıyla Güncellenmiştir...")

        txtYayinEviAdi.Clear()
        cbAdresID.SelectedItem = 0
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class