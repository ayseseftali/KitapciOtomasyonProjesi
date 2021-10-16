Public Class KategorileriListele
    Dim ktDal As KategorilerDal = New KategorilerDal
    Private Sub KategorileriListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwKategoriler.DataSource = ktDal.List()
        ToolStripStatusLabelVeriler.Text = dgwKategoriler.DataSource.Count.ToString() + " adet kategori listelenmiştir ..."
    End Sub
End Class