Public Class FrmPengguna
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblPengguna As DataTable
    Sub Data_Record()
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna")
        DGPengguna.DataSource = tblPengguna
        DGPengguna.Columns(1).Width = 200
        DGPengguna.Columns(2).Visible = False
    End Sub
    Sub Kode_Otomatis()
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna order by kode_pengguna desc")
        If tblPengguna.Rows.Count = 0 Then
            KdPenggunaTxt.Text = "PGN-001"
        Else
            With tblPengguna.Rows(0)
                KdPenggunaTxt.Text = .Item("Kode_Pengguna")
                KdPenggunaTxt.Focus()
            End With
            KdPenggunaTxt.Text = Val(Microsoft.VisualBasic.Mid(KdPenggunaTxt.Text, 5, 3)) + 1
            If Len(KdPenggunaTxt.Text) = 1 Then
                KdPenggunaTxt.Text = "PGN-00" & KdPenggunaTxt.Text & ""
            ElseIf Len(KdPenggunaTxt.Text) = 2 Then
                KdPenggunaTxt.Text = "PGN-0" & KdPenggunaTxt.Text & ""
            ElseIf Len(KdPenggunaTxt.Text) = 3 Then
                KdPenggunaTxt.Text = "PGN-" & KdPenggunaTxt.Text & ""
            End If
        End If
    End Sub
    Sub Bersih()
        KdPenggunaTxt.Enabled = True : KdPenggunaTxt.Text = "" : NmPenggunaTxt.Text = ""
        Call Kode_Otomatis()
        Call Data_Record()
        SimpanBtn.Enabled = True : UbahBtn.Enabled = False : HapusBtn.Enabled = False
        BatalBtn.Enabled = False : TutupBtn.Enabled = True : KdPenggunaTxt.Enabled = False
        PasswordTxt.Enabled = True : UlgPassword.Enabled = True
    End Sub
    Sub editgd()
        Me.DGPengguna.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPengguna.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPengguna.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGPengguna.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGPengguna.Columns(0).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPengguna.Columns(1).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPengguna.Columns(2).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)
        Me.DGPengguna.Columns(3).HeaderCell.Style.Font = New Font("Bebas Neue", 10, FontStyle.Bold)

        Me.DGPengguna.DefaultCellStyle.Font = New Font("Arial Narrow", 10)

        Me.DGPengguna.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub
    Private Sub FrmPengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = 0
        Top = 0
        Call Bersih()
        Call editgd()
        LevelCbo.Items.Add("ADMIN")
        LevelCbo.Items.Add("OPERATOR")
        DGPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub FrmPengguna_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Data_Record()
    End Sub
    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If NmPenggunaTxt.Text = "" Then NmPenggunaTxt.Focus() : Exit Sub
        If PasswordTxt.Text = "" Then PasswordTxt.Focus() : Exit Sub
        If UlgPassword.Text = "" Then UlgPassword.Focus() : Exit Sub
        If LevelCbo.Text = "" Then LevelCbo.Focus() : Exit Sub

        If PasswordTxt.Text <> UlgPassword.Text Then MsgBox("Ulangi Password Salah..!", MsgBoxStyle.Critical, "Password") : UlgPassword.Focus() : Exit Sub
        SQL = "Insert Into TblPengguna Values ('" & KdPenggunaTxt.Text & "','" & NmPenggunaTxt.Text & "','" & PasswordTxt.Text & "','" & LevelCbo.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub
    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If NmPenggunaTxt.Text = "" Then NmPenggunaTxt.Focus() : Exit Sub
        If LevelCbo.Text = "" Then LevelCbo.Focus() : Exit Sub
        SQL = "Update TblPengguna Set Nama_Pengguna = '" & NmPenggunaTxt.Text & "',level = '" & LevelCbo.Text & "' Where Kode_Pengguna = '" & KdPenggunaTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)

        MessageBox.Show("Data telah diubah..!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub
    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete From TblPengguna Where Kode_Pengguna = '" & KdPenggunaTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub
    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        Call Bersih()
        KdPenggunaTxt.Focus()
    End Sub
    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub
    Private Sub CariDataTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CariDataTxt.TextChanged
        If CariKdPengguna.Checked = True Then
            tblPengguna = Proses.ExecuteQuery("Select * From Tblpengguna Where Kode_Pengguna Like '%" & CariDataTxt.Text & "%'")
            If tblPengguna.Rows.Count = 0 Then
                DGPengguna.DataSource = tblPengguna
                CariDataTxt.Focus()
            Else
                DGPengguna.DataSource = tblPengguna
            End If
        ElseIf CariNmPengguna.Checked = True Then
            tblPengguna = Proses.ExecuteQuery("Select * From Tblpengguna Where Nama_Pengguna Like '%" & CariDataTxt.Text & "%'")
            If tblPengguna.Rows.Count = 0 Then
                DGPengguna.DataSource = tblPengguna
                CariDataTxt.Focus()
            Else
                DGPengguna.DataSource = tblPengguna
            End If
        End If
    End Sub
    Private Sub DGPengguna_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPengguna.CellDoubleClick
        KdPenggunaTxt.Text = DGPengguna.SelectedCells(0).Value
        NmPenggunaTxt.Text = DGPengguna.SelectedCells(1).Value
        PasswordTxt.Text = DGPengguna.SelectedCells(2).Value
        UlgPassword.Text = DGPengguna.SelectedCells(3).Value
        LevelCbo.Text = DGPengguna.SelectedCells(3).Value

        SimpanBtn.Enabled = False
        UbahBtn.Enabled = True
        HapusBtn.Enabled = True
        BatalBtn.Enabled = True
        TutupBtn.Enabled = True
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel1.ClientRectangle, Color.DarkTurquoise, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTxt.UseSystemPasswordChar = False
        Else
            PasswordTxt.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            UlgPassword.UseSystemPasswordChar = False
        Else
            UlgPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub PasswordTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTxt.Leave
        If PasswordTxt.Text = "Masukan Password" Or PasswordTxt.Text = "" Then
            PasswordTxt.Text = "Masukan Password"
            PasswordTxt.ForeColor = Color.DimGray


            PasswordTxt.PasswordChar = "x"
        End If
    End Sub
    Private Sub PasswordTxt_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PasswordTxt.MouseClick
        If PasswordTxt.Text = "Masukan Password" Then
            PasswordTxt.Clear()
            PasswordTxt.ForeColor = Color.DimGray
            PasswordTxt.PasswordChar = "x"
        End If
    End Sub

    Private Sub UlgPassword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles UlgPassword.Leave
        If UlgPassword.Text = "Ulangi Password Anda" Or UlgPassword.Text = "" Then
            UlgPassword.Text = "Ulangi Password Anda"
            UlgPassword.ForeColor = Color.DimGray

            UlgPassword.PasswordChar = "x"
        End If
    End Sub

    Private Sub UlgPassword_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles UlgPassword.MouseClick
        If UlgPassword.Text = "Ulangi Password Anda" Then
            UlgPassword.Clear()
            UlgPassword.ForeColor = Color.DimGray

            UlgPassword.PasswordChar = "x"
        End If
    End Sub
End Class