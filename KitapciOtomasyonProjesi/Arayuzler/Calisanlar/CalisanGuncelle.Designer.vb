<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalisanGuncelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalisanGuncelle))
        Me.cbSubeSec = New System.Windows.Forms.ComboBox()
        Me.cbAdresID = New System.Windows.Forms.ComboBox()
        Me.mtxtTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.cbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.lblSifre = New System.Windows.Forms.Label()
        Me.lblSubeSec = New System.Windows.Forms.Label()
        Me.txtEposta = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtPozisyon = New System.Windows.Forms.TextBox()
        Me.btnYeniAdresEkle = New System.Windows.Forms.Button()
        Me.btnResimEkle = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.lblAdresID = New System.Windows.Forms.Label()
        Me.lblPozisyon = New System.Windows.Forms.Label()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblEposta = New System.Windows.Forms.Label()
        Me.lblCinsiyet = New System.Windows.Forms.Label()
        Me.lblSoyad = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblCalisanGuncellemeIslemleri = New System.Windows.Forms.Label()
        Me.lstCalisanlar = New System.Windows.Forms.ListBox()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSubeSec
        '
        Me.cbSubeSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbSubeSec.FormattingEnabled = True
        Me.cbSubeSec.Location = New System.Drawing.Point(599, 402)
        Me.cbSubeSec.Name = "cbSubeSec"
        Me.cbSubeSec.Size = New System.Drawing.Size(245, 37)
        Me.cbSubeSec.TabIndex = 54
        '
        'cbAdresID
        '
        Me.cbAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbAdresID.FormattingEnabled = True
        Me.cbAdresID.Location = New System.Drawing.Point(599, 359)
        Me.cbAdresID.Name = "cbAdresID"
        Me.cbAdresID.Size = New System.Drawing.Size(245, 37)
        Me.cbAdresID.TabIndex = 53
        '
        'mtxtTelefon
        '
        Me.mtxtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxtTelefon.Location = New System.Drawing.Point(599, 279)
        Me.mtxtTelefon.Mask = "(999) 000-0000"
        Me.mtxtTelefon.Name = "mtxtTelefon"
        Me.mtxtTelefon.Size = New System.Drawing.Size(245, 34)
        Me.mtxtTelefon.TabIndex = 52
        '
        'cbCinsiyet
        '
        Me.cbCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbCinsiyet.FormattingEnabled = True
        Me.cbCinsiyet.Items.AddRange(New Object() {"Erkek", "Kız"})
        Me.cbCinsiyet.Location = New System.Drawing.Point(599, 196)
        Me.cbCinsiyet.Name = "cbCinsiyet"
        Me.cbCinsiyet.Size = New System.Drawing.Size(245, 37)
        Me.cbCinsiyet.TabIndex = 51
        '
        'pbFoto
        '
        Me.pbFoto.BackColor = System.Drawing.Color.Gainsboro
        Me.pbFoto.Location = New System.Drawing.Point(899, 103)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(202, 158)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 50
        Me.pbFoto.TabStop = False
        '
        'txtSifre
        '
        Me.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSifre.Location = New System.Drawing.Point(942, 393)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.Size = New System.Drawing.Size(167, 34)
        Me.txtSifre.TabIndex = 49
        '
        'lblSifre
        '
        Me.lblSifre.AutoSize = True
        Me.lblSifre.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSifre.ForeColor = System.Drawing.Color.Black
        Me.lblSifre.Location = New System.Drawing.Point(871, 396)
        Me.lblSifre.Name = "lblSifre"
        Me.lblSifre.Size = New System.Drawing.Size(65, 31)
        Me.lblSifre.TabIndex = 48
        Me.lblSifre.Text = "Şifre"
        '
        'lblSubeSec
        '
        Me.lblSubeSec.AutoSize = True
        Me.lblSubeSec.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeSec.ForeColor = System.Drawing.Color.Black
        Me.lblSubeSec.Location = New System.Drawing.Point(465, 405)
        Me.lblSubeSec.Name = "lblSubeSec"
        Me.lblSubeSec.Size = New System.Drawing.Size(120, 31)
        Me.lblSubeSec.TabIndex = 47
        Me.lblSubeSec.Text = "Şube Seç"
        '
        'txtEposta
        '
        Me.txtEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtEposta.Location = New System.Drawing.Point(599, 239)
        Me.txtEposta.Name = "txtEposta"
        Me.txtEposta.Size = New System.Drawing.Size(245, 34)
        Me.txtEposta.TabIndex = 46
        '
        'txtSoyad
        '
        Me.txtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSoyad.Location = New System.Drawing.Point(599, 156)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(245, 34)
        Me.txtSoyad.TabIndex = 45
        '
        'txtAd
        '
        Me.txtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAd.Location = New System.Drawing.Point(599, 116)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(245, 34)
        Me.txtAd.TabIndex = 44
        '
        'txtPozisyon
        '
        Me.txtPozisyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPozisyon.Location = New System.Drawing.Point(599, 319)
        Me.txtPozisyon.Name = "txtPozisyon"
        Me.txtPozisyon.Size = New System.Drawing.Size(245, 34)
        Me.txtPozisyon.TabIndex = 43
        '
        'btnYeniAdresEkle
        '
        Me.btnYeniAdresEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYeniAdresEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYeniAdresEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYeniAdresEkle.ForeColor = System.Drawing.Color.Black
        Me.btnYeniAdresEkle.Location = New System.Drawing.Point(899, 333)
        Me.btnYeniAdresEkle.Name = "btnYeniAdresEkle"
        Me.btnYeniAdresEkle.Size = New System.Drawing.Size(202, 47)
        Me.btnYeniAdresEkle.TabIndex = 42
        Me.btnYeniAdresEkle.Text = "Yeni Adres Ekle"
        Me.btnYeniAdresEkle.UseVisualStyleBackColor = False
        '
        'btnResimEkle
        '
        Me.btnResimEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnResimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResimEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnResimEkle.ForeColor = System.Drawing.Color.Black
        Me.btnResimEkle.Location = New System.Drawing.Point(899, 279)
        Me.btnResimEkle.Name = "btnResimEkle"
        Me.btnResimEkle.Size = New System.Drawing.Size(202, 48)
        Me.btnResimEkle.TabIndex = 41
        Me.btnResimEkle.Text = "Resim Ekle"
        Me.btnResimEkle.UseVisualStyleBackColor = False
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnGuncelle.Location = New System.Drawing.Point(845, 472)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(225, 41)
        Me.btnGuncelle.TabIndex = 40
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(544, 472)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(225, 41)
        Me.btnIptal.TabIndex = 39
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'lblAdresID
        '
        Me.lblAdresID.AutoSize = True
        Me.lblAdresID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAdresID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdresID.ForeColor = System.Drawing.Color.Black
        Me.lblAdresID.Location = New System.Drawing.Point(463, 362)
        Me.lblAdresID.Name = "lblAdresID"
        Me.lblAdresID.Size = New System.Drawing.Size(107, 31)
        Me.lblAdresID.TabIndex = 38
        Me.lblAdresID.Text = "Adres ID"
        '
        'lblPozisyon
        '
        Me.lblPozisyon.AutoSize = True
        Me.lblPozisyon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPozisyon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPozisyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPozisyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblPozisyon.ForeColor = System.Drawing.Color.Black
        Me.lblPozisyon.Location = New System.Drawing.Point(463, 319)
        Me.lblPozisyon.Name = "lblPozisyon"
        Me.lblPozisyon.Size = New System.Drawing.Size(112, 31)
        Me.lblPozisyon.TabIndex = 37
        Me.lblPozisyon.Text = "Pozisyon"
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTelefon.ForeColor = System.Drawing.Color.Black
        Me.lblTelefon.Location = New System.Drawing.Point(465, 282)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(98, 31)
        Me.lblTelefon.TabIndex = 36
        Me.lblTelefon.Text = "Telefon"
        '
        'lblEposta
        '
        Me.lblEposta.AutoSize = True
        Me.lblEposta.BackColor = System.Drawing.Color.Gainsboro
        Me.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblEposta.ForeColor = System.Drawing.Color.Black
        Me.lblEposta.Location = New System.Drawing.Point(465, 242)
        Me.lblEposta.Name = "lblEposta"
        Me.lblEposta.Size = New System.Drawing.Size(90, 31)
        Me.lblEposta.TabIndex = 35
        Me.lblEposta.Text = "Eposta"
        '
        'lblCinsiyet
        '
        Me.lblCinsiyet.AutoSize = True
        Me.lblCinsiyet.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCinsiyet.ForeColor = System.Drawing.Color.Black
        Me.lblCinsiyet.Location = New System.Drawing.Point(463, 199)
        Me.lblCinsiyet.Name = "lblCinsiyet"
        Me.lblCinsiyet.Size = New System.Drawing.Size(100, 31)
        Me.lblCinsiyet.TabIndex = 34
        Me.lblCinsiyet.Text = "Cinsiyet"
        '
        'lblSoyad
        '
        Me.lblSoyad.AutoSize = True
        Me.lblSoyad.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoyad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSoyad.ForeColor = System.Drawing.Color.Black
        Me.lblSoyad.Location = New System.Drawing.Point(463, 159)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(83, 31)
        Me.lblSoyad.TabIndex = 33
        Me.lblSoyad.Text = "Soyad"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAd.ForeColor = System.Drawing.Color.Black
        Me.lblAd.Location = New System.Drawing.Point(465, 119)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(44, 31)
        Me.lblAd.TabIndex = 32
        Me.lblAd.Text = "Ad"
        '
        'lblCalisanGuncellemeIslemleri
        '
        Me.lblCalisanGuncellemeIslemleri.AutoSize = True
        Me.lblCalisanGuncellemeIslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCalisanGuncellemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalisanGuncellemeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCalisanGuncellemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCalisanGuncellemeIslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblCalisanGuncellemeIslemleri.Location = New System.Drawing.Point(301, 27)
        Me.lblCalisanGuncellemeIslemleri.Name = "lblCalisanGuncellemeIslemleri"
        Me.lblCalisanGuncellemeIslemleri.Size = New System.Drawing.Size(518, 46)
        Me.lblCalisanGuncellemeIslemleri.TabIndex = 31
        Me.lblCalisanGuncellemeIslemleri.Text = "Çalışan Güncelleme İşlemleri"
        '
        'lstCalisanlar
        '
        Me.lstCalisanlar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstCalisanlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCalisanlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstCalisanlar.ForeColor = System.Drawing.Color.Black
        Me.lstCalisanlar.FormattingEnabled = True
        Me.lstCalisanlar.ItemHeight = 29
        Me.lstCalisanlar.Location = New System.Drawing.Point(19, 105)
        Me.lstCalisanlar.Name = "lstCalisanlar"
        Me.lstCalisanlar.Size = New System.Drawing.Size(416, 408)
        Me.lstCalisanlar.TabIndex = 55
        '
        'CalisanGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1141, 547)
        Me.Controls.Add(Me.lstCalisanlar)
        Me.Controls.Add(Me.cbSubeSec)
        Me.Controls.Add(Me.cbAdresID)
        Me.Controls.Add(Me.mtxtTelefon)
        Me.Controls.Add(Me.cbCinsiyet)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.lblSifre)
        Me.Controls.Add(Me.lblSubeSec)
        Me.Controls.Add(Me.txtEposta)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.txtPozisyon)
        Me.Controls.Add(Me.btnYeniAdresEkle)
        Me.Controls.Add(Me.btnResimEkle)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.lblAdresID)
        Me.Controls.Add(Me.lblPozisyon)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.lblEposta)
        Me.Controls.Add(Me.lblCinsiyet)
        Me.Controls.Add(Me.lblSoyad)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.lblCalisanGuncellemeIslemleri)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CalisanGuncelle"
        Me.Text = "Çalışan Güncelleme"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbSubeSec As ComboBox
    Friend WithEvents cbAdresID As ComboBox
    Friend WithEvents mtxtTelefon As MaskedTextBox
    Friend WithEvents cbCinsiyet As ComboBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents lblSifre As Label
    Friend WithEvents lblSubeSec As Label
    Friend WithEvents txtEposta As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtPozisyon As TextBox
    Friend WithEvents btnYeniAdresEkle As Button
    Friend WithEvents btnResimEkle As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents btnIptal As Button
    Friend WithEvents lblAdresID As Label
    Friend WithEvents lblPozisyon As Label
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblEposta As Label
    Friend WithEvents lblCinsiyet As Label
    Friend WithEvents lblSoyad As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents lblCalisanGuncellemeIslemleri As Label
    Friend WithEvents lstCalisanlar As ListBox
End Class
