<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusterileriGuncelle
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
        Me.lstMusteriler = New System.Windows.Forms.ListBox()
        Me.mtxtTelefon = New System.Windows.Forms.MaskedTextBox()
        Me.cbCinsiyet = New System.Windows.Forms.ComboBox()
        Me.txtEposta = New System.Windows.Forms.TextBox()
        Me.txtSoyad = New System.Windows.Forms.TextBox()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.lblEposta = New System.Windows.Forms.Label()
        Me.lblCinsiyet = New System.Windows.Forms.Label()
        Me.lblSoyad = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblCalisanGuncellemeIslemleri = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstMusteriler
        '
        Me.lstMusteriler.BackColor = System.Drawing.Color.Khaki
        Me.lstMusteriler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstMusteriler.ForeColor = System.Drawing.Color.Coral
        Me.lstMusteriler.FormattingEnabled = True
        Me.lstMusteriler.ItemHeight = 29
        Me.lstMusteriler.Location = New System.Drawing.Point(34, 124)
        Me.lstMusteriler.Name = "lstMusteriler"
        Me.lstMusteriler.Size = New System.Drawing.Size(320, 294)
        Me.lstMusteriler.TabIndex = 80
        '
        'mtxtTelefon
        '
        Me.mtxtTelefon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxtTelefon.Location = New System.Drawing.Point(515, 287)
        Me.mtxtTelefon.Mask = "(999) 000-0000"
        Me.mtxtTelefon.Name = "mtxtTelefon"
        Me.mtxtTelefon.Size = New System.Drawing.Size(225, 34)
        Me.mtxtTelefon.TabIndex = 77
        '
        'cbCinsiyet
        '
        Me.cbCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbCinsiyet.FormattingEnabled = True
        Me.cbCinsiyet.Location = New System.Drawing.Point(515, 202)
        Me.cbCinsiyet.Name = "cbCinsiyet"
        Me.cbCinsiyet.Size = New System.Drawing.Size(225, 37)
        Me.cbCinsiyet.TabIndex = 76
        '
        'txtEposta
        '
        Me.txtEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtEposta.Location = New System.Drawing.Point(515, 243)
        Me.txtEposta.Name = "txtEposta"
        Me.txtEposta.Size = New System.Drawing.Size(225, 34)
        Me.txtEposta.TabIndex = 71
        '
        'txtSoyad
        '
        Me.txtSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSoyad.Location = New System.Drawing.Point(515, 161)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.Size = New System.Drawing.Size(225, 34)
        Me.txtSoyad.TabIndex = 70
        '
        'txtAd
        '
        Me.txtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAd.Location = New System.Drawing.Point(515, 121)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(225, 34)
        Me.txtAd.TabIndex = 69
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.Maroon
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.ForeColor = System.Drawing.Color.Coral
        Me.btnGuncelle.Location = New System.Drawing.Point(582, 358)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(168, 41)
        Me.btnGuncelle.TabIndex = 65
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Maroon
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Coral
        Me.btnIptal.Location = New System.Drawing.Point(379, 358)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(168, 41)
        Me.btnIptal.TabIndex = 64
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
        Me.lblTelefon.Location = New System.Drawing.Point(381, 295)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(98, 31)
        Me.lblTelefon.TabIndex = 61
        Me.lblTelefon.Text = "Telefon"
        '
        'lblEposta
        '
        Me.lblEposta.AutoSize = True
        Me.lblEposta.BackColor = System.Drawing.Color.Maroon
        Me.lblEposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblEposta.ForeColor = System.Drawing.Color.Coral
        Me.lblEposta.Location = New System.Drawing.Point(381, 251)
        Me.lblEposta.Name = "lblEposta"
        Me.lblEposta.Size = New System.Drawing.Size(90, 31)
        Me.lblEposta.TabIndex = 60
        Me.lblEposta.Text = "Eposta"
        '
        'lblCinsiyet
        '
        Me.lblCinsiyet.AutoSize = True
        Me.lblCinsiyet.BackColor = System.Drawing.Color.Maroon
        Me.lblCinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCinsiyet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCinsiyet.ForeColor = System.Drawing.Color.Coral
        Me.lblCinsiyet.Location = New System.Drawing.Point(379, 205)
        Me.lblCinsiyet.Name = "lblCinsiyet"
        Me.lblCinsiyet.Size = New System.Drawing.Size(100, 31)
        Me.lblCinsiyet.TabIndex = 59
        Me.lblCinsiyet.Text = "Cinsiyet"
        '
        'lblSoyad
        '
        Me.lblSoyad.AutoSize = True
        Me.lblSoyad.BackColor = System.Drawing.Color.Maroon
        Me.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSoyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSoyad.ForeColor = System.Drawing.Color.Coral
        Me.lblSoyad.Location = New System.Drawing.Point(381, 164)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(83, 31)
        Me.lblSoyad.TabIndex = 58
        Me.lblSoyad.Text = "Soyad"
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.BackColor = System.Drawing.Color.Maroon
        Me.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAd.ForeColor = System.Drawing.Color.Coral
        Me.lblAd.Location = New System.Drawing.Point(381, 124)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(44, 31)
        Me.lblAd.TabIndex = 57
        Me.lblAd.Text = "Ad"
        '
        'lblCalisanGuncellemeIslemleri
        '
        Me.lblCalisanGuncellemeIslemleri.AutoSize = True
        Me.lblCalisanGuncellemeIslemleri.BackColor = System.Drawing.Color.Maroon
        Me.lblCalisanGuncellemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalisanGuncellemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCalisanGuncellemeIslemleri.ForeColor = System.Drawing.Color.Coral
        Me.lblCalisanGuncellemeIslemleri.Location = New System.Drawing.Point(96, 22)
        Me.lblCalisanGuncellemeIslemleri.Name = "lblCalisanGuncellemeIslemleri"
        Me.lblCalisanGuncellemeIslemleri.Size = New System.Drawing.Size(517, 46)
        Me.lblCalisanGuncellemeIslemleri.TabIndex = 56
        Me.lblCalisanGuncellemeIslemleri.Text = "Müşteri Güncelleme İşlemleri"
        '
        'MusterileriGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(818, 476)
        Me.Controls.Add(Me.lstMusteriler)
        Me.Controls.Add(Me.mtxtTelefon)
        Me.Controls.Add(Me.cbCinsiyet)
        Me.Controls.Add(Me.txtEposta)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.lblEposta)
        Me.Controls.Add(Me.lblCinsiyet)
        Me.Controls.Add(Me.lblSoyad)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.lblCalisanGuncellemeIslemleri)
        Me.Name = "MusterileriGuncelle"
        Me.Text = "MusteriGuncelle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMusteriler As ListBox
    Friend WithEvents mtxtTelefon As MaskedTextBox
    Friend WithEvents cbCinsiyet As ComboBox
    Friend WithEvents txtEposta As TextBox
    Friend WithEvents txtSoyad As TextBox
    Friend WithEvents txtAd As TextBox
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents btnIptal As Button
    Friend WithEvents lblTelefon As Label
    Friend WithEvents lblEposta As Label
    Friend WithEvents lblCinsiyet As Label
    Friend WithEvents lblSoyad As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents lblCalisanGuncellemeIslemleri As Label
End Class
