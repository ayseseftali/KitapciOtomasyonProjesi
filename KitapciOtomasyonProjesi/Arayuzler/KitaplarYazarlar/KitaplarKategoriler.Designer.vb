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
        Me.btnKategoriEkle = New System.Windows.Forms.Button()
        Me.btnSayfayiYenile = New System.Windows.Forms.Button()
        Me.btnSecimiOnayla = New System.Windows.Forms.Button()
        Me.btnKategoriSil = New System.Windows.Forms.Button()
        Me.lblKategoriSecimIslemi = New System.Windows.Forms.Label()
        Me.lstwKategoriler = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnKategoriEkle
        '
        Me.btnKategoriEkle.BackColor = System.Drawing.Color.Maroon
        Me.btnKategoriEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKategoriEkle.ForeColor = System.Drawing.Color.Coral
        Me.btnKategoriEkle.Location = New System.Drawing.Point(24, 437)
        Me.btnKategoriEkle.Name = "btnKategoriEkle"
        Me.btnKategoriEkle.Size = New System.Drawing.Size(191, 45)
        Me.btnKategoriEkle.TabIndex = 0
        Me.btnKategoriEkle.Text = "Kategori Ekle"
        Me.btnKategoriEkle.UseVisualStyleBackColor = False
        '
        'btnSayfayiYenile
        '
        Me.btnSayfayiYenile.BackColor = System.Drawing.Color.Maroon
        Me.btnSayfayiYenile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSayfayiYenile.ForeColor = System.Drawing.Color.Coral
        Me.btnSayfayiYenile.Location = New System.Drawing.Point(191, 505)
        Me.btnSayfayiYenile.Name = "btnSayfayiYenile"
        Me.btnSayfayiYenile.Size = New System.Drawing.Size(316, 48)
        Me.btnSayfayiYenile.TabIndex = 1
        Me.btnSayfayiYenile.Text = "Sayfayı Yenile"
        Me.btnSayfayiYenile.UseVisualStyleBackColor = False
        '
        'btnSecimiOnayla
        '
        Me.btnSecimiOnayla.BackColor = System.Drawing.Color.Maroon
        Me.btnSecimiOnayla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSecimiOnayla.ForeColor = System.Drawing.Color.Coral
        Me.btnSecimiOnayla.Location = New System.Drawing.Point(504, 437)
        Me.btnSecimiOnayla.Name = "btnSecimiOnayla"
        Me.btnSecimiOnayla.Size = New System.Drawing.Size(178, 45)
        Me.btnSecimiOnayla.TabIndex = 2
        Me.btnSecimiOnayla.Text = "Seçimi Onayla"
        Me.btnSecimiOnayla.UseVisualStyleBackColor = False
        '
        'btnKategoriSil
        '
        Me.btnKategoriSil.BackColor = System.Drawing.Color.Maroon
        Me.btnKategoriSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKategoriSil.ForeColor = System.Drawing.Color.Coral
        Me.btnKategoriSil.Location = New System.Drawing.Point(266, 437)
        Me.btnKategoriSil.Name = "btnKategoriSil"
        Me.btnKategoriSil.Size = New System.Drawing.Size(179, 45)
        Me.btnKategoriSil.TabIndex = 3
        Me.btnKategoriSil.Text = "Kategori Sil"
        Me.btnKategoriSil.UseVisualStyleBackColor = False
        '
        'lblKategoriSecimIslemi
        '
        Me.lblKategoriSecimIslemi.AutoSize = True
        Me.lblKategoriSecimIslemi.BackColor = System.Drawing.Color.Maroon
        Me.lblKategoriSecimIslemi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKategoriSecimIslemi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKategoriSecimIslemi.ForeColor = System.Drawing.Color.Coral
        Me.lblKategoriSecimIslemi.Location = New System.Drawing.Point(66, 53)
        Me.lblKategoriSecimIslemi.Name = "lblKategoriSecimIslemi"
        Me.lblKategoriSecimIslemi.Size = New System.Drawing.Size(307, 33)
        Me.lblKategoriSecimIslemi.TabIndex = 4
        Me.lblKategoriSecimIslemi.Text = "Kategori Seçim İşlemleri"
        '
        'lstwKategoriler
        '
        Me.lstwKategoriler.BackColor = System.Drawing.Color.Khaki
        Me.lstwKategoriler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstwKategoriler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwKategoriler.ForeColor = System.Drawing.Color.Coral
        Me.lstwKategoriler.FullRowSelect = True
        Me.lstwKategoriler.GridLines = True
        Me.lstwKategoriler.Location = New System.Drawing.Point(24, 117)
        Me.lstwKategoriler.Name = "lstwKategoriler"
        Me.lstwKategoriler.Size = New System.Drawing.Size(658, 250)
        Me.lstwKategoriler.TabIndex = 5
        Me.lstwKategoriler.UseCompatibleStateImageBehavior = False
        Me.lstwKategoriler.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kategori ID"
        Me.ColumnHeader1.Width = 175
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Kategori Adı"
        Me.ColumnHeader2.Width = 194
        '
        'KitaplarKategoriler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(721, 586)
        Me.Controls.Add(Me.lstwKategoriler)
        Me.Controls.Add(Me.lblKategoriSecimIslemi)
        Me.Controls.Add(Me.btnKategoriSil)
        Me.Controls.Add(Me.btnSecimiOnayla)
        Me.Controls.Add(Me.btnSayfayiYenile)
        Me.Controls.Add(Me.btnKategoriEkle)
        Me.Name = "KitaplarKategoriler"
        Me.Text = "KitaplarKategoriler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKategoriEkle As Button
    Friend WithEvents btnSayfayiYenile As Button
    Friend WithEvents btnSecimiOnayla As Button
    Friend WithEvents btnKategoriSil As Button
    Friend WithEvents lblKategoriSecimIslemi As Label
    Friend WithEvents lstwKategoriler As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
