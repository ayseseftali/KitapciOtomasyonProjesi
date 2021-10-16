<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YazarEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YazarEkle))
        Me.txtYazarSoyadi = New System.Windows.Forms.TextBox()
        Me.lblYazarSoyadi = New System.Windows.Forms.Label()
        Me.lblYazarEklemeİslemleri = New System.Windows.Forms.Label()
        Me.btnIptal = New System.Windows.Forms.Button()
        Me.btnYazarEkle = New System.Windows.Forms.Button()
        Me.txtYazarAdi = New System.Windows.Forms.TextBox()
        Me.lblYazarAdi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtYazarSoyadi
        '
        Me.txtYazarSoyadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYazarSoyadi.ForeColor = System.Drawing.Color.Black
        Me.txtYazarSoyadi.Location = New System.Drawing.Point(256, 166)
        Me.txtYazarSoyadi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYazarSoyadi.Name = "txtYazarSoyadi"
        Me.txtYazarSoyadi.Size = New System.Drawing.Size(321, 36)
        Me.txtYazarSoyadi.TabIndex = 106
        '
        'lblYazarSoyadi
        '
        Me.lblYazarSoyadi.AutoSize = True
        Me.lblYazarSoyadi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYazarSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYazarSoyadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYazarSoyadi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYazarSoyadi.ForeColor = System.Drawing.Color.Black
        Me.lblYazarSoyadi.Location = New System.Drawing.Point(58, 169)
        Me.lblYazarSoyadi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYazarSoyadi.Name = "lblYazarSoyadi"
        Me.lblYazarSoyadi.Size = New System.Drawing.Size(165, 31)
        Me.lblYazarSoyadi.TabIndex = 105
        Me.lblYazarSoyadi.Text = "Yazar Soyadı"
        '
        'lblYazarEklemeİslemleri
        '
        Me.lblYazarEklemeİslemleri.AutoSize = True
        Me.lblYazarEklemeİslemleri.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYazarEklemeİslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYazarEklemeİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYazarEklemeİslemleri.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYazarEklemeİslemleri.ForeColor = System.Drawing.Color.Black
        Me.lblYazarEklemeİslemleri.Location = New System.Drawing.Point(130, 31)
        Me.lblYazarEklemeİslemleri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYazarEklemeİslemleri.Name = "lblYazarEklemeİslemleri"
        Me.lblYazarEklemeİslemleri.Size = New System.Drawing.Size(367, 41)
        Me.lblYazarEklemeİslemleri.TabIndex = 104
        Me.lblYazarEklemeİslemleri.Text = "Yazar Ekleme İşlemleri"
        '
        'btnIptal
        '
        Me.btnIptal.BackColor = System.Drawing.Color.Gainsboro
        Me.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptal.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Location = New System.Drawing.Point(75, 231)
        Me.btnIptal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(223, 43)
        Me.btnIptal.TabIndex = 102
        Me.btnIptal.Text = "İptal"
        Me.btnIptal.UseVisualStyleBackColor = False
        '
        'btnYazarEkle
        '
        Me.btnYazarEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYazarEkle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYazarEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnYazarEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYazarEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYazarEkle.ForeColor = System.Drawing.Color.Black
        Me.btnYazarEkle.Location = New System.Drawing.Point(339, 231)
        Me.btnYazarEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYazarEkle.Name = "btnYazarEkle"
        Me.btnYazarEkle.Size = New System.Drawing.Size(223, 43)
        Me.btnYazarEkle.TabIndex = 101
        Me.btnYazarEkle.Text = "Kaydet"
        Me.btnYazarEkle.UseVisualStyleBackColor = False
        '
        'txtYazarAdi
        '
        Me.txtYazarAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYazarAdi.ForeColor = System.Drawing.Color.Black
        Me.txtYazarAdi.Location = New System.Drawing.Point(256, 113)
        Me.txtYazarAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYazarAdi.Name = "txtYazarAdi"
        Me.txtYazarAdi.Size = New System.Drawing.Size(321, 36)
        Me.txtYazarAdi.TabIndex = 100
        '
        'lblYazarAdi
        '
        Me.lblYazarAdi.AutoSize = True
        Me.lblYazarAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYazarAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYazarAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYazarAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblYazarAdi.ForeColor = System.Drawing.Color.Black
        Me.lblYazarAdi.Location = New System.Drawing.Point(58, 116)
        Me.lblYazarAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYazarAdi.Name = "lblYazarAdi"
        Me.lblYazarAdi.Size = New System.Drawing.Size(124, 31)
        Me.lblYazarAdi.TabIndex = 99
        Me.lblYazarAdi.Text = "Yazar Adı"
        '
        'YazarEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 303)
        Me.Controls.Add(Me.txtYazarSoyadi)
        Me.Controls.Add(Me.lblYazarSoyadi)
        Me.Controls.Add(Me.lblYazarEklemeİslemleri)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnYazarEkle)
        Me.Controls.Add(Me.txtYazarAdi)
        Me.Controls.Add(Me.lblYazarAdi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "YazarEkle"
        Me.Text = "Yazar Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtYazarSoyadi As TextBox
    Private WithEvents lblYazarSoyadi As Label
    Private WithEvents lblYazarEklemeİslemleri As Label
    Private WithEvents btnIptal As Button
    Private WithEvents btnYazarEkle As Button
    Private WithEvents txtYazarAdi As TextBox
    Private WithEvents lblYazarAdi As Label
End Class
