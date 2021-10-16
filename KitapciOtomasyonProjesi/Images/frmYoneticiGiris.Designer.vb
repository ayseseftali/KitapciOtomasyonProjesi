<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYoneticiGiris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbYoneticiResim = New System.Windows.Forms.PictureBox()
        Me.gbYoneticiGirisi = New System.Windows.Forms.GroupBox()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.txtYoneticiSifresi = New System.Windows.Forms.TextBox()
        Me.txtYoneticiAdi = New System.Windows.Forms.TextBox()
        Me.lblYoneticiSifresi = New System.Windows.Forms.Label()
        Me.lblYoneticiAdi = New System.Windows.Forms.Label()
        CType(Me.pbYoneticiResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbYoneticiGirisi.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbYoneticiResim
        '
        Me.pbYoneticiResim.BackColor = System.Drawing.Color.LemonChiffon
        Me.pbYoneticiResim.Image = Global.KitapciOtomasyonProjesi.My.Resources.Resources.if_Global_manager_131490
        Me.pbYoneticiResim.Location = New System.Drawing.Point(12, 72)
        Me.pbYoneticiResim.Name = "pbYoneticiResim"
        Me.pbYoneticiResim.Size = New System.Drawing.Size(244, 259)
        Me.pbYoneticiResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbYoneticiResim.TabIndex = 0
        Me.pbYoneticiResim.TabStop = False
        '
        'gbYoneticiGirisi
        '
        Me.gbYoneticiGirisi.BackColor = System.Drawing.Color.Thistle
        Me.gbYoneticiGirisi.Controls.Add(Me.btnGiris)
        Me.gbYoneticiGirisi.Controls.Add(Me.btnCikis)
        Me.gbYoneticiGirisi.Controls.Add(Me.txtYoneticiSifresi)
        Me.gbYoneticiGirisi.Controls.Add(Me.txtYoneticiAdi)
        Me.gbYoneticiGirisi.Controls.Add(Me.lblYoneticiSifresi)
        Me.gbYoneticiGirisi.Controls.Add(Me.lblYoneticiAdi)
        Me.gbYoneticiGirisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbYoneticiGirisi.ForeColor = System.Drawing.SystemColors.Window
        Me.gbYoneticiGirisi.Location = New System.Drawing.Point(289, 72)
        Me.gbYoneticiGirisi.Name = "gbYoneticiGirisi"
        Me.gbYoneticiGirisi.Size = New System.Drawing.Size(391, 259)
        Me.gbYoneticiGirisi.TabIndex = 1
        Me.gbYoneticiGirisi.TabStop = False
        Me.gbYoneticiGirisi.Text = "Yönetici Girişi"
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.DarkCyan
        Me.btnGiris.ForeColor = System.Drawing.SystemColors.Window
        Me.btnGiris.Location = New System.Drawing.Point(220, 189)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(99, 37)
        Me.btnGiris.TabIndex = 7
        Me.btnGiris.Text = "GİRİŞ"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.DarkCyan
        Me.btnCikis.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCikis.Location = New System.Drawing.Point(25, 189)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(108, 37)
        Me.btnCikis.TabIndex = 6
        Me.btnCikis.Text = "ÇIKIŞ"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'txtYoneticiSifresi
        '
        Me.txtYoneticiSifresi.Location = New System.Drawing.Point(200, 105)
        Me.txtYoneticiSifresi.Name = "txtYoneticiSifresi"
        Me.txtYoneticiSifresi.Size = New System.Drawing.Size(173, 34)
        Me.txtYoneticiSifresi.TabIndex = 5
        '
        'txtYoneticiAdi
        '
        Me.txtYoneticiAdi.Location = New System.Drawing.Point(200, 43)
        Me.txtYoneticiAdi.Name = "txtYoneticiAdi"
        Me.txtYoneticiAdi.Size = New System.Drawing.Size(173, 34)
        Me.txtYoneticiAdi.TabIndex = 4
        '
        'lblYoneticiSifresi
        '
        Me.lblYoneticiSifresi.AutoSize = True
        Me.lblYoneticiSifresi.BackColor = System.Drawing.Color.DarkCyan
        Me.lblYoneticiSifresi.ForeColor = System.Drawing.SystemColors.Window
        Me.lblYoneticiSifresi.Location = New System.Drawing.Point(20, 110)
        Me.lblYoneticiSifresi.Name = "lblYoneticiSifresi"
        Me.lblYoneticiSifresi.Size = New System.Drawing.Size(174, 29)
        Me.lblYoneticiSifresi.TabIndex = 3
        Me.lblYoneticiSifresi.Text = "&Yönetici Şifresi"
        '
        'lblYoneticiAdi
        '
        Me.lblYoneticiAdi.AutoSize = True
        Me.lblYoneticiAdi.BackColor = System.Drawing.Color.DarkCyan
        Me.lblYoneticiAdi.ForeColor = System.Drawing.SystemColors.Window
        Me.lblYoneticiAdi.Location = New System.Drawing.Point(20, 46)
        Me.lblYoneticiAdi.Name = "lblYoneticiAdi"
        Me.lblYoneticiAdi.Size = New System.Drawing.Size(141, 29)
        Me.lblYoneticiAdi.TabIndex = 2
        Me.lblYoneticiAdi.Text = "&Yönetici Adı"
        '
        'frmYoneticiGiris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(692, 422)
        Me.Controls.Add(Me.gbYoneticiGirisi)
        Me.Controls.Add(Me.pbYoneticiResim)
        Me.Name = "frmYoneticiGiris"
        Me.Text = "frmYoneticiGiris"
        CType(Me.pbYoneticiResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbYoneticiGirisi.ResumeLayout(False)
        Me.gbYoneticiGirisi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbYoneticiResim As PictureBox
    Friend WithEvents gbYoneticiGirisi As GroupBox
    Friend WithEvents txtYoneticiSifresi As TextBox
    Friend WithEvents txtYoneticiAdi As TextBox
    Friend WithEvents lblYoneticiSifresi As Label
    Friend WithEvents lblYoneticiAdi As Label
    Friend WithEvents btnGiris As Button
    Friend WithEvents btnCikis As Button
End Class
