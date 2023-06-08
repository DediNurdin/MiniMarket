Public Class FrmLogin
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblLogin As DataTable
    Sub Login()
        If KdPenggunaTxt.Text = "" Then KdPenggunaTxt.Focus() : Exit Sub
        If PswTxt.Text = "" Then PswTxt.Focus() : Exit Sub
        tblLogin = Proses.ExecuteQuery("Select * From TblPengguna Where kode_pengguna = '" & KdPenggunaTxt.Text & "' and password = '" & PswTxt.Text & "'")
        If tblLogin.Rows.Count = 0 Then
            MessageBox.Show("Password atau Id Pengguna Tidak Valid...!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            KdPenggunaTxt.Focus()
        Else
            FrmMenuUtama.TsPengguna.Text = KdPenggunaTxt.Text
            FrmMenuUtama.TsLevel.Text = LevelTxt.Text
            FrmMenuUtama.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub KdPenggunaTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles KdPenggunaTxt.KeyPress
        If e.KeyChar = Chr(13) Then
            tblLogin = Proses.ExecuteQuery("Select * From TblPengguna Where kode_pengguna = '" & KdPenggunaTxt.Text & "'")
            If tblLogin.Rows.Count = 0 Then
                MessageBox.Show("Id tidak ditemukan..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                KdPenggunaTxt.Focus()
            Else
                LevelTxt.Text = tblLogin.Rows(0).Item("level")
                PswTxt.Focus()
            End If
        End If
    End Sub
    Private Sub PswTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PswTxt.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub
    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        Call Login()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PswTxt.UseSystemPasswordChar = False
        Else
            PswTxt.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub KdPenggunaTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles KdPenggunaTxt.Leave
        If KdPenggunaTxt.Text = "Id Pengguna" Or KdPenggunaTxt.Text = "" Then
            KdPenggunaTxt.ForeColor = Color.DimGray
            KdPenggunaTxt.Text = "Id Pengguna"
        End If
    End Sub
    Private Sub KdPenggunaTxt_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles KdPenggunaTxt.MouseClick
        If KdPenggunaTxt.Text = "Id Pengguna" Then
            KdPenggunaTxt.Clear()
            KdPenggunaTxt.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub PswTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PswTxt.Leave
        If PswTxt.Text = "Password" Or PswTxt.Text = "" Then
            PswTxt.Text = "Password"
            PswTxt.ForeColor = Color.DimGray
            PswTxt.PasswordChar = "x"
        End If
    End Sub
    Private Sub PswTxt_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PswTxt.MouseClick
        If PswTxt.Text = "Password" Then
            PswTxt.Clear()
            PswTxt.ForeColor = Color.DimGray
            PswTxt.PasswordChar = "x"
        End If
    End Sub
    Private Sub LevelTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LevelTxt.Leave
        If LevelTxt.Text = "Level" Or LevelTxt.Text = "" Then
            LevelTxt.ForeColor = Color.DimGray
            LevelTxt.Text = "Level"
        End If
    End Sub
    Private Sub LevelTxt_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LevelTxt.MouseClick
        If LevelTxt.Text = "Level" Then
            LevelTxt.Clear()
            LevelTxt.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub BtnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        End
    End Sub
    Private Sub BtnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class