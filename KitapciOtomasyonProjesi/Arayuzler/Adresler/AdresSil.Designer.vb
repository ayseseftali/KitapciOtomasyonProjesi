<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdresSil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdresSil))
        Me.dgwAdresler = New System.Windows.Forms.DataGridView()
        Me.btnAdresSil = New System.Windows.Forms.Button()
        CType(Me.dgwAdresler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwAdresler
        '
        Me.dgwAdresler.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwAdresler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAdresler.Location = New System.Drawing.Point(12, 12)
        Me.dgwAdresler.Name = "dgwAdresler"
        Me.dgwAdresler.RowTemplate.Height = 24
        Me.dgwAdresler.Size = New System.Drawing.Size(1359, 488)
        Me.dgwAdresler.TabIndex = 0
        '
        'btnAdresSil
        '
        Me.btnAdresSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAdresSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdresSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAdresSil.ForeColor = System.Drawing.Color.Black
        Me.btnAdresSil.Location = New System.Drawing.Point(12, 517)
        Me.btnAdresSil.Name = "btnAdresSil"
        Me.btnAdresSil.Size = New System.Drawing.Size(1359, 50)
        Me.btnAdresSil.TabIndex = 1
        Me.btnAdresSil.Text = "Adresi Sil"
        Me.btnAdresSil.UseVisualStyleBackColor = False
        '
        'AdresSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1383, 581)
        Me.Controls.Add(Me.btnAdresSil)
        Me.Controls.Add(Me.dgwAdresler)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdresSil"
        Me.Text = "Adres Silme"
        CType(Me.dgwAdresler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgwAdresler As DataGridView
    Friend WithEvents btnAdresSil As Button
End Class
