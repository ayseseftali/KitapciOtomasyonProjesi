<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitapEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KitapEkle))
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.lblKitapEklemeIşlemleri = New System.Windows.Forms.Label()
        Me.lblKitapAdi = New System.Windows.Forms.Label()
        Me.lblYayinTarihi = New System.Windows.Forms.Label()
        Me.lblSayfaSayisi = New System.Windows.Forms.Label()
        Me.lblSatişFiyati = New System.Windows.Forms.Label()
        Me.txtKitapAdi = New System.Windows.Forms.TextBox()
        Me.txtYayinTarihi = New System.Windows.Forms.TextBox()
        Me.txtSatisFiyati = New System.Windows.Forms.TextBox()
        Me.txtSayfaSayisi = New System.Windows.Forms.TextBox()
        Me.lblYayinEviID = New System.Windows.Forms.Label()
        Me.cbYayinEviID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(39, 327)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(203, 42)
        Me.btnIptal.TabIndex = 0
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.ForeColor = System.Drawing.Color.Black
        Me.btnKaydet.Location = New System.Drawing.Point(259, 327)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(203, 42)
        Me.btnKaydet.TabIndex = 1
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'lblKitapEklemeIşlemleri
        '
        Me.lblKitapEklemeIşlemleri.AutoSize = True
        Me.lblKitapEklemeIşlemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKitapEklemeIşlemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKitapEklemeIşlemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblKitapEklemeIşlemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKitapEklemeIşlemleri.ForeColor = System.Drawing.Color.Black
        Me.lblKitapEklemeIşlemleri.Location = New System.Drawing.Point(82, 26)
        Me.lblKitapEklemeIşlemleri.Name = "lblKitapEklemeIşlemleri"
        Me.lblKitapEklemeIşlemleri.Size = New System.Drawing.Size(357, 41)
        Me.lblKitapEklemeIşlemleri.TabIndex = 2
        Me.lblKitapEklemeIşlemleri.Text = "Kitap Ekleme İşlemleri"
        '
        'lblKitapAdi
        '
        Me.lblKitapAdi.AutoSize = True
        Me.lblKitapAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKitapAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblKitapAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKitapAdi.ForeColor = System.Drawing.Color.Black
        Me.lblKitapAdi.Location = New System.Drawing.Point(23, 97)
        Me.lblKitapAdi.Name = "lblKitapAdi"
        Me.lblKitapAdi.Size = New System.Drawing.Size(117, 31)
        Me.lblKitapAdi.TabIndex = 3
        Me.lblKitapAdi.Text = "Kitap Adı"
        '
        'lblYayinTarihi
        '
        Me.lblYayinTarihi.AutoSize = True
        Me.lblYayinTarihi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYayinTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinTarihi.ForeColor = System.Drawing.Color.Black
        Me.lblYayinTarihi.Location = New System.Drawing.Point(23, 139)
        Me.lblYayinTarihi.Name = "lblYayinTarihi"
        Me.lblYayinTarihi.Size = New System.Drawing.Size(148, 31)
        Me.lblYayinTarihi.TabIndex = 4
        Me.lblYayinTarihi.Text = "Yayın Tarihi"
        '
        'lblSayfaSayisi
        '
        Me.lblSayfaSayisi.AutoSize = True
        Me.lblSayfaSayisi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSayfaSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSayfaSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSayfaSayisi.ForeColor = System.Drawing.Color.Black
        Me.lblSayfaSayisi.Location = New System.Drawing.Point(23, 181)
        Me.lblSayfaSayisi.Name = "lblSayfaSayisi"
        Me.lblSayfaSayisi.Size = New System.Drawing.Size(156, 31)
        Me.lblSayfaSayisi.TabIndex = 5
        Me.lblSayfaSayisi.Text = "Sayfa Sayısı"
        '
        'lblSatişFiyati
        '
        Me.lblSatişFiyati.AutoSize = True
        Me.lblSatişFiyati.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSatişFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSatişFiyati.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSatişFiyati.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSatişFiyati.ForeColor = System.Drawing.Color.Black
        Me.lblSatişFiyati.Location = New System.Drawing.Point(23, 266)
        Me.lblSatişFiyati.Name = "lblSatişFiyati"
        Me.lblSatişFiyati.Size = New System.Drawing.Size(140, 31)
        Me.lblSatişFiyati.TabIndex = 6
        Me.lblSatişFiyati.Text = "Satış Fiyatı"
        '
        'txtKitapAdi
        '
        Me.txtKitapAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKitapAdi.Location = New System.Drawing.Point(204, 94)
        Me.txtKitapAdi.Name = "txtKitapAdi"
        Me.txtKitapAdi.Size = New System.Drawing.Size(289, 36)
        Me.txtKitapAdi.TabIndex = 7
        '
        'txtYayinTarihi
        '
        Me.txtYayinTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinTarihi.Location = New System.Drawing.Point(204, 136)
        Me.txtYayinTarihi.Name = "txtYayinTarihi"
        Me.txtYayinTarihi.Size = New System.Drawing.Size(289, 36)
        Me.txtYayinTarihi.TabIndex = 8
        '
        'txtSatisFiyati
        '
        Me.txtSatisFiyati.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSatisFiyati.Location = New System.Drawing.Point(204, 263)
        Me.txtSatisFiyati.Name = "txtSatisFiyati"
        Me.txtSatisFiyati.Size = New System.Drawing.Size(289, 36)
        Me.txtSatisFiyati.TabIndex = 10
        '
        'txtSayfaSayisi
        '
        Me.txtSayfaSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSayfaSayisi.Location = New System.Drawing.Point(204, 178)
        Me.txtSayfaSayisi.Name = "txtSayfaSayisi"
        Me.txtSayfaSayisi.Size = New System.Drawing.Size(289, 36)
        Me.txtSayfaSayisi.TabIndex = 11
        '
        'lblYayinEviID
        '
        Me.lblYayinEviID.AutoSize = True
        Me.lblYayinEviID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYayinEviID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviID.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviID.Location = New System.Drawing.Point(23, 223)
        Me.lblYayinEviID.Name = "lblYayinEviID"
        Me.lblYayinEviID.Size = New System.Drawing.Size(152, 31)
        Me.lblYayinEviID.TabIndex = 12
        Me.lblYayinEviID.Text = "Yayın Evi ID"
        '
        'cbYayinEviID
        '
        Me.cbYayinEviID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbYayinEviID.FormattingEnabled = True
        Me.cbYayinEviID.Location = New System.Drawing.Point(204, 220)
        Me.cbYayinEviID.Name = "cbYayinEviID"
        Me.cbYayinEviID.Size = New System.Drawing.Size(289, 37)
        Me.cbYayinEviID.TabIndex = 13
        '
        'KitapEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(517, 396)
        Me.Controls.Add(Me.cbYayinEviID)
        Me.Controls.Add(Me.lblYayinEviID)
        Me.Controls.Add(Me.txtSayfaSayisi)
        Me.Controls.Add(Me.txtSatisFiyati)
        Me.Controls.Add(Me.txtYayinTarihi)
        Me.Controls.Add(Me.txtKitapAdi)
        Me.Controls.Add(Me.lblSatişFiyati)
        Me.Controls.Add(Me.lblSayfaSayisi)
        Me.Controls.Add(Me.lblYayinTarihi)
        Me.Controls.Add(Me.lblKitapAdi)
        Me.Controls.Add(Me.lblKitapEklemeIşlemleri)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnIptal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KitapEkle"
        Me.Text = "Kitap Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIptal As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents lblKitapEklemeIşlemleri As Label
    Friend WithEvents lblKitapAdi As Label
    Friend WithEvents lblYayinTarihi As Label
    Friend WithEvents lblSayfaSayisi As Label
    Friend WithEvents lblSatişFiyati As Label
    Friend WithEvents txtKitapAdi As TextBox
    Friend WithEvents txtYayinTarihi As TextBox
    Friend WithEvents txtSatisFiyati As TextBox
    Friend WithEvents txtSayfaSayisi As TextBox
    Friend WithEvents lblYayinEviID As Label
    Friend WithEvents cbYayinEviID As ComboBox
End Class
