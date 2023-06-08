<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoryPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistoryPenjualan))
        Me.DGHistoriPenjualan = New System.Windows.Forms.DataGridView()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariKdBarang = New System.Windows.Forms.RadioButton()
        Me.CariFaktur = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TutupBtn = New System.Windows.Forms.Button()
        CType(Me.DGHistoriPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGHistoriPenjualan
        '
        Me.DGHistoriPenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGHistoriPenjualan.BackgroundColor = System.Drawing.Color.OldLace
        Me.DGHistoriPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGHistoriPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGHistoriPenjualan.Location = New System.Drawing.Point(25, 261)
        Me.DGHistoriPenjualan.Name = "DGHistoriPenjualan"
        Me.DGHistoriPenjualan.RowTemplate.Height = 28
        Me.DGHistoriPenjualan.Size = New System.Drawing.Size(1047, 325)
        Me.DGHistoriPenjualan.TabIndex = 22
        '
        'CariDataTxt
        '
        Me.CariDataTxt.BackColor = System.Drawing.Color.Gainsboro
        Me.CariDataTxt.Location = New System.Drawing.Point(322, 39)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(299, 26)
        Me.CariDataTxt.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariKdBarang)
        Me.GroupBox1.Controls.Add(Me.CariFaktur)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 100)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariKdBarang
        '
        Me.CariKdBarang.AutoSize = True
        Me.CariKdBarang.Location = New System.Drawing.Point(156, 39)
        Me.CariKdBarang.Name = "CariKdBarang"
        Me.CariKdBarang.Size = New System.Drawing.Size(127, 24)
        Me.CariKdBarang.TabIndex = 1
        Me.CariKdBarang.TabStop = True
        Me.CariKdBarang.Text = "Kode Barang"
        Me.CariKdBarang.UseVisualStyleBackColor = True
        '
        'CariFaktur
        '
        Me.CariFaktur.AutoSize = True
        Me.CariFaktur.Location = New System.Drawing.Point(37, 39)
        Me.CariFaktur.Name = "CariFaktur"
        Me.CariFaktur.Size = New System.Drawing.Size(80, 24)
        Me.CariFaktur.TabIndex = 0
        Me.CariFaktur.TabStop = True
        Me.CariFaktur.Text = "Faktur"
        Me.CariFaktur.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1093, 62)
        Me.Panel1.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(376, 9)
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
        Me.Label1.Location = New System.Drawing.Point(-8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1109, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HISTORY PENJUALAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TutupBtn
        '
        Me.TutupBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TutupBtn.FlatAppearance.BorderSize = 0
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.Location = New System.Drawing.Point(985, 152)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(87, 77)
        Me.TutupBtn.TabIndex = 23
        Me.TutupBtn.Text = "  Tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'FrmHistoryPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1093, 612)
        Me.Controls.Add(Me.DGHistoriPenjualan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TutupBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHistoryPenjualan"
        Me.Text = "History Penjualan"
        CType(Me.DGHistoriPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGHistoriPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariKdBarang As System.Windows.Forms.RadioButton
    Friend WithEvents CariFaktur As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
End Class
