Public Class FrmBayar
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tbljual As DataTable
    Dim disc As Single
    Sub Bersih()
        LblSubTotal.Text = ""
        DiscTxt.Text = ""
        LblGrandTot.Text = "0"
        BayarTxt.Text = "0"
        LblKembali.Text = "0"
    End Sub
    Private Sub BtnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If BayarTxt.Text = "0" Then Exit Sub
        If BayarTxt.Text < Replace(LblGrandTot.Text, ".", "") Then MsgBox("Pembayaran tidak cukup", MsgBoxStyle.Critical, "Bayar")
        SQL = "Insert Into Tblpenjualan Values ('" & FrmPenjualan.LblFaktur.Text & "','" &
            Format(Now, "yyyy/MM/dd") & "','" &
            Microsoft.VisualBasic.Left(FrmPenjualan.CmbPelanggan.Text, 7) & "','" &
            Replace(LblSubTotal.Text, ".", "") & "','" & DiscTxt.Text & "','" &
            Replace(LblGrandTot.Text, ".", "") & "','" & BayarTxt.Text & "','" &
            Replace(LblKembali.Text, ".", "") & "')"
        Proses.ExecuteNonQuery(SQL)


        Call Bersih()

        FrmPenjualan.Bersih()
        FrmPenjualan.BarangTxt.Focus()
        Me.Close()
    End Sub
    Private Sub FrmBayar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        DiscTxt.Focus()
    End Sub
    Private Sub DiscTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DiscTxt.TextChanged
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"
        disc = (Val(Replace(LblSubTotal.Text, ".", "") * DiscTxt.Text)) / 100
        LblGrandTot.Text = (Val(Replace(LblSubTotal.Text, ".", "")) - Val(disc)).ToString("#,#")
    End Sub
    Private Sub LblGrandTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblGrandTot.TextChanged
        If LblGrandTot.Text = "" Then LblGrandTot.Text = "0"
    End Sub
    Private Sub BatalBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        FrmPenjualan.BarangTxt.Focus()
        Me.Close()
    End Sub
    Private Sub BayarTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BayarTxt.TextChanged
        If BayarTxt.Text = "" Then BayarTxt.Text = "0"
        LblKembali.Text = Val(BayarTxt.Text) - Replace(LblGrandTot.Text, ".", "")
        Dim Kembali As Single
        Kembali = Replace(LblKembali.Text, ".", "")
        LblKembali.Text = Kembali.ToString("#,#")
        If LblKembali.Text = "" Then LblKembali.Text = "0"
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel1.ClientRectangle, Color.LightSteelBlue, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
End Class