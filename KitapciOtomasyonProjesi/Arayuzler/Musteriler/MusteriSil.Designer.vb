<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusteriSil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusteriSil))
        Me.btnMusteriSil = New System.Windows.Forms.Button()
        Me.dgwMusteri = New System.Windows.Forms.DataGridView()
        CType(Me.dgwMusteri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMusteriSil
        '
        Me.btnMusteriSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMusteriSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnMusteriSil.ForeColor = System.Drawing.Color.Black
        Me.btnMusteriSil.Location = New System.Drawing.Point(12, 517)
        Me.btnMusteriSil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMusteriSil.Name = "btnMusteriSil"
        Me.btnMusteriSil.Size = New System.Drawing.Size(872, 50)
        Me.btnMusteriSil.TabIndex = 5
        Me.btnMusteriSil.Text = "Müşteri Sil"
        Me.btnMusteriSil.UseVisualStyleBackColor = False
        '
        'dgwMusteri
        '
        Me.dgwMusteri.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwMusteri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgwMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwMusteri.GridColor = System.Drawing.Color.Black
        Me.dgwMusteri.Location = New System.Drawing.Point(12, 11)
        Me.dgwMusteri.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgwMusteri.Name = "dgwMusteri"
        Me.dgwMusteri.RowTemplate.Height = 24
        Me.dgwMusteri.Size = New System.Drawing.Size(872, 487)
        Me.dgwMusteri.TabIndex = 4
        '
        'MusteriSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(893, 578)
        Me.Controls.Add(Me.btnMusteriSil)
        Me.Controls.Add(Me.dgwMusteri)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MusteriSil"
        Me.Text = "Müşteri Silme"
        CType(Me.dgwMusteri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMusteriSil As Button
    Friend WithEvents dgwMusteri As DataGridView
End Class
