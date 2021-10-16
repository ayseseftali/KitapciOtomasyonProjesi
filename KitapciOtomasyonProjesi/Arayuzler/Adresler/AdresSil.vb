Public Class AdresSil

    Dim adDal As AdreslerDal = New AdreslerDal

    Private Sub AdresSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwAdresler.DataSource = adDal.List()
    End Sub

    Private Sub btnAdresSil_Click(sender As Object, e As EventArgs) Handles btnAdresSil.Click
        Dim result As Integer = adDal.Delete(Convert.ToInt32(dgwAdresler.CurrentRow.Cells(9).Value))
        If result > 0 Then
            MessageBox.Show("Adres Başarıyla Silinmiştir...")
        Else
            MessageBox.Show("Bu Adres Diğer İşlemlerle İlişkili Olduğundan Silinemiyor...")
        End If

        dgwAdresler.DataSource = adDal.List
    End Sub
End Class