Imports System.Data.SqlClient

Public Class SubeGuncelle
    Dim sbDal As SubelerDal = New SubelerDal
    Dim adDal As AdreslerDal = New AdreslerDal

    Private Sub SubeGuncelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSubeler.DataSource = sbDal.List()
        cbAdresID.DataSource = adDal.List()
    End Sub

    Private cnn As SqlConnection = New SqlConnection(My.Settings.KitapciOtomasyonConnectionString)

    Private cmd As SqlCommand

    Private reader As SqlDataReader

    Private Sub lstSubeler_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubeler.SelectedIndexChanged
        If (cnn.State = ConnectionState.Closed) Then
            cnn.Open()
        End If

        If (lstSubeler.SelectedItem Is Nothing) Then
            MessageBox.Show("Lütfen Güncellemek istediğniz şubeyi ListBox'tan Seçiniz !!!")
            Return
        End If

        Dim seciliSube As Subeler = CType(lstSubeler.SelectedItem, Subeler)
        Dim secilenId As Integer = seciliSube.Id
        cmd = New SqlCommand("Select * From Subeler Where SubeID = @id", cnn)
        cmd.Parameters.AddWithValue("@id", secilenId)
        reader = cmd.ExecuteReader
        If reader.HasRows Then

            While reader.Read
                txtSubeAdi.Text = reader("SubeAdi").ToString

            End While

        End If

        reader.Close()
        cnn.Close()
    End Sub

    Private Sub btnSubeGuncelle_Click(sender As Object, e As EventArgs) Handles btnSubeGuncelle.Click
        Dim sube As Subeler = CType(lstSubeler.SelectedItem, Subeler)
        sube.Id = sube.Id
        sube.SubeAdi = txtSubeAdi.Text
        Dim seciliAdres As Adresler = CType(cbAdresID.SelectedItem, Adresler)
        Dim secilenId As Integer = seciliAdres.Id
        sube.AdresID = secilenId
        sbDal.Update(sube)
        MessageBox.Show("Kategoriniz Başarıyla Güncellenmiştir ...")
        txtSubeAdi.Clear()
        cbAdresID.SelectedItem = 0
    End Sub

    Private Sub btnIptal_Click(sender As Object, e As EventArgs) Handles btnIptal.Click
        Me.Close()
    End Sub
End Class