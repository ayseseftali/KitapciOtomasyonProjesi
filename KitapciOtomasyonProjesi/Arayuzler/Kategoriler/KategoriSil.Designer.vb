<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KategoriSil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KategoriSil))
        Me.dgwKategoriler = New System.Windows.Forms.DataGridView()
        Me.btnKategoriSil = New System.Windows.Forms.Button()
        CType(Me.dgwKategoriler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwKategoriler
        '
        Me.dgwKategoriler.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwKategoriler.GridColor = System.Drawing.Color.Black
        Me.dgwKategoriler.Location = New System.Drawing.Point(12, 12)
        Me.dgwKategoriler.Name = "dgwKategoriler"
        Me.dgwKategoriler.RowTemplate.Height = 24
        Me.dgwKategoriler.Size = New System.Drawing.Size(324, 517)
        Me.dgwKategoriler.TabIndex = 0
        '
        'btnKategoriSil
        '
        Me.btnKategoriSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategoriSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKategoriSil.ForeColor = System.Drawing.Color.Black
        Me.btnKategoriSil.Location = New System.Drawing.Point(12, 546)
        Me.btnKategoriSil.Name = "btnKategoriSil"
        Me.btnKategoriSil.Size = New System.Drawing.Size(324, 61)
        Me.btnKategoriSil.TabIndex = 1
        Me.btnKategoriSil.Text = "Kategori Sil"
        Me.btnKategoriSil.UseVisualStyleBackColor = False
        '
        'KategoriSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(348, 620)
        Me.Controls.Add(Me.btnKategoriSil)
        Me.Controls.Add(Me.dgwKategoriler)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KategoriSil"
        Me.Text = "Kategori Silme"
        CType(Me.dgwKategoriler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgwKategoriler As DataGridView
    Friend WithEvents btnKategoriSil As Button
End Class
