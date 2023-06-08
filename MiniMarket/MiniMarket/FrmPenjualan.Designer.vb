<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPenjualan))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbPelanggan = New System.Windows.Forms.ComboBox()
        Me.BarangTxt = New System.Windows.Forms.TextBox()
        Me.LblNmPelanggan = New System.Windows.Forms.TextBox()
        Me.TxtJml = New System.Windows.Forms.TextBox()
        Me.LblStock = New System.Windows.Forms.TextBox()
        Me.LblHrg = New System.Windows.Forms.TextBox()
        Me.LblNmBarang = New System.Windows.Forms.TextBox()
        Me.LblSubTotal = New System.Windows.Forms.TextBox()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.LblFaktur = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTotHrga = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bebas Neue", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1134, 62)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "PENJUALAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1137, 62)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiniMarket.My.Resources.Resources.trade
        Me.PictureBox1.Location = New System.Drawing.Point(453, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Barcode Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(460, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(701, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Harga Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(829, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(955, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Jumlah Jual"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(458, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Faktur Penjualan"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(829, 658)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Sub Total"
        '
        'CmbPelanggan
        '
        Me.CmbPelanggan.BackColor = System.Drawing.Color.Gainsboro
        Me.CmbPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbPelanggan.FormattingEnabled = True
        Me.CmbPelanggan.Location = New System.Drawing.Point(154, 140)
        Me.CmbPelanggan.Name = "CmbPelanggan"
        Me.CmbPelanggan.Size = New System.Drawing.Size(270, 28)
        Me.CmbPelanggan.TabIndex = 12
        '
        'BarangTxt
        '
        Me.BarangTxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BarangTxt.Location = New System.Drawing.Point(154, 234)
        Me.BarangTxt.Name = "BarangTxt"
        Me.BarangTxt.Size = New System.Drawing.Size(270, 26)
        Me.BarangTxt.TabIndex = 13
        '
        'LblNmPelanggan
        '
        Me.LblNmPelanggan.BackColor = System.Drawing.Color.Gainsboro
        Me.LblNmPelanggan.Location = New System.Drawing.Point(154, 187)
        Me.LblNmPelanggan.Name = "LblNmPelanggan"
        Me.LblNmPelanggan.Size = New System.Drawing.Size(270, 26)
        Me.LblNmPelanggan.TabIndex = 14
        '
        'TxtJml
        '
        Me.TxtJml.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtJml.Location = New System.Drawing.Point(959, 234)
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(100, 26)
        Me.TxtJml.TabIndex = 15
        Me.TxtJml.Text = "0"
        '
        'LblStock
        '
        Me.LblStock.BackColor = System.Drawing.Color.Gainsboro
        Me.LblStock.Location = New System.Drawing.Point(833, 234)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(100, 26)
        Me.LblStock.TabIndex = 16
        Me.LblStock.Text = "0"
        '
        'LblHrg
        '
        Me.LblHrg.BackColor = System.Drawing.Color.Gainsboro
        Me.LblHrg.Location = New System.Drawing.Point(705, 234)
        Me.LblHrg.Name = "LblHrg"
        Me.LblHrg.Size = New System.Drawing.Size(100, 26)
        Me.LblHrg.TabIndex = 17
        Me.LblHrg.Text = "0"
        '
        'LblNmBarang
        '
        Me.LblNmBarang.BackColor = System.Drawing.Color.Gainsboro
        Me.LblNmBarang.Location = New System.Drawing.Point(464, 234)
        Me.LblNmBarang.Name = "LblNmBarang"
        Me.LblNmBarang.Size = New System.Drawing.Size(219, 26)
        Me.LblNmBarang.TabIndex = 18
        '
        'LblSubTotal
        '
        Me.LblSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.LblSubTotal.ForeColor = System.Drawing.Color.Red
        Me.LblSubTotal.Location = New System.Drawing.Point(929, 655)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(176, 26)
        Me.LblSubTotal.TabIndex = 19
        Me.LblSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DGPenjualan
        '
        Me.DGPenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPenjualan.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenjualan.Location = New System.Drawing.Point(6, 288)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.RowTemplate.Height = 28
        Me.DGPenjualan.Size = New System.Drawing.Size(1119, 346)
        Me.DGPenjualan.TabIndex = 20
        '
        'LblFaktur
        '
        Me.LblFaktur.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblFaktur.ForeColor = System.Drawing.Color.Red
        Me.LblFaktur.Location = New System.Drawing.Point(598, 140)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(207, 26)
        Me.LblFaktur.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.LblTotHrga)
        Me.Panel1.Location = New System.Drawing.Point(0, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1137, 62)
        Me.Panel1.TabIndex = 22
        '
        'LblTotHrga
        '
        Me.LblTotHrga.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LblTotHrga.AutoSize = True
        Me.LblTotHrga.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotHrga.ForeColor = System.Drawing.Color.Red
        Me.LblTotHrga.Location = New System.Drawing.Point(921, 6)
        Me.LblTotHrga.Name = "LblTotHrga"
        Me.LblTotHrga.Size = New System.Drawing.Size(42, 46)
        Me.LblTotHrga.TabIndex = 23
        Me.LblTotHrga.Text = "0"
        Me.LblTotHrga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 661)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 22)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "[Fn+F1]-BAYAR"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(415, 661)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 22)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "[Fn+F3]-BATAL"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(594, 661)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(140, 22)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "[Ecs]-KELUAR"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(218, 661)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(169, 22)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "[Fn+F2]-BARANG"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(196, 661)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 22)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "|"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(571, 661)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 22)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "|"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(393, 661)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 22)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "|"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1065, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 35)
        Me.Button1.TabIndex = 33
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1137, 705)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblFaktur)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.LblSubTotal)
        Me.Controls.Add(Me.LblNmBarang)
        Me.Controls.Add(Me.LblHrg)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.TxtJml)
        Me.Controls.Add(Me.LblNmPelanggan)
        Me.Controls.Add(Me.BarangTxt)
        Me.Controls.Add(Me.CmbPelanggan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPenjualan"
        Me.Text = "Penjualan"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CmbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents BarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents LblNmPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents LblStock As System.Windows.Forms.TextBox
    Friend WithEvents LblHrg As System.Windows.Forms.TextBox
    Friend WithEvents LblNmBarang As System.Windows.Forms.TextBox
    Friend WithEvents LblSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents DGPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents LblFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblTotHrga As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
