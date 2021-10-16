<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YazarlarListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YazarlarListele))
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabelVeriler = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgwYazarlar = New System.Windows.Forms.DataGridView()
        Me.statusStrip1.SuspendLayout()
        CType(Me.dgwYazarlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusStrip1
        '
        Me.statusStrip1.BackColor = System.Drawing.Color.White
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabelVeriler})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 492)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.statusStrip1.Size = New System.Drawing.Size(896, 22)
        Me.statusStrip1.TabIndex = 14
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabelVeriler
        '
        Me.toolStripStatusLabelVeriler.Name = "toolStripStatusLabelVeriler"
        Me.toolStripStatusLabelVeriler.Size = New System.Drawing.Size(0, 17)
        '
        'dgwYazarlar
        '
        Me.dgwYazarlar.AllowUserToAddRows = False
        Me.dgwYazarlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwYazarlar.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwYazarlar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwYazarlar.GridColor = System.Drawing.Color.Black
        Me.dgwYazarlar.Location = New System.Drawing.Point(0, 0)
        Me.dgwYazarlar.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwYazarlar.Name = "dgwYazarlar"
        Me.dgwYazarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwYazarlar.Size = New System.Drawing.Size(896, 514)
        Me.dgwYazarlar.TabIndex = 15
        '
        'YazarlarListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(896, 514)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.dgwYazarlar)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "YazarlarListele"
        Me.Text = "Yazarları Listele"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        CType(Me.dgwYazarlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents toolStripStatusLabelVeriler As ToolStripStatusLabel
    Private WithEvents dgwYazarlar As DataGridView
End Class
