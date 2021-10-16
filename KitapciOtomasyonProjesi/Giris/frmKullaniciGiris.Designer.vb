<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKullaniciGiris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKullaniciGiris))
        Me.pbResim = New System.Windows.Forms.PictureBox()
        Me.gbKullaniciGiris = New System.Windows.Forms.GroupBox()
        Me.txtKullaniciSifresi = New System.Windows.Forms.TextBox()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.lblKullaniciSifresi = New System.Windows.Forms.Label()
        Me.lblKullaniciAdi = New System.Windows.Forms.Label()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        CType(Me.pbResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbKullaniciGiris.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbResim
        '
        Me.pbResim.BackColor = System.Drawing.Color.Gainsboro
        Me.pbResim.Image = Global.KitapciOtomasyonProjesi.My.Resources.Resources.if_preferences_desktop_user_password_24269
        Me.pbResim.Location = New System.Drawing.Point(12, 12)
        Me.pbResim.Name = "pbResim"
        Me.pbResim.Size = New System.Drawing.Size(280, 281)
        Me.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbResim.TabIndex = 0
        Me.pbResim.TabStop = False
        '
        'gbKullaniciGiris
        '
        Me.gbKullaniciGiris.Controls.Add(Me.txtKullaniciSifresi)
        Me.gbKullaniciGiris.Controls.Add(Me.txtKullaniciAdi)
        Me.gbKullaniciGiris.Controls.Add(Me.lblKullaniciSifresi)
        Me.gbKullaniciGiris.Controls.Add(Me.lblKullaniciAdi)
        Me.gbKullaniciGiris.Controls.Add(Me.btnGiris)
        Me.gbKullaniciGiris.Controls.Add(Me.btnCikis)
        Me.gbKullaniciGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbKullaniciGiris.ForeColor = System.Drawing.Color.Black
        Me.gbKullaniciGiris.Location = New System.Drawing.Point(312, 12)
        Me.gbKullaniciGiris.Name = "gbKullaniciGiris"
        Me.gbKullaniciGiris.Size = New System.Drawing.Size(667, 281)
        Me.gbKullaniciGiris.TabIndex = 1
        Me.gbKullaniciGiris.TabStop = False
        Me.gbKullaniciGiris.Text = "Kullanıcı Girişi"
        '
        'txtKullaniciSifresi
        '
        Me.txtKullaniciSifresi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKullaniciSifresi.Location = New System.Drawing.Point(277, 128)
        Me.txtKullaniciSifresi.Name = "txtKullaniciSifresi"
        Me.txtKullaniciSifresi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKullaniciSifresi.Size = New System.Drawing.Size(365, 36)
        Me.txtKullaniciSifresi.TabIndex = 5
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(277, 62)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(365, 36)
        Me.txtKullaniciAdi.TabIndex = 4
        '
        'lblKullaniciSifresi
        '
        Me.lblKullaniciSifresi.AutoSize = True
        Me.lblKullaniciSifresi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKullaniciSifresi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKullaniciSifresi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblKullaniciSifresi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKullaniciSifresi.Location = New System.Drawing.Point(44, 131)
        Me.lblKullaniciSifresi.Name = "lblKullaniciSifresi"
        Me.lblKullaniciSifresi.Size = New System.Drawing.Size(189, 31)
        Me.lblKullaniciSifresi.TabIndex = 3
        Me.lblKullaniciSifresi.Text = "&Kullanıcı Şifresi"
        '
        'lblKullaniciAdi
        '
        Me.lblKullaniciAdi.AutoSize = True
        Me.lblKullaniciAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKullaniciAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblKullaniciAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKullaniciAdi.Location = New System.Drawing.Point(44, 67)
        Me.lblKullaniciAdi.Name = "lblKullaniciAdi"
        Me.lblKullaniciAdi.Size = New System.Drawing.Size(155, 31)
        Me.lblKullaniciAdi.TabIndex = 2
        Me.lblKullaniciAdi.Text = "&Kullanıcı Adı"
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiris.Location = New System.Drawing.Point(395, 198)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(191, 55)
        Me.btnGiris.TabIndex = 1
        Me.btnGiris.Text = "GİRİŞ"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCikis.Location = New System.Drawing.Point(101, 198)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(197, 55)
        Me.btnCikis.TabIndex = 0
        Me.btnCikis.Text = "KAPAT"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'frmKullaniciGiris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(997, 310)
        Me.Controls.Add(Me.gbKullaniciGiris)
        Me.Controls.Add(Me.pbResim)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKullaniciGiris"
        Me.Text = "Kullanıcı Girişi"
        CType(Me.pbResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbKullaniciGiris.ResumeLayout(False)
        Me.gbKullaniciGiris.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbResim As PictureBox
    Friend WithEvents gbKullaniciGiris As GroupBox
    Friend WithEvents txtKullaniciSifresi As TextBox
    Friend WithEvents txtKullaniciAdi As TextBox
    Friend WithEvents lblKullaniciSifresi As Label
    Friend WithEvents lblKullaniciAdi As Label
    Friend WithEvents btnGiris As Button
    Friend WithEvents btnCikis As Button
End Class
