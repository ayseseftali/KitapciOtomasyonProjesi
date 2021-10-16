<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KategoriGuncelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KategoriGuncelle))
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.lblYeniKayıtGuncellemeIslemleri = New System.Windows.Forms.Label()
        Me.lblKategoriAdi = New System.Windows.Forms.Label()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.lstKategoriler = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(341, 286)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(211, 46)
        Me.btnIptal.TabIndex = 0
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnGuncelle.Location = New System.Drawing.Point(341, 231)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(211, 46)
        Me.btnGuncelle.TabIndex = 1
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'lblYeniKayıtGuncellemeIslemleri
        '
        Me.lblYeniKayıtGuncellemeIslemleri.AutoSize = True
        Me.lblYeniKayıtGuncellemeIslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYeniKayıtGuncellemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYeniKayıtGuncellemeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYeniKayıtGuncellemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYeniKayıtGuncellemeIslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblYeniKayıtGuncellemeIslemleri.Location = New System.Drawing.Point(78, 28)
        Me.lblYeniKayıtGuncellemeIslemleri.Name = "lblYeniKayıtGuncellemeIslemleri"
        Me.lblYeniKayıtGuncellemeIslemleri.Size = New System.Drawing.Size(474, 41)
        Me.lblYeniKayıtGuncellemeIslemleri.TabIndex = 2
        Me.lblYeniKayıtGuncellemeIslemleri.Text = "Kategori Güncelleme İşlemleri"
        '
        'lblKategoriAdi
        '
        Me.lblKategoriAdi.AutoSize = True
        Me.lblKategoriAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKategoriAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKategoriAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblKategoriAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKategoriAdi.ForeColor = System.Drawing.Color.Black
        Me.lblKategoriAdi.Location = New System.Drawing.Point(363, 130)
        Me.lblKategoriAdi.Name = "lblKategoriAdi"
        Me.lblKategoriAdi.Size = New System.Drawing.Size(163, 33)
        Me.lblKategoriAdi.TabIndex = 3
        Me.lblKategoriAdi.Text = "Kategori Adı"
        '
        'txtKategori
        '
        Me.txtKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKategori.Location = New System.Drawing.Point(315, 173)
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(267, 34)
        Me.txtKategori.TabIndex = 4
        '
        'lstKategoriler
        '
        Me.lstKategoriler.BackColor = System.Drawing.Color.Gainsboro
        Me.lstKategoriler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstKategoriler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstKategoriler.ForeColor = System.Drawing.Color.Black
        Me.lstKategoriler.FormattingEnabled = True
        Me.lstKategoriler.ItemHeight = 29
        Me.lstKategoriler.Location = New System.Drawing.Point(12, 99)
        Me.lstKategoriler.Name = "lstKategoriler"
        Me.lstKategoriler.Size = New System.Drawing.Size(270, 263)
        Me.lstKategoriler.TabIndex = 5
        '
        'KategoriGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(601, 383)
        Me.Controls.Add(Me.lstKategoriler)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.lblKategoriAdi)
        Me.Controls.Add(Me.lblYeniKayıtGuncellemeIslemleri)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.btnIptal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KategoriGuncelle"
        Me.Text = "Kategori Güncelleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIptal As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents lblYeniKayıtGuncellemeIslemleri As Label
    Friend WithEvents lblKategoriAdi As Label
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents lstKategoriler As ListBox
End Class
