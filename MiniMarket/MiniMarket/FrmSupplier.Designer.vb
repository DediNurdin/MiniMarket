<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplier))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KdSupplierTxt = New System.Windows.Forms.TextBox()
        Me.NmSupplierTxt = New System.Windows.Forms.TextBox()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.TlpTxt = New System.Windows.Forms.TextBox()
        Me.KontakTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.CariKontak = New System.Windows.Forms.RadioButton()
        Me.CariNmSupplier = New System.Windows.Forms.RadioButton()
        Me.CariKdSupplier = New System.Windows.Forms.RadioButton()
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(991, 62)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MiniMarket.My.Resources.Resources.bussiness_man
        Me.PictureBox1.Location = New System.Drawing.Point(328, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bebas Neue", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(991, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT DATA SUPPLIER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(524, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(524, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kontak"
        '
        'KdSupplierTxt
        '
        Me.KdSupplierTxt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.KdSupplierTxt.ForeColor = System.Drawing.Color.Red
        Me.KdSupplierTxt.Location = New System.Drawing.Point(169, 79)
        Me.KdSupplierTxt.Name = "KdSupplierTxt"
        Me.KdSupplierTxt.Size = New System.Drawing.Size(283, 26)
        Me.KdSupplierTxt.TabIndex = 6
        '
        'NmSupplierTxt
        '
        Me.NmSupplierTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.NmSupplierTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NmSupplierTxt.Location = New System.Drawing.Point(169, 117)
        Me.NmSupplierTxt.Name = "NmSupplierTxt"
        Me.NmSupplierTxt.Size = New System.Drawing.Size(283, 26)
        Me.NmSupplierTxt.TabIndex = 7
        '
        'AlmTxt
        '
        Me.AlmTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.AlmTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlmTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlmTxt.Location = New System.Drawing.Point(169, 155)
        Me.AlmTxt.Multiline = True
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AlmTxt.Size = New System.Drawing.Size(283, 80)
        Me.AlmTxt.TabIndex = 8
        '
        'TlpTxt
        '
        Me.TlpTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.TlpTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlpTxt.Location = New System.Drawing.Point(619, 79)
        Me.TlpTxt.Name = "TlpTxt"
        Me.TlpTxt.Size = New System.Drawing.Size(305, 26)
        Me.TlpTxt.TabIndex = 9
        '
        'KontakTxt
        '
        Me.KontakTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.KontakTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KontakTxt.Location = New System.Drawing.Point(619, 117)
        Me.KontakTxt.Name = "KontakTxt"
        Me.KontakTxt.Size = New System.Drawing.Size(305, 26)
        Me.KontakTxt.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariKontak)
        Me.GroupBox1.Controls.Add(Me.CariNmSupplier)
        Me.GroupBox1.Controls.Add(Me.CariKdSupplier)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(17, 346)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(949, 103)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariDataTxt
        '
        Me.CariDataTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariDataTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.CariDataTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CariDataTxt.Location = New System.Drawing.Point(554, 41)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(370, 26)
        Me.CariDataTxt.TabIndex = 3
        '
        'CariKontak
        '
        Me.CariKontak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariKontak.AutoSize = True
        Me.CariKontak.BackColor = System.Drawing.Color.OldLace
        Me.CariKontak.Location = New System.Drawing.Point(405, 43)
        Me.CariKontak.Name = "CariKontak"
        Me.CariKontak.Size = New System.Drawing.Size(84, 24)
        Me.CariKontak.TabIndex = 2
        Me.CariKontak.TabStop = True
        Me.CariKontak.Text = "Kontak"
        Me.CariKontak.UseVisualStyleBackColor = False
        '
        'CariNmSupplier
        '
        Me.CariNmSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariNmSupplier.AutoSize = True
        Me.CariNmSupplier.BackColor = System.Drawing.Color.OldLace
        Me.CariNmSupplier.Location = New System.Drawing.Point(234, 43)
        Me.CariNmSupplier.Name = "CariNmSupplier"
        Me.CariNmSupplier.Size = New System.Drawing.Size(138, 24)
        Me.CariNmSupplier.TabIndex = 1
        Me.CariNmSupplier.TabStop = True
        Me.CariNmSupplier.Text = "Nama Supplier"
        Me.CariNmSupplier.UseVisualStyleBackColor = False
        '
        'CariKdSupplier
        '
        Me.CariKdSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CariKdSupplier.AutoSize = True
        Me.CariKdSupplier.BackColor = System.Drawing.Color.OldLace
        Me.CariKdSupplier.Location = New System.Drawing.Point(74, 41)
        Me.CariKdSupplier.Name = "CariKdSupplier"
        Me.CariKdSupplier.Size = New System.Drawing.Size(133, 24)
        Me.CariKdSupplier.TabIndex = 0
        Me.CariKdSupplier.TabStop = True
        Me.CariKdSupplier.Text = "Kode Supplier"
        Me.CariKdSupplier.UseVisualStyleBackColor = False
        '
        'DGSupplier
        '
        Me.DGSupplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGSupplier.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.DGSupplier.Location = New System.Drawing.Point(17, 455)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.RowTemplate.Height = 28
        Me.DGSupplier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGSupplier.Size = New System.Drawing.Size(950, 219)
        Me.DGSupplier.TabIndex = 24
        '
        'TutupBtn
        '
        Me.TutupBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TutupBtn.FlatAppearance.BorderSize = 0
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.Location = New System.Drawing.Point(617, 21)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(87, 77)
        Me.TutupBtn.TabIndex = 19
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
        Me.BatalBtn.Location = New System.Drawing.Point(524, 21)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(87, 77)
        Me.BatalBtn.TabIndex = 18
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
        Me.HapusBtn.Location = New System.Drawing.Point(431, 21)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(87, 77)
        Me.HapusBtn.TabIndex = 17
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
        Me.UbahBtn.Location = New System.Drawing.Point(333, 21)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(87, 77)
        Me.UbahBtn.TabIndex = 16
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
        Me.SimpanBtn.Location = New System.Drawing.Point(234, 21)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(87, 77)
        Me.SimpanBtn.TabIndex = 15
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
        Me.GroupBox2.Location = New System.Drawing.Point(17, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(950, 108)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(991, 699)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGSupplier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.KontakTxt)
        Me.Controls.Add(Me.TlpTxt)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.NmSupplierTxt)
        Me.Controls.Add(Me.KdSupplierTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSupplier"
        Me.Text = "Data Supplier"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KdSupplierTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmSupplierTxt As System.Windows.Forms.TextBox
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents TlpTxt As System.Windows.Forms.TextBox
    Friend WithEvents KontakTxt As System.Windows.Forms.TextBox
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents CariKontak As System.Windows.Forms.RadioButton
    Friend WithEvents CariNmSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents DGSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
