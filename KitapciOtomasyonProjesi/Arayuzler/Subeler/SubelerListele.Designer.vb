<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubelerListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubelerListele))
        Me.dgwSubeler = New System.Windows.Forms.DataGridView()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabelVeriler = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgwSubeler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgwSubeler
        '
        Me.dgwSubeler.AllowUserToAddRows = False
        Me.dgwSubeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwSubeler.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwSubeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSubeler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwSubeler.GridColor = System.Drawing.Color.Black
        Me.dgwSubeler.Location = New System.Drawing.Point(0, 0)
        Me.dgwSubeler.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwSubeler.Name = "dgwSubeler"
        Me.dgwSubeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwSubeler.Size = New System.Drawing.Size(808, 429)
        Me.dgwSubeler.TabIndex = 11
        '
        'statusStrip1
        '
        Me.statusStrip1.BackColor = System.Drawing.Color.White
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabelVeriler})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 429)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.statusStrip1.Size = New System.Drawing.Size(808, 22)
        Me.statusStrip1.TabIndex = 10
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripStatusLabelVeriler
        '
        Me.toolStripStatusLabelVeriler.Name = "toolStripStatusLabelVeriler"
        Me.toolStripStatusLabelVeriler.Size = New System.Drawing.Size(0, 17)
        '
        'SubelerListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(808, 451)
        Me.Controls.Add(Me.dgwSubeler)
        Me.Controls.Add(Me.statusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SubelerListele"
        Me.Text = "Şubeleri Listeleme"
        CType(Me.dgwSubeler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dgwSubeler As DataGridView
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents toolStripStatusLabelVeriler As ToolStripStatusLabel
End Class
