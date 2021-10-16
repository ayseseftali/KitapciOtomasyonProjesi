<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rapor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rapor))
        Me.lblToplamMusteriSayisi = New System.Windows.Forms.Label()
        Me.lblToplamSatisSayisi = New System.Windows.Forms.Label()
        Me.lblToplamTutar = New System.Windows.Forms.Label()
        Me.lblKitap = New System.Windows.Forms.Label()
        Me.lblSube = New System.Windows.Forms.Label()
        Me.lblSatisTarihi = New System.Windows.Forms.Label()
        Me.dateSatisTarihi = New System.Windows.Forms.DateTimePicker()
        Me.cbSube = New System.Windows.Forms.ComboBox()
        Me.cbKitap = New System.Windows.Forms.ComboBox()
        Me.btnTarihSR = New System.Windows.Forms.Button()
        Me.btnSubeSR = New System.Windows.Forms.Button()
        Me.btnKitapSR = New System.Windows.Forms.Button()
        Me.txtToplamTutar = New System.Windows.Forms.TextBox()
        Me.txtSatisSayisi = New System.Windows.Forms.TextBox()
        Me.txtMusteriSayisi = New System.Windows.Forms.TextBox()
        Me.lstwRaporlar = New System.Windows.Forms.ListView()
        Me.SatisID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubeID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KitapID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MusteriID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SatisSayisi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SatisTarihi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToplamTutar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblToplamMusteriSayisi
        '
        Me.lblToplamMusteriSayisi.AutoSize = True
        Me.lblToplamMusteriSayisi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblToplamMusteriSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToplamMusteriSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblToplamMusteriSayisi.ForeColor = System.Drawing.Color.Black
        Me.lblToplamMusteriSayisi.Location = New System.Drawing.Point(705, 145)
        Me.lblToplamMusteriSayisi.Name = "lblToplamMusteriSayisi"
        Me.lblToplamMusteriSayisi.Size = New System.Drawing.Size(311, 31)
        Me.lblToplamMusteriSayisi.TabIndex = 16
        Me.lblToplamMusteriSayisi.Text = "Raporlanan Müşteri Sayısı"
        '
        'lblToplamSatisSayisi
        '
        Me.lblToplamSatisSayisi.AutoSize = True
        Me.lblToplamSatisSayisi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblToplamSatisSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToplamSatisSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblToplamSatisSayisi.ForeColor = System.Drawing.Color.Black
        Me.lblToplamSatisSayisi.Location = New System.Drawing.Point(705, 82)
        Me.lblToplamSatisSayisi.Name = "lblToplamSatisSayisi"
        Me.lblToplamSatisSayisi.Size = New System.Drawing.Size(285, 31)
        Me.lblToplamSatisSayisi.TabIndex = 15
        Me.lblToplamSatisSayisi.Text = "Raporlanan Satış Sayısı"
        '
        'lblToplamTutar
        '
        Me.lblToplamTutar.AutoSize = True
        Me.lblToplamTutar.BackColor = System.Drawing.Color.Gainsboro
        Me.lblToplamTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToplamTutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblToplamTutar.ForeColor = System.Drawing.Color.Black
        Me.lblToplamTutar.Location = New System.Drawing.Point(705, 17)
        Me.lblToplamTutar.Name = "lblToplamTutar"
        Me.lblToplamTutar.Size = New System.Drawing.Size(302, 31)
        Me.lblToplamTutar.TabIndex = 14
        Me.lblToplamTutar.Text = "Raporlanan Toplam Tutar"
        '
        'lblKitap
        '
        Me.lblKitap.AutoSize = True
        Me.lblKitap.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKitap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKitap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKitap.ForeColor = System.Drawing.Color.Black
        Me.lblKitap.Location = New System.Drawing.Point(29, 150)
        Me.lblKitap.Name = "lblKitap"
        Me.lblKitap.Size = New System.Drawing.Size(70, 31)
        Me.lblKitap.TabIndex = 13
        Me.lblKitap.Text = "Kitap"
        '
        'lblSube
        '
        Me.lblSube.AutoSize = True
        Me.lblSube.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSube.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSube.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSube.ForeColor = System.Drawing.Color.Black
        Me.lblSube.Location = New System.Drawing.Point(29, 87)
        Me.lblSube.Name = "lblSube"
        Me.lblSube.Size = New System.Drawing.Size(72, 31)
        Me.lblSube.TabIndex = 12
        Me.lblSube.Text = "Şube"
        '
        'lblSatisTarihi
        '
        Me.lblSatisTarihi.AutoSize = True
        Me.lblSatisTarihi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSatisTarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSatisTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSatisTarihi.ForeColor = System.Drawing.Color.Black
        Me.lblSatisTarihi.Location = New System.Drawing.Point(29, 25)
        Me.lblSatisTarihi.Name = "lblSatisTarihi"
        Me.lblSatisTarihi.Size = New System.Drawing.Size(136, 31)
        Me.lblSatisTarihi.TabIndex = 11
        Me.lblSatisTarihi.Text = "Satış Tarihi"
        '
        'dateSatisTarihi
        '
        Me.dateSatisTarihi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dateSatisTarihi.Location = New System.Drawing.Point(190, 25)
        Me.dateSatisTarihi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateSatisTarihi.Name = "dateSatisTarihi"
        Me.dateSatisTarihi.Size = New System.Drawing.Size(296, 28)
        Me.dateSatisTarihi.TabIndex = 17
        '
        'cbSube
        '
        Me.cbSube.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbSube.FormattingEnabled = True
        Me.cbSube.Location = New System.Drawing.Point(190, 86)
        Me.cbSube.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSube.Name = "cbSube"
        Me.cbSube.Size = New System.Drawing.Size(296, 30)
        Me.cbSube.TabIndex = 18
        '
        'cbKitap
        '
        Me.cbKitap.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbKitap.FormattingEnabled = True
        Me.cbKitap.Location = New System.Drawing.Point(190, 150)
        Me.cbKitap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbKitap.Name = "cbKitap"
        Me.cbKitap.Size = New System.Drawing.Size(296, 30)
        Me.cbKitap.TabIndex = 19
        '
        'btnTarihSR
        '
        Me.btnTarihSR.BackColor = System.Drawing.Color.Gainsboro
        Me.btnTarihSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarihSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnTarihSR.ForeColor = System.Drawing.Color.Black
        Me.btnTarihSR.Location = New System.Drawing.Point(519, 19)
        Me.btnTarihSR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTarihSR.Name = "btnTarihSR"
        Me.btnTarihSR.Size = New System.Drawing.Size(151, 56)
        Me.btnTarihSR.TabIndex = 20
        Me.btnTarihSR.Text = "Tarih ile Satış Raporla"
        Me.btnTarihSR.UseVisualStyleBackColor = False
        '
        'btnSubeSR
        '
        Me.btnSubeSR.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubeSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubeSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSubeSR.ForeColor = System.Drawing.Color.Black
        Me.btnSubeSR.Location = New System.Drawing.Point(519, 79)
        Me.btnSubeSR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubeSR.Name = "btnSubeSR"
        Me.btnSubeSR.Size = New System.Drawing.Size(151, 56)
        Me.btnSubeSR.TabIndex = 21
        Me.btnSubeSR.Text = "Şube ile Satış Raporla"
        Me.btnSubeSR.UseVisualStyleBackColor = False
        '
        'btnKitapSR
        '
        Me.btnKitapSR.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKitapSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKitapSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKitapSR.ForeColor = System.Drawing.Color.Black
        Me.btnKitapSR.Location = New System.Drawing.Point(519, 139)
        Me.btnKitapSR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKitapSR.Name = "btnKitapSR"
        Me.btnKitapSR.Size = New System.Drawing.Size(151, 56)
        Me.btnKitapSR.TabIndex = 22
        Me.btnKitapSR.Text = "Kitap ile Satış Raporla"
        Me.btnKitapSR.UseVisualStyleBackColor = False
        '
        'txtToplamTutar
        '
        Me.txtToplamTutar.Location = New System.Drawing.Point(1036, 15)
        Me.txtToplamTutar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtToplamTutar.Multiline = True
        Me.txtToplamTutar.Name = "txtToplamTutar"
        Me.txtToplamTutar.Size = New System.Drawing.Size(231, 38)
        Me.txtToplamTutar.TabIndex = 23
        '
        'txtSatisSayisi
        '
        Me.txtSatisSayisi.Location = New System.Drawing.Point(1036, 78)
        Me.txtSatisSayisi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSatisSayisi.Multiline = True
        Me.txtSatisSayisi.Name = "txtSatisSayisi"
        Me.txtSatisSayisi.Size = New System.Drawing.Size(229, 38)
        Me.txtSatisSayisi.TabIndex = 24
        '
        'txtMusteriSayisi
        '
        Me.txtMusteriSayisi.Location = New System.Drawing.Point(1038, 142)
        Me.txtMusteriSayisi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMusteriSayisi.Multiline = True
        Me.txtMusteriSayisi.Name = "txtMusteriSayisi"
        Me.txtMusteriSayisi.Size = New System.Drawing.Size(229, 38)
        Me.txtMusteriSayisi.TabIndex = 25
        '
        'lstwRaporlar
        '
        Me.lstwRaporlar.AllowColumnReorder = True
        Me.lstwRaporlar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstwRaporlar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwRaporlar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SatisID, Me.SubeID, Me.KitapID, Me.MusteriID, Me.SatisSayisi, Me.SatisTarihi, Me.ToplamTutar})
        Me.lstwRaporlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstwRaporlar.FullRowSelect = True
        Me.lstwRaporlar.GridLines = True
        Me.lstwRaporlar.Location = New System.Drawing.Point(29, 214)
        Me.lstwRaporlar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwRaporlar.Name = "lstwRaporlar"
        Me.lstwRaporlar.Size = New System.Drawing.Size(1236, 338)
        Me.lstwRaporlar.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstwRaporlar.TabIndex = 26
        Me.lstwRaporlar.UseCompatibleStateImageBehavior = False
        Me.lstwRaporlar.View = System.Windows.Forms.View.Details
        '
        'SatisID
        '
        Me.SatisID.Text = "Satış ID"
        Me.SatisID.Width = 108
        '
        'SubeID
        '
        Me.SubeID.Text = "Şube ID"
        Me.SubeID.Width = 103
        '
        'KitapID
        '
        Me.KitapID.Text = "Kitap ID"
        Me.KitapID.Width = 113
        '
        'MusteriID
        '
        Me.MusteriID.Text = "Müşteri ID"
        Me.MusteriID.Width = 133
        '
        'SatisSayisi
        '
        Me.SatisSayisi.Text = "Satış Sayısı"
        Me.SatisSayisi.Width = 144
        '
        'SatisTarihi
        '
        Me.SatisTarihi.Text = "Satış Tarihi"
        Me.SatisTarihi.Width = 162
        '
        'ToplamTutar
        '
        Me.ToplamTutar.Text = "Toplam Tutar"
        Me.ToplamTutar.Width = 189
        '
        'Rapor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1310, 565)
        Me.Controls.Add(Me.lstwRaporlar)
        Me.Controls.Add(Me.txtMusteriSayisi)
        Me.Controls.Add(Me.txtSatisSayisi)
        Me.Controls.Add(Me.txtToplamTutar)
        Me.Controls.Add(Me.btnKitapSR)
        Me.Controls.Add(Me.btnSubeSR)
        Me.Controls.Add(Me.btnTarihSR)
        Me.Controls.Add(Me.cbKitap)
        Me.Controls.Add(Me.cbSube)
        Me.Controls.Add(Me.dateSatisTarihi)
        Me.Controls.Add(Me.lblToplamMusteriSayisi)
        Me.Controls.Add(Me.lblToplamSatisSayisi)
        Me.Controls.Add(Me.lblToplamTutar)
        Me.Controls.Add(Me.lblKitap)
        Me.Controls.Add(Me.lblSube)
        Me.Controls.Add(Me.lblSatisTarihi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Rapor"
        Me.Text = "Rapor Ekranı"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblToplamMusteriSayisi As Label
    Friend WithEvents lblToplamSatisSayisi As Label
    Friend WithEvents lblToplamTutar As Label
    Friend WithEvents lblKitap As Label
    Friend WithEvents lblSube As Label
    Friend WithEvents lblSatisTarihi As Label
    Friend WithEvents dateSatisTarihi As DateTimePicker
    Friend WithEvents cbSube As ComboBox
    Friend WithEvents cbKitap As ComboBox
    Friend WithEvents btnTarihSR As Button
    Friend WithEvents btnSubeSR As Button
    Friend WithEvents btnKitapSR As Button
    Friend WithEvents txtToplamTutar As TextBox
    Friend WithEvents txtSatisSayisi As TextBox
    Friend WithEvents txtMusteriSayisi As TextBox
    Friend WithEvents lstwRaporlar As ListView
    Private WithEvents SatisID As ColumnHeader
    Private WithEvents SubeID As ColumnHeader
    Private WithEvents KitapID As ColumnHeader
    Private WithEvents MusteriID As ColumnHeader
    Private WithEvents SatisSayisi As ColumnHeader
    Private WithEvents SatisTarihi As ColumnHeader
    Private WithEvents ToplamTutar As ColumnHeader
End Class
