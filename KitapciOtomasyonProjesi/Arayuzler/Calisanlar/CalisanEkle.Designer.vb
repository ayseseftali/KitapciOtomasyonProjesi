<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalisanEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalisanEkle))
        Me.lblCalisanEklemeIslemleri = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblSoyad = New System.Windows.Forms.Label()
        Me.lblCinsiyet = New System.Windows.Forms.Label()
        Me.lblEposta = New System.Windows.Forms.Label()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblPozisyon = New System.Windows.Forms.Label()
        Me.lblAdresID = New System.Windows.Forms.Label()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnResimEkle = New System.Windows.Forms.Button()
        Me.btnYeniAdresEkle = New System.Windows.Forms.Button()
        Me.txtPozisyon = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtEposta = New System.Windows.Forms.TextBox()
        Me.lblSubeSec = New System.Windows.Forms.Label()
        Me.lblSifre = New System.Windows.Forms.Label()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.cbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.mtxtTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.cbAdresID = New System.Windows.Forms.ComboBox()
        Me.cbSubeSec = New System.Windows.Forms.ComboBox()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCalisanEklemeIslemleri
        '
        Me.lblCalisanEklemeIslemleri.AutoSize = True
        Me.lblCalisanEklemeIslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCalisanEklemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalisanEklemeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCalisanEklemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCalisanEklemeIslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblCalisanEklemeIslemleri.Location = New System.Drawing.Point(165, 29)
        Me.lblCalisanEklemeIslemleri.Name = "lblCalisanEklemeIslemleri"
        Me.lblCalisanEklemeIslemleri.Size = New System.Drawing.Size(394, 41)
        Me.lblCalisanEklemeIslemleri.TabIndex = 0
        Me.lblCalisanEklemeIslemleri.Text = "Çalışan Ekleme İşlemleri"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAd.ForeColor = System.Drawing.Color.Black
        Me.lblAd.Location = New System.Drawing.Point(36, 103)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(46, 31)
        Me.lblAd.TabIndex = 1
        Me.lblAd.Text = "Ad"
        '
        'lblSoyad
        '
        Me.lblSoyad.AutoSize = True
        Me.lblSoyad.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoyad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSoyad.ForeColor = System.Drawing.Color.Black
        Me.lblSoyad.Location = New System.Drawing.Point(34, 143)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(87, 31)
        Me.lblSoyad.TabIndex = 2
        Me.lblSoyad.Text = "Soyad"
        '
        'lblCinsiyet
        '
        Me.lblCinsiyet.AutoSize = True
        Me.lblCinsiyet.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCinsiyet.ForeColor = System.Drawing.Color.Black
        Me.lblCinsiyet.Location = New System.Drawing.Point(36, 183)
        Me.lblCinsiyet.Name = "lblCinsiyet"
        Me.lblCinsiyet.Size = New System.Drawing.Size(106, 31)
        Me.lblCinsiyet.TabIndex = 3
        Me.lblCinsiyet.Text = "Cinsiyet"
        '
        'lblEposta
        '
        Me.lblEposta.AutoSize = True
        Me.lblEposta.BackColor = System.Drawing.Color.Gainsboro
        Me.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblEposta.ForeColor = System.Drawing.Color.Black
        Me.lblEposta.Location = New System.Drawing.Point(36, 226)
        Me.lblEposta.Name = "lblEposta"
        Me.lblEposta.Size = New System.Drawing.Size(94, 31)
        Me.lblEposta.TabIndex = 4
        Me.lblEposta.Text = "Eposta"
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTelefon.ForeColor = System.Drawing.Color.Black
        Me.lblTelefon.Location = New System.Drawing.Point(36, 266)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(99, 31)
        Me.lblTelefon.TabIndex = 5
        Me.lblTelefon.Text = "Telefon"
        '
        'lblPozisyon
        '
        Me.lblPozisyon.AutoSize = True
        Me.lblPozisyon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPozisyon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPozisyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPozisyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblPozisyon.ForeColor = System.Drawing.Color.Black
        Me.lblPozisyon.Location = New System.Drawing.Point(34, 306)
        Me.lblPozisyon.Name = "lblPozisyon"
        Me.lblPozisyon.Size = New System.Drawing.Size(119, 31)
        Me.lblPozisyon.TabIndex = 6
        Me.lblPozisyon.Text = "Pozisyon"
        '
        'lblAdresID
        '
        Me.lblAdresID.AutoSize = True
        Me.lblAdresID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAdresID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdresID.ForeColor = System.Drawing.Color.Black
        Me.lblAdresID.Location = New System.Drawing.Point(34, 346)
        Me.lblAdresID.Name = "lblAdresID"
        Me.lblAdresID.Size = New System.Drawing.Size(112, 31)
        Me.lblAdresID.TabIndex = 7
        Me.lblAdresID.Text = "Adres ID"
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(92, 448)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(225, 41)
        Me.btnIptal.TabIndex = 8
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.ForeColor = System.Drawing.Color.Black
        Me.btnKaydet.Location = New System.Drawing.Point(366, 448)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(225, 41)
        Me.btnKaydet.TabIndex = 9
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'btnResimEkle
        '
        Me.btnResimEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnResimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResimEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnResimEkle.ForeColor = System.Drawing.Color.Black
        Me.btnResimEkle.Location = New System.Drawing.Point(458, 269)
        Me.btnResimEkle.Name = "btnResimEkle"
        Me.btnResimEkle.Size = New System.Drawing.Size(202, 48)
        Me.btnResimEkle.TabIndex = 10
        Me.btnResimEkle.Text = "Resim Ekle"
        Me.btnResimEkle.UseVisualStyleBackColor = False
        '
        'btnYeniAdresEkle
        '
        Me.btnYeniAdresEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYeniAdresEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYeniAdresEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYeniAdresEkle.ForeColor = System.Drawing.Color.Black
        Me.btnYeniAdresEkle.Location = New System.Drawing.Point(458, 323)
        Me.btnYeniAdresEkle.Name = "btnYeniAdresEkle"
        Me.btnYeniAdresEkle.Size = New System.Drawing.Size(202, 47)
        Me.btnYeniAdresEkle.TabIndex = 11
        Me.btnYeniAdresEkle.Text = "Yeni Adres Ekle"
        Me.btnYeniAdresEkle.UseVisualStyleBackColor = False
        '
        'txtPozisyon
        '
        Me.txtPozisyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPozisyon.Location = New System.Drawing.Point(176, 303)
        Me.txtPozisyon.Name = "txtPozisyon"
        Me.txtPozisyon.Size = New System.Drawing.Size(225, 34)
        Me.txtPozisyon.TabIndex = 13
        '
        'txtAd
        '
        Me.txtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAd.Location = New System.Drawing.Point(176, 100)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(225, 34)
        Me.txtAd.TabIndex = 14
        '
        'txtSoyad
        '
        Me.txtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSoyad.Location = New System.Drawing.Point(176, 140)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(225, 34)
        Me.txtSoyad.TabIndex = 15
        '
        'txtEposta
        '
        Me.txtEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtEposta.Location = New System.Drawing.Point(176, 223)
        Me.txtEposta.Name = "txtEposta"
        Me.txtEposta.Size = New System.Drawing.Size(225, 34)
        Me.txtEposta.TabIndex = 17
        '
        'lblSubeSec
        '
        Me.lblSubeSec.AutoSize = True
        Me.lblSubeSec.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeSec.ForeColor = System.Drawing.Color.Black
        Me.lblSubeSec.Location = New System.Drawing.Point(36, 389)
        Me.lblSubeSec.Name = "lblSubeSec"
        Me.lblSubeSec.Size = New System.Drawing.Size(125, 31)
        Me.lblSubeSec.TabIndex = 22
        Me.lblSubeSec.Text = "Şube Seç"
        '
        'lblSifre
        '
        Me.lblSifre.AutoSize = True
        Me.lblSifre.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSifre.ForeColor = System.Drawing.Color.Black
        Me.lblSifre.Location = New System.Drawing.Point(427, 386)
        Me.lblSifre.Name = "lblSifre"
        Me.lblSifre.Size = New System.Drawing.Size(67, 31)
        Me.lblSifre.TabIndex = 24
        Me.lblSifre.Text = "Şifre"
        '
        'txtSifre
        '
        Me.txtSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSifre.Location = New System.Drawing.Point(500, 385)
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.Size = New System.Drawing.Size(167, 34)
        Me.txtSifre.TabIndex = 25
        '
        'pbFoto
        '
        Me.pbFoto.BackColor = System.Drawing.Color.Gainsboro
        Me.pbFoto.Location = New System.Drawing.Point(458, 100)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(202, 158)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 26
        Me.pbFoto.TabStop = False
        '
        'cbCinsiyet
        '
        Me.cbCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbCinsiyet.FormattingEnabled = True
        Me.cbCinsiyet.Items.AddRange(New Object() {"Erkek", "Kız"})
        Me.cbCinsiyet.Location = New System.Drawing.Point(176, 180)
        Me.cbCinsiyet.Name = "cbCinsiyet"
        Me.cbCinsiyet.Size = New System.Drawing.Size(225, 37)
        Me.cbCinsiyet.TabIndex = 27
        '
        'mtxtTelefon
        '
        Me.mtxtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxtTelefon.Location = New System.Drawing.Point(176, 263)
        Me.mtxtTelefon.Mask = "(999) 000-0000"
        Me.mtxtTelefon.Name = "mtxtTelefon"
        Me.mtxtTelefon.Size = New System.Drawing.Size(225, 34)
        Me.mtxtTelefon.TabIndex = 28
        '
        'cbAdresID
        '
        Me.cbAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbAdresID.FormattingEnabled = True
        Me.cbAdresID.Location = New System.Drawing.Point(176, 343)
        Me.cbAdresID.Name = "cbAdresID"
        Me.cbAdresID.Size = New System.Drawing.Size(225, 37)
        Me.cbAdresID.TabIndex = 29
        '
        'cbSubeSec
        '
        Me.cbSubeSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbSubeSec.FormattingEnabled = True
        Me.cbSubeSec.Location = New System.Drawing.Point(176, 386)
        Me.cbSubeSec.Name = "cbSubeSec"
        Me.cbSubeSec.Size = New System.Drawing.Size(225, 37)
        Me.cbSubeSec.TabIndex = 30
        '
        'CalisanEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(704, 521)
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
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.lblAdresID)
        Me.Controls.Add(Me.lblPozisyon)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.lblEposta)
        Me.Controls.Add(Me.lblCinsiyet)
        Me.Controls.Add(Me.lblSoyad)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.lblCalisanEklemeIslemleri)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CalisanEkle"
        Me.Text = "Çalışan Ekleme"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCalisanEklemeIslemleri As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents lblSoyad As Label
    Friend WithEvents lblCinsiyet As Label
    Friend WithEvents lblEposta As Label
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblPozisyon As Label
    Friend WithEvents lblAdresID As Label
    Friend WithEvents btnIptal As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnResimEkle As Button
    Friend WithEvents btnYeniAdresEkle As Button
    Friend WithEvents txtPozisyon As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtEposta As TextBox
    Friend WithEvents lblSubeSec As Label
    Friend WithEvents lblSifre As Label
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents cbCinsiyet As ComboBox
    Friend WithEvents mtxtTelefon As MaskedTextBox
    Friend WithEvents cbAdresID As ComboBox
    Friend WithEvents cbSubeSec As ComboBox
End Class
