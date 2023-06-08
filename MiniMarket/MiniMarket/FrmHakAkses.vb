Public Class FrmHakAkses
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblHakAkses As DataTable
    Sub kosong()
        ChkPengguna.Checked = False
        ChkJenis.Checked = False
        ChkSatuan.Checked = False
        ChkBarang.Checked = False
        ChkSupplier.Checked = False
        ChkPelanggan.Checked = False
        ChkPembelian.Checked = False
        ChkPenjualan.Checked = False
    End Sub
    Sub Hak_Akses()
        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where level ='" & CmbLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            Call kosong()
        Else
            With tblHakAkses.Rows(0)
                ChkPengguna.Checked = .Item("pengguna")
                ChkJenis.Checked = .Item("jenis_barang")
                ChkSatuan.Checked = .Item("satuan")
                ChkBarang.Checked = .Item("barang")
                ChkSupplier.Checked = .Item("supplier")
                ChkPelanggan.Checked = .Item("pelanggan")
                ChkPembelian.Checked = .Item("pembelian")
                ChkPenjualan.Checked = .Item("penjualan")
                ChkAkses.Checked = .Item("hakakses")
            End With
        End If
    End Sub
    Private Sub FrmHakAkses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbLevel.Items.Add("ADMIN")
        CmbLevel.Items.Add("OPERATOR")
    End Sub
    Private Sub FrmHakAkses_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Hak_Akses()
    End Sub
    Private Sub CmbLevel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLevel.TextChanged
        Call Hak_Akses()
    End Sub
    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        If CmbLevel.Text = "" Then Exit Sub
        tblHakAkses = Proses.ExecuteQuery("Select * From TblHakAkses Where level = '" & CmbLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            SQL = "Insert Into Tblhakakses Values ('" & CmbLevel.Text & "','" & _
                CInt(ChkPengguna.Checked) * -1 & "','" & CInt(ChkJenis.Checked) * -1 & "','" & _
                CInt(ChkSatuan.Checked) * -1 & "','" & CInt(ChkBarang.Checked) * -1 & "','" & _
                CInt(ChkSupplier.Checked) * -1 & "','" & CInt(ChkPelanggan.Checked) * -1 & "','" & _
                CInt(ChkPembelian.Checked) * -1 & "','" & CInt(ChkPenjualan.Checked) * -1 & _
                "','" & CInt(ChkAkses.Checked) * -1 & "')"

            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            SQL = "Update Tblhakakses Set Pengguna = '" & CInt(ChkPengguna.Checked) * -1 & "',jenis_barang= '" & _
                CInt(ChkJenis.Checked) * -1 & "',satuan = '" & CInt(ChkSatuan.Checked) * -1 & "', barang = '" & _
                CInt(ChkBarang.Checked) * -1 & "',supplier = '" & CInt(ChkSupplier.Checked) * -1 & "', pelanggan = '" & _
                CInt(ChkPelanggan.Checked) * -1 & "',pembelian = '" & CInt(ChkPembelian.Checked) * -1 & "', penjualan = '" & _
                CInt(ChkPenjualan.Checked) * -1 & "',HakAkses = '" & CInt(ChkAkses.Checked) * -1 & "' where Level = '" & CmbLevel.Text & "' "
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data telah diubah..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel1.ClientRectangle, Color.PowderBlue, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
End Class