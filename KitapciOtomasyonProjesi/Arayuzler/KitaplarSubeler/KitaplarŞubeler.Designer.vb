<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitaplarŞubeler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KitaplarŞubeler))
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.lblSubeyeKitapEklemeIslemleri = New System.Windows.Forms.Label()
        Me.lblSubeSec = New System.Windows.Forms.Label()
        Me.lblAdetSayisi = New System.Windows.Forms.Label()
        Me.cbSubeSec = New System.Windows.Forms.ComboBox()
        Me.txtAdetSayisi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEkle.ForeColor = System.Drawing.Color.Black
        Me.btnEkle.Location = New System.Drawing.Point(269, 220)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(190, 47)
        Me.btnEkle.TabIndex = 0
        Me.btnEkle.Text = "Ekle"
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(54, 220)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(190, 47)
        Me.btnIptal.TabIndex = 1
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'lblSubeyeKitapEklemeIslemleri
        '
        Me.lblSubeyeKitapEklemeIslemleri.AutoSize = True
        Me.lblSubeyeKitapEklemeIslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeyeKitapEklemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeyeKitapEklemeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeyeKitapEklemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeyeKitapEklemeIslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblSubeyeKitapEklemeIslemleri.Location = New System.Drawing.Point(28, 25)
        Me.lblSubeyeKitapEklemeIslemleri.Name = "lblSubeyeKitapEklemeIslemleri"
        Me.lblSubeyeKitapEklemeIslemleri.Size = New System.Drawing.Size(482, 41)
        Me.lblSubeyeKitapEklemeIslemleri.TabIndex = 2
        Me.lblSubeyeKitapEklemeIslemleri.Text = "Şubeye Kitap Ekleme İşlemleri"
        '
        'lblSubeSec
        '
        Me.lblSubeSec.AutoSize = True
        Me.lblSubeSec.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblSubeSec.ForeColor = System.Drawing.Color.Black
        Me.lblSubeSec.Location = New System.Drawing.Point(28, 101)
        Me.lblSubeSec.Name = "lblSubeSec"
        Me.lblSubeSec.Size = New System.Drawing.Size(125, 31)
        Me.lblSubeSec.TabIndex = 3
        Me.lblSubeSec.Text = "Şube Seç"
        '
        'lblAdetSayisi
        '
        Me.lblAdetSayisi.AutoSize = True
        Me.lblAdetSayisi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAdetSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdetSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAdetSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblAdetSayisi.ForeColor = System.Drawing.Color.Black
        Me.lblAdetSayisi.Location = New System.Drawing.Point(28, 151)
        Me.lblAdetSayisi.Name = "lblAdetSayisi"
        Me.lblAdetSayisi.Size = New System.Drawing.Size(143, 31)
        Me.lblAdetSayisi.TabIndex = 4
        Me.lblAdetSayisi.Text = "Adet Sayısı"
        '
        'cbSubeSec
        '
        Me.cbSubeSec.BackColor = System.Drawing.SystemColors.Window
        Me.cbSubeSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cbSubeSec.FormattingEnabled = True
        Me.cbSubeSec.Location = New System.Drawing.Point(250, 98)
        Me.cbSubeSec.Name = "cbSubeSec"
        Me.cbSubeSec.Size = New System.Drawing.Size(260, 37)
        Me.cbSubeSec.TabIndex = 5
        '
        'txtAdetSayisi
        '
        Me.txtAdetSayisi.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdetSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtAdetSayisi.Location = New System.Drawing.Point(250, 151)
        Me.txtAdetSayisi.Name = "txtAdetSayisi"
        Me.txtAdetSayisi.Size = New System.Drawing.Size(260, 36)
        Me.txtAdetSayisi.TabIndex = 6
        '
        'KitaplarŞubeler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(537, 295)
        Me.Controls.Add(Me.txtAdetSayisi)
        Me.Controls.Add(Me.cbSubeSec)
        Me.Controls.Add(Me.lblAdetSayisi)
        Me.Controls.Add(Me.lblSubeSec)
        Me.Controls.Add(Me.lblSubeyeKitapEklemeIslemleri)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnEkle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KitaplarŞubeler"
        Me.Text = "Şubeye Kitap Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEkle As Button
    Friend WithEvents btnIptal As Button
    Friend WithEvents lblSubeyeKitapEklemeIslemleri As Label
    Friend WithEvents lblSubeSec As Label
    Friend WithEvents lblAdetSayisi As Label
    Friend WithEvents cbSubeSec As ComboBox
    Friend WithEvents txtAdetSayisi As TextBox
End Class
