<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SatisEkrani
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SatisEkrani))
        Me.lblFiyat = New System.Windows.Forms.Label()
        Me.lblSatisTarihi = New System.Windows.Forms.Label()
        Me.lblSatisSayisi = New System.Windows.Forms.Label()
        Me.lblKitapID = New System.Windows.Forms.Label()
        Me.lblMusteriID = New System.Windows.Forms.Label()
        Me.lblSubeID = New System.Windows.Forms.Label()
        Me.cbSubeID = New System.Windows.Forms.ComboBox()
        Me.cbMusteriID = New System.Windows.Forms.ComboBox()
        Me.cbKitapID = New System.Windows.Forms.ComboBox()
        Me.txtSatisSayisi = New System.Windows.Forms.TextBox()
        Me.dateSatisTarihi = New System.Windows.Forms.DateTimePicker()
        Me.txtFiyat = New System.Windows.Forms.TextBox()
        Me.btnSatisEkle = New System.Windows.Forms.Button()
        Me.btnSatisGuncelle = New System.Windows.Forms.Button()
        Me.btnSatisSil = New System.Windows.Forms.Button()
        Me.btnSatinAl = New System.Windows.Forms.Button()
        Me.lstwSatislar = New System.Windows.Forms.ListView()
        Me.SatisID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubeID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KitapID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MusteriID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SatisSayisi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SatisTarihi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToplamTutar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelVeriler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgwSatisListesi = New System.Windows.Forms.DataGridView()
        Me.subeAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kitapAdi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatışSayısı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatışTarihi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fiyat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MüşteriAdı = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgwSatisListesi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFiyat
        '
        Me.lblFiyat.AutoSize = True
        Me.lblFiyat.BackColor = System.Drawing.Color.Gainsboro
        Me.lblFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiyat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblFiyat.ForeColor = System.Drawing.Color.Black
        Me.lblFiyat.Location = New System.Drawing.Point(21, 284)
        Me.lblFiyat.Name = "lblFiyat"
        Me.lblFiyat.Size = New System.Drawing.Size(66, 31)
        Me.lblFiyat.TabIndex = 16
        Me.lblFiyat.Text = "Fiyat"
        '
        'lblSatisTarihi
        '
        Me.lblSatisTarihi.AutoSize = True
        Me.lblSatisTarihi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSatisTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSatisTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSatisTarihi.ForeColor = System.Drawing.Color.Black
        Me.lblSatisTarihi.Location = New System.Drawing.Point(21, 235)
        Me.lblSatisTarihi.Name = "lblSatisTarihi"
        Me.lblSatisTarihi.Size = New System.Drawing.Size(136, 31)
        Me.lblSatisTarihi.TabIndex = 15
        Me.lblSatisTarihi.Text = "Satış Tarihi"
        '
        'lblSatisSayisi
        '
        Me.lblSatisSayisi.AutoSize = True
        Me.lblSatisSayisi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSatisSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSatisSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSatisSayisi.ForeColor = System.Drawing.Color.Black
        Me.lblSatisSayisi.Location = New System.Drawing.Point(21, 183)
        Me.lblSatisSayisi.Name = "lblSatisSayisi"
        Me.lblSatisSayisi.Size = New System.Drawing.Size(138, 31)
        Me.lblSatisSayisi.TabIndex = 14
        Me.lblSatisSayisi.Text = "Satış Sayısı"
        '
        'lblKitapID
        '
        Me.lblKitapID.AutoSize = True
        Me.lblKitapID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKitapID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKitapID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKitapID.ForeColor = System.Drawing.Color.Black
        Me.lblKitapID.Location = New System.Drawing.Point(21, 129)
        Me.lblKitapID.Name = "lblKitapID"
        Me.lblKitapID.Size = New System.Drawing.Size(99, 31)
        Me.lblKitapID.TabIndex = 13
        Me.lblKitapID.Text = "Kitap ID"
        '
        'lblMusteriID
        '
        Me.lblMusteriID.AutoSize = True
        Me.lblMusteriID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMusteriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMusteriID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMusteriID.ForeColor = System.Drawing.Color.Black
        Me.lblMusteriID.Location = New System.Drawing.Point(21, 74)
        Me.lblMusteriID.Name = "lblMusteriID"
        Me.lblMusteriID.Size = New System.Drawing.Size(123, 31)
        Me.lblMusteriID.TabIndex = 12
        Me.lblMusteriID.Text = "Müşteri ID"
        '
        'lblSubeID
        '
        Me.lblSubeID.AutoSize = True
        Me.lblSubeID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeID.ForeColor = System.Drawing.Color.Black
        Me.lblSubeID.Location = New System.Drawing.Point(21, 20)
        Me.lblSubeID.Name = "lblSubeID"
        Me.lblSubeID.Size = New System.Drawing.Size(101, 31)
        Me.lblSubeID.TabIndex = 11
        Me.lblSubeID.Text = "Şube ID"
        '
        'cbSubeID
        '
        Me.cbSubeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbSubeID.FormattingEnabled = True
        Me.cbSubeID.Location = New System.Drawing.Point(186, 20)
        Me.cbSubeID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSubeID.Name = "cbSubeID"
        Me.cbSubeID.Size = New System.Drawing.Size(307, 33)
        Me.cbSubeID.TabIndex = 17
        '
        'cbMusteriID
        '
        Me.cbMusteriID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbMusteriID.FormattingEnabled = True
        Me.cbMusteriID.Location = New System.Drawing.Point(186, 74)
        Me.cbMusteriID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbMusteriID.Name = "cbMusteriID"
        Me.cbMusteriID.Size = New System.Drawing.Size(307, 33)
        Me.cbMusteriID.TabIndex = 18
        '
        'cbKitapID
        '
        Me.cbKitapID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbKitapID.FormattingEnabled = True
        Me.cbKitapID.Location = New System.Drawing.Point(186, 129)
        Me.cbKitapID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbKitapID.Name = "cbKitapID"
        Me.cbKitapID.Size = New System.Drawing.Size(307, 33)
        Me.cbKitapID.TabIndex = 19
        '
        'txtSatisSayisi
        '
        Me.txtSatisSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSatisSayisi.Location = New System.Drawing.Point(186, 183)
        Me.txtSatisSayisi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSatisSayisi.Multiline = True
        Me.txtSatisSayisi.Name = "txtSatisSayisi"
        Me.txtSatisSayisi.Size = New System.Drawing.Size(307, 31)
        Me.txtSatisSayisi.TabIndex = 20
        '
        'dateSatisTarihi
        '
        Me.dateSatisTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dateSatisTarihi.Location = New System.Drawing.Point(186, 233)
        Me.dateSatisTarihi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateSatisTarihi.Name = "dateSatisTarihi"
        Me.dateSatisTarihi.Size = New System.Drawing.Size(307, 30)
        Me.dateSatisTarihi.TabIndex = 21
        '
        'txtFiyat
        '
        Me.txtFiyat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtFiyat.Location = New System.Drawing.Point(186, 284)
        Me.txtFiyat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFiyat.Multiline = True
        Me.txtFiyat.Name = "txtFiyat"
        Me.txtFiyat.Size = New System.Drawing.Size(307, 31)
        Me.txtFiyat.TabIndex = 22
        '
        'btnSatisEkle
        '
        Me.btnSatisEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSatisEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSatisEkle.Location = New System.Drawing.Point(527, 17)
        Me.btnSatisEkle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSatisEkle.Name = "btnSatisEkle"
        Me.btnSatisEkle.Size = New System.Drawing.Size(124, 66)
        Me.btnSatisEkle.TabIndex = 23
        Me.btnSatisEkle.Text = "Satış Ekle"
        Me.btnSatisEkle.UseVisualStyleBackColor = False
        '
        'btnSatisGuncelle
        '
        Me.btnSatisGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSatisGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSatisGuncelle.Location = New System.Drawing.Point(527, 95)
        Me.btnSatisGuncelle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSatisGuncelle.Name = "btnSatisGuncelle"
        Me.btnSatisGuncelle.Size = New System.Drawing.Size(124, 66)
        Me.btnSatisGuncelle.TabIndex = 24
        Me.btnSatisGuncelle.Text = "Satış Güncelle"
        Me.btnSatisGuncelle.UseVisualStyleBackColor = False
        '
        'btnSatisSil
        '
        Me.btnSatisSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSatisSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSatisSil.Location = New System.Drawing.Point(527, 173)
        Me.btnSatisSil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSatisSil.Name = "btnSatisSil"
        Me.btnSatisSil.Size = New System.Drawing.Size(124, 66)
        Me.btnSatisSil.TabIndex = 25
        Me.btnSatisSil.Text = "Satış Sil"
        Me.btnSatisSil.UseVisualStyleBackColor = False
        '
        'btnSatinAl
        '
        Me.btnSatinAl.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSatinAl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSatinAl.Location = New System.Drawing.Point(527, 250)
        Me.btnSatinAl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSatinAl.Name = "btnSatinAl"
        Me.btnSatinAl.Size = New System.Drawing.Size(124, 66)
        Me.btnSatinAl.TabIndex = 26
        Me.btnSatinAl.Text = "Satış Yap"
        Me.btnSatinAl.UseVisualStyleBackColor = False
        '
        'lstwSatislar
        '
        Me.lstwSatislar.AllowColumnReorder = True
        Me.lstwSatislar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstwSatislar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwSatislar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SatisID, Me.SubeID, Me.KitapID, Me.MusteriID, Me.SatisSayisi, Me.SatisTarihi, Me.ToplamTutar})
        Me.lstwSatislar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstwSatislar.FullRowSelect = True
        Me.lstwSatislar.GridLines = True
        Me.lstwSatislar.Location = New System.Drawing.Point(21, 346)
        Me.lstwSatislar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwSatislar.Name = "lstwSatislar"
        Me.lstwSatislar.Size = New System.Drawing.Size(1456, 410)
        Me.lstwSatislar.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstwSatislar.TabIndex = 7
        Me.lstwSatislar.UseCompatibleStateImageBehavior = False
        Me.lstwSatislar.View = System.Windows.Forms.View.Details
        '
        'SatisID
        '
        Me.SatisID.Text = "Satış ID"
        Me.SatisID.Width = 149
        '
        'SubeID
        '
        Me.SubeID.Text = "Şube ID"
        Me.SubeID.Width = 170
        '
        'KitapID
        '
        Me.KitapID.Text = "Kitap ID"
        Me.KitapID.Width = 155
        '
        'MusteriID
        '
        Me.MusteriID.Text = "Müşteri ID"
        Me.MusteriID.Width = 148
        '
        'SatisSayisi
        '
        Me.SatisSayisi.Text = "Satış Sayısı"
        Me.SatisSayisi.Width = 163
        '
        'SatisTarihi
        '
        Me.SatisTarihi.Text = "Satış Tarihi"
        Me.SatisTarihi.Width = 205
        '
        'ToplamTutar
        '
        Me.ToplamTutar.Text = "Toplam Tutar"
        Me.ToplamTutar.Width = 157
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelVeriler})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 777)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1494, 22)
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelVeriler
        '
        Me.ToolStripStatusLabelVeriler.Name = "ToolStripStatusLabelVeriler"
        Me.ToolStripStatusLabelVeriler.Size = New System.Drawing.Size(0, 17)
        '
        'dgwSatisListesi
        '
        Me.dgwSatisListesi.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwSatisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSatisListesi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subeAdi, Me.kitapAdi, Me.SatışSayısı, Me.SatışTarihi, Me.Fiyat, Me.MüşteriAdı})
        Me.dgwSatisListesi.Location = New System.Drawing.Point(684, 18)
        Me.dgwSatisListesi.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwSatisListesi.Name = "dgwSatisListesi"
        Me.dgwSatisListesi.Size = New System.Drawing.Size(793, 297)
        Me.dgwSatisListesi.TabIndex = 29
        '
        'subeAdi
        '
        Me.subeAdi.HeaderText = "ŞubeAdi"
        Me.subeAdi.Name = "subeAdi"
        '
        'kitapAdi
        '
        Me.kitapAdi.HeaderText = "KitapAdı"
        Me.kitapAdi.Name = "kitapAdi"
        '
        'SatışSayısı
        '
        Me.SatışSayısı.HeaderText = "SatışSayısı"
        Me.SatışSayısı.Name = "SatışSayısı"
        '
        'SatışTarihi
        '
        Me.SatışTarihi.HeaderText = "SatışTarihi"
        Me.SatışTarihi.Name = "SatışTarihi"
        '
        'Fiyat
        '
        Me.Fiyat.HeaderText = "Fiyat"
        Me.Fiyat.Name = "Fiyat"
        '
        'MüşteriAdı
        '
        Me.MüşteriAdı.HeaderText = "MüşteriAdı"
        Me.MüşteriAdı.Name = "MüşteriAdı"
        '
        'SatisEkrani
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1494, 799)
        Me.Controls.Add(Me.dgwSatisListesi)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lstwSatislar)
        Me.Controls.Add(Me.btnSatinAl)
        Me.Controls.Add(Me.btnSatisSil)
        Me.Controls.Add(Me.btnSatisGuncelle)
        Me.Controls.Add(Me.btnSatisEkle)
        Me.Controls.Add(Me.txtFiyat)
        Me.Controls.Add(Me.dateSatisTarihi)
        Me.Controls.Add(Me.txtSatisSayisi)
        Me.Controls.Add(Me.cbKitapID)
        Me.Controls.Add(Me.cbMusteriID)
        Me.Controls.Add(Me.cbSubeID)
        Me.Controls.Add(Me.lblFiyat)
        Me.Controls.Add(Me.lblSatisTarihi)
        Me.Controls.Add(Me.lblSatisSayisi)
        Me.Controls.Add(Me.lblKitapID)
        Me.Controls.Add(Me.lblMusteriID)
        Me.Controls.Add(Me.lblSubeID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SatisEkrani"
        Me.Text = "W"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgwSatisListesi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFiyat As Label
    Friend WithEvents lblSatisTarihi As Label
    Friend WithEvents lblSatisSayisi As Label
    Friend WithEvents lblKitapID As Label
    Friend WithEvents lblMusteriID As Label
    Friend WithEvents lblSubeID As Label
    Friend WithEvents cbSubeID As ComboBox
    Friend WithEvents cbMusteriID As ComboBox
    Friend WithEvents cbKitapID As ComboBox
    Friend WithEvents txtSatisSayisi As TextBox
    Friend WithEvents dateSatisTarihi As DateTimePicker
    Friend WithEvents txtFiyat As TextBox
    Friend WithEvents btnSatisEkle As Button
    Friend WithEvents btnSatisGuncelle As Button
    Friend WithEvents btnSatisSil As Button
    Friend WithEvents btnSatinAl As Button
    Friend WithEvents lstwSatislar As ListView
    Private WithEvents SatisID As ColumnHeader
    Private WithEvents SubeID As ColumnHeader
    Private WithEvents KitapID As ColumnHeader
    Private WithEvents MusteriID As ColumnHeader
    Private WithEvents SatisSayisi As ColumnHeader
    Private WithEvents SatisTarihi As ColumnHeader
    Private WithEvents ToplamTutar As ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelVeriler As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgwSatisListesi As System.Windows.Forms.DataGridView
    Friend WithEvents subeAdi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kitapAdi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatışSayısı As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatışTarihi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fiyat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MüşteriAdı As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
