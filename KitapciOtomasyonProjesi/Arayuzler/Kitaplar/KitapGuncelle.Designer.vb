<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitapGuncelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KitapGuncelle))
        Me.btnGuncelle = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.cbYayinEviID = New System.Windows.Forms.ComboBox()
        Me.lblKitapGuncellemeIslemleri = New System.Windows.Forms.Label()
        Me.lblKitapAdi = New System.Windows.Forms.Label()
        Me.lblYayinTarihi = New System.Windows.Forms.Label()
        Me.lblSayfaSayisi = New System.Windows.Forms.Label()
        Me.lblYayinEviID = New System.Windows.Forms.Label()
        Me.txtSayfaSayisi = New System.Windows.Forms.TextBox()
        Me.txtSatisFiyati = New System.Windows.Forms.TextBox()
        Me.txtYayinTarihi = New System.Windows.Forms.TextBox()
        Me.txtKitapAdi = New System.Windows.Forms.TextBox()
        Me.lstKitaplar = New System.Windows.Forms.ListBox()
        Me.lblSatisFiyati = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuncelle
        '
        Me.btnGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnGuncelle.Location = New System.Drawing.Point(675, 331)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(197, 39)
        Me.btnGuncelle.TabIndex = 0
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseVisualStyleBackColor = False
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(429, 331)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(197, 39)
        Me.btnIptal.TabIndex = 1
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'cbYayinEviID
        '
        Me.cbYayinEviID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbYayinEviID.FormattingEnabled = True
        Me.cbYayinEviID.Location = New System.Drawing.Point(595, 231)
        Me.cbYayinEviID.Name = "cbYayinEviID"
        Me.cbYayinEviID.Size = New System.Drawing.Size(277, 37)
        Me.cbYayinEviID.TabIndex = 2
        '
        'lblKitapGuncellemeIslemleri
        '
        Me.lblKitapGuncellemeIslemleri.AutoSize = True
        Me.lblKitapGuncellemeIslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKitapGuncellemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKitapGuncellemeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblKitapGuncellemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKitapGuncellemeIslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblKitapGuncellemeIslemleri.Location = New System.Drawing.Point(243, 26)
        Me.lblKitapGuncellemeIslemleri.Name = "lblKitapGuncellemeIslemleri"
        Me.lblKitapGuncellemeIslemleri.Size = New System.Drawing.Size(425, 41)
        Me.lblKitapGuncellemeIslemleri.TabIndex = 3
        Me.lblKitapGuncellemeIslemleri.Text = "Kitap Güncelleme İşlemleri"
        '
        'lblKitapAdi
        '
        Me.lblKitapAdi.AutoSize = True
        Me.lblKitapAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKitapAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKitapAdi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblKitapAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKitapAdi.ForeColor = System.Drawing.Color.Black
        Me.lblKitapAdi.Location = New System.Drawing.Point(429, 108)
        Me.lblKitapAdi.Name = "lblKitapAdi"
        Me.lblKitapAdi.Size = New System.Drawing.Size(117, 31)
        Me.lblKitapAdi.TabIndex = 4
        Me.lblKitapAdi.Text = "Kitap Adı"
        '
        'lblYayinTarihi
        '
        Me.lblYayinTarihi.AutoSize = True
        Me.lblYayinTarihi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblYayinTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinTarihi.ForeColor = System.Drawing.Color.Black
        Me.lblYayinTarihi.Location = New System.Drawing.Point(429, 150)
        Me.lblYayinTarihi.Name = "lblYayinTarihi"
        Me.lblYayinTarihi.Size = New System.Drawing.Size(148, 31)
        Me.lblYayinTarihi.TabIndex = 5
        Me.lblYayinTarihi.Text = "Yayın Tarihi"
        '
        'lblSayfaSayisi
        '
        Me.lblSayfaSayisi.AutoSize = True
        Me.lblSayfaSayisi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSayfaSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSayfaSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSayfaSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSayfaSayisi.ForeColor = System.Drawing.Color.Black
        Me.lblSayfaSayisi.Location = New System.Drawing.Point(429, 192)
        Me.lblSayfaSayisi.Name = "lblSayfaSayisi"
        Me.lblSayfaSayisi.Size = New System.Drawing.Size(156, 31)
        Me.lblSayfaSayisi.TabIndex = 6
        Me.lblSayfaSayisi.Text = "Sayfa Sayısı"
        '
        'lblYayinEviID
        '
        Me.lblYayinEviID.AutoSize = True
        Me.lblYayinEviID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblYayinEviID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviID.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviID.Location = New System.Drawing.Point(429, 234)
        Me.lblYayinEviID.Name = "lblYayinEviID"
        Me.lblYayinEviID.Size = New System.Drawing.Size(145, 31)
        Me.lblYayinEviID.TabIndex = 7
        Me.lblYayinEviID.Text = "YayınEvi ID"
        '
        'txtSayfaSayisi
        '
        Me.txtSayfaSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSayfaSayisi.Location = New System.Drawing.Point(595, 189)
        Me.txtSayfaSayisi.Name = "txtSayfaSayisi"
        Me.txtSayfaSayisi.Size = New System.Drawing.Size(277, 36)
        Me.txtSayfaSayisi.TabIndex = 9
        '
        'txtSatisFiyati
        '
        Me.txtSatisFiyati.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSatisFiyati.Location = New System.Drawing.Point(595, 274)
        Me.txtSatisFiyati.Name = "txtSatisFiyati"
        Me.txtSatisFiyati.Size = New System.Drawing.Size(277, 36)
        Me.txtSatisFiyati.TabIndex = 11
        '
        'txtYayinTarihi
        '
        Me.txtYayinTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinTarihi.Location = New System.Drawing.Point(595, 147)
        Me.txtYayinTarihi.Name = "txtYayinTarihi"
        Me.txtYayinTarihi.Size = New System.Drawing.Size(277, 36)
        Me.txtYayinTarihi.TabIndex = 15
        '
        'txtKitapAdi
        '
        Me.txtKitapAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKitapAdi.Location = New System.Drawing.Point(595, 105)
        Me.txtKitapAdi.Name = "txtKitapAdi"
        Me.txtKitapAdi.Size = New System.Drawing.Size(277, 36)
        Me.txtKitapAdi.TabIndex = 16
        '
        'lstKitaplar
        '
        Me.lstKitaplar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstKitaplar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstKitaplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstKitaplar.ForeColor = System.Drawing.Color.Black
        Me.lstKitaplar.FormattingEnabled = True
        Me.lstKitaplar.ItemHeight = 26
        Me.lstKitaplar.Location = New System.Drawing.Point(29, 103)
        Me.lstKitaplar.Name = "lstKitaplar"
        Me.lstKitaplar.Size = New System.Drawing.Size(373, 288)
        Me.lstKitaplar.TabIndex = 17
        '
        'lblSatisFiyati
        '
        Me.lblSatisFiyati.AutoSize = True
        Me.lblSatisFiyati.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSatisFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSatisFiyati.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSatisFiyati.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSatisFiyati.ForeColor = System.Drawing.Color.Black
        Me.lblSatisFiyati.Location = New System.Drawing.Point(429, 277)
        Me.lblSatisFiyati.Name = "lblSatisFiyati"
        Me.lblSatisFiyati.Size = New System.Drawing.Size(140, 31)
        Me.lblSatisFiyati.TabIndex = 18
        Me.lblSatisFiyati.Text = "Satış Fiyatı"
        '
        'KitapGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(906, 417)
        Me.Controls.Add(Me.lblSatisFiyati)
        Me.Controls.Add(Me.lstKitaplar)
        Me.Controls.Add(Me.txtKitapAdi)
        Me.Controls.Add(Me.txtYayinTarihi)
        Me.Controls.Add(Me.txtSatisFiyati)
        Me.Controls.Add(Me.txtSayfaSayisi)
        Me.Controls.Add(Me.lblYayinEviID)
        Me.Controls.Add(Me.lblSayfaSayisi)
        Me.Controls.Add(Me.lblYayinTarihi)
        Me.Controls.Add(Me.lblKitapAdi)
        Me.Controls.Add(Me.lblKitapGuncellemeIslemleri)
        Me.Controls.Add(Me.cbYayinEviID)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KitapGuncelle"
        Me.Text = "Kitap Güncelleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuncelle As Button
    Friend WithEvents btnIptal As Button
    Friend WithEvents cbYayinEviID As ComboBox
    Friend WithEvents lblKitapGuncellemeIslemleri As Label
    Friend WithEvents lblKitapAdi As Label
    Friend WithEvents lblYayinTarihi As Label
    Friend WithEvents lblSayfaSayisi As Label
    Friend WithEvents lblYayinEviID As Label
    Friend WithEvents txtSayfaSayisi As TextBox
    Friend WithEvents txtSatisFiyati As TextBox
    Friend WithEvents txtYayinTarihi As TextBox
    Friend WithEvents txtKitapAdi As TextBox
    Friend WithEvents lstKitaplar As ListBox
    Friend WithEvents lblSatisFiyati As Label
End Class
