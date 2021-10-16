<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YayinEviGuncelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YayinEviGuncelle))
        Me.lstYayinEvleri = New System.Windows.Forms.ListBox()
        Me.cbAdresID = New System.Windows.Forms.ComboBox()
        Me.lblAdresID = New System.Windows.Forms.Label()
        Me.lblYayinEviGuncellemeİslemleri = New System.Windows.Forms.Label()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnYayinEviGuncelle = New System.Windows.Forms.Button()
        Me.txtYayinEviAdi = New System.Windows.Forms.TextBox()
        Me.lblYayinEviAdi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstYayinEvleri
        '
        Me.lstYayinEvleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lstYayinEvleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstYayinEvleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstYayinEvleri.FormattingEnabled = True
        Me.lstYayinEvleri.ItemHeight = 29
        Me.lstYayinEvleri.Location = New System.Drawing.Point(24, 98)
        Me.lstYayinEvleri.Margin = New System.Windows.Forms.Padding(4)
        Me.lstYayinEvleri.Name = "lstYayinEvleri"
        Me.lstYayinEvleri.Size = New System.Drawing.Size(302, 263)
        Me.lstYayinEvleri.TabIndex = 106
        '
        'cbAdresID
        '
        Me.cbAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbAdresID.ForeColor = System.Drawing.Color.Black
        Me.cbAdresID.FormattingEnabled = True
        Me.cbAdresID.Location = New System.Drawing.Point(562, 188)
        Me.cbAdresID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAdresID.Name = "cbAdresID"
        Me.cbAdresID.Size = New System.Drawing.Size(321, 37)
        Me.cbAdresID.TabIndex = 105
        '
        'lblAdresID
        '
        Me.lblAdresID.AutoSize = True
        Me.lblAdresID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAdresID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdresID.ForeColor = System.Drawing.Color.Black
        Me.lblAdresID.Location = New System.Drawing.Point(353, 191)
        Me.lblAdresID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresID.Name = "lblAdresID"
        Me.lblAdresID.Size = New System.Drawing.Size(105, 31)
        Me.lblAdresID.TabIndex = 104
        Me.lblAdresID.Text = "AdresID"
        '
        'lblYayinEviGuncellemeİslemleri
        '
        Me.lblYayinEviGuncellemeİslemleri.AutoSize = True
        Me.lblYayinEviGuncellemeİslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviGuncellemeİslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviGuncellemeİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYayinEviGuncellemeİslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviGuncellemeİslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviGuncellemeİslemleri.Location = New System.Drawing.Point(215, 29)
        Me.lblYayinEviGuncellemeİslemleri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviGuncellemeİslemleri.Name = "lblYayinEviGuncellemeİslemleri"
        Me.lblYayinEviGuncellemeİslemleri.Size = New System.Drawing.Size(489, 41)
        Me.lblYayinEviGuncellemeİslemleri.TabIndex = 103
        Me.lblYayinEviGuncellemeİslemleri.Text = "Yayın Evi Güncelleme İşlemleri"
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(366, 270)
        Me.btnIptal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(223, 43)
        Me.btnIptal.TabIndex = 101
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnYayinEviGuncelle
        '
        Me.btnYayinEviGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYayinEviGuncelle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYayinEviGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnYayinEviGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYayinEviGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYayinEviGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnYayinEviGuncelle.Location = New System.Drawing.Point(646, 270)
        Me.btnYayinEviGuncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYayinEviGuncelle.Name = "btnYayinEviGuncelle"
        Me.btnYayinEviGuncelle.Size = New System.Drawing.Size(223, 43)
        Me.btnYayinEviGuncelle.TabIndex = 100
        Me.btnYayinEviGuncelle.Text = "Güncelle"
        Me.btnYayinEviGuncelle.UseVisualStyleBackColor = False
        '
        'txtYayinEviAdi
        '
        Me.txtYayinEviAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviAdi.ForeColor = System.Drawing.Color.Black
        Me.txtYayinEviAdi.Location = New System.Drawing.Point(562, 118)
        Me.txtYayinEviAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviAdi.Name = "txtYayinEviAdi"
        Me.txtYayinEviAdi.Size = New System.Drawing.Size(321, 36)
        Me.txtYayinEviAdi.TabIndex = 99
        '
        'lblYayinEviAdi
        '
        Me.lblYayinEviAdi.AutoSize = True
        Me.lblYayinEviAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYayinEviAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviAdi.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviAdi.Location = New System.Drawing.Point(353, 121)
        Me.lblYayinEviAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviAdi.Name = "lblYayinEviAdi"
        Me.lblYayinEviAdi.Size = New System.Drawing.Size(165, 31)
        Me.lblYayinEviAdi.TabIndex = 98
        Me.lblYayinEviAdi.Text = "Yayın Evi Adı"
        '
        'YayinEviGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(910, 387)
        Me.Controls.Add(Me.lstYayinEvleri)
        Me.Controls.Add(Me.cbAdresID)
        Me.Controls.Add(Me.lblAdresID)
        Me.Controls.Add(Me.lblYayinEviGuncellemeİslemleri)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnYayinEviGuncelle)
        Me.Controls.Add(Me.txtYayinEviAdi)
        Me.Controls.Add(Me.lblYayinEviAdi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "YayinEviGuncelle"
        Me.Text = "Yayın Evi Güncelleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lstYayinEvleri As ListBox
    Private WithEvents cbAdresID As ComboBox
    Private WithEvents lblAdresID As Label
    Private WithEvents lblYayinEviGuncellemeİslemleri As Label
    Private WithEvents btnIptal As Button
    Private WithEvents btnYayinEviGuncelle As Button
    Private WithEvents txtYayinEviAdi As TextBox
    Private WithEvents lblYayinEviAdi As Label
End Class
