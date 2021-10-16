<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYoneticiGirisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYoneticiGirisi))
        Me.gbYoneticiGiris = New System.Windows.Forms.GroupBox()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.txtYoneticiSifresi = New System.Windows.Forms.TextBox()
        Me.txtYoneticiAdi = New System.Windows.Forms.TextBox()
        Me.lblYoneticiSifresi = New System.Windows.Forms.Label()
        Me.lblYoneticiAdi = New System.Windows.Forms.Label()
        Me.pbResim = New System.Windows.Forms.PictureBox()
        Me.gbYoneticiGiris.SuspendLayout()
        CType(Me.pbResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbYoneticiGiris
        '
        Me.gbYoneticiGiris.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbYoneticiGiris.Controls.Add(Me.btnGiris)
        Me.gbYoneticiGiris.Controls.Add(Me.btnCikis)
        Me.gbYoneticiGiris.Controls.Add(Me.txtYoneticiSifresi)
        Me.gbYoneticiGiris.Controls.Add(Me.txtYoneticiAdi)
        Me.gbYoneticiGiris.Controls.Add(Me.lblYoneticiSifresi)
        Me.gbYoneticiGiris.Controls.Add(Me.lblYoneticiAdi)
        Me.gbYoneticiGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.gbYoneticiGiris.ForeColor = System.Drawing.Color.Black
        Me.gbYoneticiGiris.Location = New System.Drawing.Point(327, 13)
        Me.gbYoneticiGiris.Margin = New System.Windows.Forms.Padding(4)
        Me.gbYoneticiGiris.Name = "gbYoneticiGiris"
        Me.gbYoneticiGiris.Padding = New System.Windows.Forms.Padding(4)
        Me.gbYoneticiGiris.Size = New System.Drawing.Size(653, 288)
        Me.gbYoneticiGiris.TabIndex = 5
        Me.gbYoneticiGiris.TabStop = False
        Me.gbYoneticiGiris.Text = "Yönetici Girişi"
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGiris.ForeColor = System.Drawing.Color.Black
        Me.btnGiris.Location = New System.Drawing.Point(379, 201)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(147, 54)
        Me.btnGiris.TabIndex = 3
        Me.btnGiris.Text = "GİRİŞ"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCikis.ForeColor = System.Drawing.Color.Black
        Me.btnCikis.Location = New System.Drawing.Point(157, 201)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(153, 54)
        Me.btnCikis.TabIndex = 2
        Me.btnCikis.Text = "KAPAT"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'txtYoneticiSifresi
        '
        Me.txtYoneticiSifresi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYoneticiSifresi.ForeColor = System.Drawing.Color.Black
        Me.txtYoneticiSifresi.Location = New System.Drawing.Point(255, 129)
        Me.txtYoneticiSifresi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYoneticiSifresi.Name = "txtYoneticiSifresi"
        Me.txtYoneticiSifresi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtYoneticiSifresi.Size = New System.Drawing.Size(370, 36)
        Me.txtYoneticiSifresi.TabIndex = 1
        '
        'txtYoneticiAdi
        '
        Me.txtYoneticiAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtYoneticiAdi.ForeColor = System.Drawing.Color.Black
        Me.txtYoneticiAdi.Location = New System.Drawing.Point(255, 70)
        Me.txtYoneticiAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtYoneticiAdi.Name = "txtYoneticiAdi"
        Me.txtYoneticiAdi.Size = New System.Drawing.Size(370, 36)
        Me.txtYoneticiAdi.TabIndex = 0
        '
        'lblYoneticiSifresi
        '
        Me.lblYoneticiSifresi.AutoSize = True
        Me.lblYoneticiSifresi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYoneticiSifresi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYoneticiSifresi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblYoneticiSifresi.ForeColor = System.Drawing.Color.Black
        Me.lblYoneticiSifresi.Location = New System.Drawing.Point(35, 134)
        Me.lblYoneticiSifresi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYoneticiSifresi.Name = "lblYoneticiSifresi"
        Me.lblYoneticiSifresi.Size = New System.Drawing.Size(183, 31)
        Me.lblYoneticiSifresi.TabIndex = 0
        Me.lblYoneticiSifresi.Text = "&Yönetici Şifresi"
        '
        'lblYoneticiAdi
        '
        Me.lblYoneticiAdi.AutoSize = True
        Me.lblYoneticiAdi.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYoneticiAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYoneticiAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblYoneticiAdi.ForeColor = System.Drawing.Color.Black
        Me.lblYoneticiAdi.Location = New System.Drawing.Point(35, 73)
        Me.lblYoneticiAdi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYoneticiAdi.Name = "lblYoneticiAdi"
        Me.lblYoneticiAdi.Size = New System.Drawing.Size(156, 31)
        Me.lblYoneticiAdi.TabIndex = 0
        Me.lblYoneticiAdi.Text = "&Yönetici Adı "
        '
        'pbResim
        '
        Me.pbResim.BackColor = System.Drawing.Color.Gainsboro
        Me.pbResim.Image = Global.KitapciOtomasyonProjesi.My.Resources.Resources.if_Global_manager_131490
        Me.pbResim.Location = New System.Drawing.Point(13, 13)
        Me.pbResim.Margin = New System.Windows.Forms.Padding(4)
        Me.pbResim.Name = "pbResim"
        Me.pbResim.Size = New System.Drawing.Size(292, 288)
        Me.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbResim.TabIndex = 4
        Me.pbResim.TabStop = False
        '
        'frmYoneticiGirisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(995, 314)
        Me.Controls.Add(Me.gbYoneticiGiris)
        Me.Controls.Add(Me.pbResim)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmYoneticiGirisi"
        Me.Text = "Yönetici Girişi"
        Me.gbYoneticiGiris.ResumeLayout(False)
        Me.gbYoneticiGiris.PerformLayout()
        CType(Me.pbResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents gbYoneticiGiris As GroupBox
    Private WithEvents txtYoneticiSifresi As TextBox
    Private WithEvents txtYoneticiAdi As TextBox
    Private WithEvents lblYoneticiSifresi As Label
    Private WithEvents lblYoneticiAdi As Label
    Private WithEvents pbResim As PictureBox
    Friend WithEvents btnGiris As Button
    Friend WithEvents btnCikis As Button
End Class
