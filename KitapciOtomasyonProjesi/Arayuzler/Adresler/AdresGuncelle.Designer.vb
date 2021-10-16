<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdresGuncelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdresGuncelle))
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.lstAdresler = New System.Windows.Forms.ListBox()
        Me.lblAdresGuncellemeIslemleri = New System.Windows.Forms.Label()
        Me.lblCadde = New System.Windows.Forms.Label()
        Me.lblSokak = New System.Windows.Forms.Label()
        Me.lblMahalle = New System.Windows.Forms.Label()
        Me.lblBinaNo = New System.Windows.Forms.Label()
        Me.lblKat = New System.Windows.Forms.Label()
        Me.lblDaireNo = New System.Windows.Forms.Label()
        Me.lblPostaKodu = New System.Windows.Forms.Label()
        Me.lblIlce = New System.Windows.Forms.Label()
        Me.txtCadde = New System.Windows.Forms.TextBox()
        Me.txtSokak = New System.Windows.Forms.TextBox()
        Me.txtMahalle = New System.Windows.Forms.TextBox()
        Me.txtBinaNo = New System.Windows.Forms.TextBox()
        Me.txtKat = New System.Windows.Forms.TextBox()
        Me.txtDaireNo = New System.Windows.Forms.TextBox()
        Me.txtPostaKodu = New System.Windows.Forms.TextBox()
        Me.txtIlce = New System.Windows.Forms.TextBox()
        Me.lblIl = New System.Windows.Forms.Label()
        Me.txtIl = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(502, 489)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(142, 46)
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
        Me.btnGuncelle.Location = New System.Drawing.Point(675, 489)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(142, 46)
        Me.btnGuncelle.TabIndex = 1
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'lstAdresler
        '
        Me.lstAdresler.BackColor = System.Drawing.Color.Gainsboro
        Me.lstAdresler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstAdresler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstAdresler.ForeColor = System.Drawing.Color.Black
        Me.lstAdresler.FormattingEnabled = True
        Me.lstAdresler.ItemHeight = 29
        Me.lstAdresler.Location = New System.Drawing.Point(23, 108)
        Me.lstAdresler.Name = "lstAdresler"
        Me.lstAdresler.Size = New System.Drawing.Size(429, 437)
        Me.lstAdresler.TabIndex = 2
        '
        'lblAdresGuncellemeIslemleri
        '
        Me.lblAdresGuncellemeIslemleri.AutoSize = True
        Me.lblAdresGuncellemeIslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAdresGuncellemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresGuncellemeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAdresGuncellemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdresGuncellemeIslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblAdresGuncellemeIslemleri.Location = New System.Drawing.Point(221, 29)
        Me.lblAdresGuncellemeIslemleri.Name = "lblAdresGuncellemeIslemleri"
        Me.lblAdresGuncellemeIslemleri.Size = New System.Drawing.Size(436, 41)
        Me.lblAdresGuncellemeIslemleri.TabIndex = 3
        Me.lblAdresGuncellemeIslemleri.Text = "Adres Güncelleme İşlemleri"
        '
        'lblCadde
        '
        Me.lblCadde.AutoSize = True
        Me.lblCadde.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCadde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCadde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCadde.ForeColor = System.Drawing.Color.Black
        Me.lblCadde.Location = New System.Drawing.Point(484, 107)
        Me.lblCadde.Name = "lblCadde"
        Me.lblCadde.Size = New System.Drawing.Size(87, 31)
        Me.lblCadde.TabIndex = 5
        Me.lblCadde.Text = "Cadde"
        '
        'lblSokak
        '
        Me.lblSokak.AutoSize = True
        Me.lblSokak.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSokak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSokak.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSokak.ForeColor = System.Drawing.Color.Black
        Me.lblSokak.Location = New System.Drawing.Point(484, 147)
        Me.lblSokak.Name = "lblSokak"
        Me.lblSokak.Size = New System.Drawing.Size(82, 31)
        Me.lblSokak.TabIndex = 6
        Me.lblSokak.Text = "Sokak"
        '
        'lblMahalle
        '
        Me.lblMahalle.AutoSize = True
        Me.lblMahalle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMahalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMahalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMahalle.ForeColor = System.Drawing.Color.Black
        Me.lblMahalle.Location = New System.Drawing.Point(484, 187)
        Me.lblMahalle.Name = "lblMahalle"
        Me.lblMahalle.Size = New System.Drawing.Size(100, 31)
        Me.lblMahalle.TabIndex = 7
        Me.lblMahalle.Text = "Mahalle"
        '
        'lblBinaNo
        '
        Me.lblBinaNo.AutoSize = True
        Me.lblBinaNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblBinaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBinaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBinaNo.ForeColor = System.Drawing.Color.Black
        Me.lblBinaNo.Location = New System.Drawing.Point(484, 227)
        Me.lblBinaNo.Name = "lblBinaNo"
        Me.lblBinaNo.Size = New System.Drawing.Size(101, 31)
        Me.lblBinaNo.TabIndex = 8
        Me.lblBinaNo.Text = "Bina No"
        '
        'lblKat
        '
        Me.lblKat.AutoSize = True
        Me.lblKat.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKat.ForeColor = System.Drawing.Color.Black
        Me.lblKat.Location = New System.Drawing.Point(484, 267)
        Me.lblKat.Name = "lblKat"
        Me.lblKat.Size = New System.Drawing.Size(50, 31)
        Me.lblKat.TabIndex = 9
        Me.lblKat.Text = "Kat"
        '
        'lblDaireNo
        '
        Me.lblDaireNo.AutoSize = True
        Me.lblDaireNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDaireNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDaireNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblDaireNo.ForeColor = System.Drawing.Color.Black
        Me.lblDaireNo.Location = New System.Drawing.Point(484, 307)
        Me.lblDaireNo.Name = "lblDaireNo"
        Me.lblDaireNo.Size = New System.Drawing.Size(111, 31)
        Me.lblDaireNo.TabIndex = 10
        Me.lblDaireNo.Text = "Daire No"
        '
        'lblPostaKodu
        '
        Me.lblPostaKodu.AutoSize = True
        Me.lblPostaKodu.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPostaKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostaKodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblPostaKodu.ForeColor = System.Drawing.Color.Black
        Me.lblPostaKodu.Location = New System.Drawing.Point(484, 347)
        Me.lblPostaKodu.Name = "lblPostaKodu"
        Me.lblPostaKodu.Size = New System.Drawing.Size(139, 31)
        Me.lblPostaKodu.TabIndex = 11
        Me.lblPostaKodu.Text = "Posta Kodu"
        '
        'lblIlce
        '
        Me.lblIlce.AutoSize = True
        Me.lblIlce.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIlce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIlce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblIlce.ForeColor = System.Drawing.Color.Black
        Me.lblIlce.Location = New System.Drawing.Point(484, 387)
        Me.lblIlce.Name = "lblIlce"
        Me.lblIlce.Size = New System.Drawing.Size(53, 31)
        Me.lblIlce.TabIndex = 12
        Me.lblIlce.Text = "İlçe"
        '
        'txtCadde
        '
        Me.txtCadde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCadde.Location = New System.Drawing.Point(647, 104)
        Me.txtCadde.Name = "txtCadde"
        Me.txtCadde.Size = New System.Drawing.Size(191, 34)
        Me.txtCadde.TabIndex = 13
        '
        'txtSokak
        '
        Me.txtSokak.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSokak.Location = New System.Drawing.Point(647, 144)
        Me.txtSokak.Name = "txtSokak"
        Me.txtSokak.Size = New System.Drawing.Size(191, 34)
        Me.txtSokak.TabIndex = 14
        '
        'txtMahalle
        '
        Me.txtMahalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMahalle.Location = New System.Drawing.Point(647, 184)
        Me.txtMahalle.Name = "txtMahalle"
        Me.txtMahalle.Size = New System.Drawing.Size(191, 34)
        Me.txtMahalle.TabIndex = 15
        '
        'txtBinaNo
        '
        Me.txtBinaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBinaNo.Location = New System.Drawing.Point(647, 224)
        Me.txtBinaNo.Name = "txtBinaNo"
        Me.txtBinaNo.Size = New System.Drawing.Size(191, 34)
        Me.txtBinaNo.TabIndex = 16
        '
        'txtKat
        '
        Me.txtKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKat.Location = New System.Drawing.Point(647, 264)
        Me.txtKat.Name = "txtKat"
        Me.txtKat.Size = New System.Drawing.Size(191, 34)
        Me.txtKat.TabIndex = 17
        '
        'txtDaireNo
        '
        Me.txtDaireNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtDaireNo.Location = New System.Drawing.Point(647, 304)
        Me.txtDaireNo.Name = "txtDaireNo"
        Me.txtDaireNo.Size = New System.Drawing.Size(191, 34)
        Me.txtDaireNo.TabIndex = 18
        '
        'txtPostaKodu
        '
        Me.txtPostaKodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPostaKodu.Location = New System.Drawing.Point(647, 344)
        Me.txtPostaKodu.Name = "txtPostaKodu"
        Me.txtPostaKodu.Size = New System.Drawing.Size(191, 34)
        Me.txtPostaKodu.TabIndex = 19
        '
        'txtIlce
        '
        Me.txtIlce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtIlce.Location = New System.Drawing.Point(647, 384)
        Me.txtIlce.Name = "txtIlce"
        Me.txtIlce.Size = New System.Drawing.Size(191, 34)
        Me.txtIlce.TabIndex = 20
        '
        'lblIl
        '
        Me.lblIl.AutoSize = True
        Me.lblIl.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblIl.ForeColor = System.Drawing.Color.Black
        Me.lblIl.Location = New System.Drawing.Point(484, 427)
        Me.lblIl.Name = "lblIl"
        Me.lblIl.Size = New System.Drawing.Size(27, 31)
        Me.lblIl.TabIndex = 21
        Me.lblIl.Text = "İl"
        '
        'txtIl
        '
        Me.txtIl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtIl.Location = New System.Drawing.Point(647, 424)
        Me.txtIl.Name = "txtIl"
        Me.txtIl.Size = New System.Drawing.Size(191, 34)
        Me.txtIl.TabIndex = 22
        '
        'AdresGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(861, 563)
        Me.Controls.Add(Me.txtIl)
        Me.Controls.Add(Me.lblIl)
        Me.Controls.Add(Me.txtIlce)
        Me.Controls.Add(Me.txtPostaKodu)
        Me.Controls.Add(Me.txtDaireNo)
        Me.Controls.Add(Me.txtKat)
        Me.Controls.Add(Me.txtBinaNo)
        Me.Controls.Add(Me.txtMahalle)
        Me.Controls.Add(Me.txtSokak)
        Me.Controls.Add(Me.txtCadde)
        Me.Controls.Add(Me.lblIlce)
        Me.Controls.Add(Me.lblPostaKodu)
        Me.Controls.Add(Me.lblDaireNo)
        Me.Controls.Add(Me.lblKat)
        Me.Controls.Add(Me.lblBinaNo)
        Me.Controls.Add(Me.lblMahalle)
        Me.Controls.Add(Me.lblSokak)
        Me.Controls.Add(Me.lblCadde)
        Me.Controls.Add(Me.lblAdresGuncellemeIslemleri)
        Me.Controls.Add(Me.lstAdresler)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.btnIptal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdresGuncelle"
        Me.Text = "Adres Güncelleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIptal As Button
    Friend WithEvents btnGuncelle As Button
    Friend WithEvents lstAdresler As ListBox
    Friend WithEvents lblAdresGuncellemeIslemleri As Label
    Friend WithEvents lblCadde As Label
    Friend WithEvents lblSokak As Label
    Friend WithEvents lblMahalle As Label
    Friend WithEvents lblBinaNo As Label
    Friend WithEvents lblKat As Label
    Friend WithEvents lblDaireNo As Label
    Friend WithEvents lblPostaKodu As Label
    Friend WithEvents lblIlce As Label
    Friend WithEvents txtCadde As TextBox
    Friend WithEvents txtSokak As TextBox
    Friend WithEvents txtMahalle As TextBox
    Friend WithEvents txtBinaNo As TextBox
    Friend WithEvents txtKat As TextBox
    Friend WithEvents txtDaireNo As TextBox
    Friend WithEvents txtPostaKodu As TextBox
    Friend WithEvents txtIlce As TextBox
    Friend WithEvents lblIl As Label
    Friend WithEvents txtIl As TextBox
End Class
