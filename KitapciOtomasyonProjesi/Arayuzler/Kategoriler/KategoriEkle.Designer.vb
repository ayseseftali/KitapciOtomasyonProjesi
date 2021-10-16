<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KategoriEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KategoriEkle))
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnKaydet = New System.Windows.Forms.Button()
        Me.lblYeniKayitEklemeIşlemleri = New System.Windows.Forms.Label()
        Me.lblKategoriAdi = New System.Windows.Forms.Label()
        Me.txtKategoriAdi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(61, 166)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(197, 44)
        Me.btnIptal.TabIndex = 0
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnKaydet
        '
        Me.btnKaydet.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKaydet.ForeColor = System.Drawing.Color.Black
        Me.btnKaydet.Location = New System.Drawing.Point(297, 166)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(194, 44)
        Me.btnKaydet.TabIndex = 1
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseVisualStyleBackColor = False
        '
        'lblYeniKayitEklemeIşlemleri
        '
        Me.lblYeniKayitEklemeIşlemleri.AutoSize = True
        Me.lblYeniKayitEklemeIşlemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYeniKayitEklemeIşlemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYeniKayitEklemeIşlemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYeniKayitEklemeIşlemleri.ForeColor = System.Drawing.Color.Black
        Me.lblYeniKayitEklemeIşlemleri.Location = New System.Drawing.Point(32, 38)
        Me.lblYeniKayitEklemeIşlemleri.Name = "lblYeniKayitEklemeIşlemleri"
        Me.lblYeniKayitEklemeIşlemleri.Size = New System.Drawing.Size(483, 41)
        Me.lblYeniKayitEklemeIşlemleri.TabIndex = 2
        Me.lblYeniKayitEklemeIşlemleri.Text = "Yeni Kategori Ekleme İşlemleri"
        '
        'lblKategoriAdi
        '
        Me.lblKategoriAdi.AutoSize = True
        Me.lblKategoriAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKategoriAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKategoriAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKategoriAdi.ForeColor = System.Drawing.Color.Black
        Me.lblKategoriAdi.Location = New System.Drawing.Point(50, 107)
        Me.lblKategoriAdi.Name = "lblKategoriAdi"
        Me.lblKategoriAdi.Size = New System.Drawing.Size(163, 33)
        Me.lblKategoriAdi.TabIndex = 3
        Me.lblKategoriAdi.Text = "Kategori Adı"
        '
        'txtKategoriAdi
        '
        Me.txtKategoriAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKategoriAdi.Location = New System.Drawing.Point(239, 106)
        Me.txtKategoriAdi.Name = "txtKategoriAdi"
        Me.txtKategoriAdi.Size = New System.Drawing.Size(261, 36)
        Me.txtKategoriAdi.TabIndex = 4
        '
        'KategoriEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(573, 235)
        Me.Controls.Add(Me.txtKategoriAdi)
        Me.Controls.Add(Me.lblKategoriAdi)
        Me.Controls.Add(Me.lblYeniKayitEklemeIşlemleri)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnIptal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KategoriEkle"
        Me.Text = "Kategori Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIptal As Button
    Friend WithEvents btnKaydet As Button
    Friend WithEvents lblYeniKayitEklemeIşlemleri As Label
    Friend WithEvents lblKategoriAdi As Label
    Friend WithEvents txtKategoriAdi As TextBox
End Class
