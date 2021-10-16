<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MusterileriListele
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusterileriListele))
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabelVeriler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstwMusteriler = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusStrip1
        '
        Me.statusStrip1.BackColor = System.Drawing.Color.White
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabelVeriler})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 680)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.statusStrip1.Size = New System.Drawing.Size(896, 24)
        Me.statusStrip1.TabIndex = 9
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabelVeriler
        '
        Me.toolStripStatusLabelVeriler.Name = "toolStripStatusLabelVeriler"
        Me.toolStripStatusLabelVeriler.Size = New System.Drawing.Size(0, 19)
        '
        'lstwMusteriler
        '
        Me.lstwMusteriler.AllowColumnReorder = True
        Me.lstwMusteriler.BackColor = System.Drawing.Color.Gainsboro
        Me.lstwMusteriler.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4, Me.columnHeader5, Me.columnHeader6})
        Me.lstwMusteriler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstwMusteriler.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstwMusteriler.ForeColor = System.Drawing.Color.Black
        Me.lstwMusteriler.FullRowSelect = True
        Me.lstwMusteriler.GridLines = True
        Me.lstwMusteriler.Location = New System.Drawing.Point(0, 0)
        Me.lstwMusteriler.Margin = New System.Windows.Forms.Padding(4)
        Me.lstwMusteriler.Name = "lstwMusteriler"
        Me.lstwMusteriler.Size = New System.Drawing.Size(896, 704)
        Me.lstwMusteriler.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstwMusteriler.TabIndex = 10
        Me.lstwMusteriler.UseCompatibleStateImageBehavior = False
        Me.lstwMusteriler.View = System.Windows.Forms.View.Details
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
        'columnHeader4
        '
        Me.columnHeader4.Text = "Telefon"
        Me.columnHeader4.Width = 155
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "E-posta"
        Me.columnHeader5.Width = 258
        '
        'columnHeader6
        '
        Me.columnHeader6.Text = "Cinsiyet"
        Me.columnHeader6.Width = 147
        '
        'MusterileriListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(896, 704)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.lstwMusteriler)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MusterileriListele"
        Me.Text = "Müşterileri Listele"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents toolStripStatusLabelVeriler As ToolStripStatusLabel
    Private WithEvents lstwMusteriler As ListView
    Private WithEvents columnHeader1 As ColumnHeader
    Private WithEvents columnHeader2 As ColumnHeader
    Private WithEvents columnHeader3 As ColumnHeader
    Private WithEvents columnHeader6 As ColumnHeader
    Private WithEvents columnHeader4 As ColumnHeader
    Private WithEvents columnHeader5 As ColumnHeader
End Class
