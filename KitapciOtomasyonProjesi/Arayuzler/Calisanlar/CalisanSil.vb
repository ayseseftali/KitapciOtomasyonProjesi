Public Class CalisanSil
    Dim clDal As CalisanlarDal = New CalisanlarDal

    Private Sub btnCalisanSil_Click(sender As Object, e As EventArgs) Handles btnCalisanSil.Click
        Dim result As Integer = clDal.Delete(Convert.ToInt32(dgwCalisan.CurrentRow.Cells(10).Value))
        If result > 0 Then
            MessageBox.Show("Çalışan Başarıyla Silinmiştir...")
        Else
            MessageBox.Show("Bu Çalışan Silinemiyor...")
        End If
        dgwCalisan.DataSource = clDal.List()
    End Sub

    Private Sub CalisanSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwCalisan.DataSource = clDal.List()
    End Sub
End Class