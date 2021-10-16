<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KullaniciArayuzu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KullaniciArayuzu))
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.gbKitapSorgula = New System.Windows.Forms.GroupBox()
        Me.txtKitapAra = New System.Windows.Forms.TextBox()
        Me.pbResim = New System.Windows.Forms.PictureBox()
        Me.pbResimAra = New System.Windows.Forms.PictureBox()
        Me.gbSubeAdetSayisi = New System.Windows.Forms.GroupBox()
        Me.lstwAdetler = New System.Windows.Forms.ListView()
        Me.columnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbKategoriler = New System.Windows.Forms.GroupBox()
        Me.lstKategoriler = New System.Windows.Forms.ListBox()
        Me.gbYayinEviBilgileri = New System.Windows.Forms.GroupBox()
        Me.txtYayınEviAdi = New System.Windows.Forms.TextBox()
        Me.lblYayinEviAdi = New System.Windows.Forms.Label()
        Me.txtSokak = New System.Windows.Forms.TextBox()
        Me.txtKat = New System.Windows.Forms.TextBox()
        Me.txtIl = New System.Windows.Forms.TextBox()
        Me.txtPostaKodu = New System.Windows.Forms.TextBox()
        Me.txtIlce = New System.Windows.Forms.TextBox()
        Me.txtDaireNo = New System.Windows.Forms.TextBox()
        Me.txtBinaNo = New System.Windows.Forms.TextBox()
        Me.txtMahalle = New System.Windows.Forms.TextBox()
        Me.txtCadde = New System.Windows.Forms.TextBox()
        Me.lblCadde = New System.Windows.Forms.Label()
        Me.lblPostaKodu = New System.Windows.Forms.Label()
        Me.lblDaireNo = New System.Windows.Forms.Label()
        Me.lblIlce = New System.Windows.Forms.Label()
        Me.lblIl = New System.Windows.Forms.Label()
        Me.lblBinaNo = New System.Windows.Forms.Label()
        Me.lblKat = New System.Windows.Forms.Label()
        Me.lblMahalle = New System.Windows.Forms.Label()
        Me.lblSokak = New System.Windows.Forms.Label()
        Me.lstwKitaplar = New System.Windows.Forms.ListView()
        Me.columnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbYazarlar = New System.Windows.Forms.GroupBox()
        Me.lstwYazarlar = New System.Windows.Forms.ListView()
        Me.columnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbKitapSorgula.SuspendLayout()
        CType(Me.pbResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbResimAra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSubeAdetSayisi.SuspendLayout()
        Me.gbKategoriler.SuspendLayout()
        Me.gbYayinEviBilgileri.SuspendLayout()
        Me.gbYazarlar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCikis
        '
        Me.btnCikis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCikis.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCikis.ForeColor = System.Drawing.Color.Black
        Me.btnCikis.Location = New System.Drawing.Point(1198, 725)
        Me.btnCikis.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(242, 48)
        Me.btnCikis.TabIndex = 36
        Me.btnCikis.Text = "Kapat"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'gbKitapSorgula
        '
        Me.gbKitapSorgula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbKitapSorgula.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbKitapSorgula.Controls.Add(Me.txtKitapAra)
        Me.gbKitapSorgula.Controls.Add(Me.pbResim)
        Me.gbKitapSorgula.Controls.Add(Me.pbResimAra)
        Me.gbKitapSorgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbKitapSorgula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbKitapSorgula.ForeColor = System.Drawing.Color.Black
        Me.gbKitapSorgula.Location = New System.Drawing.Point(30, 13)
        Me.gbKitapSorgula.Margin = New System.Windows.Forms.Padding(4)
        Me.gbKitapSorgula.Name = "gbKitapSorgula"
        Me.gbKitapSorgula.Padding = New System.Windows.Forms.Padding(4)
        Me.gbKitapSorgula.Size = New System.Drawing.Size(1414, 92)
        Me.gbKitapSorgula.TabIndex = 31
        Me.gbKitapSorgula.TabStop = False
        Me.gbKitapSorgula.Text = "Kitap Sorgula"
        '
        'txtKitapAra
        '
        Me.txtKitapAra.BackColor = System.Drawing.Color.White
        Me.txtKitapAra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKitapAra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKitapAra.ForeColor = System.Drawing.Color.Black
        Me.txtKitapAra.Location = New System.Drawing.Point(504, 41)
        Me.txtKitapAra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKitapAra.Name = "txtKitapAra"
        Me.txtKitapAra.Size = New System.Drawing.Size(232, 23)
        Me.txtKitapAra.TabIndex = 19
        '
        'pbResim
        '
        Me.pbResim.Image = Global.KitapciOtomasyonProjesi.My.Resources.Resources.find
        Me.pbResim.Location = New System.Drawing.Point(766, 33)
        Me.pbResim.Margin = New System.Windows.Forms.Padding(4)
        Me.pbResim.Name = "pbResim"
        Me.pbResim.Size = New System.Drawing.Size(55, 41)
        Me.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbResim.TabIndex = 18
        Me.pbResim.TabStop = False
        '
        'pbResimAra
        '
        Me.pbResimAra.Image = Global.KitapciOtomasyonProjesi.My.Resources.Resources.nobetci
        Me.pbResimAra.Location = New System.Drawing.Point(481, 22)
        Me.pbResimAra.Margin = New System.Windows.Forms.Padding(4)
        Me.pbResimAra.Name = "pbResimAra"
        Me.pbResimAra.Size = New System.Drawing.Size(275, 62)
        Me.pbResimAra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbResimAra.TabIndex = 17
        Me.pbResimAra.TabStop = False
        '
        'gbSubeAdetSayisi
        '
        Me.gbSubeAdetSayisi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSubeAdetSayisi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbSubeAdetSayisi.Controls.Add(Me.lstwAdetler)
        Me.gbSubeAdetSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbSubeAdetSayisi.ForeColor = System.Drawing.Color.Black
        Me.gbSubeAdetSayisi.Location = New System.Drawing.Point(30, 541)
        Me.gbSubeAdetSayisi.Margin = New System.Windows.Forms.Padding(4)
        Me.gbSubeAdetSayisi.Name = "gbSubeAdetSayisi"
        Me.gbSubeAdetSayisi.Padding = New System.Windows.Forms.Padding(4)
        Me.gbSubeAdetSayisi.Size = New System.Drawing.Size(489, 172)
        Me.gbSubeAdetSayisi.TabIndex = 35
        Me.gbSubeAdetSayisi.TabStop = False
        Me.gbSubeAdetSayisi.Text = "Şubedeki Adet Sayısı "
        '
        'lstwAdetler
        '
        Me.lstwAdetler.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwAdetler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstwAdetler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader20, Me.columnHeader21, Me.columnHeader22})
        Me.lstwAdetler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstwAdetler.ForeColor = System.Drawing.Color.Black
        Me.lstwAdetler.FullRowSelect = True
        Me.lstwAdetler.GridLines = True
        Me.lstwAdetler.Location = New System.Drawing.Point(4, 27)
        Me.lstwAdetler.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwAdetler.Name = "lstwAdetler"
        Me.lstwAdetler.Size = New System.Drawing.Size(481, 141)
        Me.lstwAdetler.TabIndex = 8
        Me.lstwAdetler.UseCompatibleStateImageBehavior = False
        Me.lstwAdetler.View = System.Windows.Forms.View.Details
        '
        'columnHeader20
        '
        Me.columnHeader20.Text = "Sube ID"
        Me.columnHeader20.Width = 107
        '
        'columnHeader21
        '
        Me.columnHeader21.Text = "Sube Adı"
        Me.columnHeader21.Width = 135
        '
        'columnHeader22
        '
        Me.columnHeader22.Text = "Adet Sayısı"
        Me.columnHeader22.Width = 135
        '
        'gbKategoriler
        '
        Me.gbKategoriler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbKategoriler.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbKategoriler.Controls.Add(Me.lstKategoriler)
        Me.gbKategoriler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbKategoriler.ForeColor = System.Drawing.Color.Black
        Me.gbKategoriler.Location = New System.Drawing.Point(1123, 541)
        Me.gbKategoriler.Margin = New System.Windows.Forms.Padding(4)
        Me.gbKategoriler.Name = "gbKategoriler"
        Me.gbKategoriler.Padding = New System.Windows.Forms.Padding(4)
        Me.gbKategoriler.Size = New System.Drawing.Size(321, 172)
        Me.gbKategoriler.TabIndex = 32
        Me.gbKategoriler.TabStop = False
        Me.gbKategoriler.Text = "Kategoriler"
        '
        'lstKategoriler
        '
        Me.lstKategoriler.BackColor = System.Drawing.Color.Gainsboro
        Me.lstKategoriler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstKategoriler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstKategoriler.ForeColor = System.Drawing.Color.Black
        Me.lstKategoriler.FormattingEnabled = True
        Me.lstKategoriler.ItemHeight = 25
        Me.lstKategoriler.Location = New System.Drawing.Point(4, 27)
        Me.lstKategoriler.Margin = New System.Windows.Forms.Padding(4)
        Me.lstKategoriler.Name = "lstKategoriler"
        Me.lstKategoriler.Size = New System.Drawing.Size(313, 141)
        Me.lstKategoriler.TabIndex = 0
        '
        'gbYayinEviBilgileri
        '
        Me.gbYayinEviBilgileri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbYayinEviBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayınEviAdi)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviAdi)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtSokak)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtKat)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtIl)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtPostaKodu)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtIlce)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtDaireNo)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtBinaNo)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtMahalle)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtCadde)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblCadde)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblPostaKodu)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblDaireNo)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblIlce)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblIl)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblBinaNo)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblKat)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblMahalle)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblSokak)
        Me.gbYayinEviBilgileri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbYayinEviBilgileri.ForeColor = System.Drawing.Color.Black
        Me.gbYayinEviBilgileri.Location = New System.Drawing.Point(1095, 115)
        Me.gbYayinEviBilgileri.Margin = New System.Windows.Forms.Padding(4)
        Me.gbYayinEviBilgileri.Name = "gbYayinEviBilgileri"
        Me.gbYayinEviBilgileri.Padding = New System.Windows.Forms.Padding(4)
        Me.gbYayinEviBilgileri.Size = New System.Drawing.Size(345, 418)
        Me.gbYayinEviBilgileri.TabIndex = 33
        Me.gbYayinEviBilgileri.TabStop = False
        Me.gbYayinEviBilgileri.Text = " Yayın Evi Bilgileri"
        '
        'txtYayınEviAdi
        '
        Me.txtYayınEviAdi.ForeColor = System.Drawing.Color.Black
        Me.txtYayınEviAdi.Location = New System.Drawing.Point(160, 33)
        Me.txtYayınEviAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayınEviAdi.Name = "txtYayınEviAdi"
        Me.txtYayınEviAdi.ReadOnly = True
        Me.txtYayınEviAdi.Size = New System.Drawing.Size(172, 30)
        Me.txtYayınEviAdi.TabIndex = 1
        '
        'lblYayinEviAdi
        '
        Me.lblYayinEviAdi.AutoSize = True
        Me.lblYayinEviAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYayinEviAdi.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviAdi.Location = New System.Drawing.Point(17, 36)
        Me.lblYayinEviAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviAdi.Name = "lblYayinEviAdi"
        Me.lblYayinEviAdi.Size = New System.Drawing.Size(124, 27)
        Me.lblYayinEviAdi.TabIndex = 0
        Me.lblYayinEviAdi.Text = "YayınEvi Adı"
        '
        'txtSokak
        '
        Me.txtSokak.ForeColor = System.Drawing.Color.Black
        Me.txtSokak.Location = New System.Drawing.Point(161, 109)
        Me.txtSokak.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSokak.Name = "txtSokak"
        Me.txtSokak.ReadOnly = True
        Me.txtSokak.Size = New System.Drawing.Size(172, 30)
        Me.txtSokak.TabIndex = 22
        '
        'txtKat
        '
        Me.txtKat.ForeColor = System.Drawing.Color.Black
        Me.txtKat.Location = New System.Drawing.Point(161, 223)
        Me.txtKat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKat.Name = "txtKat"
        Me.txtKat.ReadOnly = True
        Me.txtKat.Size = New System.Drawing.Size(172, 30)
        Me.txtKat.TabIndex = 23
        '
        'txtIl
        '
        Me.txtIl.ForeColor = System.Drawing.Color.Black
        Me.txtIl.Location = New System.Drawing.Point(161, 337)
        Me.txtIl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIl.Name = "txtIl"
        Me.txtIl.ReadOnly = True
        Me.txtIl.Size = New System.Drawing.Size(172, 30)
        Me.txtIl.TabIndex = 27
        '
        'txtPostaKodu
        '
        Me.txtPostaKodu.ForeColor = System.Drawing.Color.Black
        Me.txtPostaKodu.Location = New System.Drawing.Point(161, 376)
        Me.txtPostaKodu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPostaKodu.Name = "txtPostaKodu"
        Me.txtPostaKodu.ReadOnly = True
        Me.txtPostaKodu.Size = New System.Drawing.Size(172, 30)
        Me.txtPostaKodu.TabIndex = 26
        '
        'txtIlce
        '
        Me.txtIlce.ForeColor = System.Drawing.Color.Black
        Me.txtIlce.Location = New System.Drawing.Point(161, 299)
        Me.txtIlce.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIlce.Name = "txtIlce"
        Me.txtIlce.ReadOnly = True
        Me.txtIlce.Size = New System.Drawing.Size(172, 30)
        Me.txtIlce.TabIndex = 25
        '
        'txtDaireNo
        '
        Me.txtDaireNo.ForeColor = System.Drawing.Color.Black
        Me.txtDaireNo.Location = New System.Drawing.Point(161, 261)
        Me.txtDaireNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDaireNo.Name = "txtDaireNo"
        Me.txtDaireNo.ReadOnly = True
        Me.txtDaireNo.Size = New System.Drawing.Size(172, 30)
        Me.txtDaireNo.TabIndex = 24
        '
        'txtBinaNo
        '
        Me.txtBinaNo.ForeColor = System.Drawing.Color.Black
        Me.txtBinaNo.Location = New System.Drawing.Point(161, 185)
        Me.txtBinaNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBinaNo.Name = "txtBinaNo"
        Me.txtBinaNo.ReadOnly = True
        Me.txtBinaNo.Size = New System.Drawing.Size(172, 30)
        Me.txtBinaNo.TabIndex = 28
        '
        'txtMahalle
        '
        Me.txtMahalle.ForeColor = System.Drawing.Color.Black
        Me.txtMahalle.Location = New System.Drawing.Point(161, 147)
        Me.txtMahalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMahalle.Name = "txtMahalle"
        Me.txtMahalle.ReadOnly = True
        Me.txtMahalle.Size = New System.Drawing.Size(172, 30)
        Me.txtMahalle.TabIndex = 29
        '
        'txtCadde
        '
        Me.txtCadde.ForeColor = System.Drawing.Color.Black
        Me.txtCadde.Location = New System.Drawing.Point(160, 71)
        Me.txtCadde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCadde.Name = "txtCadde"
        Me.txtCadde.ReadOnly = True
        Me.txtCadde.Size = New System.Drawing.Size(172, 30)
        Me.txtCadde.TabIndex = 30
        '
        'lblCadde
        '
        Me.lblCadde.AutoSize = True
        Me.lblCadde.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCadde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCadde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCadde.ForeColor = System.Drawing.Color.Black
        Me.lblCadde.Location = New System.Drawing.Point(17, 74)
        Me.lblCadde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCadde.Name = "lblCadde"
        Me.lblCadde.Size = New System.Drawing.Size(73, 27)
        Me.lblCadde.TabIndex = 13
        Me.lblCadde.Text = "Cadde"
        '
        'lblPostaKodu
        '
        Me.lblPostaKodu.AutoSize = True
        Me.lblPostaKodu.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPostaKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostaKodu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPostaKodu.ForeColor = System.Drawing.Color.Black
        Me.lblPostaKodu.Location = New System.Drawing.Point(17, 379)
        Me.lblPostaKodu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPostaKodu.Name = "lblPostaKodu"
        Me.lblPostaKodu.Size = New System.Drawing.Size(116, 27)
        Me.lblPostaKodu.TabIndex = 15
        Me.lblPostaKodu.Text = "Posta Kodu"
        '
        'lblDaireNo
        '
        Me.lblDaireNo.AutoSize = True
        Me.lblDaireNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDaireNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDaireNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDaireNo.ForeColor = System.Drawing.Color.Black
        Me.lblDaireNo.Location = New System.Drawing.Point(17, 264)
        Me.lblDaireNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDaireNo.Name = "lblDaireNo"
        Me.lblDaireNo.Size = New System.Drawing.Size(90, 27)
        Me.lblDaireNo.TabIndex = 14
        Me.lblDaireNo.Text = "Daire No"
        '
        'lblIlce
        '
        Me.lblIlce.AutoSize = True
        Me.lblIlce.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIlce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIlce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIlce.ForeColor = System.Drawing.Color.Black
        Me.lblIlce.Location = New System.Drawing.Point(17, 302)
        Me.lblIlce.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIlce.Name = "lblIlce"
        Me.lblIlce.Size = New System.Drawing.Size(44, 27)
        Me.lblIlce.TabIndex = 17
        Me.lblIlce.Text = "İlçe"
        '
        'lblIl
        '
        Me.lblIl.AutoSize = True
        Me.lblIl.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIl.ForeColor = System.Drawing.Color.Black
        Me.lblIl.Location = New System.Drawing.Point(17, 340)
        Me.lblIl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIl.Name = "lblIl"
        Me.lblIl.Size = New System.Drawing.Size(23, 27)
        Me.lblIl.TabIndex = 19
        Me.lblIl.Text = "İl"
        '
        'lblBinaNo
        '
        Me.lblBinaNo.AutoSize = True
        Me.lblBinaNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblBinaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBinaNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBinaNo.ForeColor = System.Drawing.Color.Black
        Me.lblBinaNo.Location = New System.Drawing.Point(17, 188)
        Me.lblBinaNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBinaNo.Name = "lblBinaNo"
        Me.lblBinaNo.Size = New System.Drawing.Size(78, 27)
        Me.lblBinaNo.TabIndex = 16
        Me.lblBinaNo.Text = "BinaNo"
        '
        'lblKat
        '
        Me.lblKat.AutoSize = True
        Me.lblKat.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblKat.ForeColor = System.Drawing.Color.Black
        Me.lblKat.Location = New System.Drawing.Point(17, 226)
        Me.lblKat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKat.Name = "lblKat"
        Me.lblKat.Size = New System.Drawing.Size(44, 27)
        Me.lblKat.TabIndex = 18
        Me.lblKat.Text = "Kat"
        '
        'lblMahalle
        '
        Me.lblMahalle.AutoSize = True
        Me.lblMahalle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMahalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMahalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMahalle.ForeColor = System.Drawing.Color.Black
        Me.lblMahalle.Location = New System.Drawing.Point(17, 150)
        Me.lblMahalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMahalle.Name = "lblMahalle"
        Me.lblMahalle.Size = New System.Drawing.Size(83, 27)
        Me.lblMahalle.TabIndex = 20
        Me.lblMahalle.Text = "Mahalle"
        '
        'lblSokak
        '
        Me.lblSokak.AutoSize = True
        Me.lblSokak.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSokak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSokak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSokak.ForeColor = System.Drawing.Color.Black
        Me.lblSokak.Location = New System.Drawing.Point(17, 112)
        Me.lblSokak.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSokak.Name = "lblSokak"
        Me.lblSokak.Size = New System.Drawing.Size(70, 27)
        Me.lblSokak.TabIndex = 21
        Me.lblSokak.Text = "Sokak"
        '
        'lstwKitaplar
        '
        Me.lstwKitaplar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstwKitaplar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwKitaplar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstwKitaplar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader11, Me.columnHeader12, Me.columnHeader13, Me.columnHeader14, Me.columnHeader15, Me.columnHeader16})
        Me.lstwKitaplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwKitaplar.ForeColor = System.Drawing.Color.Black
        Me.lstwKitaplar.FullRowSelect = True
        Me.lstwKitaplar.GridLines = True
        Me.lstwKitaplar.Location = New System.Drawing.Point(30, 114)
        Me.lstwKitaplar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwKitaplar.Name = "lstwKitaplar"
        Me.lstwKitaplar.Size = New System.Drawing.Size(1051, 418)
        Me.lstwKitaplar.TabIndex = 30
        Me.lstwKitaplar.UseCompatibleStateImageBehavior = False
        Me.lstwKitaplar.View = System.Windows.Forms.View.Details
        '
        'columnHeader11
        '
        Me.columnHeader11.Text = "Kitap ID"
        Me.columnHeader11.Width = 93
        '
        'columnHeader12
        '
        Me.columnHeader12.Text = "Kitap Adı"
        Me.columnHeader12.Width = 232
        '
        'columnHeader13
        '
        Me.columnHeader13.Text = "Yayın Tarihi"
        Me.columnHeader13.Width = 164
        '
        'columnHeader14
        '
        Me.columnHeader14.Text = "Sayfa Sayısı"
        Me.columnHeader14.Width = 131
        '
        'columnHeader15
        '
        Me.columnHeader15.Text = "Yayın Evi ID"
        Me.columnHeader15.Width = 117
        '
        'columnHeader16
        '
        Me.columnHeader16.Text = "Satış Fiyatı"
        Me.columnHeader16.Width = 173
        '
        'gbYazarlar
        '
        Me.gbYazarlar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbYazarlar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbYazarlar.Controls.Add(Me.lstwYazarlar)
        Me.gbYazarlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbYazarlar.ForeColor = System.Drawing.Color.Black
        Me.gbYazarlar.Location = New System.Drawing.Point(543, 541)
        Me.gbYazarlar.Margin = New System.Windows.Forms.Padding(4)
        Me.gbYazarlar.Name = "gbYazarlar"
        Me.gbYazarlar.Padding = New System.Windows.Forms.Padding(4)
        Me.gbYazarlar.Size = New System.Drawing.Size(557, 172)
        Me.gbYazarlar.TabIndex = 34
        Me.gbYazarlar.TabStop = False
        Me.gbYazarlar.Text = "Yazarlar"
        '
        'lstwYazarlar
        '
        Me.lstwYazarlar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwYazarlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstwYazarlar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader17, Me.columnHeader18, Me.columnHeader19})
        Me.lstwYazarlar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstwYazarlar.ForeColor = System.Drawing.Color.Black
        Me.lstwYazarlar.FullRowSelect = True
        Me.lstwYazarlar.GridLines = True
        Me.lstwYazarlar.Location = New System.Drawing.Point(4, 27)
        Me.lstwYazarlar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwYazarlar.Name = "lstwYazarlar"
        Me.lstwYazarlar.Size = New System.Drawing.Size(549, 141)
        Me.lstwYazarlar.TabIndex = 8
        Me.lstwYazarlar.UseCompatibleStateImageBehavior = False
        Me.lstwYazarlar.View = System.Windows.Forms.View.Details
        '
        'columnHeader17
        '
        Me.columnHeader17.Text = "Yazar ID"
        Me.columnHeader17.Width = 96
        '
        'columnHeader18
        '
        Me.columnHeader18.Text = "Yazar Adı"
        Me.columnHeader18.Width = 162
        '
        'columnHeader19
        '
        Me.columnHeader19.Text = "Yazar Soyadı"
        Me.columnHeader19.Width = 156
        '
        'KullaniciArayuzu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1473, 786)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.gbKitapSorgula)
        Me.Controls.Add(Me.gbSubeAdetSayisi)
        Me.Controls.Add(Me.gbKategoriler)
        Me.Controls.Add(Me.gbYayinEviBilgileri)
        Me.Controls.Add(Me.lstwKitaplar)
        Me.Controls.Add(Me.gbYazarlar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KullaniciArayuzu"
        Me.Text = "Kullanıcı Arayüzü"
        Me.gbKitapSorgula.ResumeLayout(False)
        Me.gbKitapSorgula.PerformLayout()
        CType(Me.pbResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbResimAra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSubeAdetSayisi.ResumeLayout(False)
        Me.gbKategoriler.ResumeLayout(False)
        Me.gbYayinEviBilgileri.ResumeLayout(False)
        Me.gbYayinEviBilgileri.PerformLayout()
        Me.gbYazarlar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnCikis As Button
    Private WithEvents gbKitapSorgula As GroupBox
    Private WithEvents txtKitapAra As TextBox
    Private WithEvents pbResim As PictureBox
    Private WithEvents pbResimAra As PictureBox
    Private WithEvents gbSubeAdetSayisi As GroupBox
    Private WithEvents lstwAdetler As ListView
    Private WithEvents columnHeader20 As ColumnHeader
    Private WithEvents columnHeader21 As ColumnHeader
    Private WithEvents columnHeader22 As ColumnHeader
    Private WithEvents gbKategoriler As GroupBox
    Private WithEvents lstKategoriler As ListBox
    Private WithEvents gbYayinEviBilgileri As GroupBox
    Private WithEvents txtYayınEviAdi As TextBox
    Private WithEvents lblYayinEviAdi As Label
    Private WithEvents txtSokak As TextBox
    Private WithEvents txtKat As TextBox
    Private WithEvents txtIl As TextBox
    Private WithEvents txtPostaKodu As TextBox
    Private WithEvents txtIlce As TextBox
    Private WithEvents txtDaireNo As TextBox
    Private WithEvents txtBinaNo As TextBox
    Private WithEvents txtMahalle As TextBox
    Private WithEvents txtCadde As TextBox
    Private WithEvents lblCadde As Label
    Private WithEvents lblPostaKodu As Label
    Private WithEvents lblDaireNo As Label
    Private WithEvents lblIlce As Label
    Private WithEvents lblIl As Label
    Private WithEvents lblBinaNo As Label
    Private WithEvents lblKat As Label
    Private WithEvents lblMahalle As Label
    Private WithEvents lblSokak As Label
    Private WithEvents lstwKitaplar As ListView
    Private WithEvents columnHeader11 As ColumnHeader
    Private WithEvents columnHeader12 As ColumnHeader
    Private WithEvents columnHeader13 As ColumnHeader
    Private WithEvents columnHeader14 As ColumnHeader
    Private WithEvents columnHeader15 As ColumnHeader
    Private WithEvents columnHeader16 As ColumnHeader
    Private WithEvents gbYazarlar As GroupBox
    Private WithEvents lstwYazarlar As ListView
    Private WithEvents columnHeader17 As ColumnHeader
    Private WithEvents columnHeader18 As ColumnHeader
    Private WithEvents columnHeader19 As ColumnHeader
End Class
