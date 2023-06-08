<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHakAkses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHakAkses))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbLevel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkPengguna = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkPelanggan = New System.Windows.Forms.CheckBox()
        Me.ChkSupplier = New System.Windows.Forms.CheckBox()
        Me.ChkBarang = New System.Windows.Forms.CheckBox()
        Me.ChkSatuan = New System.Windows.Forms.CheckBox()
        Me.ChkJenis = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkPenjualan = New System.Windows.Forms.CheckBox()
        Me.ChkPembelian = New System.Windows.Forms.CheckBox()
        Me.ChkAkses = New System.Windows.Forms.CheckBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Level  :"
        '
        'CmbLevel
        '
        Me.CmbLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbLevel.BackColor = System.Drawing.Color.LightGray
        Me.CmbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbLevel.FormattingEnabled = True
        Me.CmbLevel.Location = New System.Drawing.Point(107, 93)
        Me.CmbLevel.Name = "CmbLevel"
        Me.CmbLevel.Size = New System.Drawing.Size(201, 28)
        Me.CmbLevel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.OldLace
        Me.GroupBox1.Controls.Add(Me.ChkPengguna)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 134)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sistem"
        '
        'ChkPengguna
        '
        Me.ChkPengguna.AutoSize = True
        Me.ChkPengguna.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkPengguna.Location = New System.Drawing.Point(48, 61)
        Me.ChkPengguna.Name = "ChkPengguna"
        Me.ChkPengguna.Size = New System.Drawing.Size(107, 25)
        Me.ChkPengguna.TabIndex = 0
        Me.ChkPengguna.Text = "Pengguna"
        Me.ChkPengguna.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.ChkPelanggan)
        Me.GroupBox2.Controls.Add(Me.ChkSupplier)
        Me.GroupBox2.Controls.Add(Me.ChkBarang)
        Me.GroupBox2.Controls.Add(Me.ChkSatuan)
        Me.GroupBox2.Controls.Add(Me.ChkJenis)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 290)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Master Data"
        '
        'ChkPelanggan
        '
        Me.ChkPelanggan.AutoSize = True
        Me.ChkPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkPelanggan.Location = New System.Drawing.Point(48, 236)
        Me.ChkPelanggan.Name = "ChkPelanggan"
        Me.ChkPelanggan.Size = New System.Drawing.Size(110, 25)
        Me.ChkPelanggan.TabIndex = 4
        Me.ChkPelanggan.Text = "Pelanggan"
        Me.ChkPelanggan.UseVisualStyleBackColor = True
        '
        'ChkSupplier
        '
        Me.ChkSupplier.AutoSize = True
        Me.ChkSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkSupplier.Location = New System.Drawing.Point(48, 193)
        Me.ChkSupplier.Name = "ChkSupplier"
        Me.ChkSupplier.Size = New System.Drawing.Size(92, 25)
        Me.ChkSupplier.TabIndex = 3
        Me.ChkSupplier.Text = "Supplier"
        Me.ChkSupplier.UseVisualStyleBackColor = True
        '
        'ChkBarang
        '
        Me.ChkBarang.AutoSize = True
        Me.ChkBarang.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkBarang.Location = New System.Drawing.Point(48, 150)
        Me.ChkBarang.Name = "ChkBarang"
        Me.ChkBarang.Size = New System.Drawing.Size(86, 25)
        Me.ChkBarang.TabIndex = 2
        Me.ChkBarang.Text = "Barang"
        Me.ChkBarang.UseVisualStyleBackColor = True
        '
        'ChkSatuan
        '
        Me.ChkSatuan.AutoSize = True
        Me.ChkSatuan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkSatuan.Location = New System.Drawing.Point(48, 77)
        Me.ChkSatuan.Name = "ChkSatuan"
        Me.ChkSatuan.Size = New System.Drawing.Size(86, 25)
        Me.ChkSatuan.TabIndex = 1
        Me.ChkSatuan.Text = "Satuan"
        Me.ChkSatuan.UseVisualStyleBackColor = True
        '
        'ChkJenis
        '
        Me.ChkJenis.AutoSize = True
        Me.ChkJenis.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkJenis.Location = New System.Drawing.Point(48, 36)
        Me.ChkJenis.Name = "ChkJenis"
        Me.ChkJenis.Size = New System.Drawing.Size(127, 25)
        Me.ChkJenis.TabIndex = 0
        Me.ChkJenis.Text = "Jenis Barang"
        Me.ChkJenis.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.ChkPenjualan)
        Me.GroupBox3.Controls.Add(Me.ChkPembelian)
        Me.GroupBox3.Location = New System.Drawing.Point(366, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(277, 134)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaksi"
        '
        'ChkPenjualan
        '
        Me.ChkPenjualan.AutoSize = True
        Me.ChkPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkPenjualan.Location = New System.Drawing.Point(43, 87)
        Me.ChkPenjualan.Name = "ChkPenjualan"
        Me.ChkPenjualan.Size = New System.Drawing.Size(156, 25)
        Me.ChkPenjualan.TabIndex = 1
        Me.ChkPenjualan.Text = "Penjualan - Kasir "
        Me.ChkPenjualan.UseVisualStyleBackColor = True
        '
        'ChkPembelian
        '
        Me.ChkPembelian.AutoSize = True
        Me.ChkPembelian.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChkPembelian.Location = New System.Drawing.Point(43, 36)
        Me.ChkPembelian.Name = "ChkPembelian"
        Me.ChkPembelian.Size = New System.Drawing.Size(108, 25)
        Me.ChkPembelian.TabIndex = 0
        Me.ChkPembelian.Text = "Pembelian"
        Me.ChkPembelian.UseVisualStyleBackColor = True
        '
        'ChkAkses
        '
        Me.ChkAkses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkAkses.AutoSize = True
        Me.ChkAkses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAkses.ForeColor = System.Drawing.Color.Red
        Me.ChkAkses.Location = New System.Drawing.Point(409, 352)
        Me.ChkAkses.Name = "ChkAkses"
        Me.ChkAkses.Size = New System.Drawing.Size(112, 24)
        Me.ChkAkses.TabIndex = 5
        Me.ChkAkses.Text = "Hak Akses"
        Me.ChkAkses.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OkBtn.FlatAppearance.BorderSize = 0
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkBtn.Image = CType(resources.GetObject("OkBtn.Image"), System.Drawing.Image)
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OkBtn.Location = New System.Drawing.Point(423, 475)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(106, 55)
        Me.OkBtn.TabIndex = 6
        Me.OkBtn.Text = "OK"
        Me.OkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bebas Neue", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-127, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(935, 62)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hak Akses Pengguna"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 62)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiniMarket.My.Resources.Resources.check
        Me.PictureBox1.Location = New System.Drawing.Point(169, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FrmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(681, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.ChkAkses)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbLevel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHakAkses"
        Me.Text = "Hak Akses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPengguna As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPelanggan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBarang As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSatuan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkJenis As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAkses As System.Windows.Forms.CheckBox
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
