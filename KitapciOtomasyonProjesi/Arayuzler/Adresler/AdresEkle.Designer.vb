<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdresEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdresEkle))
        Me.lblYeniAdres = New System.Windows.Forms.Label()
        Me.lblCadde = New System.Windows.Forms.Label()
        Me.lblSokak = New System.Windows.Forms.Label()
        Me.lblMahalle = New System.Windows.Forms.Label()
        Me.lblBinaNo = New System.Windows.Forms.Label()
        Me.lblKat = New System.Windows.Forms.Label()
        Me.lblDaireNo = New System.Windows.Forms.Label()
        Me.lblPostaKodu = New System.Windows.Forms.Label()
        Me.lblIlce = New System.Windows.Forms.Label()
        Me.lblIl = New System.Windows.Forms.Label()
        Me.txtCadde = New System.Windows.Forms.TextBox()
        Me.txtPostaKodu = New System.Windows.Forms.TextBox()
        Me.txtDaireNo = New System.Windows.Forms.TextBox()
        Me.txtIlce = New System.Windows.Forms.TextBox()
        Me.txtIl = New System.Windows.Forms.TextBox()
        Me.txtKat = New System.Windows.Forms.TextBox()
        Me.txtBinaNo = New System.Windows.Forms.TextBox()
        Me.txtMahalle = New System.Windows.Forms.TextBox()
        Me.txtSokak = New System.Windows.Forms.TextBox()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblYeniAdres
        '
        Me.lblYeniAdres.AutoSize = True
        Me.lblYeniAdres.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYeniAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYeniAdres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYeniAdres.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYeniAdres.ForeColor = System.Drawing.Color.Black
        Me.lblYeniAdres.Location = New System.Drawing.Point(41, 28)
        Me.lblYeniAdres.Name = "lblYeniAdres"
        Me.lblYeniAdres.Size = New System.Drawing.Size(445, 41)
        Me.lblYeniAdres.TabIndex = 0
        Me.lblYeniAdres.Text = "Yeni Adres Ekleme İşlemleri"
        '
        'lblCadde
        '
        Me.lblCadde.AutoSize = True
        Me.lblCadde.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCadde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCadde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCadde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCadde.ForeColor = System.Drawing.Color.Black
        Me.lblCadde.Location = New System.Drawing.Point(52, 106)
        Me.lblCadde.Name = "lblCadde"
        Me.lblCadde.Size = New System.Drawing.Size(87, 31)
        Me.lblCadde.TabIndex = 2
        Me.lblCadde.Text = "Cadde"
        '
        'lblSokak
        '
        Me.lblSokak.AutoSize = True
        Me.lblSokak.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSokak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSokak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSokak.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSokak.ForeColor = System.Drawing.Color.Black
        Me.lblSokak.Location = New System.Drawing.Point(51, 146)
        Me.lblSokak.Name = "lblSokak"
        Me.lblSokak.Size = New System.Drawing.Size(82, 31)
        Me.lblSokak.TabIndex = 3
        Me.lblSokak.Text = "Sokak"
        '
        'lblMahalle
        '
        Me.lblMahalle.AutoSize = True
        Me.lblMahalle.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMahalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMahalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMahalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMahalle.ForeColor = System.Drawing.Color.Black
        Me.lblMahalle.Location = New System.Drawing.Point(52, 186)
        Me.lblMahalle.Name = "lblMahalle"
        Me.lblMahalle.Size = New System.Drawing.Size(100, 31)
        Me.lblMahalle.TabIndex = 4
        Me.lblMahalle.Text = "Mahalle"
        '
        'lblBinaNo
        '
        Me.lblBinaNo.AutoSize = True
        Me.lblBinaNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblBinaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBinaNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBinaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBinaNo.ForeColor = System.Drawing.Color.Black
        Me.lblBinaNo.Location = New System.Drawing.Point(52, 226)
        Me.lblBinaNo.Name = "lblBinaNo"
        Me.lblBinaNo.Size = New System.Drawing.Size(101, 31)
        Me.lblBinaNo.TabIndex = 5
        Me.lblBinaNo.Text = "Bina No"
        '
        'lblKat
        '
        Me.lblKat.AutoSize = True
        Me.lblKat.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKat.ForeColor = System.Drawing.Color.Black
        Me.lblKat.Location = New System.Drawing.Point(51, 266)
        Me.lblKat.Name = "lblKat"
        Me.lblKat.Size = New System.Drawing.Size(50, 31)
        Me.lblKat.TabIndex = 6
        Me.lblKat.Text = "Kat"
        '
        'lblDaireNo
        '
        Me.lblDaireNo.AutoSize = True
        Me.lblDaireNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDaireNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDaireNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDaireNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblDaireNo.ForeColor = System.Drawing.Color.Black
        Me.lblDaireNo.Location = New System.Drawing.Point(52, 306)
        Me.lblDaireNo.Name = "lblDaireNo"
        Me.lblDaireNo.Size = New System.Drawing.Size(111, 31)
        Me.lblDaireNo.TabIndex = 7
        Me.lblDaireNo.Text = "Daire No"
        '
        'lblPostaKodu
        '
        Me.lblPostaKodu.AutoSize = True
        Me.lblPostaKodu.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPostaKodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPostaKodu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPostaKodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblPostaKodu.ForeColor = System.Drawing.Color.Black
        Me.lblPostaKodu.Location = New System.Drawing.Point(51, 346)
        Me.lblPostaKodu.Name = "lblPostaKodu"
        Me.lblPostaKodu.Size = New System.Drawing.Size(139, 31)
        Me.lblPostaKodu.TabIndex = 8
        Me.lblPostaKodu.Text = "Posta Kodu"
        '
        'lblIlce
        '
        Me.lblIlce.AutoSize = True
        Me.lblIlce.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIlce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIlce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIlce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblIlce.ForeColor = System.Drawing.Color.Black
        Me.lblIlce.Location = New System.Drawing.Point(52, 386)
        Me.lblIlce.Name = "lblIlce"
        Me.lblIlce.Size = New System.Drawing.Size(53, 31)
        Me.lblIlce.TabIndex = 9
        Me.lblIlce.Text = "İlçe"
        '
        'lblIl
        '
        Me.lblIl.AutoSize = True
        Me.lblIl.BackColor = System.Drawing.Color.Gainsboro
        Me.lblIl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblIl.ForeColor = System.Drawing.Color.Black
        Me.lblIl.Location = New System.Drawing.Point(51, 426)
        Me.lblIl.Name = "lblIl"
        Me.lblIl.Size = New System.Drawing.Size(27, 31)
        Me.lblIl.TabIndex = 10
        Me.lblIl.Text = "İl"
        '
        'txtCadde
        '
        Me.txtCadde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCadde.Location = New System.Drawing.Point(230, 103)
        Me.txtCadde.Name = "txtCadde"
        Me.txtCadde.Size = New System.Drawing.Size(228, 34)
        Me.txtCadde.TabIndex = 11
        '
        'txtPostaKodu
        '
        Me.txtPostaKodu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPostaKodu.Location = New System.Drawing.Point(230, 343)
        Me.txtPostaKodu.Name = "txtPostaKodu"
        Me.txtPostaKodu.Size = New System.Drawing.Size(228, 34)
        Me.txtPostaKodu.TabIndex = 12
        '
        'txtDaireNo
        '
        Me.txtDaireNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtDaireNo.Location = New System.Drawing.Point(230, 303)
        Me.txtDaireNo.Name = "txtDaireNo"
        Me.txtDaireNo.Size = New System.Drawing.Size(228, 34)
        Me.txtDaireNo.TabIndex = 13
        '
        'txtIlce
        '
        Me.txtIlce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtIlce.Location = New System.Drawing.Point(230, 383)
        Me.txtIlce.Name = "txtIlce"
        Me.txtIlce.Size = New System.Drawing.Size(228, 34)
        Me.txtIlce.TabIndex = 14
        '
        'txtIl
        '
        Me.txtIl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtIl.Location = New System.Drawing.Point(230, 423)
        Me.txtIl.Name = "txtIl"
        Me.txtIl.Size = New System.Drawing.Size(228, 34)
        Me.txtIl.TabIndex = 15
        '
        'txtKat
        '
        Me.txtKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKat.Location = New System.Drawing.Point(230, 263)
        Me.txtKat.Name = "txtKat"
        Me.txtKat.Size = New System.Drawing.Size(228, 34)
        Me.txtKat.TabIndex = 16
        '
        'txtBinaNo
        '
        Me.txtBinaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtBinaNo.Location = New System.Drawing.Point(230, 223)
        Me.txtBinaNo.Name = "txtBinaNo"
        Me.txtBinaNo.Size = New System.Drawing.Size(228, 34)
        Me.txtBinaNo.TabIndex = 17
        '
        'txtMahalle
        '
        Me.txtMahalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMahalle.Location = New System.Drawing.Point(230, 183)
        Me.txtMahalle.Name = "txtMahalle"
        Me.txtMahalle.Size = New System.Drawing.Size(228, 34)
        Me.txtMahalle.TabIndex = 18
        '
        'txtSokak
        '
        Me.txtSokak.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSokak.Location = New System.Drawing.Point(230, 143)
        Me.txtSokak.Name = "txtSokak"
        Me.txtSokak.Size = New System.Drawing.Size(228, 34)
        Me.txtSokak.TabIndex = 19
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(74, 490)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(150, 52)
        Me.btnIptal.TabIndex = 20
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.ForeColor = System.Drawing.Color.Black
        Me.btnKaydet.Location = New System.Drawing.Point(276, 490)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(159, 52)
        Me.btnKaydet.TabIndex = 21
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'AdresEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(527, 582)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.txtSokak)
        Me.Controls.Add(Me.txtMahalle)
        Me.Controls.Add(Me.txtBinaNo)
        Me.Controls.Add(Me.txtKat)
        Me.Controls.Add(Me.txtIl)
        Me.Controls.Add(Me.txtIlce)
        Me.Controls.Add(Me.txtDaireNo)
        Me.Controls.Add(Me.txtPostaKodu)
        Me.Controls.Add(Me.txtCadde)
        Me.Controls.Add(Me.lblIl)
        Me.Controls.Add(Me.lblIlce)
        Me.Controls.Add(Me.lblPostaKodu)
        Me.Controls.Add(Me.lblDaireNo)
        Me.Controls.Add(Me.lblKat)
        Me.Controls.Add(Me.lblBinaNo)
        Me.Controls.Add(Me.lblMahalle)
        Me.Controls.Add(Me.lblSokak)
        Me.Controls.Add(Me.lblCadde)
        Me.Controls.Add(Me.lblYeniAdres)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdresEkle"
        Me.Text = "Adres Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblYeniAdres As Label
    Friend WithEvents lblCadde As Label
    Friend WithEvents lblSokak As Label
    Friend WithEvents lblMahalle As Label
    Friend WithEvents lblBinaNo As Label
    Friend WithEvents lblKat As Label
    Friend WithEvents lblDaireNo As Label
    Friend WithEvents lblPostaKodu As Label
    Friend WithEvents lblIlce As Label
    Friend WithEvents lblIl As Label
    Friend WithEvents txtCadde As TextBox
    Friend WithEvents txtPostaKodu As TextBox
    Friend WithEvents txtDaireNo As TextBox
    Friend WithEvents txtIlce As TextBox
    Friend WithEvents txtIl As TextBox
    Friend WithEvents txtKat As TextBox
    Friend WithEvents txtBinaNo As TextBox
    Friend WithEvents txtMahalle As TextBox
    Friend WithEvents txtSokak As TextBox
    Friend WithEvents btnIptal As Button
    Friend WithEvents btnKaydet As Button
End Class
