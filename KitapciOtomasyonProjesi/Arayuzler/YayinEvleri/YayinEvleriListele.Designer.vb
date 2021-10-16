<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YayinEvleriListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YayinEvleriListele))
        Me.toolStripStatusLabelVeriler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dgwYayinEvleri = New System.Windows.Forms.DataGridView()
        Me.statusStrip1.SuspendLayout()
        CType(Me.dgwYayinEvleri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolStripStatusLabelVeriler
        '
        Me.toolStripStatusLabelVeriler.Name = "toolStripStatusLabelVeriler"
        Me.toolStripStatusLabelVeriler.Size = New System.Drawing.Size(0, 17)
        '
        'statusStrip1
        '
        Me.statusStrip1.BackColor = System.Drawing.Color.White
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabelVeriler})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 542)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.statusStrip1.Size = New System.Drawing.Size(490, 22)
        Me.statusStrip1.TabIndex = 12
        Me.statusStrip1.Text = "statusStrip1"
        '
        'dgwYayinEvleri
        '
        Me.dgwYayinEvleri.AllowUserToAddRows = False
        Me.dgwYayinEvleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwYayinEvleri.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwYayinEvleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwYayinEvleri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwYayinEvleri.GridColor = System.Drawing.Color.Black
        Me.dgwYayinEvleri.Location = New System.Drawing.Point(0, 0)
        Me.dgwYayinEvleri.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwYayinEvleri.Name = "dgwYayinEvleri"
        Me.dgwYayinEvleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwYayinEvleri.Size = New System.Drawing.Size(490, 564)
        Me.dgwYayinEvleri.TabIndex = 13
        '
        'YayinEvleriListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 564)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.dgwYayinEvleri)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "YayinEvleriListele"
        Me.Text = "Yayın Evlerini Listele"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        CType(Me.dgwYayinEvleri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents toolStripStatusLabelVeriler As ToolStripStatusLabel
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents dgwYayinEvleri As DataGridView
End Class
