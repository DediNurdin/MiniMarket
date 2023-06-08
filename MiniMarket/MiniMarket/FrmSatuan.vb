Public Class FrmSatuan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblsatuan As DataTable
    Sub Data_Record()
        tblsatuan = Proses.ExecuteQuery("Select * From TblSatuan order by no asc")
        DGSatuan.DataSource = tblsatuan
    End Sub
    Sub Kode_Otomatis()
        tblsatuan = Proses.ExecuteQuery("Select * From Tblsatuan order by No desc")
        If tblsatuan.Rows.Count = 0 Then
            KdSatuanTxt.Text = "STN-001"
        Else
            With tblsatuan.Rows(0)
                KdSatuanTxt.Text = .Item("No")
            End With
            KdSatuanTxt.Text = Val(Microsoft.VisualBasic.Mid(KdSatuanTxt.Text, 5, 3)) + 1
            If Len(KdSatuanTxt.Text) = 1 Then
                KdSatuanTxt.Text = "STN-00" & KdSatuanTxt.Text & ""
            ElseIf Len(KdSatuanTxt.Text) = 2 Then
                KdSatuanTxt.Text = "STN-0" & KdSatuanTxt.Text & ""
            ElseIf Len(KdSatuanTxt.Text) = 3 Then
                KdSatuanTxt.Text = "STN-" & KdSatuanTxt.Text & ""
            End If
        End If
    End Sub
    Sub bersih()
        Call Data_Record()
        Call Kode_Otomatis()
        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
        KdSatuanTxt.Enabled = False
        SatuanTxt.Text = ""
        SatuanTxt.Focus()
    End Sub
    Sub editgd()
        Me.DGSatuan.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGSatuan.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGSatuan.Columns(0).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGSatuan.Columns(1).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)

        Me.DGSatuan.DefaultCellStyle.Font = New Font("Arial Narrow", 10)

        Me.DGSatuan.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub FrmSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersih()
        Call editgd()
        DGSatuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If SatuanTxt.Text = "" Then SatuanTxt.Focus() : Exit Sub
        SQL = "Insert Into Tblsatuan Values ('" & KdSatuanTxt.Text & "','" & SatuanTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call bersih()
    End Sub
    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If SatuanTxt.Text = "" Then SatuanTxt.Focus() : Exit Sub
        SQL = "update Tblsatuan set satuan = '" & SatuanTxt.Text & "' where no = '" & KdSatuanTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah Berhasil diubah..!!", "Pengubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call bersih()
    End Sub
    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        SQL = "delete from tblsatuan where no = '" & KdSatuanTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah berhasil dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call bersih()
    End Sub
    Private Sub DGSatuan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGSatuan.DoubleClick
        KdSatuanTxt.Text = DGSatuan.SelectedCells(0).Value
        SatuanTxt.Text = DGSatuan.SelectedCells(1).Value
        UbahBtn.Enabled = True
        HapusBtn.Enabled = True
        SimpanBtn.Enabled = False
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel1.ClientRectangle, Color.Orange, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
End Class