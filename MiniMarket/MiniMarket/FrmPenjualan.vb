Public Class FrmPenjualan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tbljual As DataTable
    Sub Data_Record()
        tbljual = Proses.ExecuteQuery("Select tblpenjualan_rinci.No,tblpenjualan_rinci.Kode_Barcode, tblbarang.Nama_Barang, tblpenjualan_rinci.Harga_Jual, tblpenjualan_rinci.Jumlah, tblpenjualan_rinci.Sub_Total From Tblpenjualan_rinci inner join tblbarang on tblpenjualan_rinci.kode_barcode = tblbarang.kode_barcode where tblpenjualan_rinci.faktur_penjualan = '" & LblFaktur.Text & "' order by tblpenjualan_rinci.no asc")
        DGPenjualan.DataSource = tbljual
        DGPenjualan.Columns(0).Width = 50
        DGPenjualan.Columns(1).Width = 98
        DGPenjualan.Columns(2).Width = 150
        DGPenjualan.Columns(4).Width = 50
    End Sub
    Sub Pelanggan()
        tbljual = Proses.ExecuteQuery("Select * From Tblpelanggan order by kode_pelanggan asc")
        If tbljual.Rows.Count = 0 Then
        Else
            CmbPelanggan.Items.Clear()
            With tbljual.Columns(1)
                For a = 0 To tbljual.Rows.Count - 1
                    CmbPelanggan.Items.Add(.Table.Rows(a).Item(0) + "/" + .Table.Rows(a).Item(1))
                Next a
            End With
        End If
    End Sub
    Sub Bersih()
        BarangTxt.Text = ""
        LblNmBarang.Text = ""
        LblHrg.Text = ""
        LblStock.Text = ""
        TxtJml.Text = ""
        CmbPelanggan.Enabled = True
        BarangTxt.Enabled = True
        BarangTxt.Focus()

        Call Pelanggan()
        Call Faktur_Otomatis()
        Call Data_Record()

        On Error Resume Next

        Dim Total_seluruh As Single

        Dim i As Integer
        i = DGPenjualan.CurrentRow.Index
        For i = 0 To DGPenjualan.Rows.Count - 1
            Total_seluruh = Val(Total_seluruh) + Val(DGPenjualan.Item(5, i).Value)
        Next
        LblSubTotal.Text = Total_seluruh.ToString("#,#")
        LblTotHrga.Text = LblSubTotal.Text
    End Sub
    Sub Faktur_Otomatis()
        tbljual = Proses.ExecuteQuery("Select * From Tblpenjualan order by faktur_penjualan desc")
        If tbljual.Rows.Count = 0 Then
            LblFaktur.Text = "0001"
        Else
            With tbljual.Rows(0)
                LblFaktur.Text = .Item("faktur_penjualan")
            End With

            LblFaktur.Text = Val(LblFaktur.Text) + 1
            If Len(LblFaktur.Text) = 1 Then
                LblFaktur.Text = "000" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 2 Then
                LblFaktur.Text = "00" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 3 Then
                LblFaktur.Text = "0" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 4 Then
                LblFaktur.Text = "" & LblFaktur.Text & ""
            End If
        End If
    End Sub
    Sub editgd()
        Me.DGPenjualan.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGPenjualan.Columns(0).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPenjualan.Columns(1).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPenjualan.Columns(2).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPenjualan.Columns(3).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPenjualan.Columns(4).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPenjualan.Columns(5).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)

        Me.DGPenjualan.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPenjualan.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGPenjualan.DefaultCellStyle.Font = New Font("Arial Narrow", 10)

        Me.DGPenjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub FrmPenjualan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Bersih()
        Call editgd()
        DGPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub CmbPelanggan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPelanggan.KeyPress
        e.KeyChar = Chr(0)
    End Sub
    Private Sub CmbPelanggan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPelanggan.TextChanged
        tbljual = Proses.ExecuteQuery("Select * From Tblpelanggan where kode_pelanggan = '" & Mid(CmbPelanggan.Text, 1, 6) & "'")
        If tbljual.Rows.Count = 0 Then
        Else
            LblNmPelanggan.Text = tbljual.Rows(0).Item("Nama_pelanggan")
        End If
    End Sub
    Private Sub TxtJml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJml.KeyPress
        If TxtJml.Text = "" Or TxtJml.Text = "0" Then Exit Sub
        If Val(LblStock.Text) < Val(TxtJml.Text) Then MsgBox("Stock tidak mencukupi !", MsgBoxStyle.Critical, "Message") : TxtJml.Text = "0" : Exit Sub
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJml.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                tbljual = Proses.ExecuteQuery("select * from tblpenjualan_rinci where faktur_penjualan = '" & LblFaktur.Text & "' and kode_barcode = '" & BarangTxt.Text & "'")
                If tbljual.Rows.Count = 0 Then
                    Dim total = Val(LblHrg.Text) * Val(TxtJml.Text)
                    SQL = "Insert Into Tblpenjualan_rinci Values ('" & LblFaktur.Text & "','" & DGPenjualan.RowCount & "','" & BarangTxt.Text & "','" & LblHrg.Text & "','" & TxtJml.Text & "','" & total & "')"
                    Proses.ExecuteNonQuery(SQL)
                Else
                    MsgBox("Proses penjualan tidak dapat dilakukan !")
                    BarangTxt.Text = ""
                    BarangTxt.Focus()
                    Exit Sub
                End If

                Call Bersih()
                Dim Total_seluruh As Single

                Dim i As Integer
                i = DGPenjualan.CurrentRow.Index
                For i = 0 To DGPenjualan.Rows.Count - 1
                    Total_seluruh = Val(Total_seluruh) + Val(DGPenjualan.Item(5, i).Value)
                Next
                LblSubTotal.Text = Total_seluruh.ToString("#,#")
                LblTotHrga.Text = LblSubTotal.Text
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub
    Private Sub BarangTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarangTxt.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Sub_Total As Single
            Sub_Total = Replace(LblSubTotal.Text, ".", "")

            FrmBayar.LblSubTotal.Text = Sub_Total.ToString("#,#")
            FrmBayar.ShowDialog()


        ElseIf e.KeyCode = Keys.F2 Then
            FrmBarang.ShowDialog()

        ElseIf e.KeyCode = Keys.F3 Then
            On Error GoTo Keluar
            Dim i As Integer
            i = DGPenjualan.CurrentRow.Index
            For i = 0 To DGPenjualan.Rows.Count - 1
                tbljual = Proses.ExecuteQuery("select * from tblbarang where kode_barcode = '" & DGPenjualan.Item(2, i).Value & "'")
                If tbljual.Rows.Count = 0 Then
                Else
                    Dim Jumlah = Val(tbljual.Rows(0).Item("stock")) + Val(DGPenjualan.Item(4, i).Value)
                    SQL = "update tblbarang set stock = '" & CInt(Jumlah) & "' where kode_barcode = '" & DGPenjualan.Item(2, i).Value & "'"
                    Proses.ExecuteNonQuery(SQL)
                End If
            Next
            SQL = "delete from tblpenjualan_rinci where faktur_penjualan = '" & LblFaktur.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            LblSubTotal.Text = "Rp,"
            Call Bersih()

Keluar:
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub BarangTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarangTxt.TextChanged
        tbljual = Proses.ExecuteQuery("Select * From TblBarang where kode_barcode = '" & BarangTxt.Text & "'")
        If tbljual.Rows.Count = 0 Then
        Else
            LblNmBarang.Text = tbljual.Rows(0).Item("Nama_barang")
            LblHrg.Text = tbljual.Rows(0).Item("Harga_jual")
            LblStock.Text = tbljual.Rows(0).Item("Stock")
            TxtJml.Focus()
        End If
    End Sub
    Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel2.ClientRectangle, Color.HotPink, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel2.ClientRectangle)
    End Sub
End Class