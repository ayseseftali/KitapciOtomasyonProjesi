<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YayinEviEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YayinEviEkle))
        Me.cbAdresID = New System.Windows.Forms.ComboBox()
        Me.lblAdresID = New System.Windows.Forms.Label()
        Me.lblYayinEviEklemeİslemleri = New System.Windows.Forms.Label()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnYayinEviEkle = New System.Windows.Forms.Button()
        Me.txtYayinEviAdi = New System.Windows.Forms.TextBox()
        Me.lblYayinEviAdi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbAdresID
        '
        Me.cbAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbAdresID.ForeColor = System.Drawing.Color.Black
        Me.cbAdresID.FormattingEnabled = True
        Me.cbAdresID.Location = New System.Drawing.Point(224, 150)
        Me.cbAdresID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAdresID.Name = "cbAdresID"
        Me.cbAdresID.Size = New System.Drawing.Size(321, 37)
        Me.cbAdresID.TabIndex = 96
        '
        'lblAdresID
        '
        Me.lblAdresID.AutoSize = True
        Me.lblAdresID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAdresID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdresID.ForeColor = System.Drawing.Color.Black
        Me.lblAdresID.Location = New System.Drawing.Point(20, 153)
        Me.lblAdresID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresID.Name = "lblAdresID"
        Me.lblAdresID.Size = New System.Drawing.Size(105, 31)
        Me.lblAdresID.TabIndex = 95
        Me.lblAdresID.Text = "AdresID"
        '
        'lblYayinEviEklemeİslemleri
        '
        Me.lblYayinEviEklemeİslemleri.AutoSize = True
        Me.lblYayinEviEklemeİslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviEklemeİslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviEklemeİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYayinEviEklemeİslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviEklemeİslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviEklemeİslemleri.Location = New System.Drawing.Point(80, 22)
        Me.lblYayinEviEklemeİslemleri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviEklemeİslemleri.Name = "lblYayinEviEklemeİslemleri"
        Me.lblYayinEviEklemeİslemleri.Size = New System.Drawing.Size(421, 41)
        Me.lblYayinEviEklemeİslemleri.TabIndex = 94
        Me.lblYayinEviEklemeİslemleri.Text = "Yayın Evi Ekleme İşlemleri"
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(51, 215)
        Me.btnIptal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(223, 43)
        Me.btnIptal.TabIndex = 92
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnYayinEviEkle
        '
        Me.btnYayinEviEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYayinEviEkle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYayinEviEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnYayinEviEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYayinEviEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYayinEviEkle.ForeColor = System.Drawing.Color.Black
        Me.btnYayinEviEkle.Location = New System.Drawing.Point(297, 215)
        Me.btnYayinEviEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYayinEviEkle.Name = "btnYayinEviEkle"
        Me.btnYayinEviEkle.Size = New System.Drawing.Size(223, 43)
        Me.btnYayinEviEkle.TabIndex = 91
        Me.btnYayinEviEkle.Text = "Kaydet"
        Me.btnYayinEviEkle.UseVisualStyleBackColor = False
        '
        'txtYayinEviAdi
        '
        Me.txtYayinEviAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYayinEviAdi.ForeColor = System.Drawing.Color.Black
        Me.txtYayinEviAdi.Location = New System.Drawing.Point(224, 92)
        Me.txtYayinEviAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYayinEviAdi.Name = "txtYayinEviAdi"
        Me.txtYayinEviAdi.Size = New System.Drawing.Size(321, 36)
        Me.txtYayinEviAdi.TabIndex = 90
        '
        'lblYayinEviAdi
        '
        Me.lblYayinEviAdi.AutoSize = True
        Me.lblYayinEviAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYayinEviAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYayinEviAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYayinEviAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYayinEviAdi.ForeColor = System.Drawing.Color.Black
        Me.lblYayinEviAdi.Location = New System.Drawing.Point(20, 95)
        Me.lblYayinEviAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYayinEviAdi.Name = "lblYayinEviAdi"
        Me.lblYayinEviAdi.Size = New System.Drawing.Size(165, 31)
        Me.lblYayinEviAdi.TabIndex = 89
        Me.lblYayinEviAdi.Text = "Yayın Evi Adı"
        '
        'YayinEviEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(576, 283)
        Me.Controls.Add(Me.cbAdresID)
        Me.Controls.Add(Me.lblAdresID)
        Me.Controls.Add(Me.lblYayinEviEklemeİslemleri)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnYayinEviEkle)
        Me.Controls.Add(Me.txtYayinEviAdi)
        Me.Controls.Add(Me.lblYayinEviAdi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "YayinEviEkle"
        Me.Text = "Yayın Evi Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cbAdresID As ComboBox
    Private WithEvents lblAdresID As Label
    Private WithEvents lblYayinEviEklemeİslemleri As Label
    Private WithEvents btnIptal As Button
    Private WithEvents btnYayinEviEkle As Button
    Private WithEvents txtYayinEviAdi As TextBox
    Private WithEvents lblYayinEviAdi As Label
End Class
