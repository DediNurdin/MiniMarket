Public Class FrmHistoryPembelian
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblhistory As DataTable
    Sub Data_Record()
        tblhistory = Proses.ExecuteQuery("SELECT TblPembelian.Faktur_Pembelian, TblPembelian.Tgl_Pembelian, TblPembelian.Kode_Supplier, TblPembelian_Rinci.Kode_Barang, TblPembelian_Rinci.Jumlah,  TblPembelian_Rinci.Sub_Total, TblPembelian.Diskon, TblPembelian.Total From TblPembelian LEFT JOIN TblPembelian_Rinci ON TblPembelian.Faktur_Pembelian = TblPembelian_Rinci.Faktur_Pembelian")
        DGHistoriPembelian.DataSource = tblhistory
    End Sub
    Sub editgd()
        Me.DGHistoriPembelian.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGHistoriPembelian.Columns(0).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPembelian.Columns(1).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPembelian.Columns(2).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPembelian.Columns(3).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPembelian.Columns(4).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPembelian.Columns(5).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPembelian.Columns(6).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGHistoriPembelian.Columns(7).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)

        Me.DGHistoriPembelian.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGHistoriPembelian.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGHistoriPembelian.DefaultCellStyle.Font = New Font("Arial Narrow", 10)

        Me.DGHistoriPembelian.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub TutupBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub
    Private Sub FrmHistoryPembelian_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Data_Record()
        Call editgd()
        DGHistoriPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub CariDataTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CariDataTxt.TextChanged
        If CariFaktur.Checked = True Then
            tblhistory = Proses.ExecuteQuery("Select * From TblPembelian_Rinci Where Faktur_Pembelian Like '%" & CariDataTxt.Text & "%'")
            If tblhistory.Rows.Count = 0 Then
                DGHistoriPembelian.DataSource = tblhistory
                CariDataTxt.Focus()
            Else
                DGHistoriPembelian.DataSource = tblhistory
            End If
        ElseIf CariKdBarang.Checked = True Then
            tblhistory = Proses.ExecuteQuery("Select * From TblPembelian_Rinci Where Kode_Barang Like '%" & CariDataTxt.Text & "%'")
            If tblhistory.Rows.Count = 0 Then
                DGHistoriPembelian.DataSource = tblhistory
                CariDataTxt.Focus()
            Else
                DGHistoriPembelian.DataSource = tblhistory
            End If
        End If
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel1.ClientRectangle, Color.Pink, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
End Class