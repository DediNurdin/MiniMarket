Public Class FrmPembelian
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblbeli As DataTable
    Dim disc As Single
    Sub Data_Record()
        tblbeli = Proses.ExecuteQuery("Select No, Kode_Barang, Nama_Barang, Harga_Beli, Jumlah, Sub_Total From Tblpembelian_rinci where faktur_pembelian = '" & LblFaktur.Text & "' order by tblpembelian_rinci.no asc")
        DGPembelian.DataSource = tblbeli
        DGPembelian.Columns(0).Width = 50
        DGPembelian.Columns(1).Width = 100
        DGPembelian.Columns(3).Width = 230
        DGPembelian.Columns(4).Width = 110
        DGPembelian.Columns(5).Width = 90
    End Sub
    Sub Suplier()
        tblbeli = Proses.ExecuteQuery("Select * From TblSupplier order by Kode_Supplier asc")
        If tblbeli.Rows.Count = 0 Then
        Else
            CmbSupplier.Items.Clear()
            With tblbeli.Columns(1)
                For a = 0 To tblbeli.Rows.Count - 1
                    CmbSupplier.Items.Add(.Table.Rows(a).Item(0) + "/" + .Table.Rows(a).Item(1))
                Next a
            End With
        End If
    End Sub
    Sub Barang()
        tblbeli = Proses.ExecuteQuery("Select * From TblBarang order by kode_barang asc")
        If tblbeli.Rows.Count = 0 Then
        Else
            CmbBarang.Items.Clear()
            With tblbeli.Columns(1)
                For a = 0 To tblbeli.Rows.Count - 1
                    CmbBarang.Items.Add(.Table.Rows(a).Item(0) + "/" + .Table.Rows(a).Item(2))
                Next a
            End With
        End If
    End Sub
    Sub Bersih()
        CmbBarang.Text = ""
        LblNmBarang.Text = ""
        LblHrg.Text = ""
        LblStock.Text = ""
        TxtJml.Text = ""
        CmbSupplier.Enabled = True
        CmbBarang.Enabled = True
        CmbBarang.Focus()

        Call Suplier()
        Call Barang()
        Call Faktur_Otomatis()
        Call Data_Record()

        On Error Resume Next

        Dim Total_seluruh As Single

        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            Total_seluruh = Val(Total_seluruh) + Val(DGPembelian.Item(5, i).Value)
        Next
        LblTotHrgKotor.Text = Total_seluruh.ToString("#,#")
    End Sub
    Sub Faktur_Otomatis()
        tblbeli = Proses.ExecuteQuery("Select * From TblPembelian order by Faktur_Pembelian desc")
        If tblbeli.Rows.Count = 0 Then
            LblFaktur.Text = "0001"
        Else
            With tblbeli.Rows(0)
                LblFaktur.Text = .Item("Faktur_Pembelian")
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
        Me.DGPembelian.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGPembelian.Columns(0).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPembelian.Columns(1).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPembelian.Columns(2).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPembelian.Columns(3).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPembelian.Columns(4).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPembelian.Columns(5).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)

        Me.DGPembelian.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPembelian.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGPembelian.DefaultCellStyle.Font = New Font("Arial Narrow", 10)

        Me.DGPembelian.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub CmbSupplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSupplier.KeyPress
        e.KeyChar = Chr(0)
    End Sub
    Private Sub CmbSupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSupplier.TextChanged
        tblbeli = Proses.ExecuteQuery("Select * From TblSupplier where kode_supplier = '" & Mid(CmbSupplier.Text, 1, 6) & "'")
        If tblbeli.Rows.Count = 0 Then
        Else
            LblNmSupplier.Text = tblbeli.Rows(0).Item("Nama_Supplier")
        End If
    End Sub
    Private Sub CmbBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbBarang.KeyPress
        e.KeyChar = Chr(0)
    End Sub
    Private Sub CmbBarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBarang.TextChanged
        tblbeli = Proses.ExecuteQuery("Select * From TblBarang where Kode_Barang = '" & Mid(CmbBarang.Text, 1, 6) & "'")
        If tblbeli.Rows.Count = 0 Then
        Else
            LblNmBarang.Text = tblbeli.Rows(0).Item("Nama_Barang")
            LblHrg.Text = tblbeli.Rows(0).Item("Harga_Beli")
            LblStock.Text = tblbeli.Rows(0).Item("Stock")
            TxtJml.Focus()
        End If
    End Sub
    Private Sub DiscTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiscTxt.TextChanged
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"

        disc = (Val(Replace(LblTotHrgKotor.Text, ".", "") * DiscTxt.Text)) / 100

        LblTotHrgBersih.Text = (Val(Replace(LblTotHrgKotor.Text, ".", "")) - Val(disc)).ToString("#,#")
    End Sub
    Private Sub LblTotHrgBersih_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblTotHrgBersih.TextChanged
        If LblTotHrgBersih.Text = "" Then LblTotHrgBersih.Text = "0"
    End Sub
    Private Sub BatalBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            tblbeli = Proses.ExecuteQuery("select * from tblbarang where kode_barang = '" & DGPembelian.Item(2, i).Value & "'")
            If tblbeli.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tblbeli.Rows(0).Item("stock")) - Val(DGPembelian.Item(4, i).Value)
                SQL = "update tblbarang set stock = '" & CInt(Jumlah) & "' where kode_barang = '" & DGPembelian.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next
        SQL = "delete from tblpembelian_rinci where faktur_pembelian = '" & LblFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        LblTotHrgKotor.Text = "0"
        DiscTxt.Text = "0"
        LblTotHrgBersih.Text = "0"
        Call Bersih()
Keluar:
    End Sub
    Private Sub SimpanBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If LblTotHrgKotor.Text = "0" Then Exit Sub
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"

        SQL = "Insert Into Tblpembelian Values ('" & LblFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & Microsoft.VisualBasic.Left(CmbSupplier.Text, 6) & "','" & DiscTxt.Text & "','" & Replace(LblTotHrgBersih.Text, ".", "") & "')"
        Proses.ExecuteNonQuery(SQL)
        Call Bersih()
        CmbSupplier.Text = ""
        LblNmSupplier.Text = ""
        LblTotHrgKotor.Text = "0"
        LblTotHrgBersih.Text = "0"
        DiscTxt.Text = "0"
        CmbSupplier.Focus()
    End Sub
    Private Sub FrmPembelian_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Bersih()
        Call editgd()
        SimpanBtn.Enabled = False
        DGPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub TxtJml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJml.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJml.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)

            Case Chr(13)
                tblbeli = Proses.ExecuteQuery("select * from tblpembelian_rinci where faktur_pembelian = '" & LblFaktur.Text & "' and kode_barang = '" & Mid(CmbBarang.Text, 1, 6) & "'")
                If tblbeli.Rows.Count = 0 Then
                    Dim total = Val(LblHrg.Text) * Val(TxtJml.Text)
                    SQL = "Insert Into Tblpembelian_rinci Values ('" & LblFaktur.Text & "','" & DGPembelian.RowCount & "','" & Mid(CmbBarang.Text, 1, 6) & "','" & LblNmBarang.Text & "','" & LblHrg.Text & "','" & TxtJml.Text & "','" & total & "')"
                    Proses.ExecuteNonQuery(SQL)

                    Dim stock = Val(LblStock.Text) + Val(TxtJml.Text)
                    SQL = "update tblbarang set stock = '" & stock & "' where kode_barang = '" & Mid(CmbBarang.Text, 1, 6) & "'"
                    Proses.ExecuteNonQuery(SQL)

                    SimpanBtn.Enabled = True
                Else
                    MsgBox("Proses pembelian tidak dapat dilakukan !")
                End If
                Call Bersih()

                Dim Total_seluruh As Single

                Dim i As Integer
                i = DGPembelian.CurrentRow.Index
                For i = 0 To DGPembelian.Rows.Count - 1
                    Total_seluruh = Val(Total_seluruh) + Val(DGPembelian.Item(5, i).Value)
                Next

                LblTotHrgKotor.Text = Total_seluruh.ToString("#,#")
                disc = (Val(Replace(LblTotHrgBersih.Text, ".", "") * DiscTxt.Text)) / 100
                LblTotHrgBersih.Text = (Val(Replace(LblTotHrgKotor.Text, ".", "")) - Val(disc)).ToString("#,#")
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel1.ClientRectangle, Color.MediumAquamarine, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
End Class