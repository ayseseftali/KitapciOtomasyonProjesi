<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalisanSil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalisanSil))
        Me.btnCalisanSil = New System.Windows.Forms.Button()
        Me.dgwCalisan = New System.Windows.Forms.DataGridView()
        CType(Me.dgwCalisan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalisanSil
        '
        Me.btnCalisanSil.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCalisanSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalisanSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCalisanSil.ForeColor = System.Drawing.Color.Black
        Me.btnCalisanSil.Location = New System.Drawing.Point(12, 516)
        Me.btnCalisanSil.Name = "btnCalisanSil"
        Me.btnCalisanSil.Size = New System.Drawing.Size(1469, 50)
        Me.btnCalisanSil.TabIndex = 3
        Me.btnCalisanSil.Text = "Çalışan Sil"
        Me.btnCalisanSil.UseVisualStyleBackColor = False
        '
        'dgwCalisan
        '
        Me.dgwCalisan.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgwCalisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwCalisan.GridColor = System.Drawing.Color.Black
        Me.dgwCalisan.Location = New System.Drawing.Point(12, 12)
        Me.dgwCalisan.Name = "dgwCalisan"
        Me.dgwCalisan.RowTemplate.Height = 24
        Me.dgwCalisan.Size = New System.Drawing.Size(1469, 488)
        Me.dgwCalisan.TabIndex = 2
        '
        'CalisanSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1497, 580)
        Me.Controls.Add(Me.btnCalisanSil)
        Me.Controls.Add(Me.dgwCalisan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CalisanSil"
        Me.Text = "Çalışan Silme"
        CType(Me.dgwCalisan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalisanSil As Button
    Friend WithEvents dgwCalisan As DataGridView
End Class
