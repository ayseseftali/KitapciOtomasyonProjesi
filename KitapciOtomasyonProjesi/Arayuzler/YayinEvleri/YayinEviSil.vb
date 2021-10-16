Public Class YayinEviSil
    Dim yeDal As YayinEviDal = New YayinEviDal

    Private Sub YayinEviSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwYayinEviSil.DataSource = yeDal.List()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = yeDal.Delete(Convert.ToInt32(dgwYayinEviSil.CurrentRow.Cells(2).Value))
        If result > 0 Then
            MessageBox.Show("YayınEvi Başarıyla Silinmiştir...")
        Else
            MessageBox.Show("Bu YayınEvi Silinemiyor...")
        End If

        dgwYayinEviSil.DataSource = yeDal.List()
    End Sub
End Class