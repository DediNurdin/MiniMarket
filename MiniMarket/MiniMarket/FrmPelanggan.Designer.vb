<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPelanggan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KdPelangganTxt = New System.Windows.Forms.TextBox()
        Me.NmPelangganTxt = New System.Windows.Forms.TextBox()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.TlpTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.CariNmPelanggan = New System.Windows.Forms.RadioButton()
        Me.CariKdPelanggan = New System.Windows.Forms.RadioButton()
        Me.DGPelanggan = New System.Windows.Forms.DataGridView()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 62)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiniMarket.My.Resources.Resources.group
        Me.PictureBox1.Location = New System.Drawing.Point(334, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bebas Neue", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1021, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA PELANGGAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        '
        'KdPelangganTxt
        '
        Me.KdPelangganTxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.KdPelangganTxt.ForeColor = System.Drawing.Color.Red
        Me.KdPelangganTxt.Location = New System.Drawing.Point(187, 73)
        Me.KdPelangganTxt.Name = "KdPelangganTxt"
        Me.KdPelangganTxt.Size = New System.Drawing.Size(300, 26)
        Me.KdPelangganTxt.TabIndex = 5
        '
        'NmPelangganTxt
        '
        Me.NmPelangganTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.NmPelangganTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NmPelangganTxt.Location = New System.Drawing.Point(187, 110)
        Me.NmPelangganTxt.Name = "NmPelangganTxt"
        Me.NmPelangganTxt.Size = New System.Drawing.Size(300, 26)
        Me.NmPelangganTxt.TabIndex = 6
        '
        'AlmTxt
        '
        Me.AlmTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.AlmTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlmTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlmTxt.Location = New System.Drawing.Point(187, 185)
        Me.AlmTxt.Multiline = True
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AlmTxt.Size = New System.Drawing.Size(385, 63)
        Me.AlmTxt.TabIndex = 7
        '
        'TlpTxt
        '
        Me.TlpTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.TlpTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlpTxt.Location = New System.Drawing.Point(187, 147)
        Me.TlpTxt.Name = "TlpTxt"
        Me.TlpTxt.Size = New System.Drawing.Size(300, 26)
        Me.TlpTxt.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariNmPelanggan)
        Me.GroupBox1.Controls.Add(Me.CariKdPelanggan)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(17, 355)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 99)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariDataTxt
        '
        Me.CariDataTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariDataTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.CariDataTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CariDataTxt.ForeColor = System.Drawing.Color.Black
        Me.CariDataTxt.Location = New System.Drawing.Point(534, 40)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(299, 26)
        Me.CariDataTxt.TabIndex = 3
        '
        'CariNmPelanggan
        '
        Me.CariNmPelanggan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariNmPelanggan.AutoSize = True
        Me.CariNmPelanggan.BackColor = System.Drawing.Color.OldLace
        Me.CariNmPelanggan.FlatAppearance.BorderSize = 0
        Me.CariNmPelanggan.Location = New System.Drawing.Point(350, 40)
        Me.CariNmPelanggan.Name = "CariNmPelanggan"
        Me.CariNmPelanggan.Size = New System.Drawing.Size(156, 24)
        Me.CariNmPelanggan.TabIndex = 1
        Me.CariNmPelanggan.TabStop = True
        Me.CariNmPelanggan.Text = "Nama Pelanggan"
        Me.CariNmPelanggan.UseVisualStyleBackColor = False
        '
        'CariKdPelanggan
        '
        Me.CariKdPelanggan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariKdPelanggan.AutoSize = True
        Me.CariKdPelanggan.BackColor = System.Drawing.Color.OldLace
        Me.CariKdPelanggan.Location = New System.Drawing.Point(173, 40)
        Me.CariKdPelanggan.Name = "CariKdPelanggan"
        Me.CariKdPelanggan.Size = New System.Drawing.Size(151, 24)
        Me.CariKdPelanggan.TabIndex = 0
        Me.CariKdPelanggan.TabStop = True
        Me.CariKdPelanggan.Text = "Kode Pelanggan"
        Me.CariKdPelanggan.UseVisualStyleBackColor = False
        '
        'DGPelanggan
        '
        Me.DGPelanggan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPelanggan.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPelanggan.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.DGPelanggan.Location = New System.Drawing.Point(17, 460)
        Me.DGPelanggan.Name = "DGPelanggan"
        Me.DGPelanggan.RowTemplate.Height = 28
        Me.DGPelanggan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGPelanggan.Size = New System.Drawing.Size(982, 212)
        Me.DGPelanggan.TabIndex = 30
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpanBtn.FlatAppearance.BorderSize = 0
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.Location = New System.Drawing.Point(258, 15)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(87, 77)
        Me.SimpanBtn.TabIndex = 24
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UbahBtn.FlatAppearance.BorderSize = 0
        Me.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UbahBtn.Image = CType(resources.GetObject("UbahBtn.Image"), System.Drawing.Image)
        Me.UbahBtn.Location = New System.Drawing.Point(351, 15)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(87, 77)
        Me.UbahBtn.TabIndex = 25
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HapusBtn.FlatAppearance.BorderSize = 0
        Me.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HapusBtn.Image = CType(resources.GetObject("HapusBtn.Image"), System.Drawing.Image)
        Me.HapusBtn.Location = New System.Drawing.Point(444, 15)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(87, 77)
        Me.HapusBtn.TabIndex = 26
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.Location = New System.Drawing.Point(537, 15)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(87, 77)
        Me.BatalBtn.TabIndex = 27
        Me.BatalBtn.Text = "  Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'TutupBtn
        '
        Me.TutupBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TutupBtn.FlatAppearance.BorderSize = 0
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.Location = New System.Drawing.Point(630, 15)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(87, 77)
        Me.TutupBtn.TabIndex = 28
        Me.TutupBtn.Text = "  Tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TutupBtn)
        Me.GroupBox2.Controls.Add(Me.BatalBtn)
        Me.GroupBox2.Controls.Add(Me.HapusBtn)
        Me.GroupBox2.Controls.Add(Me.UbahBtn)
        Me.GroupBox2.Controls.Add(Me.SimpanBtn)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(17, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(982, 98)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'FrmPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1024, 716)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGPelanggan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TlpTxt)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.NmPelangganTxt)
        Me.Controls.Add(Me.KdPelangganTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPelanggan"
        Me.Text = "Pelanggan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KdPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents TlpTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents CariNmPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents DGPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
