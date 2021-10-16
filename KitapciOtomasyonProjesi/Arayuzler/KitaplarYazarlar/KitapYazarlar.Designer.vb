<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitapYazarlar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KitapYazarlar))
        Me.lstwYazarlar = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblKitabaYazarEklemeIslemi = New System.Windows.Forms.Label()
        Me.btnYazarEkle = New System.Windows.Forms.Button()
        Me.btnYazarSil = New System.Windows.Forms.Button()
        Me.btnSecimiOnayla = New System.Windows.Forms.Button()
        Me.btnSayfayıYenile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstwYazarlar
        '
        Me.lstwYazarlar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwYazarlar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstwYazarlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwYazarlar.ForeColor = System.Drawing.Color.Black
        Me.lstwYazarlar.GridLines = True
        Me.lstwYazarlar.Location = New System.Drawing.Point(34, 92)
        Me.lstwYazarlar.Name = "lstwYazarlar"
        Me.lstwYazarlar.Size = New System.Drawing.Size(648, 271)
        Me.lstwYazarlar.TabIndex = 0
        Me.lstwYazarlar.UseCompatibleStateImageBehavior = False
        Me.lstwYazarlar.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Yazar ID"
        Me.ColumnHeader1.Width = 134
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Yazar Adı"
        Me.ColumnHeader2.Width = 235
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Yazar Soyadı"
        Me.ColumnHeader3.Width = 275
        '
        'lblKitabaYazarEklemeIslemi
        '
        Me.lblKitabaYazarEklemeIslemi.AutoSize = True
        Me.lblKitabaYazarEklemeIslemi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKitabaYazarEklemeIslemi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKitabaYazarEklemeIslemi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKitabaYazarEklemeIslemi.ForeColor = System.Drawing.Color.Black
        Me.lblKitabaYazarEklemeIslemi.Location = New System.Drawing.Point(152, 30)
        Me.lblKitabaYazarEklemeIslemi.Name = "lblKitabaYazarEklemeIslemi"
        Me.lblKitabaYazarEklemeIslemi.Size = New System.Drawing.Size(435, 41)
        Me.lblKitabaYazarEklemeIslemi.TabIndex = 1
        Me.lblKitabaYazarEklemeIslemi.Text = "Kitaba Yazar Ekleme İşlemi"
        '
        'btnYazarEkle
        '
        Me.btnYazarEkle.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYazarEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYazarEkle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYazarEkle.ForeColor = System.Drawing.Color.Black
        Me.btnYazarEkle.Location = New System.Drawing.Point(12, 382)
        Me.btnYazarEkle.Name = "btnYazarEkle"
        Me.btnYazarEkle.Size = New System.Drawing.Size(229, 45)
        Me.btnYazarEkle.TabIndex = 2
        Me.btnYazarEkle.Text = "Yazar Ekle"
        Me.btnYazarEkle.UseVisualStyleBackColor = False
        '
        'btnYazarSil
        '
        Me.btnYazarSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnYazarSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYazarSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYazarSil.ForeColor = System.Drawing.Color.Black
        Me.btnYazarSil.Location = New System.Drawing.Point(247, 382)
        Me.btnYazarSil.Name = "btnYazarSil"
        Me.btnYazarSil.Size = New System.Drawing.Size(229, 45)
        Me.btnYazarSil.TabIndex = 3
        Me.btnYazarSil.Text = "Yazar Sil"
        Me.btnYazarSil.UseVisualStyleBackColor = False
        '
        'btnSecimiOnayla
        '
        Me.btnSecimiOnayla.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSecimiOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecimiOnayla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSecimiOnayla.ForeColor = System.Drawing.Color.Black
        Me.btnSecimiOnayla.Location = New System.Drawing.Point(482, 382)
        Me.btnSecimiOnayla.Name = "btnSecimiOnayla"
        Me.btnSecimiOnayla.Size = New System.Drawing.Size(229, 45)
        Me.btnSecimiOnayla.TabIndex = 4
        Me.btnSecimiOnayla.Text = "Seçimi Onayla"
        Me.btnSecimiOnayla.UseVisualStyleBackColor = False
        '
        'btnSayfayıYenile
        '
        Me.btnSayfayıYenile.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSayfayıYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSayfayıYenile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSayfayıYenile.ForeColor = System.Drawing.Color.Black
        Me.btnSayfayıYenile.Location = New System.Drawing.Point(192, 433)
        Me.btnSayfayıYenile.Name = "btnSayfayıYenile"
        Me.btnSayfayıYenile.Size = New System.Drawing.Size(338, 45)
        Me.btnSayfayıYenile.TabIndex = 5
        Me.btnSayfayıYenile.Text = "Sayfayı Yenile"
        Me.btnSayfayıYenile.UseVisualStyleBackColor = False
        '
        'KitapYazarlar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(725, 497)
        Me.Controls.Add(Me.btnSayfayıYenile)
        Me.Controls.Add(Me.btnSecimiOnayla)
        Me.Controls.Add(Me.btnYazarSil)
        Me.Controls.Add(Me.btnYazarEkle)
        Me.Controls.Add(Me.lblKitabaYazarEklemeIslemi)
        Me.Controls.Add(Me.lstwYazarlar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KitapYazarlar"
        Me.Text = "Kitap Yazarları"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstwYazarlar As ListView
    Friend WithEvents lblKitabaYazarEklemeIslemi As Label
    Friend WithEvents btnYazarEkle As Button
    Friend WithEvents btnYazarSil As Button
    Friend WithEvents btnSecimiOnayla As Button
    Friend WithEvents btnSayfayıYenile As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
