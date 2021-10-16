<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusterilerListele
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
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabelVeriler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstwCalisanlar = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusStrip1
        '
        Me.statusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabelVeriler})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 674)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.statusStrip1.Size = New System.Drawing.Size(793, 22)
        Me.statusStrip1.TabIndex = 9
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabelVeriler
        '
        Me.toolStripStatusLabelVeriler.Name = "toolStripStatusLabelVeriler"
        Me.toolStripStatusLabelVeriler.Size = New System.Drawing.Size(0, 17)
        '
        'lstwCalisanlar
        '
        Me.lstwCalisanlar.AllowColumnReorder = True
        Me.lstwCalisanlar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstwCalisanlar.BackColor = System.Drawing.Color.LightGray
        Me.lstwCalisanlar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader5, Me.columnHeader6, Me.columnHeader4})
        Me.lstwCalisanlar.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwCalisanlar.FullRowSelect = True
        Me.lstwCalisanlar.GridLines = True
        Me.lstwCalisanlar.Location = New System.Drawing.Point(-6, 0)
        Me.lstwCalisanlar.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwCalisanlar.Name = "lstwCalisanlar"
        Me.lstwCalisanlar.Size = New System.Drawing.Size(1022, 667)
        Me.lstwCalisanlar.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstwCalisanlar.TabIndex = 10
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
        Me.columnHeader2.Width = 120
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Soyad"
        Me.columnHeader3.Width = 134
        '
        'columnHeader5
        '
        Me.columnHeader5.DisplayIndex = 4
        Me.columnHeader5.Text = "Telefon"
        Me.columnHeader5.Width = 155
        '
        'columnHeader6
        '
        Me.columnHeader6.DisplayIndex = 5
        Me.columnHeader6.Text = "EPosta"
        Me.columnHeader6.Width = 174
        '
        'columnHeader4
        '
        Me.columnHeader4.DisplayIndex = 3
        Me.columnHeader4.Text = "Cinsiyet"
        Me.columnHeader4.Width = 138
        '
        'MusterilerListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 696)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.lstwCalisanlar)
        Me.Name = "MusterilerListele"
        Me.Text = "MusterilerListele"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
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
End Class
