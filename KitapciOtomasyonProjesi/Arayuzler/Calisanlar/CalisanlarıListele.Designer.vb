<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalisanlarıListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalisanlarıListele))
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabelVeriler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstwCalisanlar = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pbResim = New System.Windows.Forms.PictureBox()
        Me.statusStrip1.SuspendLayout()
        CType(Me.pbResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusStrip1
        '
        Me.statusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabelVeriler, Me.ToolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.statusStrip1.Size = New System.Drawing.Size(1761, 22)
        Me.statusStrip1.TabIndex = 6
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabelVeriler
        '
        Me.toolStripStatusLabelVeriler.Name = "toolStripStatusLabelVeriler"
        Me.toolStripStatusLabelVeriler.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'lstwCalisanlar
        '
        Me.lstwCalisanlar.AllowColumnReorder = True
        Me.lstwCalisanlar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstwCalisanlar.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwCalisanlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstwCalisanlar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5, Me.columnHeader6, Me.columnHeader7, Me.columnHeader8, Me.columnHeader9, Me.columnHeader10})
        Me.lstwCalisanlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwCalisanlar.ForeColor = System.Drawing.Color.Black
        Me.lstwCalisanlar.FullRowSelect = True
        Me.lstwCalisanlar.GridLines = True
        Me.lstwCalisanlar.Location = New System.Drawing.Point(0, 1)
        Me.lstwCalisanlar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwCalisanlar.Name = "lstwCalisanlar"
        Me.lstwCalisanlar.Size = New System.Drawing.Size(1589, 527)
        Me.lstwCalisanlar.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstwCalisanlar.TabIndex = 7
        Me.lstwCalisanlar.UseCompatibleStateImageBehavior = False
        Me.lstwCalisanlar.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "ID"
        Me.columnHeader1.Width = 78
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Ad"
        Me.columnHeader2.Width = 152
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Soyad"
        Me.columnHeader3.Width = 134
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Cinsiyet"
        Me.columnHeader4.Width = 110
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "Telefon"
        Me.columnHeader5.Width = 155
        '
        'columnHeader6
        '
        Me.columnHeader6.Text = "EPosta"
        Me.columnHeader6.Width = 170
        '
        'columnHeader7
        '
        Me.columnHeader7.Text = "Pozisyon"
        Me.columnHeader7.Width = 112
        '
        'columnHeader8
        '
        Me.columnHeader8.Text = "AdresID"
        Me.columnHeader8.Width = 99
        '
        'columnHeader9
        '
        Me.columnHeader9.Text = "ŞubeID"
        Me.columnHeader9.Width = 92
        '
        'columnHeader10
        '
        Me.columnHeader10.Text = "Şifre"
        Me.columnHeader10.Width = 165
        '
        'pbResim
        '
        Me.pbResim.BackColor = System.Drawing.Color.Gainsboro
        Me.pbResim.Location = New System.Drawing.Point(1597, 13)
        Me.pbResim.Margin = New System.Windows.Forms.Padding(4)
        Me.pbResim.Name = "pbResim"
        Me.pbResim.Size = New System.Drawing.Size(152, 176)
        Me.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbResim.TabIndex = 8
        Me.pbResim.TabStop = False
        '
        'CalisanlarıListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1761, 570)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.lstwCalisanlar)
        Me.Controls.Add(Me.pbResim)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CalisanlarıListele"
        Me.Text = "Çalışanları Listele"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        CType(Me.pbResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents toolStripStatusLabelVeriler As ToolStripStatusLabel
    Private WithEvents lstwCalisanlar As ListView
    Private WithEvents columnHeader1 As ColumnHeader
    Private WithEvents columnHeader2 As ColumnHeader
    Private WithEvents columnHeader3 As ColumnHeader
    Private WithEvents columnHeader4 As ColumnHeader
    Private WithEvents columnHeader5 As ColumnHeader
    Private WithEvents columnHeader6 As ColumnHeader
    Private WithEvents columnHeader7 As ColumnHeader
    Private WithEvents columnHeader8 As ColumnHeader
    Private WithEvents columnHeader9 As ColumnHeader
    Private WithEvents columnHeader10 As ColumnHeader
    Private WithEvents pbResim As PictureBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
