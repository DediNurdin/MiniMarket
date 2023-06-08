<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarang))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.KdBarangTxt = New System.Windows.Forms.TextBox()
        Me.BarcodeTxt = New System.Windows.Forms.TextBox()
        Me.NmBarangTxt = New System.Windows.Forms.TextBox()
        Me.HrgBeliTxt = New System.Windows.Forms.TextBox()
        Me.HrgJualTxt = New System.Windows.Forms.TextBox()
        Me.CmbKelompok = New System.Windows.Forms.ComboBox()
        Me.CmbSatuan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.CariStock = New System.Windows.Forms.RadioButton()
        Me.CariNmBarang = New System.Windows.Forms.RadioButton()
        Me.CariKdBarang = New System.Windows.Forms.RadioButton()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.StockLbl = New System.Windows.Forms.TextBox()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1231, 62)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiniMarket.My.Resources.Resources.box
        Me.PictureBox1.Location = New System.Drawing.Point(445, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bebas Neue", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1231, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA BARANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Barcode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kelompok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(564, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Satuan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(563, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Harga Beli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(564, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Harga Jual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(564, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Stock"
        '
        'KdBarangTxt
        '
        Me.KdBarangTxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.KdBarangTxt.ForeColor = System.Drawing.Color.Red
        Me.KdBarangTxt.Location = New System.Drawing.Point(132, 71)
        Me.KdBarangTxt.Name = "KdBarangTxt"
        Me.KdBarangTxt.Size = New System.Drawing.Size(338, 26)
        Me.KdBarangTxt.TabIndex = 9
        '
        'BarcodeTxt
        '
        Me.BarcodeTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.BarcodeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeTxt.Location = New System.Drawing.Point(132, 107)
        Me.BarcodeTxt.Name = "BarcodeTxt"
        Me.BarcodeTxt.Size = New System.Drawing.Size(338, 26)
        Me.BarcodeTxt.TabIndex = 10
        '
        'NmBarangTxt
        '
        Me.NmBarangTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.NmBarangTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NmBarangTxt.Location = New System.Drawing.Point(132, 146)
        Me.NmBarangTxt.Name = "NmBarangTxt"
        Me.NmBarangTxt.Size = New System.Drawing.Size(338, 26)
        Me.NmBarangTxt.TabIndex = 11
        '
        'HrgBeliTxt
        '
        Me.HrgBeliTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.HrgBeliTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HrgBeliTxt.Location = New System.Drawing.Point(668, 70)
        Me.HrgBeliTxt.Name = "HrgBeliTxt"
        Me.HrgBeliTxt.Size = New System.Drawing.Size(338, 26)
        Me.HrgBeliTxt.TabIndex = 12
        '
        'HrgJualTxt
        '
        Me.HrgJualTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.HrgJualTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HrgJualTxt.Location = New System.Drawing.Point(668, 106)
        Me.HrgJualTxt.Name = "HrgJualTxt"
        Me.HrgJualTxt.Size = New System.Drawing.Size(338, 26)
        Me.HrgJualTxt.TabIndex = 13
        '
        'CmbKelompok
        '
        Me.CmbKelompok.BackColor = System.Drawing.Color.LightGray
        Me.CmbKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbKelompok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbKelompok.FormattingEnabled = True
        Me.CmbKelompok.Location = New System.Drawing.Point(132, 182)
        Me.CmbKelompok.Name = "CmbKelompok"
        Me.CmbKelompok.Size = New System.Drawing.Size(338, 28)
        Me.CmbKelompok.TabIndex = 15
        '
        'CmbSatuan
        '
        Me.CmbSatuan.BackColor = System.Drawing.Color.LightGray
        Me.CmbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbSatuan.FormattingEnabled = True
        Me.CmbSatuan.Location = New System.Drawing.Point(668, 181)
        Me.CmbSatuan.Name = "CmbSatuan"
        Me.CmbSatuan.Size = New System.Drawing.Size(338, 28)
        Me.CmbSatuan.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariStock)
        Me.GroupBox1.Controls.Add(Me.CariNmBarang)
        Me.GroupBox1.Controls.Add(Me.CariKdBarang)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(17, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1186, 108)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariDataTxt
        '
        Me.CariDataTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariDataTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.CariDataTxt.Location = New System.Drawing.Point(700, 45)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(323, 26)
        Me.CariDataTxt.TabIndex = 3
        '
        'CariStock
        '
        Me.CariStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariStock.AutoSize = True
        Me.CariStock.BackColor = System.Drawing.Color.OldLace
        Me.CariStock.Location = New System.Drawing.Point(551, 47)
        Me.CariStock.Name = "CariStock"
        Me.CariStock.Size = New System.Drawing.Size(75, 24)
        Me.CariStock.TabIndex = 2
        Me.CariStock.TabStop = True
        Me.CariStock.Text = "Stock"
        Me.CariStock.UseVisualStyleBackColor = False
        '
        'CariNmBarang
        '
        Me.CariNmBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariNmBarang.AutoSize = True
        Me.CariNmBarang.BackColor = System.Drawing.Color.OldLace
        Me.CariNmBarang.Location = New System.Drawing.Point(360, 47)
        Me.CariNmBarang.Name = "CariNmBarang"
        Me.CariNmBarang.Size = New System.Drawing.Size(132, 24)
        Me.CariNmBarang.TabIndex = 1
        Me.CariNmBarang.TabStop = True
        Me.CariNmBarang.Text = "Nama Barang"
        Me.CariNmBarang.UseVisualStyleBackColor = False
        '
        'CariKdBarang
        '
        Me.CariKdBarang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariKdBarang.AutoSize = True
        Me.CariKdBarang.BackColor = System.Drawing.Color.OldLace
        Me.CariKdBarang.Location = New System.Drawing.Point(180, 47)
        Me.CariKdBarang.Name = "CariKdBarang"
        Me.CariKdBarang.Size = New System.Drawing.Size(127, 24)
        Me.CariKdBarang.TabIndex = 0
        Me.CariKdBarang.TabStop = True
        Me.CariKdBarang.Text = "Kode Barang"
        Me.CariKdBarang.UseVisualStyleBackColor = False
        '
        'DGBarang
        '
        Me.DGBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGBarang.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.DGBarang.Location = New System.Drawing.Point(17, 432)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.RowTemplate.Height = 28
        Me.DGBarang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGBarang.Size = New System.Drawing.Size(1186, 247)
        Me.DGBarang.TabIndex = 23
        '
        'StockLbl
        '
        Me.StockLbl.BackColor = System.Drawing.Color.Gainsboro
        Me.StockLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockLbl.Location = New System.Drawing.Point(668, 145)
        Me.StockLbl.Name = "StockLbl"
        Me.StockLbl.Size = New System.Drawing.Size(338, 26)
        Me.StockLbl.TabIndex = 24
        Me.StockLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TutupBtn
        '
        Me.TutupBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TutupBtn.FlatAppearance.BorderSize = 0
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.Location = New System.Drawing.Point(772, 15)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(87, 77)
        Me.TutupBtn.TabIndex = 21
        Me.TutupBtn.Text = "  Tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.Location = New System.Drawing.Point(679, 15)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(87, 77)
        Me.BatalBtn.TabIndex = 20
        Me.BatalBtn.Text = "  Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HapusBtn.FlatAppearance.BorderSize = 0
        Me.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HapusBtn.Image = CType(resources.GetObject("HapusBtn.Image"), System.Drawing.Image)
        Me.HapusBtn.Location = New System.Drawing.Point(586, 15)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(87, 77)
        Me.HapusBtn.TabIndex = 19
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UbahBtn.FlatAppearance.BorderSize = 0
        Me.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UbahBtn.Image = CType(resources.GetObject("UbahBtn.Image"), System.Drawing.Image)
        Me.UbahBtn.Location = New System.Drawing.Point(488, 15)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(87, 77)
        Me.UbahBtn.TabIndex = 18
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpanBtn.FlatAppearance.BorderSize = 0
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.Location = New System.Drawing.Point(389, 15)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(87, 77)
        Me.SimpanBtn.TabIndex = 17
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SimpanBtn.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Location = New System.Drawing.Point(17, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1186, 100)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1231, 728)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StockLbl)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbSatuan)
        Me.Controls.Add(Me.CmbKelompok)
        Me.Controls.Add(Me.HrgJualTxt)
        Me.Controls.Add(Me.HrgBeliTxt)
        Me.Controls.Add(Me.NmBarangTxt)
        Me.Controls.Add(Me.BarcodeTxt)
        Me.Controls.Add(Me.KdBarangTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBarang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Data Barang"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents KdBarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents BarcodeTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmBarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents HrgBeliTxt As System.Windows.Forms.TextBox
    Friend WithEvents HrgJualTxt As System.Windows.Forms.TextBox
    Friend WithEvents CmbKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents CariStock As System.Windows.Forms.RadioButton
    Friend WithEvents CariNmBarang As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdBarang As System.Windows.Forms.RadioButton
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Friend WithEvents StockLbl As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
