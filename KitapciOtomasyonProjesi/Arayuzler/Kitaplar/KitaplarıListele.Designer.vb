<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitaplarıListele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KitaplarıListele))
        Me.dgwKitaplar = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.dgwKitaplar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwKitaplar
        '
        Me.dgwKitaplar.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwKitaplar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwKitaplar.GridColor = System.Drawing.Color.Black
        Me.dgwKitaplar.Location = New System.Drawing.Point(0, 0)
        Me.dgwKitaplar.Name = "dgwKitaplar"
        Me.dgwKitaplar.RowTemplate.Height = 24
        Me.dgwKitaplar.Size = New System.Drawing.Size(775, 615)
        Me.dgwKitaplar.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 593)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(775, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'KitaplarıListele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 615)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgwKitaplar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KitaplarıListele"
        Me.Text = "Kitapları Listele"
        CType(Me.dgwKitaplar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgwKitaplar As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
