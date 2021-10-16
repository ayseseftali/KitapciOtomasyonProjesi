Public Class KitapSil
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = kpDal.Delete(Convert.ToInt32(dgwKitaplar.CurrentRow.Cells(5).Value))
        If result > 0 Then
            MessageBox.Show("Kitap Başarıyla Silinmiştir...")
        Else
            MessageBox.Show("Bu Kitap Silinemiyor...")
        End If

        dgwKitaplar.DataSource = kpDal.List()
    End Sub

    Dim kpDal As KitaplarDal = New KitaplarDal

    Private Sub KitapSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwKitaplar.DataSource = kpDal.List()
    End Sub
End Class