Public Class SubeSil
    Dim sbDal As SubelerDal = New SubelerDal

    Private Sub SubeSil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwSubeSil.DataSource = sbDal.List()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = sbDal.Delete(Convert.ToInt32(dgwSubeSil.CurrentRow.Cells(2).Value))
        If result > 0 Then
            MessageBox.Show("Şube Başarıyla Silinmiştir...")
        Else
            MessageBox.Show("Bu Şube Silinemiyor ...")
        End If

        dgwSubeSil.DataSource = sbDal.List()
    End Sub
End Class