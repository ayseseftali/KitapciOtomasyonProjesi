<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitaplarKategoriler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KitaplarKategoriler))
        Me.lblKategoriSecimi = New System.Windows.Forms.Label()
        Me.btnSecimiOnayla = New System.Windows.Forms.Button()
        Me.btnKategoriSil = New System.Windows.Forms.Button()
        Me.btnKategoriEkle = New System.Windows.Forms.Button()
        Me.lstwKategoriler = New System.Windows.Forms.ListView()
        Me.columnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnYenile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKategoriSecimi
        '
        Me.lblKategoriSecimi.AutoSize = True
        Me.lblKategoriSecimi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKategoriSecimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKategoriSecimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblKategoriSecimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKategoriSecimi.ForeColor = System.Drawing.Color.Black
        Me.lblKategoriSecimi.Location = New System.Drawing.Point(140, 19)
        Me.lblKategoriSecimi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKategoriSecimi.Name = "lblKategoriSecimi"
        Me.lblKategoriSecimi.Size = New System.Drawing.Size(349, 41)
        Me.lblKategoriSecimi.TabIndex = 30
        Me.lblKategoriSecimi.Text = "Kategori Seçim İşlemi"
        '
        'btnSecimiOnayla
        '
        Me.btnSecimiOnayla.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSecimiOnayla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecimiOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecimiOnayla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSecimiOnayla.ForeColor = System.Drawing.Color.Black
        Me.btnSecimiOnayla.Location = New System.Drawing.Point(388, 306)
        Me.btnSecimiOnayla.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSecimiOnayla.Name = "btnSecimiOnayla"
        Me.btnSecimiOnayla.Size = New System.Drawing.Size(163, 43)
        Me.btnSecimiOnayla.TabIndex = 28
        Me.btnSecimiOnayla.Text = "Seçimi Onayla"
        Me.btnSecimiOnayla.UseVisualStyleBackColor = False
        '
        'btnKategoriSil
        '
        Me.btnKategoriSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKategoriSil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategoriSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKategoriSil.ForeColor = System.Drawing.Color.Black
        Me.btnKategoriSil.Location = New System.Drawing.Point(217, 306)
        Me.btnKategoriSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKategoriSil.Name = "btnKategoriSil"
        Me.btnKategoriSil.Size = New System.Drawing.Size(163, 43)
        Me.btnKategoriSil.TabIndex = 26
        Me.btnKategoriSil.Text = "Kategori Sil"
        Me.btnKategoriSil.UseVisualStyleBackColor = False
        '
        'btnKategoriEkle
        '
        Me.btnKategoriEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKategoriEkle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategoriEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKategoriEkle.ForeColor = System.Drawing.Color.Black
        Me.btnKategoriEkle.Location = New System.Drawing.Point(46, 306)
        Me.btnKategoriEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKategoriEkle.Name = "btnKategoriEkle"
        Me.btnKategoriEkle.Size = New System.Drawing.Size(163, 43)
        Me.btnKategoriEkle.TabIndex = 27
        Me.btnKategoriEkle.Text = "Kategori Ekle"
        Me.btnKategoriEkle.UseVisualStyleBackColor = False
        '
        'lstwKategoriler
        '
        Me.lstwKategoriler.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwKategoriler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstwKategoriler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader17, Me.columnHeader18})
        Me.lstwKategoriler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwKategoriler.ForeColor = System.Drawing.Color.Black
        Me.lstwKategoriler.FullRowSelect = True
        Me.lstwKategoriler.GridLines = True
        Me.lstwKategoriler.Location = New System.Drawing.Point(37, 82)
        Me.lstwKategoriler.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwKategoriler.Name = "lstwKategoriler"
        Me.lstwKategoriler.Size = New System.Drawing.Size(525, 205)
        Me.lstwKategoriler.TabIndex = 25
        Me.lstwKategoriler.UseCompatibleStateImageBehavior = False
        Me.lstwKategoriler.View = System.Windows.Forms.View.Details
        '
        'columnHeader17
        '
        Me.columnHeader17.Text = "Kategori ID"
        Me.columnHeader17.Width = 185
        '
        'columnHeader18
        '
        Me.columnHeader18.Text = "Kategori Adı"
        Me.columnHeader18.Width = 334
        '
        'btnYenile
        '
        Me.btnYenile.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYenile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYenile.ForeColor = System.Drawing.Color.Black
        Me.btnYenile.Location = New System.Drawing.Point(147, 368)
        Me.btnYenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYenile.Name = "btnYenile"
        Me.btnYenile.Size = New System.Drawing.Size(295, 43)
        Me.btnYenile.TabIndex = 31
        Me.btnYenile.Text = "Sayfayı Yenile"
        Me.btnYenile.UseVisualStyleBackColor = False
        '
        'KitaplarKategoriler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(594, 429)
        Me.Controls.Add(Me.lblKategoriSecimi)
        Me.Controls.Add(Me.btnSecimiOnayla)
        Me.Controls.Add(Me.btnKategoriSil)
        Me.Controls.Add(Me.btnKategoriEkle)
        Me.Controls.Add(Me.lstwKategoriler)
        Me.Controls.Add(Me.btnYenile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KitaplarKategoriler"
        Me.Text = "Kitap Kategorileri"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblKategoriSecimi As Label
    Private WithEvents btnSecimiOnayla As Button
    Private WithEvents btnKategoriSil As Button
    Private WithEvents btnKategoriEkle As Button
    Private WithEvents lstwKategoriler As ListView
    Private WithEvents columnHeader17 As ColumnHeader
    Private WithEvents columnHeader18 As ColumnHeader
    Private WithEvents btnYenile As Button
End Class
