Public Class FrmKelompok
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblkelompok As DataTable
    Sub Data_Record()
        tblkelompok = Proses.ExecuteQuery("Select * From TblKelompok order by no asc")
        DGKelompok.DataSource = tblkelompok
    End Sub
    Sub Kode_Otomatis()
        tblkelompok = Proses.ExecuteQuery("Select * From TblKelompok order by No desc")
        If tblkelompok.Rows.Count = 0 Then
            KdKelompokTxt.Text = "KLP-001"
        Else
            With tblkelompok.Rows(0)
                KdKelompokTxt.Text = .Item("No")
            End With
            KdKelompokTxt.Text = Val(Microsoft.VisualBasic.Mid(KdKelompokTxt.Text, 5, 3)) + 1
            If Len(KdKelompokTxt.Text) = 1 Then
                KdKelompokTxt.Text = "KLP-00" & KdKelompokTxt.Text & ""
            ElseIf Len(KdKelompokTxt.Text) = 2 Then
                KdKelompokTxt.Text = "KLP-0" & KdKelompokTxt.Text & ""
            ElseIf Len(KdKelompokTxt.Text) = 3 Then
                KdKelompokTxt.Text = "KLP-" & KdKelompokTxt.Text & ""
            End If
        End If
    End Sub
    Sub bersih()
        Call Data_Record()
        Call Kode_Otomatis()
        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
        KdKelompokTxt.Enabled = False
        KelompokTxt.Text = ""
        KelompokTxt.Focus()
    End Sub
    Sub editgd()
        Me.DGKelompok.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGKelompok.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGKelompok.Columns(0).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGKelompok.Columns(1).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)

        Me.DGKelompok.DefaultCellStyle.Font = New Font("Arial Narrow", 10)

        Me.DGKelompok.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub FrmKelompok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersih()
        Call editgd()
        DGKelompok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If KelompokTxt.Text = "" Then KelompokTxt.Focus() : Exit Sub
        SQL = "Insert Into TblKelompok Values ('" & KdKelompokTxt.Text & "','" & KelompokTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call bersih()
    End Sub
    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If KelompokTxt.Text = "" Then KelompokTxt.Focus() : Exit Sub
        SQL = "update Tblkelompok set kelompok = '" & KelompokTxt.Text & "' where no = '" & KdKelompokTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah Berhasil diubah..!!", "Pengubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call bersih()
    End Sub
    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        SQL = "delete from tblkelompok where no = '" & KdKelompokTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah berhasil dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call bersih()
    End Sub
    Private Sub DGKelompok_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGKelompok.DoubleClick
        KdKelompokTxt.Text = DGKelompok.SelectedCells(0).Value
        KelompokTxt.Text = DGKelompok.SelectedCells(1).Value
        UbahBtn.Enabled = True
        HapusBtn.Enabled = True
        SimpanBtn.Enabled = False
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel1.ClientRectangle, Color.LightSalmon, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
End Class