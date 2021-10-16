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
        Me.btnCalisanSil = New System.Windows.Forms.Button()
        Me.dgwCalisan = New System.Windows.Forms.DataGridView()
        CType(Me.dgwCalisan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalisanSil
        '
        Me.btnCalisanSil.BackColor = System.Drawing.Color.Brown
        Me.btnCalisanSil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCalisanSil.ForeColor = System.Drawing.Color.Coral
        Me.btnCalisanSil.Location = New System.Drawing.Point(65, 547)
        Me.btnCalisanSil.Name = "btnCalisanSil"
        Me.btnCalisanSil.Size = New System.Drawing.Size(1359, 50)
        Me.btnCalisanSil.TabIndex = 5
        Me.btnCalisanSil.Text = "Müşteri Sil"
        Me.btnCalisanSil.UseVisualStyleBackColor = False
        '
        'dgwCalisan
        '
        Me.dgwCalisan.BackgroundColor = System.Drawing.Color.Coral
        Me.dgwCalisan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgwCalisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwCalisan.Location = New System.Drawing.Point(65, 27)
        Me.dgwCalisan.Name = "dgwCalisan"
        Me.dgwCalisan.RowTemplate.Height = 24
        Me.dgwCalisan.Size = New System.Drawing.Size(1359, 488)
        Me.dgwCalisan.TabIndex = 4
        '
        'MusteriSil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1513, 684)
        Me.Controls.Add(Me.btnCalisanSil)
        Me.Controls.Add(Me.dgwCalisan)
        Me.Name = "MusteriSil"
        Me.Text = "MusteriSil"
        CType(Me.dgwCalisan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalisanSil As Button
    Friend WithEvents dgwCalisan As DataGridView
End Class
