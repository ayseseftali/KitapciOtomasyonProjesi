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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusteriEkle))
        Me.mtxtTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.cbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.txtEposta = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblEposta = New System.Windows.Forms.Label()
        Me.lblCinsiyet = New System.Windows.Forms.Label()
        Me.lblSoyad = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblMusteriEklemeIslemleri = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mtxtTelefon
        '
        Me.mtxtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxtTelefon.Location = New System.Drawing.Point(191, 189)
        Me.mtxtTelefon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxtTelefon.Mask = "(999) 000-0000"
        Me.mtxtTelefon.Name = "mtxtTelefon"
        Me.mtxtTelefon.Size = New System.Drawing.Size(225, 36)
        Me.mtxtTelefon.TabIndex = 52
        '
        'cbCinsiyet
        '
        Me.cbCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbCinsiyet.FormattingEnabled = True
        Me.cbCinsiyet.Items.AddRange(New Object() {"Erkek", "Kız"})
        Me.cbCinsiyet.Location = New System.Drawing.Point(191, 269)
        Me.cbCinsiyet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCinsiyet.Name = "cbCinsiyet"
        Me.cbCinsiyet.Size = New System.Drawing.Size(225, 37)
        Me.cbCinsiyet.TabIndex = 51
        '
        'txtEposta
        '
        Me.txtEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtEposta.Location = New System.Drawing.Point(191, 229)
        Me.txtEposta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEposta.Name = "txtEposta"
        Me.txtEposta.Size = New System.Drawing.Size(225, 36)
        Me.txtEposta.TabIndex = 46
        '
        'txtSoyad
        '
        Me.txtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSoyad.Location = New System.Drawing.Point(191, 149)
        Me.txtSoyad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(225, 36)
        Me.txtSoyad.TabIndex = 45
        '
        'txtAd
        '
        Me.txtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAd.Location = New System.Drawing.Point(191, 109)
        Me.txtAd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(225, 36)
        Me.txtAd.TabIndex = 44
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.ForeColor = System.Drawing.Color.Black
        Me.btnKaydet.Location = New System.Drawing.Point(253, 345)
        Me.btnKaydet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(180, 41)
        Me.btnKaydet.TabIndex = 40
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(43, 345)
        Me.btnIptal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(182, 41)
        Me.btnIptal.TabIndex = 39
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTelefon.ForeColor = System.Drawing.Color.Black
        Me.lblTelefon.Location = New System.Drawing.Point(59, 192)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(99, 31)
        Me.lblTelefon.TabIndex = 36
        Me.lblTelefon.Text = "Telefon"
        '
        'lblEposta
        '
        Me.lblEposta.AutoSize = True
        Me.lblEposta.BackColor = System.Drawing.Color.Gainsboro
        Me.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblEposta.ForeColor = System.Drawing.Color.Black
        Me.lblEposta.Location = New System.Drawing.Point(59, 232)
        Me.lblEposta.Name = "lblEposta"
        Me.lblEposta.Size = New System.Drawing.Size(94, 31)
        Me.lblEposta.TabIndex = 35
        Me.lblEposta.Text = "Eposta"
        '
        'lblCinsiyet
        '
        Me.lblCinsiyet.AutoSize = True
        Me.lblCinsiyet.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCinsiyet.ForeColor = System.Drawing.Color.Black
        Me.lblCinsiyet.Location = New System.Drawing.Point(59, 272)
        Me.lblCinsiyet.Name = "lblCinsiyet"
        Me.lblCinsiyet.Size = New System.Drawing.Size(106, 31)
        Me.lblCinsiyet.TabIndex = 34
        Me.lblCinsiyet.Text = "Cinsiyet"
        '
        'lblSoyad
        '
        Me.lblSoyad.AutoSize = True
        Me.lblSoyad.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoyad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSoyad.ForeColor = System.Drawing.Color.Black
        Me.lblSoyad.Location = New System.Drawing.Point(59, 152)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(87, 31)
        Me.lblSoyad.TabIndex = 33
        Me.lblSoyad.Text = "Soyad"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAd.ForeColor = System.Drawing.Color.Black
        Me.lblAd.Location = New System.Drawing.Point(59, 112)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(46, 31)
        Me.lblAd.TabIndex = 32
        Me.lblAd.Text = "Ad"
        '
        'lblMusteriEklemeIslemleri
        '
        Me.lblMusteriEklemeIslemleri.AutoSize = True
        Me.lblMusteriEklemeIslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMusteriEklemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMusteriEklemeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMusteriEklemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMusteriEklemeIslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblMusteriEklemeIslemleri.Location = New System.Drawing.Point(43, 41)
        Me.lblMusteriEklemeIslemleri.Name = "lblMusteriEklemeIslemleri"
        Me.lblMusteriEklemeIslemleri.Size = New System.Drawing.Size(390, 41)
        Me.lblMusteriEklemeIslemleri.TabIndex = 31
        Me.lblMusteriEklemeIslemleri.Text = "Müşteri Ekleme İşlemleri"
        '
        'MusteriEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(481, 429)
        Me.Controls.Add(Me.mtxtTelefon)
        Me.Controls.Add(Me.cbCinsiyet)
        Me.Controls.Add(Me.txtEposta)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.lblEposta)
        Me.Controls.Add(Me.lblCinsiyet)
        Me.Controls.Add(Me.lblSoyad)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.lblMusteriEklemeIslemleri)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MusteriEkle"
        Me.Text = "Müşteri Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtxtTelefon As MaskedTextBox
    Friend WithEvents cbCinsiyet As ComboBox
    Friend WithEvents txtEposta As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents btnKaydet As Button
    Friend WithEvents btnIptal As Button
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblEposta As Label
    Friend WithEvents lblCinsiyet As Label
    Friend WithEvents lblSoyad As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents lblMusteriEklemeIslemleri As Label
End Class
