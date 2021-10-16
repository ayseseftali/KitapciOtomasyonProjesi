<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitapSil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KitapSil))
        Me.dgwKitaplar = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgwKitaplar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwKitaplar
        '
        Me.dgwKitaplar.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwKitaplar.GridColor = System.Drawing.Color.Black
        Me.dgwKitaplar.Location = New System.Drawing.Point(12, 12)
        Me.dgwKitaplar.Name = "dgwKitaplar"
        Me.dgwKitaplar.RowTemplate.Height = 24
        Me.dgwKitaplar.Size = New System.Drawing.Size(838, 561)
        Me.dgwKitaplar.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(12, 579)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(838, 50)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Kitapları Sil"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'KitapSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(862, 637)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgwKitaplar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KitapSil"
        Me.Text = "Kitap Silme"
        CType(Me.dgwKitaplar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgwKitaplar As DataGridView
    Friend WithEvents btnDelete As Button
End Class
