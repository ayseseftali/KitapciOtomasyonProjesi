Public Class KategoriSil

    Dim kateDal As KategorilerDal = New KategorilerDal

    Private Sub btnKategoriSil_Click(sender As Object, e As EventArgs) Handles btnKategoriSil.Click

        Dim result As Integer = kateDal.Delete(Convert.ToInt32(dgwKategoriler.CurrentRow.Cells(1).Value))
        If result > 0 Then
            MessageBox.Show("Kategori Başarıyla Silinmiştir ...")
        Else
            MessageBox.Show("Bu Kategori Silinemiyor...")
        End If
        dgwKategoriler.DataSource = kateDal.List()
    End Sub

    Private Sub KategoriSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwKategoriler.DataSource = kateDal.List()
    End Sub
End Class