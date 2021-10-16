Public Class SubelerListele
    Dim sbDal As SubelerDal = New SubelerDal()

    Private Sub SubelerListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwSubeler.DataSource = sbDal.List()
    End Sub
End Class