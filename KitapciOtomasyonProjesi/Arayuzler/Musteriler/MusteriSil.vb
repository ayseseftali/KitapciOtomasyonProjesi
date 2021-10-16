Public Class MusteriSil
    Dim msDal As MusterilerDal = New MusterilerDal
    Private Sub btnMusteriSil_Click(sender As Object, e As EventArgs) Handles btnMusteriSil.Click
        Dim result As Integer = msDal.Delete(Convert.ToInt32(dgwMusteri.CurrentRow.Cells(5).Value))
        If result > 0 Then
            MessageBox.Show("Müşteri Başarıyla Silinmiştir...")
        Else
            MessageBox.Show("Bu Müşteri Silinemiyor ...")
        End If

        dgwMusteri.DataSource = msDal.List()
    End Sub

    Private Sub MusteriSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwMusteri.DataSource = msDal.List()
    End Sub
End Class