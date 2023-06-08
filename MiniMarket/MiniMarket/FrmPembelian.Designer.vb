<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPembelian))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblNmSupplier = New System.Windows.Forms.TextBox()
        Me.LblNmBarang = New System.Windows.Forms.TextBox()
        Me.LblHrg = New System.Windows.Forms.TextBox()
        Me.LblStock = New System.Windows.Forms.TextBox()
        Me.TxtJml = New System.Windows.Forms.TextBox()
        Me.LblFaktur = New System.Windows.Forms.TextBox()
        Me.CmbSupplier = New System.Windows.Forms.ComboBox()
        Me.CmbBarang = New System.Windows.Forms.ComboBox()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.DGPembelian = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblTotHrgKotor = New System.Windows.Forms.TextBox()
        Me.DiscTxt = New System.Windows.Forms.TextBox()
        Me.LblTotHrgBersih = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1117, 62)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiniMarket.My.Resources.Resources.shopping_bag
        Me.PictureBox1.Location = New System.Drawing.Point(443, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bebas Neue", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1117, 62)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "PEMBELIAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nama Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(706, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(466, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Faktur Pembelian"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(823, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(941, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Jumlah Beli"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(466, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nama Barang"
        '
        'LblNmSupplier
        '
        Me.LblNmSupplier.BackColor = System.Drawing.Color.Gainsboro
        Me.LblNmSupplier.Location = New System.Drawing.Point(151, 126)
        Me.LblNmSupplier.Name = "LblNmSupplier"
        Me.LblNmSupplier.Size = New System.Drawing.Size(279, 26)
        Me.LblNmSupplier.TabIndex = 29
        '
        'LblNmBarang
        '
        Me.LblNmBarang.BackColor = System.Drawing.Color.Gainsboro
        Me.LblNmBarang.Location = New System.Drawing.Point(470, 180)
        Me.LblNmBarang.Name = "LblNmBarang"
        Me.LblNmBarang.Size = New System.Drawing.Size(220, 26)
        Me.LblNmBarang.TabIndex = 31
        '
        'LblHrg
        '
        Me.LblHrg.BackColor = System.Drawing.Color.Gainsboro
        Me.LblHrg.Location = New System.Drawing.Point(710, 180)
        Me.LblHrg.Name = "LblHrg"
        Me.LblHrg.Size = New System.Drawing.Size(100, 26)
        Me.LblHrg.TabIndex = 32
        Me.LblHrg.Text = "0"
        '
        'LblStock
        '
        Me.LblStock.BackColor = System.Drawing.Color.Gainsboro
        Me.LblStock.Location = New System.Drawing.Point(827, 180)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(100, 26)
        Me.LblStock.TabIndex = 33
        Me.LblStock.Text = "0"
        '
        'TxtJml
        '
        Me.TxtJml.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtJml.Location = New System.Drawing.Point(945, 180)
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(100, 26)
        Me.TxtJml.TabIndex = 34
        '
        'LblFaktur
        '
        Me.LblFaktur.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblFaktur.ForeColor = System.Drawing.Color.Red
        Me.LblFaktur.Location = New System.Drawing.Point(615, 78)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(195, 26)
        Me.LblFaktur.TabIndex = 35
        '
        'CmbSupplier
        '
        Me.CmbSupplier.BackColor = System.Drawing.Color.Gainsboro
        Me.CmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbSupplier.FormattingEnabled = True
        Me.CmbSupplier.Location = New System.Drawing.Point(151, 76)
        Me.CmbSupplier.Name = "CmbSupplier"
        Me.CmbSupplier.Size = New System.Drawing.Size(279, 28)
        Me.CmbSupplier.TabIndex = 36
        '
        'CmbBarang
        '
        Me.CmbBarang.BackColor = System.Drawing.Color.Gainsboro
        Me.CmbBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbBarang.FormattingEnabled = True
        Me.CmbBarang.Location = New System.Drawing.Point(151, 177)
        Me.CmbBarang.Name = "CmbBarang"
        Me.CmbBarang.Size = New System.Drawing.Size(279, 28)
        Me.CmbBarang.TabIndex = 37
        '
        'BatalBtn
        '
        Me.BatalBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.Location = New System.Drawing.Point(137, 571)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(87, 77)
        Me.BatalBtn.TabIndex = 39
        Me.BatalBtn.Text = "  Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpanBtn.FlatAppearance.BorderSize = 0
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.Location = New System.Drawing.Point(22, 571)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(87, 77)
        Me.SimpanBtn.TabIndex = 38
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'DGPembelian
        '
        Me.DGPembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPembelian.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGPembelian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPembelian.Location = New System.Drawing.Point(28, 235)
        Me.DGPembelian.Name = "DGPembelian"
        Me.DGPembelian.RowTemplate.Height = 28
        Me.DGPembelian.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGPembelian.Size = New System.Drawing.Size(1067, 307)
        Me.DGPembelian.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(780, 571)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 20)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Harga Kotor"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(780, 609)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 20)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Diskon %"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(780, 645)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 20)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Harga Bersih"
        '
        'LblTotHrgKotor
        '
        Me.LblTotHrgKotor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotHrgKotor.BackColor = System.Drawing.Color.White
        Me.LblTotHrgKotor.ForeColor = System.Drawing.Color.Black
        Me.LblTotHrgKotor.Location = New System.Drawing.Point(889, 568)
        Me.LblTotHrgKotor.Name = "LblTotHrgKotor"
        Me.LblTotHrgKotor.Size = New System.Drawing.Size(205, 26)
        Me.LblTotHrgKotor.TabIndex = 44
        Me.LblTotHrgKotor.Text = "Rp,"
        Me.LblTotHrgKotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscTxt
        '
        Me.DiscTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscTxt.BackColor = System.Drawing.Color.White
        Me.DiscTxt.Location = New System.Drawing.Point(889, 604)
        Me.DiscTxt.Name = "DiscTxt"
        Me.DiscTxt.Size = New System.Drawing.Size(205, 26)
        Me.DiscTxt.TabIndex = 45
        Me.DiscTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblTotHrgBersih
        '
        Me.LblTotHrgBersih.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotHrgBersih.BackColor = System.Drawing.Color.White
        Me.LblTotHrgBersih.ForeColor = System.Drawing.Color.Red
        Me.LblTotHrgBersih.Location = New System.Drawing.Point(889, 642)
        Me.LblTotHrgBersih.Name = "LblTotHrgBersih"
        Me.LblTotHrgBersih.Size = New System.Drawing.Size(205, 26)
        Me.LblTotHrgBersih.TabIndex = 46
        Me.LblTotHrgBersih.Text = "Rp,"
        Me.LblTotHrgBersih.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OldLace
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1051, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 35)
        Me.Button1.TabIndex = 47
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1117, 691)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblTotHrgBersih)
        Me.Controls.Add(Me.DiscTxt)
        Me.Controls.Add(Me.LblTotHrgKotor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DGPembelian)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.CmbBarang)
        Me.Controls.Add(Me.CmbSupplier)
        Me.Controls.Add(Me.LblFaktur)
        Me.Controls.Add(Me.TxtJml)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblHrg)
        Me.Controls.Add(Me.LblNmBarang)
        Me.Controls.Add(Me.LblNmSupplier)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPembelian"
        Me.Text = "Pembelian"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblNmSupplier As System.Windows.Forms.TextBox
    Friend WithEvents LblNmBarang As System.Windows.Forms.TextBox
    Friend WithEvents LblHrg As System.Windows.Forms.TextBox
    Friend WithEvents LblStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents LblFaktur As System.Windows.Forms.TextBox
    Friend WithEvents CmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBarang As System.Windows.Forms.ComboBox
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents DGPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblTotHrgKotor As System.Windows.Forms.TextBox
    Friend WithEvents DiscTxt As System.Windows.Forms.TextBox
    Friend WithEvents LblTotHrgBersih As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
