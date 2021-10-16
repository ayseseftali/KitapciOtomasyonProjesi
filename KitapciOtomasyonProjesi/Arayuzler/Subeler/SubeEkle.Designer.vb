<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubeEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubeEkle))
        Me.cbAdresID = New System.Windows.Forms.ComboBox()
        Me.lblAdresID = New System.Windows.Forms.Label()
        Me.lblSubeEklemeİslemleri = New System.Windows.Forms.Label()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnSubeEkle = New System.Windows.Forms.Button()
        Me.txtSubeAdi = New System.Windows.Forms.TextBox()
        Me.lblSubeAdi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbAdresID
        '
        Me.cbAdresID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbAdresID.FormattingEnabled = True
        Me.cbAdresID.Location = New System.Drawing.Point(196, 156)
        Me.cbAdresID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAdresID.Name = "cbAdresID"
        Me.cbAdresID.Size = New System.Drawing.Size(322, 33)
        Me.cbAdresID.TabIndex = 88
        '
        'lblAdresID
        '
        Me.lblAdresID.AutoSize = True
        Me.lblAdresID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAdresID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAdresID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdresID.ForeColor = System.Drawing.Color.Black
        Me.lblAdresID.Location = New System.Drawing.Point(38, 155)
        Me.lblAdresID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdresID.Name = "lblAdresID"
        Me.lblAdresID.Size = New System.Drawing.Size(105, 31)
        Me.lblAdresID.TabIndex = 87
        Me.lblAdresID.Text = "AdresID"
        '
        'lblSubeEklemeİslemleri
        '
        Me.lblSubeEklemeİslemleri.AutoSize = True
        Me.lblSubeEklemeİslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeEklemeİslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeEklemeİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeEklemeİslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeEklemeİslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblSubeEklemeİslemleri.Location = New System.Drawing.Point(93, 25)
        Me.lblSubeEklemeİslemleri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeEklemeİslemleri.Name = "lblSubeEklemeİslemleri"
        Me.lblSubeEklemeİslemleri.Size = New System.Drawing.Size(359, 41)
        Me.lblSubeEklemeİslemleri.TabIndex = 86
        Me.lblSubeEklemeİslemleri.Text = "Şube Ekleme İşlemleri"
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(50, 213)
        Me.btnIptal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(197, 43)
        Me.btnIptal.TabIndex = 84
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnSubeEkle
        '
        Me.btnSubeEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubeEkle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubeEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubeEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSubeEkle.ForeColor = System.Drawing.Color.Black
        Me.btnSubeEkle.Location = New System.Drawing.Point(301, 213)
        Me.btnSubeEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubeEkle.Name = "btnSubeEkle"
        Me.btnSubeEkle.Size = New System.Drawing.Size(197, 43)
        Me.btnSubeEkle.TabIndex = 83
        Me.btnSubeEkle.Text = "Kaydet"
        Me.btnSubeEkle.UseVisualStyleBackColor = False
        '
        'txtSubeAdi
        '
        Me.txtSubeAdi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSubeAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSubeAdi.ForeColor = System.Drawing.Color.Black
        Me.txtSubeAdi.Location = New System.Drawing.Point(196, 100)
        Me.txtSubeAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubeAdi.Name = "txtSubeAdi"
        Me.txtSubeAdi.Size = New System.Drawing.Size(322, 30)
        Me.txtSubeAdi.TabIndex = 82
        '
        'lblSubeAdi
        '
        Me.lblSubeAdi.AutoSize = True
        Me.lblSubeAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSubeAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubeAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubeAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSubeAdi.ForeColor = System.Drawing.Color.Black
        Me.lblSubeAdi.Location = New System.Drawing.Point(38, 99)
        Me.lblSubeAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubeAdi.Name = "lblSubeAdi"
        Me.lblSubeAdi.Size = New System.Drawing.Size(118, 31)
        Me.lblSubeAdi.TabIndex = 81
        Me.lblSubeAdi.Text = "Şube Adı"
        '
        'SubeEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(554, 291)
        Me.Controls.Add(Me.cbAdresID)
        Me.Controls.Add(Me.lblAdresID)
        Me.Controls.Add(Me.lblSubeEklemeİslemleri)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnSubeEkle)
        Me.Controls.Add(Me.txtSubeAdi)
        Me.Controls.Add(Me.lblSubeAdi)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SubeEkle"
        Me.Text = "Şube Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cbAdresID As ComboBox
    Private WithEvents lblAdresID As Label
    Private WithEvents lblSubeEklemeİslemleri As Label
    Private WithEvents btnIptal As Button
    Private WithEvents btnSubeEkle As Button
    Private WithEvents txtSubeAdi As TextBox
    Private WithEvents lblSubeAdi As Label
End Class
