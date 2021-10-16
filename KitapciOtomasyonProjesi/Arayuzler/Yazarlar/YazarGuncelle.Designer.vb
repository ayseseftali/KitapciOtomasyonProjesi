<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YazarGuncelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YazarGuncelle))
        Me.txtYazarSoyadi = New System.Windows.Forms.TextBox()
        Me.lblYazarSoyadi = New System.Windows.Forms.Label()
        Me.lblYazarGüncellemeİslemleri = New System.Windows.Forms.Label()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnYazarGüncelle = New System.Windows.Forms.Button()
        Me.txtYazarAdi = New System.Windows.Forms.TextBox()
        Me.lblYazarAdi = New System.Windows.Forms.Label()
        Me.lstYazarlar = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtYazarSoyadi
        '
        Me.txtYazarSoyadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYazarSoyadi.ForeColor = System.Drawing.Color.Black
        Me.txtYazarSoyadi.Location = New System.Drawing.Point(601, 193)
        Me.txtYazarSoyadi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYazarSoyadi.Name = "txtYazarSoyadi"
        Me.txtYazarSoyadi.Size = New System.Drawing.Size(273, 36)
        Me.txtYazarSoyadi.TabIndex = 115
        '
        'lblYazarSoyadi
        '
        Me.lblYazarSoyadi.AutoSize = True
        Me.lblYazarSoyadi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYazarSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYazarSoyadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYazarSoyadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYazarSoyadi.ForeColor = System.Drawing.Color.Black
        Me.lblYazarSoyadi.Location = New System.Drawing.Point(394, 196)
        Me.lblYazarSoyadi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYazarSoyadi.Name = "lblYazarSoyadi"
        Me.lblYazarSoyadi.Size = New System.Drawing.Size(165, 31)
        Me.lblYazarSoyadi.TabIndex = 114
        Me.lblYazarSoyadi.Text = "Yazar Soyadı"
        '
        'lblYazarGüncellemeİslemleri
        '
        Me.lblYazarGüncellemeİslemleri.AutoSize = True
        Me.lblYazarGüncellemeİslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYazarGüncellemeİslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYazarGüncellemeİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYazarGüncellemeİslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYazarGüncellemeİslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblYazarGüncellemeİslemleri.Location = New System.Drawing.Point(261, 30)
        Me.lblYazarGüncellemeİslemleri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYazarGüncellemeİslemleri.Name = "lblYazarGüncellemeİslemleri"
        Me.lblYazarGüncellemeİslemleri.Size = New System.Drawing.Size(435, 41)
        Me.lblYazarGüncellemeİslemleri.TabIndex = 113
        Me.lblYazarGüncellemeİslemleri.Text = "Yazar Güncelleme İşlemleri"
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(394, 269)
        Me.btnIptal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(223, 43)
        Me.btnIptal.TabIndex = 111
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnYazarGüncelle
        '
        Me.btnYazarGüncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYazarGüncelle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYazarGüncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnYazarGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYazarGüncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYazarGüncelle.ForeColor = System.Drawing.Color.Black
        Me.btnYazarGüncelle.Location = New System.Drawing.Point(651, 269)
        Me.btnYazarGüncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYazarGüncelle.Name = "btnYazarGüncelle"
        Me.btnYazarGüncelle.Size = New System.Drawing.Size(223, 43)
        Me.btnYazarGüncelle.TabIndex = 110
        Me.btnYazarGüncelle.Text = "Güncelle"
        Me.btnYazarGüncelle.UseVisualStyleBackColor = False
        '
        'txtYazarAdi
        '
        Me.txtYazarAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYazarAdi.ForeColor = System.Drawing.Color.Black
        Me.txtYazarAdi.Location = New System.Drawing.Point(601, 133)
        Me.txtYazarAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYazarAdi.Name = "txtYazarAdi"
        Me.txtYazarAdi.Size = New System.Drawing.Size(273, 36)
        Me.txtYazarAdi.TabIndex = 109
        '
        'lblYazarAdi
        '
        Me.lblYazarAdi.AutoSize = True
        Me.lblYazarAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYazarAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYazarAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYazarAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYazarAdi.ForeColor = System.Drawing.Color.Black
        Me.lblYazarAdi.Location = New System.Drawing.Point(394, 136)
        Me.lblYazarAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYazarAdi.Name = "lblYazarAdi"
        Me.lblYazarAdi.Size = New System.Drawing.Size(124, 31)
        Me.lblYazarAdi.TabIndex = 108
        Me.lblYazarAdi.Text = "Yazar Adı"
        '
        'lstYazarlar
        '
        Me.lstYazarlar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstYazarlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstYazarlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstYazarlar.FormattingEnabled = True
        Me.lstYazarlar.ItemHeight = 29
        Me.lstYazarlar.Location = New System.Drawing.Point(26, 103)
        Me.lstYazarlar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstYazarlar.Name = "lstYazarlar"
        Me.lstYazarlar.Size = New System.Drawing.Size(337, 234)
        Me.lstYazarlar.TabIndex = 107
        '
        'YazarGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(905, 351)
        Me.Controls.Add(Me.txtYazarSoyadi)
        Me.Controls.Add(Me.lblYazarSoyadi)
        Me.Controls.Add(Me.lblYazarGüncellemeİslemleri)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnYazarGüncelle)
        Me.Controls.Add(Me.txtYazarAdi)
        Me.Controls.Add(Me.lblYazarAdi)
        Me.Controls.Add(Me.lstYazarlar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "YazarGuncelle"
        Me.Text = "Yazar Güncelleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtYazarSoyadi As TextBox
    Private WithEvents lblYazarSoyadi As Label
    Private WithEvents lblYazarGüncellemeİslemleri As Label
    Private WithEvents btnIptal As Button
    Private WithEvents btnYazarGüncelle As Button
    Private WithEvents txtYazarAdi As TextBox
    Private WithEvents lblYazarAdi As Label
    Private WithEvents lstYazarlar As ListBox
End Class
