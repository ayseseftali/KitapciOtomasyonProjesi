<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusteriEkle
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
        Me.mtxtTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.cbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.txtEposta = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.btnYeniAdresEkle = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblEposta = New System.Windows.Forms.Label()
        Me.lblCinsiyet = New System.Windows.Forms.Label()
        Me.lblSoyad = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblCalisanEklemeIslemleri = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mtxtTelefon
        '
        Me.mtxtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxtTelefon.Location = New System.Drawing.Point(154, 172)
        Me.mtxtTelefon.Mask = "(999) 000-0000"
        Me.mtxtTelefon.Name = "mtxtTelefon"
        Me.mtxtTelefon.Size = New System.Drawing.Size(225, 34)
        Me.mtxtTelefon.TabIndex = 52
        '
        'cbCinsiyet
        '
        Me.cbCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbCinsiyet.FormattingEnabled = True
        Me.cbCinsiyet.Location = New System.Drawing.Point(154, 268)
        Me.cbCinsiyet.Name = "cbCinsiyet"
        Me.cbCinsiyet.Size = New System.Drawing.Size(225, 37)
        Me.cbCinsiyet.TabIndex = 51
        '
        'txtEposta
        '
        Me.txtEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtEposta.Location = New System.Drawing.Point(154, 218)
        Me.txtEposta.Name = "txtEposta"
        Me.txtEposta.Size = New System.Drawing.Size(225, 34)
        Me.txtEposta.TabIndex = 46
        '
        'txtSoyad
        '
        Me.txtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSoyad.Location = New System.Drawing.Point(154, 127)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(225, 34)
        Me.txtSoyad.TabIndex = 45
        '
        'txtAd
        '
        Me.txtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAd.Location = New System.Drawing.Point(154, 87)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(225, 34)
        Me.txtAd.TabIndex = 44
        '
        'btnYeniAdresEkle
        '
        Me.btnYeniAdresEkle.BackColor = System.Drawing.Color.Maroon
        Me.btnYeniAdresEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYeniAdresEkle.ForeColor = System.Drawing.Color.Coral
        Me.btnYeniAdresEkle.Location = New System.Drawing.Point(100, 380)
        Me.btnYeniAdresEkle.Name = "btnYeniAdresEkle"
        Me.btnYeniAdresEkle.Size = New System.Drawing.Size(202, 47)
        Me.btnYeniAdresEkle.TabIndex = 42
        Me.btnYeniAdresEkle.Text = "Yeni Adres Ekle"
        Me.btnYeniAdresEkle.UseVisualStyleBackColor = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Maroon
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.ForeColor = System.Drawing.Color.Coral
        Me.btnKaydet.Location = New System.Drawing.Point(207, 321)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(172, 41)
        Me.btnKaydet.TabIndex = 40
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Maroon
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Coral
        Me.btnIptal.Location = New System.Drawing.Point(20, 321)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(164, 41)
        Me.btnIptal.TabIndex = 39
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.BackColor = System.Drawing.Color.Maroon
        Me.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTelefon.ForeColor = System.Drawing.Color.Coral
        Me.lblTelefon.Location = New System.Drawing.Point(20, 180)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(98, 31)
        Me.lblTelefon.TabIndex = 36
        Me.lblTelefon.Text = "Telefon"
        '
        'lblEposta
        '
        Me.lblEposta.AutoSize = True
        Me.lblEposta.BackColor = System.Drawing.Color.Maroon
        Me.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblEposta.ForeColor = System.Drawing.Color.Coral
        Me.lblEposta.Location = New System.Drawing.Point(20, 226)
        Me.lblEposta.Name = "lblEposta"
        Me.lblEposta.Size = New System.Drawing.Size(90, 31)
        Me.lblEposta.TabIndex = 35
        Me.lblEposta.Text = "Eposta"
        '
        'lblCinsiyet
        '
        Me.lblCinsiyet.AutoSize = True
        Me.lblCinsiyet.BackColor = System.Drawing.Color.Maroon
        Me.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCinsiyet.ForeColor = System.Drawing.Color.Coral
        Me.lblCinsiyet.Location = New System.Drawing.Point(18, 271)
        Me.lblCinsiyet.Name = "lblCinsiyet"
        Me.lblCinsiyet.Size = New System.Drawing.Size(100, 31)
        Me.lblCinsiyet.TabIndex = 34
        Me.lblCinsiyet.Text = "Cinsiyet"
        '
        'lblSoyad
        '
        Me.lblSoyad.AutoSize = True
        Me.lblSoyad.BackColor = System.Drawing.Color.Maroon
        Me.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSoyad.ForeColor = System.Drawing.Color.Coral
        Me.lblSoyad.Location = New System.Drawing.Point(20, 130)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(83, 31)
        Me.lblSoyad.TabIndex = 33
        Me.lblSoyad.Text = "Soyad"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.BackColor = System.Drawing.Color.Maroon
        Me.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAd.ForeColor = System.Drawing.Color.Coral
        Me.lblAd.Location = New System.Drawing.Point(20, 90)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(44, 31)
        Me.lblAd.TabIndex = 32
        Me.lblAd.Text = "Ad"
        '
        'lblCalisanEklemeIslemleri
        '
        Me.lblCalisanEklemeIslemleri.AutoSize = True
        Me.lblCalisanEklemeIslemleri.BackColor = System.Drawing.Color.Maroon
        Me.lblCalisanEklemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalisanEklemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCalisanEklemeIslemleri.ForeColor = System.Drawing.Color.Coral
        Me.lblCalisanEklemeIslemleri.Location = New System.Drawing.Point(39, 24)
        Me.lblCalisanEklemeIslemleri.Name = "lblCalisanEklemeIslemleri"
        Me.lblCalisanEklemeIslemleri.Size = New System.Drawing.Size(338, 35)
        Me.lblCalisanEklemeIslemleri.TabIndex = 31
        Me.lblCalisanEklemeIslemleri.Text = "Müşteri Ekleme İşlemleri"
        '
        'MusteriEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(408, 447)
        Me.Controls.Add(Me.mtxtTelefon)
        Me.Controls.Add(Me.cbCinsiyet)
        Me.Controls.Add(Me.txtEposta)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.btnYeniAdresEkle)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.lblEposta)
        Me.Controls.Add(Me.lblCinsiyet)
        Me.Controls.Add(Me.lblSoyad)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.lblCalisanEklemeIslemleri)
        Me.Name = "MusteriEkle"
        Me.Text = "MusteriEkle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtxtTelefon As MaskedTextBox
    Friend WithEvents cbCinsiyet As ComboBox
    Friend WithEvents txtEposta As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents btnYeniAdresEkle As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnIptal As Button
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblEposta As Label
    Friend WithEvents lblCinsiyet As Label
    Friend WithEvents lblSoyad As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents lblCalisanEklemeIslemleri As Label
End Class
