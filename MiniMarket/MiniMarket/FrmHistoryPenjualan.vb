Public Class FrmHistoryPenjualan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblhistory As DataTable
    Sub Data_Record()
        tblhistory = Proses.ExecuteQuery("SELECT TblPenjualan.Faktur_Penjualan, Tgl_Penjualan, Kode_Pelanggan, Kode_Barcode, Jumlah, Sub_Total, Disc, Total FROM TblPenjualan_Rinci INNER JOIN TblPenjualan ON TblPenjualan_Rinci.Faktur_Penjualan = TblPenjualan.Faktur_Penjualan")
        DGHistoriPenjualan.DataSource = tblhistory
    End Sub
    Sub editgd()
        Me.DGHistoriPenjualan.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGHistoriPenjualan.Columns(0).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPenjualan.Columns(1).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPenjualan.Columns(2).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPenjualan.Columns(3).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPenjualan.Columns(4).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPenjualan.Columns(5).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPenjualan.Columns(6).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPenjualan.Columns(7).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)

        Me.DGHistoriPenjualan.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPenjualan.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGHistoriPenjualan.DefaultCellStyle.Font = New Font("Arial Narrow", 10)

        Me.DGHistoriPenjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
          (Panel1.ClientRectangle, Color.Pink, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub

    Private Sub FrmHistoryPenjualan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Data_Record()
        Call editgd()
        DGHistoriPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub CariDataTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CariDataTxt.TextChanged
        If CariFaktur.Checked = True Then
            tblhistory = Proses.ExecuteQuery("Select * From TblPenjualan_Rinci Where Faktur_Penjualan Like '%" & CariDataTxt.Text & "%'")
            If tblhistory.Rows.Count = 0 Then
                DGHistoriPenjualan.DataSource = tblhistory
                CariDataTxt.Focus()
            Else
                DGHistoriPenjualan.DataSource = tblhistory
            End If
        ElseIf CariKdBarang.Checked = True Then
            tblhistory = Proses.ExecuteQuery("Select * From TblPenjualan_Rinci Where Kode_Barcode Like '%" & CariDataTxt.Text & "%'")
            If tblhistory.Rows.Count = 0 Then
                DGHistoriPenjualan.DataSource = tblhistory
                CariDataTxt.Focus()
            Else
                DGHistoriPenjualan.DataSource = tblhistory
            End If
        End If
    End Sub
End Class