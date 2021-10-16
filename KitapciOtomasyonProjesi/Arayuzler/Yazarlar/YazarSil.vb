Public Class YazarSil
    Dim yzDal As YazarlarDal = New YazarlarDal
    Private Sub YazarSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwYazarSil.DataSource = yzDal.List()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = yzDal.Delete(Convert.ToInt32(dgwYazarSil.CurrentRow.Cells(2).Value))
        If result > 0 Then
            MessageBox.Show("Yazar Başarıyla Silinmiştir ...")
        Else
            MessageBox.Show("Bu Yazar Silinemiyor...")
        End If

        dgwYazarSil.DataSource = yzDal.List()
    End Sub
End Class