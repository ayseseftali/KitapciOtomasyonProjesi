<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YöneticiArayuzu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YöneticiArayuzu))
        Me.txtSubeKat = New System.Windows.Forms.TextBox()
        Me.txtSubeIl = New System.Windows.Forms.TextBox()
        Me.gbSubeBilgileri = New System.Windows.Forms.GroupBox()
        Me.lblBagliSube = New System.Windows.Forms.Label()
        Me.txtSubeSokak = New System.Windows.Forms.TextBox()
        Me.txtSubeAdi = New System.Windows.Forms.TextBox()
        Me.txtSubePostaKodu = New System.Windows.Forms.TextBox()
        Me.txtSubeIlce = New System.Windows.Forms.TextBox()
        Me.txtSubeDaireNo = New System.Windows.Forms.TextBox()
        Me.txtSubeBinaNo = New System.Windows.Forms.TextBox()
        Me.txtSubeMahalle = New System.Windows.Forms.TextBox()
        Me.txtSubeCadde = New System.Windows.Forms.TextBox()
        Me.lblSubeCadde = New System.Windows.Forms.Label()
        Me.lblSubePostaKodu = New System.Windows.Forms.Label()
        Me.lblSubeDaireNo = New System.Windows.Forms.Label()
        Me.lblSubeIlce = New System.Windows.Forms.Label()
        Me.lblSubeIl = New System.Windows.Forms.Label()
        Me.lblSubeBinaNo = New System.Windows.Forms.Label()
        Me.lblSubeKat = New System.Windows.Forms.Label()
        Me.lblSubeMahalle = New System.Windows.Forms.Label()
        Me.lblSubeSokak = New System.Windows.Forms.Label()
        Me.txtSokak = New System.Windows.Forms.TextBox()
        Me.txtKat = New System.Windows.Forms.TextBox()
        Me.txtIl = New System.Windows.Forms.TextBox()
        Me.txtPostaKodu = New System.Windows.Forms.TextBox()
        Me.txtIlce = New System.Windows.Forms.TextBox()
        Me.txtDaireNo = New System.Windows.Forms.TextBox()
        Me.txtBinaNo = New System.Windows.Forms.TextBox()
        Me.txtMahalle = New System.Windows.Forms.TextBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.txtCalisanAra = New System.Windows.Forms.TextBox()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.txtCadde = New System.Windows.Forms.TextBox()
        Me.lblCadde = New System.Windows.Forms.Label()
        Me.lblPostaKodu = New System.Windows.Forms.Label()
        Me.lblDaireNo = New System.Windows.Forms.Label()
        Me.lblIlce = New System.Windows.Forms.Label()
        Me.btnYenile = New System.Windows.Forms.Button()
        Me.label21 = New System.Windows.Forms.Label()
        Me.lblIl = New System.Windows.Forms.Label()
        Me.lblBinaNo = New System.Windows.Forms.Label()
        Me.lblKat = New System.Windows.Forms.Label()
        Me.lblMahalle = New System.Windows.Forms.Label()
        Me.lblSokak = New System.Windows.Forms.Label()
        Me.btnSil = New System.Windows.Forms.Button()
        Me.gbAdresBilgileri = New System.Windows.Forms.GroupBox()
        Me.gbCalisanBilgileri = New System.Windows.Forms.GroupBox()
        Me.mtxtTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtPozisyon = New System.Windows.Forms.TextBox()
        Me.txtEposta = New System.Windows.Forms.TextBox()
        Me.txtCinsiyet = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblPozisyon = New System.Windows.Forms.Label()
        Me.lblEposta = New System.Windows.Forms.Label()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblCinsiyet = New System.Windows.Forms.Label()
        Me.lblSoyad = New System.Windows.Forms.Label()
        Me.lstwCalisanlar = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabControlIslemler = New System.Windows.Forms.TabControl()
        Me.tabPageCalisanlar = New System.Windows.Forms.TabPage()
        Me.pbAraResim = New System.Windows.Forms.PictureBox()
        Me.tabPageKitaplar = New System.Windows.Forms.TabPage()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.btnKitapGuncelle = New System.Windows.Forms.Button()
        Me.btnKitapSil = New System.Windows.Forms.Button()
        Me.btnKitapEkle = New System.Windows.Forms.Button()
        Me.gbSubeAdetSayisi = New System.Windows.Forms.GroupBox()
        Me.txtAdet = New System.Windows.Forms.TextBox()
        Me.lblYeniKitap = New System.Windows.Forms.Label()
        Me.btnAdetSayisiniGuncelle = New System.Windows.Forms.Button()
        Me.lblSecilenKitapSube = New System.Windows.Forms.Label()
        Me.lstwAdetler = New System.Windows.Forms.ListView()
        Me.columnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSubelereAdetEkle = New System.Windows.Forms.Button()
        Me.gbYazarlar = New System.Windows.Forms.GroupBox()
        Me.lblSecilenKitapYazar = New System.Windows.Forms.Label()
        Me.lstwYazarlar = New System.Windows.Forms.ListView()
        Me.columnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnYazariSil = New System.Windows.Forms.Button()
        Me.btnYazarEkle = New System.Windows.Forms.Button()
        Me.gbKategoriler = New System.Windows.Forms.GroupBox()
        Me.lblSecilenKitapKategori = New System.Windows.Forms.Label()
        Me.lstKategoriler = New System.Windows.Forms.ListBox()
        Me.btnKategoriEkle = New System.Windows.Forms.Button()
        Me.btnKategoriyiSil = New System.Windows.Forms.Button()
        Me.gbYayinEviBilgileri = New System.Windows.Forms.GroupBox()
        Me.txtYayinEviPostaKodu = New System.Windows.Forms.TextBox()
        Me.txtYayinEviIl = New System.Windows.Forms.TextBox()
        Me.txtYayinEviIlce = New System.Windows.Forms.TextBox()
        Me.txtYayinEviDaireNo = New System.Windows.Forms.TextBox()
        Me.txtYayinEviKat = New System.Windows.Forms.TextBox()
        Me.txtYayinEviBinaNo = New System.Windows.Forms.TextBox()
        Me.txtYayinEviSokak = New System.Windows.Forms.TextBox()
        Me.txtYayinEviMahalle = New System.Windows.Forms.TextBox()
        Me.txtYayinEviCadde = New System.Windows.Forms.TextBox()
        Me.lblYayinEviCadde = New System.Windows.Forms.Label()
        Me.lblYayinEviPostaKodu = New System.Windows.Forms.Label()
        Me.lblYayinEviDaireNo = New System.Windows.Forms.Label()
        Me.lblYayinEviIlce = New System.Windows.Forms.Label()
        Me.lblYayinEviIl = New System.Windows.Forms.Label()
        Me.lblYayinEviBinaNo = New System.Windows.Forms.Label()
        Me.lblYayinEviKat = New System.Windows.Forms.Label()
        Me.lblYayinEviMahalle = New System.Windows.Forms.Label()
        Me.lblYayinEviSokak = New System.Windows.Forms.Label()
        Me.gbYayinEvi = New System.Windows.Forms.GroupBox()
        Me.txtYayınEviAdi = New System.Windows.Forms.TextBox()
        Me.lblYayinEviAdi = New System.Windows.Forms.Label()
        Me.lblKitapAra = New System.Windows.Forms.Label()
        Me.txtKitapAra = New System.Windows.Forms.TextBox()
        Me.lstwKitaplar = New System.Windows.Forms.ListView()
        Me.columnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbSubeBilgileri.SuspendLayout()
        Me.gbAdresBilgileri.SuspendLayout()
        Me.gbCalisanBilgileri.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControlIslemler.SuspendLayout()
        Me.tabPageCalisanlar.SuspendLayout()
        CType(Me.pbAraResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageKitaplar.SuspendLayout()
        Me.gbSubeAdetSayisi.SuspendLayout()
        Me.gbYazarlar.SuspendLayout()
        Me.gbKategoriler.SuspendLayout()
        Me.gbYayinEviBilgileri.SuspendLayout()
        Me.gbYayinEvi.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSubeKat
        '
        Me.txtSubeKat.Location = New System.Drawing.Point(390, 109)
        Me.txtSubeKat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeKat.Name = "txtSubeKat"
        Me.txtSubeKat.ReadOnly = True
        Me.txtSubeKat.Size = New System.Drawing.Size(103, 30)
        Me.txtSubeKat.TabIndex = 23
        '
        'txtSubeIl
        '
        Me.txtSubeIl.Location = New System.Drawing.Point(390, 71)
        Me.txtSubeIl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeIl.Name = "txtSubeIl"
        Me.txtSubeIl.ReadOnly = True
        Me.txtSubeIl.Size = New System.Drawing.Size(103, 30)
        Me.txtSubeIl.TabIndex = 27
        '
        'gbSubeBilgileri
        '
        Me.gbSubeBilgileri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSubeBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbSubeBilgileri.Controls.Add(Me.lblBagliSube)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeSokak)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeKat)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeAdi)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeIl)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubePostaKodu)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeIlce)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeDaireNo)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeBinaNo)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeMahalle)
        Me.gbSubeBilgileri.Controls.Add(Me.txtSubeCadde)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubeCadde)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubePostaKodu)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubeDaireNo)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubeIlce)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubeIl)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubeBinaNo)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubeKat)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubeMahalle)
        Me.gbSubeBilgileri.Controls.Add(Me.lblSubeSokak)
        Me.gbSubeBilgileri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbSubeBilgileri.ForeColor = System.Drawing.Color.Black
        Me.gbSubeBilgileri.Location = New System.Drawing.Point(1329, 8)
        Me.gbSubeBilgileri.Margin = New System.Windows.Forms.Padding(4)
        Me.gbSubeBilgileri.Name = "gbSubeBilgileri"
        Me.gbSubeBilgileri.Padding = New System.Windows.Forms.Padding(4)
        Me.gbSubeBilgileri.Size = New System.Drawing.Size(527, 278)
        Me.gbSubeBilgileri.TabIndex = 4
        Me.gbSubeBilgileri.TabStop = False
        Me.gbSubeBilgileri.Text = "Çalıştığı Şube ve Şube Adres Bilgileri"
        '
        'lblBagliSube
        '
        Me.lblBagliSube.AutoSize = True
        Me.lblBagliSube.BackColor = System.Drawing.Color.Gainsboro
        Me.lblBagliSube.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBagliSube.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBagliSube.ForeColor = System.Drawing.Color.Black
        Me.lblBagliSube.Location = New System.Drawing.Point(326, 165)
        Me.lblBagliSube.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBagliSube.Name = "lblBagliSube"
        Me.lblBagliSube.Size = New System.Drawing.Size(178, 27)
        Me.lblBagliSube.TabIndex = 5
        Me.lblBagliSube.Text = "Bağlı Olunan Şube" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtSubeSokak
        '
        Me.txtSubeSokak.Location = New System.Drawing.Point(158, 71)
        Me.txtSubeSokak.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeSokak.Name = "txtSubeSokak"
        Me.txtSubeSokak.ReadOnly = True
        Me.txtSubeSokak.Size = New System.Drawing.Size(129, 30)
        Me.txtSubeSokak.TabIndex = 22
        '
        'txtSubeAdi
        '
        Me.txtSubeAdi.BackColor = System.Drawing.Color.White
        Me.txtSubeAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubeAdi.ForeColor = System.Drawing.Color.Black
        Me.txtSubeAdi.Location = New System.Drawing.Point(343, 197)
        Me.txtSubeAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeAdi.Name = "txtSubeAdi"
        Me.txtSubeAdi.ReadOnly = True
        Me.txtSubeAdi.Size = New System.Drawing.Size(145, 30)
        Me.txtSubeAdi.TabIndex = 27
        Me.txtSubeAdi.Text = "Şube Adı"
        Me.txtSubeAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubePostaKodu
        '
        Me.txtSubePostaKodu.Location = New System.Drawing.Point(158, 223)
        Me.txtSubePostaKodu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubePostaKodu.Name = "txtSubePostaKodu"
        Me.txtSubePostaKodu.ReadOnly = True
        Me.txtSubePostaKodu.Size = New System.Drawing.Size(129, 30)
        Me.txtSubePostaKodu.TabIndex = 26
        '
        'txtSubeIlce
        '
        Me.txtSubeIlce.Location = New System.Drawing.Point(390, 33)
        Me.txtSubeIlce.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeIlce.Name = "txtSubeIlce"
        Me.txtSubeIlce.ReadOnly = True
        Me.txtSubeIlce.Size = New System.Drawing.Size(103, 30)
        Me.txtSubeIlce.TabIndex = 25
        '
        'txtSubeDaireNo
        '
        Me.txtSubeDaireNo.Location = New System.Drawing.Point(158, 185)
        Me.txtSubeDaireNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeDaireNo.Name = "txtSubeDaireNo"
        Me.txtSubeDaireNo.ReadOnly = True
        Me.txtSubeDaireNo.Size = New System.Drawing.Size(129, 30)
        Me.txtSubeDaireNo.TabIndex = 24
        '
        'txtSubeBinaNo
        '
        Me.txtSubeBinaNo.Location = New System.Drawing.Point(158, 147)
        Me.txtSubeBinaNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeBinaNo.Name = "txtSubeBinaNo"
        Me.txtSubeBinaNo.ReadOnly = True
        Me.txtSubeBinaNo.Size = New System.Drawing.Size(129, 30)
        Me.txtSubeBinaNo.TabIndex = 28
        '
        'txtSubeMahalle
        '
        Me.txtSubeMahalle.Location = New System.Drawing.Point(158, 109)
        Me.txtSubeMahalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeMahalle.Name = "txtSubeMahalle"
        Me.txtSubeMahalle.ReadOnly = True
        Me.txtSubeMahalle.Size = New System.Drawing.Size(129, 30)
        Me.txtSubeMahalle.TabIndex = 29
        '
        'txtSubeCadde
        '
        Me.txtSubeCadde.Location = New System.Drawing.Point(158, 33)
        Me.txtSubeCadde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeCadde.Name = "txtSubeCadde"
        Me.txtSubeCadde.ReadOnly = True
        Me.txtSubeCadde.Size = New System.Drawing.Size(129, 30)
        Me.txtSubeCadde.TabIndex = 30
        '
        'lblSubeCadde
        '
        Me.lblSubeCadde.AutoSize = True
        Me.lblSubeCadde.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeCadde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeCadde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeCadde.ForeColor = System.Drawing.Color.Black
        Me.lblSubeCadde.Location = New System.Drawing.Point(24, 36)
        Me.lblSubeCadde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeCadde.Name = "lblSubeCadde"
        Me.lblSubeCadde.Size = New System.Drawing.Size(73, 27)
        Me.lblSubeCadde.TabIndex = 13
        Me.lblSubeCadde.Text = "Cadde"
        '
        'lblSubePostaKodu
        '
        Me.lblSubePostaKodu.AutoSize = True
        Me.lblSubePostaKodu.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubePostaKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubePostaKodu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubePostaKodu.ForeColor = System.Drawing.Color.Black
        Me.lblSubePostaKodu.Location = New System.Drawing.Point(24, 225)
        Me.lblSubePostaKodu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubePostaKodu.Name = "lblSubePostaKodu"
        Me.lblSubePostaKodu.Size = New System.Drawing.Size(116, 27)
        Me.lblSubePostaKodu.TabIndex = 15
        Me.lblSubePostaKodu.Text = "Posta Kodu"
        '
        'lblSubeDaireNo
        '
        Me.lblSubeDaireNo.AutoSize = True
        Me.lblSubeDaireNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeDaireNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeDaireNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeDaireNo.ForeColor = System.Drawing.Color.Black
        Me.lblSubeDaireNo.Location = New System.Drawing.Point(24, 188)
        Me.lblSubeDaireNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeDaireNo.Name = "lblSubeDaireNo"
        Me.lblSubeDaireNo.Size = New System.Drawing.Size(90, 27)
        Me.lblSubeDaireNo.TabIndex = 14
        Me.lblSubeDaireNo.Text = "Daire No"
        '
        'lblSubeIlce
        '
        Me.lblSubeIlce.AutoSize = True
        Me.lblSubeIlce.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeIlce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeIlce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeIlce.ForeColor = System.Drawing.Color.Black
        Me.lblSubeIlce.Location = New System.Drawing.Point(336, 36)
        Me.lblSubeIlce.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeIlce.Name = "lblSubeIlce"
        Me.lblSubeIlce.Size = New System.Drawing.Size(44, 27)
        Me.lblSubeIlce.TabIndex = 17
        Me.lblSubeIlce.Text = "İlçe"
        '
        'lblSubeIl
        '
        Me.lblSubeIl.AutoSize = True
        Me.lblSubeIl.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeIl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeIl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeIl.ForeColor = System.Drawing.Color.Black
        Me.lblSubeIl.Location = New System.Drawing.Point(336, 74)
        Me.lblSubeIl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeIl.Name = "lblSubeIl"
        Me.lblSubeIl.Size = New System.Drawing.Size(23, 27)
        Me.lblSubeIl.TabIndex = 19
        Me.lblSubeIl.Text = "İl"
        '
        'lblSubeBinaNo
        '
        Me.lblSubeBinaNo.AutoSize = True
        Me.lblSubeBinaNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeBinaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeBinaNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeBinaNo.ForeColor = System.Drawing.Color.Black
        Me.lblSubeBinaNo.Location = New System.Drawing.Point(24, 150)
        Me.lblSubeBinaNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeBinaNo.Name = "lblSubeBinaNo"
        Me.lblSubeBinaNo.Size = New System.Drawing.Size(78, 27)
        Me.lblSubeBinaNo.TabIndex = 16
        Me.lblSubeBinaNo.Text = "BinaNo"
        '
        'lblSubeKat
        '
        Me.lblSubeKat.AutoSize = True
        Me.lblSubeKat.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeKat.ForeColor = System.Drawing.Color.Black
        Me.lblSubeKat.Location = New System.Drawing.Point(336, 112)
        Me.lblSubeKat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeKat.Name = "lblSubeKat"
        Me.lblSubeKat.Size = New System.Drawing.Size(44, 27)
        Me.lblSubeKat.TabIndex = 18
        Me.lblSubeKat.Text = "Kat"
        '
        'lblSubeMahalle
        '
        Me.lblSubeMahalle.AutoSize = True
        Me.lblSubeMahalle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeMahalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeMahalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeMahalle.ForeColor = System.Drawing.Color.Black
        Me.lblSubeMahalle.Location = New System.Drawing.Point(24, 112)
        Me.lblSubeMahalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeMahalle.Name = "lblSubeMahalle"
        Me.lblSubeMahalle.Size = New System.Drawing.Size(83, 27)
        Me.lblSubeMahalle.TabIndex = 20
        Me.lblSubeMahalle.Text = "Mahalle"
        '
        'lblSubeSokak
        '
        Me.lblSubeSokak.AutoSize = True
        Me.lblSubeSokak.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeSokak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeSokak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeSokak.ForeColor = System.Drawing.Color.Black
        Me.lblSubeSokak.Location = New System.Drawing.Point(24, 71)
        Me.lblSubeSokak.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeSokak.Name = "lblSubeSokak"
        Me.lblSubeSokak.Size = New System.Drawing.Size(70, 27)
        Me.lblSubeSokak.TabIndex = 21
        Me.lblSubeSokak.Text = "Sokak"
        '
        'txtSokak
        '
        Me.txtSokak.Location = New System.Drawing.Point(146, 77)
        Me.txtSokak.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSokak.Name = "txtSokak"
        Me.txtSokak.ReadOnly = True
        Me.txtSokak.Size = New System.Drawing.Size(129, 30)
        Me.txtSokak.TabIndex = 7
        '
        'txtKat
        '
        Me.txtKat.Location = New System.Drawing.Point(367, 112)
        Me.txtKat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKat.Name = "txtKat"
        Me.txtKat.ReadOnly = True
        Me.txtKat.Size = New System.Drawing.Size(103, 30)
        Me.txtKat.TabIndex = 8
        '
        'txtIl
        '
        Me.txtIl.Location = New System.Drawing.Point(366, 74)
        Me.txtIl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIl.Name = "txtIl"
        Me.txtIl.ReadOnly = True
        Me.txtIl.Size = New System.Drawing.Size(103, 30)
        Me.txtIl.TabIndex = 9
        '
        'txtPostaKodu
        '
        Me.txtPostaKodu.Location = New System.Drawing.Point(146, 229)
        Me.txtPostaKodu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPostaKodu.Name = "txtPostaKodu"
        Me.txtPostaKodu.ReadOnly = True
        Me.txtPostaKodu.Size = New System.Drawing.Size(129, 30)
        Me.txtPostaKodu.TabIndex = 9
        '
        'txtIlce
        '
        Me.txtIlce.Location = New System.Drawing.Point(366, 36)
        Me.txtIlce.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIlce.Name = "txtIlce"
        Me.txtIlce.ReadOnly = True
        Me.txtIlce.Size = New System.Drawing.Size(103, 30)
        Me.txtIlce.TabIndex = 9
        '
        'txtDaireNo
        '
        Me.txtDaireNo.Location = New System.Drawing.Point(146, 191)
        Me.txtDaireNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDaireNo.Name = "txtDaireNo"
        Me.txtDaireNo.ReadOnly = True
        Me.txtDaireNo.Size = New System.Drawing.Size(129, 30)
        Me.txtDaireNo.TabIndex = 9
        '
        'txtBinaNo
        '
        Me.txtBinaNo.Location = New System.Drawing.Point(146, 153)
        Me.txtBinaNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBinaNo.Name = "txtBinaNo"
        Me.txtBinaNo.ReadOnly = True
        Me.txtBinaNo.Size = New System.Drawing.Size(129, 30)
        Me.txtBinaNo.TabIndex = 10
        '
        'txtMahalle
        '
        Me.txtMahalle.Location = New System.Drawing.Point(146, 115)
        Me.txtMahalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMahalle.Name = "txtMahalle"
        Me.txtMahalle.ReadOnly = True
        Me.txtMahalle.Size = New System.Drawing.Size(129, 30)
        Me.txtMahalle.TabIndex = 11
        '
        'btnEkle
        '
        Me.btnEkle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEkle.ForeColor = System.Drawing.Color.Black
        Me.btnEkle.Location = New System.Drawing.Point(26, 730)
        Me.btnEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(428, 43)
        Me.btnEkle.TabIndex = 1
        Me.btnEkle.Text = "Çalışan Ekle"
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'txtCalisanAra
        '
        Me.txtCalisanAra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCalisanAra.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCalisanAra.ForeColor = System.Drawing.Color.Black
        Me.txtCalisanAra.Location = New System.Drawing.Point(89, 311)
        Me.txtCalisanAra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalisanAra.Name = "txtCalisanAra"
        Me.txtCalisanAra.Size = New System.Drawing.Size(1767, 38)
        Me.txtCalisanAra.TabIndex = 5
        '
        'btnGuncelle
        '
        Me.btnGuncelle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnGuncelle.Location = New System.Drawing.Point(526, 730)
        Me.btnGuncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(390, 43)
        Me.btnGuncelle.TabIndex = 1
        Me.btnGuncelle.Text = "Çalışan Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'txtCadde
        '
        Me.txtCadde.Location = New System.Drawing.Point(146, 39)
        Me.txtCadde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCadde.Name = "txtCadde"
        Me.txtCadde.ReadOnly = True
        Me.txtCadde.Size = New System.Drawing.Size(129, 30)
        Me.txtCadde.TabIndex = 12
        '
        'lblCadde
        '
        Me.lblCadde.AutoSize = True
        Me.lblCadde.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCadde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCadde.ForeColor = System.Drawing.Color.Black
        Me.lblCadde.Location = New System.Drawing.Point(11, 42)
        Me.lblCadde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCadde.Name = "lblCadde"
        Me.lblCadde.Size = New System.Drawing.Size(73, 27)
        Me.lblCadde.TabIndex = 1
        Me.lblCadde.Text = "Cadde"
        '
        'lblPostaKodu
        '
        Me.lblPostaKodu.AutoSize = True
        Me.lblPostaKodu.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPostaKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostaKodu.ForeColor = System.Drawing.Color.Black
        Me.lblPostaKodu.Location = New System.Drawing.Point(11, 230)
        Me.lblPostaKodu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPostaKodu.Name = "lblPostaKodu"
        Me.lblPostaKodu.Size = New System.Drawing.Size(116, 27)
        Me.lblPostaKodu.TabIndex = 2
        Me.lblPostaKodu.Text = "Posta Kodu"
        '
        'lblDaireNo
        '
        Me.lblDaireNo.AutoSize = True
        Me.lblDaireNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDaireNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDaireNo.ForeColor = System.Drawing.Color.Black
        Me.lblDaireNo.Location = New System.Drawing.Point(11, 194)
        Me.lblDaireNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDaireNo.Name = "lblDaireNo"
        Me.lblDaireNo.Size = New System.Drawing.Size(90, 27)
        Me.lblDaireNo.TabIndex = 2
        Me.lblDaireNo.Text = "Daire No"
        '
        'lblIlce
        '
        Me.lblIlce.AutoSize = True
        Me.lblIlce.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIlce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIlce.ForeColor = System.Drawing.Color.Black
        Me.lblIlce.Location = New System.Drawing.Point(309, 39)
        Me.lblIlce.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIlce.Name = "lblIlce"
        Me.lblIlce.Size = New System.Drawing.Size(44, 27)
        Me.lblIlce.TabIndex = 3
        Me.lblIlce.Text = "İlçe"
        '
        'btnYenile
        '
        Me.btnYenile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYenile.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYenile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYenile.ForeColor = System.Drawing.Color.Black
        Me.btnYenile.Location = New System.Drawing.Point(1463, 730)
        Me.btnYenile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYenile.Name = "btnYenile"
        Me.btnYenile.Size = New System.Drawing.Size(393, 43)
        Me.btnYenile.TabIndex = 8
        Me.btnYenile.Text = "Yenile"
        Me.btnYenile.UseVisualStyleBackColor = False
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label21.ForeColor = System.Drawing.Color.Teal
        Me.label21.Location = New System.Drawing.Point(11, 324)
        Me.label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(54, 25)
        Me.label21.TabIndex = 6
        Me.label21.Text = "&Ara :"
        '
        'lblIl
        '
        Me.lblIl.AutoSize = True
        Me.lblIl.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIl.ForeColor = System.Drawing.Color.Black
        Me.lblIl.Location = New System.Drawing.Point(309, 75)
        Me.lblIl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIl.Name = "lblIl"
        Me.lblIl.Size = New System.Drawing.Size(23, 27)
        Me.lblIl.TabIndex = 4
        Me.lblIl.Text = "İl"
        '
        'lblBinaNo
        '
        Me.lblBinaNo.AutoSize = True
        Me.lblBinaNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblBinaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBinaNo.ForeColor = System.Drawing.Color.Black
        Me.lblBinaNo.Location = New System.Drawing.Point(11, 156)
        Me.lblBinaNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBinaNo.Name = "lblBinaNo"
        Me.lblBinaNo.Size = New System.Drawing.Size(78, 27)
        Me.lblBinaNo.TabIndex = 3
        Me.lblBinaNo.Text = "BinaNo"
        '
        'lblKat
        '
        Me.lblKat.AutoSize = True
        Me.lblKat.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKat.ForeColor = System.Drawing.Color.Black
        Me.lblKat.Location = New System.Drawing.Point(309, 115)
        Me.lblKat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKat.Name = "lblKat"
        Me.lblKat.Size = New System.Drawing.Size(44, 27)
        Me.lblKat.TabIndex = 4
        Me.lblKat.Text = "Kat"
        '
        'lblMahalle
        '
        Me.lblMahalle.AutoSize = True
        Me.lblMahalle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMahalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMahalle.ForeColor = System.Drawing.Color.Black
        Me.lblMahalle.Location = New System.Drawing.Point(11, 118)
        Me.lblMahalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMahalle.Name = "lblMahalle"
        Me.lblMahalle.Size = New System.Drawing.Size(83, 27)
        Me.lblMahalle.TabIndex = 5
        Me.lblMahalle.Text = "Mahalle"
        '
        'lblSokak
        '
        Me.lblSokak.AutoSize = True
        Me.lblSokak.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSokak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSokak.ForeColor = System.Drawing.Color.Black
        Me.lblSokak.Location = New System.Drawing.Point(11, 80)
        Me.lblSokak.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSokak.Name = "lblSokak"
        Me.lblSokak.Size = New System.Drawing.Size(70, 27)
        Me.lblSokak.TabIndex = 6
        Me.lblSokak.Text = "Sokak"
        '
        'btnSil
        '
        Me.btnSil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSil.ForeColor = System.Drawing.Color.Black
        Me.btnSil.Location = New System.Drawing.Point(1001, 730)
        Me.btnSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(393, 43)
        Me.btnSil.TabIndex = 1
        Me.btnSil.Text = "Çalışan Sil"
        Me.btnSil.UseVisualStyleBackColor = False
        '
        'gbAdresBilgileri
        '
        Me.gbAdresBilgileri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAdresBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbAdresBilgileri.Controls.Add(Me.txtSokak)
        Me.gbAdresBilgileri.Controls.Add(Me.txtKat)
        Me.gbAdresBilgileri.Controls.Add(Me.txtIl)
        Me.gbAdresBilgileri.Controls.Add(Me.txtPostaKodu)
        Me.gbAdresBilgileri.Controls.Add(Me.txtIlce)
        Me.gbAdresBilgileri.Controls.Add(Me.txtDaireNo)
        Me.gbAdresBilgileri.Controls.Add(Me.txtBinaNo)
        Me.gbAdresBilgileri.Controls.Add(Me.txtMahalle)
        Me.gbAdresBilgileri.Controls.Add(Me.txtCadde)
        Me.gbAdresBilgileri.Controls.Add(Me.lblCadde)
        Me.gbAdresBilgileri.Controls.Add(Me.lblPostaKodu)
        Me.gbAdresBilgileri.Controls.Add(Me.lblDaireNo)
        Me.gbAdresBilgileri.Controls.Add(Me.lblIlce)
        Me.gbAdresBilgileri.Controls.Add(Me.lblIl)
        Me.gbAdresBilgileri.Controls.Add(Me.lblBinaNo)
        Me.gbAdresBilgileri.Controls.Add(Me.lblKat)
        Me.gbAdresBilgileri.Controls.Add(Me.lblMahalle)
        Me.gbAdresBilgileri.Controls.Add(Me.lblSokak)
        Me.gbAdresBilgileri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbAdresBilgileri.ForeColor = System.Drawing.Color.Black
        Me.gbAdresBilgileri.Location = New System.Drawing.Point(795, 8)
        Me.gbAdresBilgileri.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAdresBilgileri.Name = "gbAdresBilgileri"
        Me.gbAdresBilgileri.Padding = New System.Windows.Forms.Padding(4)
        Me.gbAdresBilgileri.Size = New System.Drawing.Size(499, 278)
        Me.gbAdresBilgileri.TabIndex = 4
        Me.gbAdresBilgileri.TabStop = False
        Me.gbAdresBilgileri.Text = "Çalışan Adres Bilgileri"
        '
        'gbCalisanBilgileri
        '
        Me.gbCalisanBilgileri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCalisanBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbCalisanBilgileri.Controls.Add(Me.mtxtTelefon)
        Me.gbCalisanBilgileri.Controls.Add(Me.pbFoto)
        Me.gbCalisanBilgileri.Controls.Add(Me.txtSoyad)
        Me.gbCalisanBilgileri.Controls.Add(Me.txtPozisyon)
        Me.gbCalisanBilgileri.Controls.Add(Me.txtEposta)
        Me.gbCalisanBilgileri.Controls.Add(Me.txtCinsiyet)
        Me.gbCalisanBilgileri.Controls.Add(Me.txtAd)
        Me.gbCalisanBilgileri.Controls.Add(Me.lblAd)
        Me.gbCalisanBilgileri.Controls.Add(Me.lblPozisyon)
        Me.gbCalisanBilgileri.Controls.Add(Me.lblEposta)
        Me.gbCalisanBilgileri.Controls.Add(Me.lblTelefon)
        Me.gbCalisanBilgileri.Controls.Add(Me.lblCinsiyet)
        Me.gbCalisanBilgileri.Controls.Add(Me.lblSoyad)
        Me.gbCalisanBilgileri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbCalisanBilgileri.ForeColor = System.Drawing.Color.Black
        Me.gbCalisanBilgileri.Location = New System.Drawing.Point(16, 8)
        Me.gbCalisanBilgileri.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCalisanBilgileri.Name = "gbCalisanBilgileri"
        Me.gbCalisanBilgileri.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCalisanBilgileri.Size = New System.Drawing.Size(756, 278)
        Me.gbCalisanBilgileri.TabIndex = 3
        Me.gbCalisanBilgileri.TabStop = False
        Me.gbCalisanBilgileri.Text = "Çalışan Bilgileri"
        '
        'mtxtTelefon
        '
        Me.mtxtTelefon.Location = New System.Drawing.Point(140, 189)
        Me.mtxtTelefon.Mask = "(999) 000-0000"
        Me.mtxtTelefon.Name = "mtxtTelefon"
        Me.mtxtTelefon.Size = New System.Drawing.Size(316, 30)
        Me.mtxtTelefon.TabIndex = 3
        '
        'pbFoto
        '
        Me.pbFoto.BackColor = System.Drawing.Color.Gainsboro
        Me.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFoto.Location = New System.Drawing.Point(481, 24)
        Me.pbFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(251, 239)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 2
        Me.pbFoto.TabStop = False
        '
        'txtSoyad
        '
        Me.txtSoyad.Location = New System.Drawing.Point(140, 76)
        Me.txtSoyad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.ReadOnly = True
        Me.txtSoyad.Size = New System.Drawing.Size(316, 30)
        Me.txtSoyad.TabIndex = 1
        '
        'txtPozisyon
        '
        Me.txtPozisyon.Location = New System.Drawing.Point(140, 226)
        Me.txtPozisyon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPozisyon.Name = "txtPozisyon"
        Me.txtPozisyon.ReadOnly = True
        Me.txtPozisyon.Size = New System.Drawing.Size(316, 30)
        Me.txtPozisyon.TabIndex = 1
        '
        'txtEposta
        '
        Me.txtEposta.Location = New System.Drawing.Point(140, 152)
        Me.txtEposta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEposta.Name = "txtEposta"
        Me.txtEposta.ReadOnly = True
        Me.txtEposta.Size = New System.Drawing.Size(316, 30)
        Me.txtEposta.TabIndex = 1
        '
        'txtCinsiyet
        '
        Me.txtCinsiyet.Location = New System.Drawing.Point(140, 114)
        Me.txtCinsiyet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCinsiyet.Name = "txtCinsiyet"
        Me.txtCinsiyet.ReadOnly = True
        Me.txtCinsiyet.Size = New System.Drawing.Size(316, 30)
        Me.txtCinsiyet.TabIndex = 1
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(140, 38)
        Me.txtAd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.ReadOnly = True
        Me.txtAd.Size = New System.Drawing.Size(316, 30)
        Me.txtAd.TabIndex = 1
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAd.ForeColor = System.Drawing.Color.Black
        Me.lblAd.Location = New System.Drawing.Point(22, 41)
        Me.lblAd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(39, 27)
        Me.lblAd.TabIndex = 0
        Me.lblAd.Text = "Ad"
        '
        'lblPozisyon
        '
        Me.lblPozisyon.AutoSize = True
        Me.lblPozisyon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPozisyon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPozisyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPozisyon.ForeColor = System.Drawing.Color.Black
        Me.lblPozisyon.Location = New System.Drawing.Point(22, 229)
        Me.lblPozisyon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPozisyon.Name = "lblPozisyon"
        Me.lblPozisyon.Size = New System.Drawing.Size(94, 27)
        Me.lblPozisyon.TabIndex = 0
        Me.lblPozisyon.Text = "Pozisyon"
        '
        'lblEposta
        '
        Me.lblEposta.AutoSize = True
        Me.lblEposta.BackColor = System.Drawing.Color.Gainsboro
        Me.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEposta.ForeColor = System.Drawing.Color.Black
        Me.lblEposta.Location = New System.Drawing.Point(22, 155)
        Me.lblEposta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEposta.Name = "lblEposta"
        Me.lblEposta.Size = New System.Drawing.Size(75, 27)
        Me.lblEposta.TabIndex = 0
        Me.lblEposta.Text = "Eposta"
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTelefon.ForeColor = System.Drawing.Color.Black
        Me.lblTelefon.Location = New System.Drawing.Point(22, 192)
        Me.lblTelefon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(80, 27)
        Me.lblTelefon.TabIndex = 0
        Me.lblTelefon.Text = "Telefon"
        '
        'lblCinsiyet
        '
        Me.lblCinsiyet.AutoSize = True
        Me.lblCinsiyet.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCinsiyet.ForeColor = System.Drawing.Color.Black
        Me.lblCinsiyet.Location = New System.Drawing.Point(22, 117)
        Me.lblCinsiyet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCinsiyet.Name = "lblCinsiyet"
        Me.lblCinsiyet.Size = New System.Drawing.Size(84, 27)
        Me.lblCinsiyet.TabIndex = 0
        Me.lblCinsiyet.Text = "Cinsiyet"
        '
        'lblSoyad
        '
        Me.lblSoyad.AutoSize = True
        Me.lblSoyad.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoyad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSoyad.ForeColor = System.Drawing.Color.Black
        Me.lblSoyad.Location = New System.Drawing.Point(22, 79)
        Me.lblSoyad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(71, 27)
        Me.lblSoyad.TabIndex = 0
        Me.lblSoyad.Text = "Soyad"
        '
        'lstwCalisanlar
        '
        Me.lstwCalisanlar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstwCalisanlar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwCalisanlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstwCalisanlar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5, Me.columnHeader6, Me.columnHeader7, Me.columnHeader8, Me.columnHeader9})
        Me.lstwCalisanlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwCalisanlar.ForeColor = System.Drawing.Color.Black
        Me.lstwCalisanlar.FullRowSelect = True
        Me.lstwCalisanlar.GridLines = True
        Me.lstwCalisanlar.Location = New System.Drawing.Point(26, 366)
        Me.lstwCalisanlar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwCalisanlar.Name = "lstwCalisanlar"
        Me.lstwCalisanlar.Size = New System.Drawing.Size(1830, 344)
        Me.lstwCalisanlar.TabIndex = 0
        Me.lstwCalisanlar.UseCompatibleStateImageBehavior = False
        Me.lstwCalisanlar.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "ID"
        Me.columnHeader1.Width = 116
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Ad"
        Me.columnHeader2.Width = 217
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Soyad"
        Me.columnHeader3.Width = 174
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Cinsiyet"
        Me.columnHeader4.Width = 192
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "Telefon"
        Me.columnHeader5.Width = 229
        '
        'columnHeader6
        '
        Me.columnHeader6.Text = "EPosta"
        Me.columnHeader6.Width = 239
        '
        'columnHeader7
        '
        Me.columnHeader7.Text = "Pozisyon"
        Me.columnHeader7.Width = 171
        '
        'columnHeader8
        '
        Me.columnHeader8.Text = "Adres ID"
        Me.columnHeader8.Width = 185
        '
        'columnHeader9
        '
        Me.columnHeader9.Text = "Şube ID"
        Me.columnHeader9.Width = 175
        '
        'tabControlIslemler
        '
        Me.tabControlIslemler.Controls.Add(Me.tabPageCalisanlar)
        Me.tabControlIslemler.Controls.Add(Me.tabPageKitaplar)
        Me.tabControlIslemler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlIslemler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tabControlIslemler.Location = New System.Drawing.Point(0, 0)
        Me.tabControlIslemler.Margin = New System.Windows.Forms.Padding(4)
        Me.tabControlIslemler.Name = "tabControlIslemler"
        Me.tabControlIslemler.SelectedIndex = 0
        Me.tabControlIslemler.Size = New System.Drawing.Size(1889, 849)
        Me.tabControlIslemler.TabIndex = 3
        '
        'tabPageCalisanlar
        '
        Me.tabPageCalisanlar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tabPageCalisanlar.Controls.Add(Me.btnYenile)
        Me.tabPageCalisanlar.Controls.Add(Me.pbAraResim)
        Me.tabPageCalisanlar.Controls.Add(Me.label21)
        Me.tabPageCalisanlar.Controls.Add(Me.btnEkle)
        Me.tabPageCalisanlar.Controls.Add(Me.txtCalisanAra)
        Me.tabPageCalisanlar.Controls.Add(Me.btnGuncelle)
        Me.tabPageCalisanlar.Controls.Add(Me.gbSubeBilgileri)
        Me.tabPageCalisanlar.Controls.Add(Me.btnSil)
        Me.tabPageCalisanlar.Controls.Add(Me.gbAdresBilgileri)
        Me.tabPageCalisanlar.Controls.Add(Me.gbCalisanBilgileri)
        Me.tabPageCalisanlar.Controls.Add(Me.lstwCalisanlar)
        Me.tabPageCalisanlar.Location = New System.Drawing.Point(4, 34)
        Me.tabPageCalisanlar.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPageCalisanlar.Name = "tabPageCalisanlar"
        Me.tabPageCalisanlar.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPageCalisanlar.Size = New System.Drawing.Size(1881, 811)
        Me.tabPageCalisanlar.TabIndex = 0
        Me.tabPageCalisanlar.Text = "Çalışan İşlemleri"
        '
        'pbAraResim
        '
        Me.pbAraResim.Image = Global.KitapciOtomasyonProjesi.My.Resources.Resources.find1
        Me.pbAraResim.Location = New System.Drawing.Point(18, 311)
        Me.pbAraResim.Margin = New System.Windows.Forms.Padding(4)
        Me.pbAraResim.Name = "pbAraResim"
        Me.pbAraResim.Size = New System.Drawing.Size(59, 38)
        Me.pbAraResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAraResim.TabIndex = 7
        Me.pbAraResim.TabStop = False
        '
        'tabPageKitaplar
        '
        Me.tabPageKitaplar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tabPageKitaplar.Controls.Add(Me.btnRefresh)
        Me.tabPageKitaplar.Controls.Add(Me.btnCikis)
        Me.tabPageKitaplar.Controls.Add(Me.btnKitapGuncelle)
        Me.tabPageKitaplar.Controls.Add(Me.btnKitapSil)
        Me.tabPageKitaplar.Controls.Add(Me.btnKitapEkle)
        Me.tabPageKitaplar.Controls.Add(Me.gbSubeAdetSayisi)
        Me.tabPageKitaplar.Controls.Add(Me.gbYazarlar)
        Me.tabPageKitaplar.Controls.Add(Me.gbKategoriler)
        Me.tabPageKitaplar.Controls.Add(Me.gbYayinEviBilgileri)
        Me.tabPageKitaplar.Controls.Add(Me.gbYayinEvi)
        Me.tabPageKitaplar.Controls.Add(Me.lblKitapAra)
        Me.tabPageKitaplar.Controls.Add(Me.txtKitapAra)
        Me.tabPageKitaplar.Controls.Add(Me.lstwKitaplar)
        Me.tabPageKitaplar.Location = New System.Drawing.Point(4, 34)
        Me.tabPageKitaplar.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPageKitaplar.Name = "tabPageKitaplar"
        Me.tabPageKitaplar.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPageKitaplar.Size = New System.Drawing.Size(1881, 811)
        Me.tabPageKitaplar.TabIndex = 1
        Me.tabPageKitaplar.Text = "Kitap İşlemleri"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(1135, 870)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(347, 43)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Yenile"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCikis.ForeColor = System.Drawing.Color.Black
        Me.btnCikis.Location = New System.Drawing.Point(1615, 870)
        Me.btnCikis.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(147, 43)
        Me.btnCikis.TabIndex = 3
        Me.btnCikis.Text = "Kapat"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'btnKitapGuncelle
        '
        Me.btnKitapGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKitapGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitapGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKitapGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnKitapGuncelle.Location = New System.Drawing.Point(388, 870)
        Me.btnKitapGuncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKitapGuncelle.Name = "btnKitapGuncelle"
        Me.btnKitapGuncelle.Size = New System.Drawing.Size(338, 43)
        Me.btnKitapGuncelle.TabIndex = 17
        Me.btnKitapGuncelle.Text = "Kitap Güncelle"
        Me.btnKitapGuncelle.UseVisualStyleBackColor = False
        '
        'btnKitapSil
        '
        Me.btnKitapSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKitapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitapSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKitapSil.ForeColor = System.Drawing.Color.Black
        Me.btnKitapSil.Location = New System.Drawing.Point(756, 870)
        Me.btnKitapSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKitapSil.Name = "btnKitapSil"
        Me.btnKitapSil.Size = New System.Drawing.Size(347, 43)
        Me.btnKitapSil.TabIndex = 14
        Me.btnKitapSil.Text = "Kitap Sil"
        Me.btnKitapSil.UseVisualStyleBackColor = False
        '
        'btnKitapEkle
        '
        Me.btnKitapEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitapEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKitapEkle.ForeColor = System.Drawing.Color.Black
        Me.btnKitapEkle.Location = New System.Drawing.Point(21, 870)
        Me.btnKitapEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKitapEkle.Name = "btnKitapEkle"
        Me.btnKitapEkle.Size = New System.Drawing.Size(342, 43)
        Me.btnKitapEkle.TabIndex = 14
        Me.btnKitapEkle.Text = "Kitap Ekle"
        Me.btnKitapEkle.UseVisualStyleBackColor = False
        '
        'gbSubeAdetSayisi
        '
        Me.gbSubeAdetSayisi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbSubeAdetSayisi.Controls.Add(Me.txtAdet)
        Me.gbSubeAdetSayisi.Controls.Add(Me.lblYeniKitap)
        Me.gbSubeAdetSayisi.Controls.Add(Me.btnAdetSayisiniGuncelle)
        Me.gbSubeAdetSayisi.Controls.Add(Me.lblSecilenKitapSube)
        Me.gbSubeAdetSayisi.Controls.Add(Me.lstwAdetler)
        Me.gbSubeAdetSayisi.Controls.Add(Me.btnSubelereAdetEkle)
        Me.gbSubeAdetSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbSubeAdetSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbSubeAdetSayisi.ForeColor = System.Drawing.Color.Black
        Me.gbSubeAdetSayisi.Location = New System.Drawing.Point(1166, 20)
        Me.gbSubeAdetSayisi.Margin = New System.Windows.Forms.Padding(4)
        Me.gbSubeAdetSayisi.Name = "gbSubeAdetSayisi"
        Me.gbSubeAdetSayisi.Padding = New System.Windows.Forms.Padding(4)
        Me.gbSubeAdetSayisi.Size = New System.Drawing.Size(706, 378)
        Me.gbSubeAdetSayisi.TabIndex = 13
        Me.gbSubeAdetSayisi.TabStop = False
        Me.gbSubeAdetSayisi.Text = "Şubelerki Adet Sayısı "
        '
        'txtAdet
        '
        Me.txtAdet.BackColor = System.Drawing.SystemColors.Control
        Me.txtAdet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAdet.Location = New System.Drawing.Point(425, 267)
        Me.txtAdet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdet.Multiline = True
        Me.txtAdet.Name = "txtAdet"
        Me.txtAdet.Size = New System.Drawing.Size(241, 31)
        Me.txtAdet.TabIndex = 18
        '
        'lblYeniKitap
        '
        Me.lblYeniKitap.AutoSize = True
        Me.lblYeniKitap.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYeniKitap.Location = New System.Drawing.Point(418, 318)
        Me.lblYeniKitap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYeniKitap.Name = "lblYeniKitap"
        Me.lblYeniKitap.Size = New System.Drawing.Size(257, 39)
        Me.lblYeniKitap.TabIndex = 17
        Me.lblYeniKitap.Text = "(Yeni Kitap İçin)"
        '
        'btnAdetSayisiniGuncelle
        '
        Me.btnAdetSayisiniGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdetSayisiniGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdetSayisiniGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAdetSayisiniGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnAdetSayisiniGuncelle.Location = New System.Drawing.Point(16, 266)
        Me.btnAdetSayisiniGuncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdetSayisiniGuncelle.Name = "btnAdetSayisiniGuncelle"
        Me.btnAdetSayisiniGuncelle.Size = New System.Drawing.Size(394, 44)
        Me.btnAdetSayisiniGuncelle.TabIndex = 16
        Me.btnAdetSayisiniGuncelle.Text = "Şubedeki Adet Sayısını Güncelle"
        Me.btnAdetSayisiniGuncelle.UseVisualStyleBackColor = False
        '
        'lblSecilenKitapSube
        '
        Me.lblSecilenKitapSube.AutoSize = True
        Me.lblSecilenKitapSube.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSecilenKitapSube.Location = New System.Drawing.Point(15, 235)
        Me.lblSecilenKitapSube.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecilenKitapSube.Name = "lblSecilenKitapSube"
        Me.lblSecilenKitapSube.Size = New System.Drawing.Size(163, 25)
        Me.lblSecilenKitapSube.TabIndex = 15
        Me.lblSecilenKitapSube.Text = "Seçilen kitap için:"
        '
        'lstwAdetler
        '
        Me.lstwAdetler.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwAdetler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader20, Me.columnHeader21, Me.columnHeader22})
        Me.lstwAdetler.FullRowSelect = True
        Me.lstwAdetler.GridLines = True
        Me.lstwAdetler.Location = New System.Drawing.Point(8, 26)
        Me.lstwAdetler.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwAdetler.Name = "lstwAdetler"
        Me.lstwAdetler.Size = New System.Drawing.Size(658, 202)
        Me.lstwAdetler.TabIndex = 8
        Me.lstwAdetler.UseCompatibleStateImageBehavior = False
        Me.lstwAdetler.View = System.Windows.Forms.View.Details
        '
        'columnHeader20
        '
        Me.columnHeader20.Text = "Sube ID"
        Me.columnHeader20.Width = 127
        '
        'columnHeader21
        '
        Me.columnHeader21.Text = "Sube Adı"
        Me.columnHeader21.Width = 204
        '
        'columnHeader22
        '
        Me.columnHeader22.Text = "Adet Sayısı"
        Me.columnHeader22.Width = 159
        '
        'btnSubelereAdetEkle
        '
        Me.btnSubelereAdetEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubelereAdetEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubelereAdetEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSubelereAdetEkle.ForeColor = System.Drawing.Color.Black
        Me.btnSubelereAdetEkle.Location = New System.Drawing.Point(16, 318)
        Me.btnSubelereAdetEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubelereAdetEkle.Name = "btnSubelereAdetEkle"
        Me.btnSubelereAdetEkle.Size = New System.Drawing.Size(394, 47)
        Me.btnSubelereAdetEkle.TabIndex = 14
        Me.btnSubelereAdetEkle.Text = "Şubelerdeki Adet Sayısını Gir"
        Me.btnSubelereAdetEkle.UseVisualStyleBackColor = False
        '
        'gbYazarlar
        '
        Me.gbYazarlar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbYazarlar.Controls.Add(Me.lblSecilenKitapYazar)
        Me.gbYazarlar.Controls.Add(Me.lstwYazarlar)
        Me.gbYazarlar.Controls.Add(Me.btnYazariSil)
        Me.gbYazarlar.Controls.Add(Me.btnYazarEkle)
        Me.gbYazarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbYazarlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbYazarlar.ForeColor = System.Drawing.Color.Black
        Me.gbYazarlar.Location = New System.Drawing.Point(605, 20)
        Me.gbYazarlar.Margin = New System.Windows.Forms.Padding(4)
        Me.gbYazarlar.Name = "gbYazarlar"
        Me.gbYazarlar.Padding = New System.Windows.Forms.Padding(4)
        Me.gbYazarlar.Size = New System.Drawing.Size(514, 318)
        Me.gbYazarlar.TabIndex = 12
        Me.gbYazarlar.TabStop = False
        Me.gbYazarlar.Text = "Yazarlar"
        '
        'lblSecilenKitapYazar
        '
        Me.lblSecilenKitapYazar.AutoSize = True
        Me.lblSecilenKitapYazar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSecilenKitapYazar.Location = New System.Drawing.Point(8, 260)
        Me.lblSecilenKitapYazar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecilenKitapYazar.Name = "lblSecilenKitapYazar"
        Me.lblSecilenKitapYazar.Size = New System.Drawing.Size(200, 29)
        Me.lblSecilenKitapYazar.TabIndex = 15
        Me.lblSecilenKitapYazar.Text = "Seçilen kitap için:"
        '
        'lstwYazarlar
        '
        Me.lstwYazarlar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwYazarlar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader17, Me.columnHeader18, Me.columnHeader19})
        Me.lstwYazarlar.ForeColor = System.Drawing.Color.Black
        Me.lstwYazarlar.FullRowSelect = True
        Me.lstwYazarlar.GridLines = True
        Me.lstwYazarlar.Location = New System.Drawing.Point(8, 26)
        Me.lstwYazarlar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwYazarlar.Name = "lstwYazarlar"
        Me.lstwYazarlar.Size = New System.Drawing.Size(486, 205)
        Me.lstwYazarlar.TabIndex = 8
        Me.lstwYazarlar.UseCompatibleStateImageBehavior = False
        Me.lstwYazarlar.View = System.Windows.Forms.View.Details
        '
        'columnHeader17
        '
        Me.columnHeader17.Text = "Yazar ID"
        Me.columnHeader17.Width = 91
        '
        'columnHeader18
        '
        Me.columnHeader18.Text = "Yazar Adı"
        Me.columnHeader18.Width = 123
        '
        'columnHeader19
        '
        Me.columnHeader19.Text = "Yazar Soyadı"
        Me.columnHeader19.Width = 130
        '
        'btnYazariSil
        '
        Me.btnYazariSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYazariSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYazariSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYazariSil.ForeColor = System.Drawing.Color.Black
        Me.btnYazariSil.Location = New System.Drawing.Point(363, 253)
        Me.btnYazariSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYazariSil.Name = "btnYazariSil"
        Me.btnYazariSil.Size = New System.Drawing.Size(131, 47)
        Me.btnYazariSil.TabIndex = 15
        Me.btnYazariSil.Text = "Yazar Sil"
        Me.btnYazariSil.UseVisualStyleBackColor = False
        '
        'btnYazarEkle
        '
        Me.btnYazarEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYazarEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYazarEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYazarEkle.ForeColor = System.Drawing.Color.Black
        Me.btnYazarEkle.Location = New System.Drawing.Point(220, 253)
        Me.btnYazarEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYazarEkle.Name = "btnYazarEkle"
        Me.btnYazarEkle.Size = New System.Drawing.Size(131, 47)
        Me.btnYazarEkle.TabIndex = 14
        Me.btnYazarEkle.Text = "Yazar Ekle"
        Me.btnYazarEkle.UseVisualStyleBackColor = False
        '
        'gbKategoriler
        '
        Me.gbKategoriler.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbKategoriler.Controls.Add(Me.lblSecilenKitapKategori)
        Me.gbKategoriler.Controls.Add(Me.lstKategoriler)
        Me.gbKategoriler.Controls.Add(Me.btnKategoriEkle)
        Me.gbKategoriler.Controls.Add(Me.btnKategoriyiSil)
        Me.gbKategoriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbKategoriler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbKategoriler.ForeColor = System.Drawing.Color.Black
        Me.gbKategoriler.Location = New System.Drawing.Point(363, 20)
        Me.gbKategoriler.Margin = New System.Windows.Forms.Padding(4)
        Me.gbKategoriler.Name = "gbKategoriler"
        Me.gbKategoriler.Padding = New System.Windows.Forms.Padding(4)
        Me.gbKategoriler.Size = New System.Drawing.Size(189, 380)
        Me.gbKategoriler.TabIndex = 11
        Me.gbKategoriler.TabStop = False
        Me.gbKategoriler.Text = "Kategorileri"
        '
        'lblSecilenKitapKategori
        '
        Me.lblSecilenKitapKategori.AutoSize = True
        Me.lblSecilenKitapKategori.Location = New System.Drawing.Point(11, 219)
        Me.lblSecilenKitapKategori.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecilenKitapKategori.Name = "lblSecilenKitapKategori"
        Me.lblSecilenKitapKategori.Size = New System.Drawing.Size(163, 25)
        Me.lblSecilenKitapKategori.TabIndex = 15
        Me.lblSecilenKitapKategori.Text = "Seçilen kitap için:"
        '
        'lstKategoriler
        '
        Me.lstKategoriler.BackColor = System.Drawing.SystemColors.Window
        Me.lstKategoriler.FormattingEnabled = True
        Me.lstKategoriler.ItemHeight = 25
        Me.lstKategoriler.Location = New System.Drawing.Point(8, 28)
        Me.lstKategoriler.Margin = New System.Windows.Forms.Padding(4)
        Me.lstKategoriler.Name = "lstKategoriler"
        Me.lstKategoriler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstKategoriler.Size = New System.Drawing.Size(171, 179)
        Me.lstKategoriler.TabIndex = 0
        '
        'btnKategoriEkle
        '
        Me.btnKategoriEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategoriEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKategoriEkle.ForeColor = System.Drawing.Color.Black
        Me.btnKategoriEkle.Location = New System.Drawing.Point(8, 312)
        Me.btnKategoriEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKategoriEkle.Name = "btnKategoriEkle"
        Me.btnKategoriEkle.Size = New System.Drawing.Size(173, 54)
        Me.btnKategoriEkle.TabIndex = 14
        Me.btnKategoriEkle.Text = "Kategori Ekle"
        Me.btnKategoriEkle.UseVisualStyleBackColor = False
        '
        'btnKategoriyiSil
        '
        Me.btnKategoriyiSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKategoriyiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategoriyiSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKategoriyiSil.ForeColor = System.Drawing.Color.Black
        Me.btnKategoriyiSil.Location = New System.Drawing.Point(9, 253)
        Me.btnKategoriyiSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKategoriyiSil.Name = "btnKategoriyiSil"
        Me.btnKategoriyiSil.Size = New System.Drawing.Size(172, 48)
        Me.btnKategoriyiSil.TabIndex = 16
        Me.btnKategoriyiSil.Text = "Kategori Sil "
        Me.btnKategoriyiSil.UseVisualStyleBackColor = False
        '
        'gbYayinEviBilgileri
        '
        Me.gbYayinEviBilgileri.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviPostaKodu)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviIl)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviIlce)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviDaireNo)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviKat)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviBinaNo)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviSokak)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviMahalle)
        Me.gbYayinEviBilgileri.Controls.Add(Me.txtYayinEviCadde)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviCadde)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviPostaKodu)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviDaireNo)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviIlce)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviIl)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviBinaNo)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviKat)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviMahalle)
        Me.gbYayinEviBilgileri.Controls.Add(Me.lblYayinEviSokak)
        Me.gbYayinEviBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbYayinEviBilgileri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbYayinEviBilgileri.ForeColor = System.Drawing.Color.Black
        Me.gbYayinEviBilgileri.Location = New System.Drawing.Point(21, 95)
        Me.gbYayinEviBilgileri.Margin = New System.Windows.Forms.Padding(4)
        Me.gbYayinEviBilgileri.Name = "gbYayinEviBilgileri"
        Me.gbYayinEviBilgileri.Padding = New System.Windows.Forms.Padding(4)
        Me.gbYayinEviBilgileri.Size = New System.Drawing.Size(300, 356)
        Me.gbYayinEviBilgileri.TabIndex = 11
        Me.gbYayinEviBilgileri.TabStop = False
        Me.gbYayinEviBilgileri.Text = " Yayın Evi Adres Bilgileri"
        '
        'txtYayinEviPostaKodu
        '
        Me.txtYayinEviPostaKodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviPostaKodu.Location = New System.Drawing.Point(151, 307)
        Me.txtYayinEviPostaKodu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviPostaKodu.Name = "txtYayinEviPostaKodu"
        Me.txtYayinEviPostaKodu.ReadOnly = True
        Me.txtYayinEviPostaKodu.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviPostaKodu.TabIndex = 36
        '
        'txtYayinEviIl
        '
        Me.txtYayinEviIl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviIl.Location = New System.Drawing.Point(151, 273)
        Me.txtYayinEviIl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviIl.Name = "txtYayinEviIl"
        Me.txtYayinEviIl.ReadOnly = True
        Me.txtYayinEviIl.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviIl.TabIndex = 35
        '
        'txtYayinEviIlce
        '
        Me.txtYayinEviIlce.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviIlce.Location = New System.Drawing.Point(151, 239)
        Me.txtYayinEviIlce.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviIlce.Name = "txtYayinEviIlce"
        Me.txtYayinEviIlce.ReadOnly = True
        Me.txtYayinEviIlce.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviIlce.TabIndex = 34
        '
        'txtYayinEviDaireNo
        '
        Me.txtYayinEviDaireNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviDaireNo.Location = New System.Drawing.Point(151, 205)
        Me.txtYayinEviDaireNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviDaireNo.Name = "txtYayinEviDaireNo"
        Me.txtYayinEviDaireNo.ReadOnly = True
        Me.txtYayinEviDaireNo.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviDaireNo.TabIndex = 33
        '
        'txtYayinEviKat
        '
        Me.txtYayinEviKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviKat.Location = New System.Drawing.Point(151, 171)
        Me.txtYayinEviKat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviKat.Name = "txtYayinEviKat"
        Me.txtYayinEviKat.ReadOnly = True
        Me.txtYayinEviKat.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviKat.TabIndex = 32
        '
        'txtYayinEviBinaNo
        '
        Me.txtYayinEviBinaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviBinaNo.Location = New System.Drawing.Point(151, 137)
        Me.txtYayinEviBinaNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviBinaNo.Name = "txtYayinEviBinaNo"
        Me.txtYayinEviBinaNo.ReadOnly = True
        Me.txtYayinEviBinaNo.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviBinaNo.TabIndex = 31
        '
        'txtYayinEviSokak
        '
        Me.txtYayinEviSokak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviSokak.Location = New System.Drawing.Point(151, 68)
        Me.txtYayinEviSokak.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviSokak.Name = "txtYayinEviSokak"
        Me.txtYayinEviSokak.ReadOnly = True
        Me.txtYayinEviSokak.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviSokak.TabIndex = 27
        '
        'txtYayinEviMahalle
        '
        Me.txtYayinEviMahalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviMahalle.Location = New System.Drawing.Point(151, 102)
        Me.txtYayinEviMahalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviMahalle.Name = "txtYayinEviMahalle"
        Me.txtYayinEviMahalle.ReadOnly = True
        Me.txtYayinEviMahalle.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviMahalle.TabIndex = 26
        '
        'txtYayinEviCadde
        '
        Me.txtYayinEviCadde.BackColor = System.Drawing.SystemColors.Control
        Me.txtYayinEviCadde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviCadde.Location = New System.Drawing.Point(151, 34)
        Me.txtYayinEviCadde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviCadde.Name = "txtYayinEviCadde"
        Me.txtYayinEviCadde.Size = New System.Drawing.Size(129, 30)
        Me.txtYayinEviCadde.TabIndex = 30
        '
        'lblYayinEviCadde
        '
        Me.lblYayinEviCadde.AutoSize = True
        Me.lblYayinEviCadde.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviCadde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviCadde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviCadde.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviCadde.Location = New System.Drawing.Point(14, 37)
        Me.lblYayinEviCadde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviCadde.Name = "lblYayinEviCadde"
        Me.lblYayinEviCadde.Size = New System.Drawing.Size(73, 27)
        Me.lblYayinEviCadde.TabIndex = 13
        Me.lblYayinEviCadde.Text = "Cadde"
        '
        'lblYayinEviPostaKodu
        '
        Me.lblYayinEviPostaKodu.AutoSize = True
        Me.lblYayinEviPostaKodu.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviPostaKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviPostaKodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviPostaKodu.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviPostaKodu.Location = New System.Drawing.Point(15, 310)
        Me.lblYayinEviPostaKodu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviPostaKodu.Name = "lblYayinEviPostaKodu"
        Me.lblYayinEviPostaKodu.Size = New System.Drawing.Size(116, 27)
        Me.lblYayinEviPostaKodu.TabIndex = 15
        Me.lblYayinEviPostaKodu.Text = "Posta Kodu"
        '
        'lblYayinEviDaireNo
        '
        Me.lblYayinEviDaireNo.AutoSize = True
        Me.lblYayinEviDaireNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviDaireNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviDaireNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviDaireNo.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviDaireNo.Location = New System.Drawing.Point(15, 208)
        Me.lblYayinEviDaireNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviDaireNo.Name = "lblYayinEviDaireNo"
        Me.lblYayinEviDaireNo.Size = New System.Drawing.Size(90, 27)
        Me.lblYayinEviDaireNo.TabIndex = 14
        Me.lblYayinEviDaireNo.Text = "Daire No"
        '
        'lblYayinEviIlce
        '
        Me.lblYayinEviIlce.AutoSize = True
        Me.lblYayinEviIlce.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviIlce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviIlce.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviIlce.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviIlce.Location = New System.Drawing.Point(15, 242)
        Me.lblYayinEviIlce.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviIlce.Name = "lblYayinEviIlce"
        Me.lblYayinEviIlce.Size = New System.Drawing.Size(44, 27)
        Me.lblYayinEviIlce.TabIndex = 17
        Me.lblYayinEviIlce.Text = "İlçe"
        '
        'lblYayinEviIl
        '
        Me.lblYayinEviIl.AutoSize = True
        Me.lblYayinEviIl.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviIl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviIl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviIl.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviIl.Location = New System.Drawing.Point(15, 276)
        Me.lblYayinEviIl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviIl.Name = "lblYayinEviIl"
        Me.lblYayinEviIl.Size = New System.Drawing.Size(23, 27)
        Me.lblYayinEviIl.TabIndex = 19
        Me.lblYayinEviIl.Text = "İl"
        '
        'lblYayinEviBinaNo
        '
        Me.lblYayinEviBinaNo.AutoSize = True
        Me.lblYayinEviBinaNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviBinaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviBinaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviBinaNo.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviBinaNo.Location = New System.Drawing.Point(14, 140)
        Me.lblYayinEviBinaNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviBinaNo.Name = "lblYayinEviBinaNo"
        Me.lblYayinEviBinaNo.Size = New System.Drawing.Size(78, 27)
        Me.lblYayinEviBinaNo.TabIndex = 16
        Me.lblYayinEviBinaNo.Text = "BinaNo"
        '
        'lblYayinEviKat
        '
        Me.lblYayinEviKat.AutoSize = True
        Me.lblYayinEviKat.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviKat.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviKat.Location = New System.Drawing.Point(15, 174)
        Me.lblYayinEviKat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviKat.Name = "lblYayinEviKat"
        Me.lblYayinEviKat.Size = New System.Drawing.Size(44, 27)
        Me.lblYayinEviKat.TabIndex = 18
        Me.lblYayinEviKat.Text = "Kat"
        '
        'lblYayinEviMahalle
        '
        Me.lblYayinEviMahalle.AutoSize = True
        Me.lblYayinEviMahalle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviMahalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviMahalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviMahalle.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviMahalle.Location = New System.Drawing.Point(14, 105)
        Me.lblYayinEviMahalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviMahalle.Name = "lblYayinEviMahalle"
        Me.lblYayinEviMahalle.Size = New System.Drawing.Size(83, 27)
        Me.lblYayinEviMahalle.TabIndex = 20
        Me.lblYayinEviMahalle.Text = "Mahalle"
        '
        'lblYayinEviSokak
        '
        Me.lblYayinEviSokak.AutoSize = True
        Me.lblYayinEviSokak.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviSokak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviSokak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviSokak.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviSokak.Location = New System.Drawing.Point(14, 71)
        Me.lblYayinEviSokak.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviSokak.Name = "lblYayinEviSokak"
        Me.lblYayinEviSokak.Size = New System.Drawing.Size(70, 27)
        Me.lblYayinEviSokak.TabIndex = 21
        Me.lblYayinEviSokak.Text = "Sokak"
        '
        'gbYayinEvi
        '
        Me.gbYayinEvi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbYayinEvi.Controls.Add(Me.txtYayınEviAdi)
        Me.gbYayinEvi.Controls.Add(Me.lblYayinEviAdi)
        Me.gbYayinEvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbYayinEvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbYayinEvi.ForeColor = System.Drawing.Color.Black
        Me.gbYayinEvi.Location = New System.Drawing.Point(21, 7)
        Me.gbYayinEvi.Margin = New System.Windows.Forms.Padding(4)
        Me.gbYayinEvi.Name = "gbYayinEvi"
        Me.gbYayinEvi.Padding = New System.Windows.Forms.Padding(4)
        Me.gbYayinEvi.Size = New System.Drawing.Size(300, 80)
        Me.gbYayinEvi.TabIndex = 11
        Me.gbYayinEvi.TabStop = False
        Me.gbYayinEvi.Text = "Yayın Evi Bilgileri"
        '
        'txtYayınEviAdi
        '
        Me.txtYayınEviAdi.Location = New System.Drawing.Point(157, 32)
        Me.txtYayınEviAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayınEviAdi.Name = "txtYayınEviAdi"
        Me.txtYayınEviAdi.ReadOnly = True
        Me.txtYayınEviAdi.Size = New System.Drawing.Size(132, 30)
        Me.txtYayınEviAdi.TabIndex = 1
        '
        'lblYayinEviAdi
        '
        Me.lblYayinEviAdi.AutoSize = True
        Me.lblYayinEviAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYayinEviAdi.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviAdi.Location = New System.Drawing.Point(9, 33)
        Me.lblYayinEviAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviAdi.Name = "lblYayinEviAdi"
        Me.lblYayinEviAdi.Size = New System.Drawing.Size(129, 27)
        Me.lblYayinEviAdi.TabIndex = 0
        Me.lblYayinEviAdi.Text = "Yayın Evi Adı"
        '
        'lblKitapAra
        '
        Me.lblKitapAra.AutoSize = True
        Me.lblKitapAra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKitapAra.ForeColor = System.Drawing.Color.Black
        Me.lblKitapAra.Location = New System.Drawing.Point(25, 464)
        Me.lblKitapAra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKitapAra.Name = "lblKitapAra"
        Me.lblKitapAra.Size = New System.Drawing.Size(108, 26)
        Me.lblKitapAra.TabIndex = 10
        Me.lblKitapAra.Text = "&Kitap Ara:"
        '
        'txtKitapAra
        '
        Me.txtKitapAra.BackColor = System.Drawing.SystemColors.Control
        Me.txtKitapAra.Location = New System.Drawing.Point(141, 463)
        Me.txtKitapAra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKitapAra.Name = "txtKitapAra"
        Me.txtKitapAra.Size = New System.Drawing.Size(1720, 30)
        Me.txtKitapAra.TabIndex = 9
        '
        'lstwKitaplar
        '
        Me.lstwKitaplar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwKitaplar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstwKitaplar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader11, Me.columnHeader12, Me.columnHeader13, Me.columnHeader14, Me.columnHeader15, Me.columnHeader16})
        Me.lstwKitaplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwKitaplar.ForeColor = System.Drawing.Color.Black
        Me.lstwKitaplar.FullRowSelect = True
        Me.lstwKitaplar.GridLines = True
        Me.lstwKitaplar.Location = New System.Drawing.Point(21, 513)
        Me.lstwKitaplar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwKitaplar.Name = "lstwKitaplar"
        Me.lstwKitaplar.Size = New System.Drawing.Size(1840, 323)
        Me.lstwKitaplar.TabIndex = 7
        Me.lstwKitaplar.UseCompatibleStateImageBehavior = False
        Me.lstwKitaplar.View = System.Windows.Forms.View.Details
        '
        'columnHeader11
        '
        Me.columnHeader11.Text = "Kitap ID"
        Me.columnHeader11.Width = 218
        '
        'columnHeader12
        '
        Me.columnHeader12.Text = "Kitap Adı"
        Me.columnHeader12.Width = 341
        '
        'columnHeader13
        '
        Me.columnHeader13.Text = "Yayın Tarihi"
        Me.columnHeader13.Width = 364
        '
        'columnHeader14
        '
        Me.columnHeader14.Text = "Sayfa Sayısı"
        Me.columnHeader14.Width = 213
        '
        'columnHeader15
        '
        Me.columnHeader15.Text = "Yayın Evi ID"
        Me.columnHeader15.Width = 241
        '
        'columnHeader16
        '
        Me.columnHeader16.Text = "Satış Fiyatı"
        Me.columnHeader16.Width = 201
        '
        'YöneticiArayuzu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1889, 849)
        Me.Controls.Add(Me.tabControlIslemler)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "YöneticiArayuzu"
        Me.Text = "Yönetici Arayüzü"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbSubeBilgileri.ResumeLayout(False)
        Me.gbSubeBilgileri.PerformLayout()
        Me.gbAdresBilgileri.ResumeLayout(False)
        Me.gbAdresBilgileri.PerformLayout()
        Me.gbCalisanBilgileri.ResumeLayout(False)
        Me.gbCalisanBilgileri.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControlIslemler.ResumeLayout(False)
        Me.tabPageCalisanlar.ResumeLayout(False)
        Me.tabPageCalisanlar.PerformLayout()
        CType(Me.pbAraResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageKitaplar.ResumeLayout(False)
        Me.tabPageKitaplar.PerformLayout()
        Me.gbSubeAdetSayisi.ResumeLayout(False)
        Me.gbSubeAdetSayisi.PerformLayout()
        Me.gbYazarlar.ResumeLayout(False)
        Me.gbYazarlar.PerformLayout()
        Me.gbKategoriler.ResumeLayout(False)
        Me.gbKategoriler.PerformLayout()
        Me.gbYayinEviBilgileri.ResumeLayout(False)
        Me.gbYayinEviBilgileri.PerformLayout()
        Me.gbYayinEvi.ResumeLayout(False)
        Me.gbYayinEvi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtSubeKat As TextBox
    Private WithEvents txtSubeIl As TextBox
    Private WithEvents gbSubeBilgileri As GroupBox
    Private WithEvents lblBagliSube As Label
    Private WithEvents txtSubeSokak As TextBox
    Private WithEvents txtSubeAdi As TextBox
    Private WithEvents txtSubePostaKodu As TextBox
    Private WithEvents txtSubeIlce As TextBox
    Private WithEvents txtSubeDaireNo As TextBox
    Private WithEvents txtSubeBinaNo As TextBox
    Private WithEvents txtSubeMahalle As TextBox
    Private WithEvents txtSubeCadde As TextBox
    Private WithEvents lblSubeCadde As Label
    Private WithEvents lblSubePostaKodu As Label
    Private WithEvents lblSubeDaireNo As Label
    Private WithEvents lblSubeIlce As Label
    Private WithEvents lblSubeIl As Label
    Private WithEvents lblSubeBinaNo As Label
    Private WithEvents lblSubeKat As Label
    Private WithEvents lblSubeMahalle As Label
    Private WithEvents lblSubeSokak As Label
    Private WithEvents txtSokak As TextBox
    Private WithEvents txtKat As TextBox
    Private WithEvents txtIl As TextBox
    Private WithEvents txtPostaKodu As TextBox
    Private WithEvents txtIlce As TextBox
    Private WithEvents txtDaireNo As TextBox
    Private WithEvents txtBinaNo As TextBox
    Private WithEvents txtMahalle As TextBox
    Private WithEvents btnEkle As Button
    Private WithEvents txtCalisanAra As TextBox
    Private WithEvents btnGuncelle As Button
    Private WithEvents txtCadde As TextBox
    Private WithEvents lblCadde As Label
    Private WithEvents lblPostaKodu As Label
    Private WithEvents lblDaireNo As Label
    Private WithEvents lblIlce As Label
    Private WithEvents btnYenile As Button
    Private WithEvents label21 As Label
    Private WithEvents lblIl As Label
    Private WithEvents lblBinaNo As Label
    Private WithEvents lblKat As Label
    Private WithEvents lblMahalle As Label
    Private WithEvents lblSokak As Label
    Private WithEvents btnSil As Button
    Private WithEvents gbAdresBilgileri As GroupBox
    Private WithEvents gbCalisanBilgileri As GroupBox
    Private WithEvents pbFoto As PictureBox
    Private WithEvents txtSoyad As TextBox
    Private WithEvents txtPozisyon As TextBox
    Private WithEvents txtEposta As TextBox
    Private WithEvents txtCinsiyet As TextBox
    Private WithEvents txtAd As TextBox
    Private WithEvents lblAd As Label
    Private WithEvents lblPozisyon As Label
    Private WithEvents lblEposta As Label
    Private WithEvents lblTelefon As Label
    Private WithEvents lblCinsiyet As Label
    Private WithEvents lblSoyad As Label
    Private WithEvents pbAraResim As PictureBox
    Private WithEvents lstwCalisanlar As ListView
    Private WithEvents columnHeader1 As ColumnHeader
    Private WithEvents columnHeader2 As ColumnHeader
    Private WithEvents columnHeader3 As ColumnHeader
    Private WithEvents columnHeader4 As ColumnHeader
    Private WithEvents columnHeader5 As ColumnHeader
    Private WithEvents columnHeader6 As ColumnHeader
    Private WithEvents columnHeader7 As ColumnHeader
    Private WithEvents columnHeader8 As ColumnHeader
    Private WithEvents columnHeader9 As ColumnHeader
    Private WithEvents tabControlIslemler As TabControl
    Private WithEvents tabPageCalisanlar As TabPage
    Private WithEvents tabPageKitaplar As TabPage
    Private WithEvents btnRefresh As Button
    Private WithEvents btnCikis As Button
    Private WithEvents btnKitapGuncelle As Button
    Private WithEvents btnKategoriyiSil As Button
    Private WithEvents btnKitapSil As Button
    Private WithEvents btnKitapEkle As Button
    Private WithEvents gbSubeAdetSayisi As GroupBox
    Private WithEvents txtAdet As TextBox
    Private WithEvents lblYeniKitap As Label
    Private WithEvents btnAdetSayisiniGuncelle As Button
    Private WithEvents lblSecilenKitapSube As Label
    Private WithEvents lstwAdetler As ListView
    Private WithEvents columnHeader20 As ColumnHeader
    Private WithEvents columnHeader21 As ColumnHeader
    Private WithEvents columnHeader22 As ColumnHeader
    Private WithEvents btnSubelereAdetEkle As Button
    Private WithEvents gbYazarlar As GroupBox
    Private WithEvents lblSecilenKitapYazar As Label
    Private WithEvents lstwYazarlar As ListView
    Private WithEvents columnHeader17 As ColumnHeader
    Private WithEvents columnHeader18 As ColumnHeader
    Private WithEvents columnHeader19 As ColumnHeader
    Private WithEvents btnYazariSil As Button
    Private WithEvents btnYazarEkle As Button
    Private WithEvents gbKategoriler As GroupBox
    Private WithEvents lblSecilenKitapKategori As Label
    Private WithEvents lstKategoriler As ListBox
    Private WithEvents btnKategoriEkle As Button
    Private WithEvents gbYayinEviBilgileri As GroupBox
    Private WithEvents txtYayinEviPostaKodu As TextBox
    Private WithEvents txtYayinEviIl As TextBox
    Private WithEvents txtYayinEviIlce As TextBox
    Private WithEvents txtYayinEviDaireNo As TextBox
    Private WithEvents txtYayinEviKat As TextBox
    Private WithEvents txtYayinEviBinaNo As TextBox
    Private WithEvents txtYayinEviSokak As TextBox
    Private WithEvents txtYayinEviMahalle As TextBox
    Private WithEvents txtYayinEviCadde As TextBox
    Private WithEvents lblYayinEviCadde As Label
    Private WithEvents lblYayinEviPostaKodu As Label
    Private WithEvents lblYayinEviDaireNo As Label
    Private WithEvents lblYayinEviIlce As Label
    Private WithEvents lblYayinEviIl As Label
    Private WithEvents lblYayinEviBinaNo As Label
    Private WithEvents lblYayinEviKat As Label
    Private WithEvents lblYayinEviMahalle As Label
    Private WithEvents lblYayinEviSokak As Label
    Private WithEvents gbYayinEvi As GroupBox
    Private WithEvents txtYayınEviAdi As TextBox
    Private WithEvents lblYayinEviAdi As Label
    Private WithEvents lblKitapAra As Label
    Private WithEvents txtKitapAra As TextBox
    Private WithEvents lstwKitaplar As ListView
    Private WithEvents columnHeader11 As ColumnHeader
    Private WithEvents columnHeader12 As ColumnHeader
    Private WithEvents columnHeader13 As ColumnHeader
    Private WithEvents columnHeader14 As ColumnHeader
    Private WithEvents columnHeader15 As ColumnHeader
    Private WithEvents columnHeader16 As ColumnHeader
    Friend WithEvents mtxtTelefon As MaskedTextBox
End Class
