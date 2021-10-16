<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubeGuncelle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubeGuncelle))
        Me.lstSubeler = New System.Windows.Forms.ListBox()
        Me.cbAdresID = New System.Windows.Forms.ComboBox()
        Me.lblAdresID = New System.Windows.Forms.Label()
        Me.lblSubeGuncellemeIslemleri = New System.Windows.Forms.Label()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnSubeGuncelle = New System.Windows.Forms.Button()
        Me.txtSubeAdi = New System.Windows.Forms.TextBox()
        Me.lblSubeAdi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstSubeler
        '
        Me.lstSubeler.BackColor = System.Drawing.Color.Gainsboro
        Me.lstSubeler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSubeler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstSubeler.FormattingEnabled = True
        Me.lstSubeler.ItemHeight = 29
        Me.lstSubeler.Location = New System.Drawing.Point(22, 96)
        Me.lstSubeler.Margin = New System.Windows.Forms.Padding(4)
        Me.lstSubeler.Name = "lstSubeler"
        Me.lstSubeler.Size = New System.Drawing.Size(275, 263)
        Me.lstSubeler.TabIndex = 98
        '
        'cbAdresID
        '
        Me.cbAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbAdresID.ForeColor = System.Drawing.Color.Black
        Me.cbAdresID.FormattingEnabled = True
        Me.cbAdresID.Location = New System.Drawing.Point(484, 194)
        Me.cbAdresID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAdresID.Name = "cbAdresID"
        Me.cbAdresID.Size = New System.Drawing.Size(321, 37)
        Me.cbAdresID.TabIndex = 97
        '
        'lblAdresID
        '
        Me.lblAdresID.AutoSize = True
        Me.lblAdresID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAdresID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdresID.ForeColor = System.Drawing.Color.Black
        Me.lblAdresID.Location = New System.Drawing.Point(337, 197)
        Me.lblAdresID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresID.Name = "lblAdresID"
        Me.lblAdresID.Size = New System.Drawing.Size(105, 31)
        Me.lblAdresID.TabIndex = 96
        Me.lblAdresID.Text = "AdresID"
        '
        'lblSubeGuncellemeIslemleri
        '
        Me.lblSubeGuncellemeIslemleri.AutoSize = True
        Me.lblSubeGuncellemeIslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeGuncellemeIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeGuncellemeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeGuncellemeIslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeGuncellemeIslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblSubeGuncellemeIslemleri.Location = New System.Drawing.Point(181, 28)
        Me.lblSubeGuncellemeIslemleri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeGuncellemeIslemleri.Name = "lblSubeGuncellemeIslemleri"
        Me.lblSubeGuncellemeIslemleri.Size = New System.Drawing.Size(427, 41)
        Me.lblSubeGuncellemeIslemleri.TabIndex = 95
        Me.lblSubeGuncellemeIslemleri.Text = "Şube Güncelleme İşlemleri"
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(337, 263)
        Me.btnIptal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(223, 43)
        Me.btnIptal.TabIndex = 93
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnSubeGuncelle
        '
        Me.btnSubeGuncelle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubeGuncelle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubeGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubeGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSubeGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnSubeGuncelle.Location = New System.Drawing.Point(582, 263)
        Me.btnSubeGuncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubeGuncelle.Name = "btnSubeGuncelle"
        Me.btnSubeGuncelle.Size = New System.Drawing.Size(223, 43)
        Me.btnSubeGuncelle.TabIndex = 92
        Me.btnSubeGuncelle.Text = "Güncelle"
        Me.btnSubeGuncelle.UseVisualStyleBackColor = False
        '
        'txtSubeAdi
        '
        Me.txtSubeAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSubeAdi.ForeColor = System.Drawing.Color.Black
        Me.txtSubeAdi.Location = New System.Drawing.Point(484, 136)
        Me.txtSubeAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeAdi.Name = "txtSubeAdi"
        Me.txtSubeAdi.Size = New System.Drawing.Size(321, 36)
        Me.txtSubeAdi.TabIndex = 91
        '
        'lblSubeAdi
        '
        Me.lblSubeAdi.AutoSize = True
        Me.lblSubeAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeAdi.ForeColor = System.Drawing.Color.Black
        Me.lblSubeAdi.Location = New System.Drawing.Point(337, 139)
        Me.lblSubeAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeAdi.Name = "lblSubeAdi"
        Me.lblSubeAdi.Size = New System.Drawing.Size(118, 31)
        Me.lblSubeAdi.TabIndex = 90
        Me.lblSubeAdi.Text = "Şube Adı"
        '
        'SubeGuncelle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(829, 393)
        Me.Controls.Add(Me.lstSubeler)
        Me.Controls.Add(Me.cbAdresID)
        Me.Controls.Add(Me.lblAdresID)
        Me.Controls.Add(Me.lblSubeGuncellemeIslemleri)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnSubeGuncelle)
        Me.Controls.Add(Me.txtSubeAdi)
        Me.Controls.Add(Me.lblSubeAdi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SubeGuncelle"
        Me.Text = "Şube Güncelleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lstSubeler As ListBox
    Private WithEvents cbAdresID As ComboBox
    Private WithEvents lblAdresID As Label
    Private WithEvents lblSubeGuncellemeIslemleri As Label
    Private WithEvents btnIptal As Button
    Private WithEvents btnSubeGuncelle As Button
    Private WithEvents txtSubeAdi As TextBox
    Private WithEvents lblSubeAdi As Label
End Class
