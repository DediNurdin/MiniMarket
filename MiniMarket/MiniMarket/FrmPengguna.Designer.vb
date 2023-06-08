<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPengguna))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KdPenggunaTxt = New System.Windows.Forms.TextBox()
        Me.NmPenggunaTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.UlgPassword = New System.Windows.Forms.TextBox()
        Me.LevelCbo = New System.Windows.Forms.ComboBox()
        Me.DGPengguna = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.CariNmPengguna = New System.Windows.Forms.RadioButton()
        Me.CariKdPengguna = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        CType(Me.DGPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pengguna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pengguna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ulangi Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Level"
        '
        'KdPenggunaTxt
        '
        Me.KdPenggunaTxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.KdPenggunaTxt.ForeColor = System.Drawing.Color.Black
        Me.KdPenggunaTxt.Location = New System.Drawing.Point(198, 93)
        Me.KdPenggunaTxt.Name = "KdPenggunaTxt"
        Me.KdPenggunaTxt.Size = New System.Drawing.Size(384, 26)
        Me.KdPenggunaTxt.TabIndex = 5
        '
        'NmPenggunaTxt
        '
        Me.NmPenggunaTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.NmPenggunaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NmPenggunaTxt.Location = New System.Drawing.Point(199, 130)
        Me.NmPenggunaTxt.Name = "NmPenggunaTxt"
        Me.NmPenggunaTxt.Size = New System.Drawing.Size(383, 26)
        Me.NmPenggunaTxt.TabIndex = 6
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.ForeColor = System.Drawing.Color.DimGray
        Me.PasswordTxt.Location = New System.Drawing.Point(199, 168)
        Me.PasswordTxt.Multiline = True
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.PasswordTxt.Size = New System.Drawing.Size(347, 26)
        Me.PasswordTxt.TabIndex = 7
        Me.PasswordTxt.Text = "Masukan Password"
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'UlgPassword
        '
        Me.UlgPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.UlgPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UlgPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UlgPassword.ForeColor = System.Drawing.Color.DimGray
        Me.UlgPassword.Location = New System.Drawing.Point(199, 204)
        Me.UlgPassword.Multiline = True
        Me.UlgPassword.Name = "UlgPassword"
        Me.UlgPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.UlgPassword.Size = New System.Drawing.Size(347, 26)
        Me.UlgPassword.TabIndex = 8
        Me.UlgPassword.Text = "Ulangi Password Anda"
        Me.UlgPassword.UseSystemPasswordChar = True
        '
        'LevelCbo
        '
        Me.LevelCbo.BackColor = System.Drawing.Color.Gainsboro
        Me.LevelCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LevelCbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LevelCbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelCbo.FormattingEnabled = True
        Me.LevelCbo.Location = New System.Drawing.Point(198, 239)
        Me.LevelCbo.Name = "LevelCbo"
        Me.LevelCbo.Size = New System.Drawing.Size(383, 28)
        Me.LevelCbo.TabIndex = 9
        '
        'DGPengguna
        '
        Me.DGPengguna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPengguna.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGPengguna.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPengguna.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.DGPengguna.Location = New System.Drawing.Point(710, 93)
        Me.DGPengguna.Name = "DGPengguna"
        Me.DGPengguna.RowTemplate.Height = 28
        Me.DGPengguna.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGPengguna.Size = New System.Drawing.Size(373, 449)
        Me.DGPengguna.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bebas Neue", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1111, 62)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Input Data Pengguna"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TutupBtn
        '
        Me.TutupBtn.FlatAppearance.BorderSize = 0
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.Location = New System.Drawing.Point(495, 304)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(87, 77)
        Me.TutupBtn.TabIndex = 14
        Me.TutupBtn.Text = "  Tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.Location = New System.Drawing.Point(402, 304)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(87, 77)
        Me.BatalBtn.TabIndex = 13
        Me.BatalBtn.Text = "  Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.FlatAppearance.BorderSize = 0
        Me.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HapusBtn.Image = CType(resources.GetObject("HapusBtn.Image"), System.Drawing.Image)
        Me.HapusBtn.Location = New System.Drawing.Point(309, 304)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(87, 77)
        Me.HapusBtn.TabIndex = 12
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.FlatAppearance.BorderSize = 0
        Me.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UbahBtn.Image = CType(resources.GetObject("UbahBtn.Image"), System.Drawing.Image)
        Me.UbahBtn.Location = New System.Drawing.Point(211, 304)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(87, 77)
        Me.UbahBtn.TabIndex = 11
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.FlatAppearance.BorderSize = 0
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.Location = New System.Drawing.Point(112, 304)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(87, 77)
        Me.SimpanBtn.TabIndex = 10
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1111, 62)
        Me.Panel1.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiniMarket.My.Resources.Resources.man
        Me.PictureBox1.Location = New System.Drawing.Point(377, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariNmPengguna)
        Me.GroupBox1.Controls.Add(Me.CariKdPengguna)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(36, 407)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 117)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariDataTxt
        '
        Me.CariDataTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.CariDataTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CariDataTxt.Location = New System.Drawing.Point(353, 49)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(240, 26)
        Me.CariDataTxt.TabIndex = 3
        '
        'CariNmPengguna
        '
        Me.CariNmPengguna.AutoSize = True
        Me.CariNmPengguna.BackColor = System.Drawing.Color.OldLace
        Me.CariNmPengguna.Location = New System.Drawing.Point(169, 49)
        Me.CariNmPengguna.Name = "CariNmPengguna"
        Me.CariNmPengguna.Size = New System.Drawing.Size(153, 24)
        Me.CariNmPengguna.TabIndex = 1
        Me.CariNmPengguna.TabStop = True
        Me.CariNmPengguna.Text = "Nama Pengguna"
        Me.CariNmPengguna.UseVisualStyleBackColor = False
        '
        'CariKdPengguna
        '
        Me.CariKdPengguna.AutoSize = True
        Me.CariKdPengguna.BackColor = System.Drawing.Color.OldLace
        Me.CariKdPengguna.Location = New System.Drawing.Point(17, 47)
        Me.CariKdPengguna.Name = "CariKdPengguna"
        Me.CariKdPengguna.Size = New System.Drawing.Size(148, 24)
        Me.CariKdPengguna.TabIndex = 0
        Me.CariKdPengguna.TabStop = True
        Me.CariKdPengguna.Text = "Kode Pengguna"
        Me.CariKdPengguna.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.Color.OldLace
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.OldLace
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Mongolian Baiti", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Image = CType(resources.GetObject("CheckBox1.Image"), System.Drawing.Image)
        Me.CheckBox1.Location = New System.Drawing.Point(544, 168)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 26)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.BackColor = System.Drawing.Color.OldLace
        Me.CheckBox2.FlatAppearance.BorderSize = 0
        Me.CheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.OldLace
        Me.CheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.CheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Mongolian Baiti", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Image = CType(resources.GetObject("CheckBox2.Image"), System.Drawing.Image)
        Me.CheckBox2.Location = New System.Drawing.Point(544, 204)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(51, 26)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'FrmPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1111, 586)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGPengguna)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.LevelCbo)
        Me.Controls.Add(Me.UlgPassword)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.NmPenggunaTxt)
        Me.Controls.Add(Me.KdPenggunaTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPengguna"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pengguna"
        Me.TopMost = True
        CType(Me.DGPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KdPenggunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmPenggunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents UlgPassword As System.Windows.Forms.TextBox
    Friend WithEvents LevelCbo As System.Windows.Forms.ComboBox
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents DGPengguna As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents CariNmPengguna As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdPengguna As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
