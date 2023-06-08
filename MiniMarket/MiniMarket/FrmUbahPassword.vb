Public Class FrmUbahPassword
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblUbahPsw As DataTable
    Sub bersih()
        PswLamaTxt.Text = ""
        PswBaruTxt.Text = ""
        PswLamaTxt.Focus()
    End Sub
    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If PswLamaTxt.Text = "" Then PswLamaTxt.Focus() : Exit Sub
        If PswBaruTxt.Text = "" Then PswBaruTxt.Focus() : Exit Sub
        tblUbahPsw = Proses.ExecuteQuery("Select * From TblPengguna Where password ='" & PswLamaTxt.Text & "'")
        If tblUbahPsw.Rows.Count = 0 Then
            MessageBox.Show("Perubahan Password tidak berhasil..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PswLamaTxt.SelectedText = PswLamaTxt.Text
            PswLamaTxt.Focus()
        Else
            SQL = "Update TblPengguna Set password = '" & PswBaruTxt.Text & "' where kode_pengguna = '" & FrmMenuUtama.TsPengguna.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Password telah diubah..!!", "Perubahan Password Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call bersih()
            Me.Close()
        End If
    End Sub
    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        Me.Close()
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            PswBaruTxt.UseSystemPasswordChar = False
        Else
            PswBaruTxt.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PswLamaTxt.UseSystemPasswordChar = False
        Else
            PswLamaTxt.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub PswBaruTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PswBaruTxt.Leave
        If PswBaruTxt.Text = "Masukan Password Baru" Or PswBaruTxt.Text = "" Then
            PswBaruTxt.Text = "Masukan Password Baru"
            PswBaruTxt.ForeColor = Color.DimGray

            PswBaruTxt.PasswordChar = "x"
        End If
    End Sub
    Private Sub PswBaruTxt_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PswBaruTxt.MouseClick
        If PswBaruTxt.Text = "Masukan Password Baru" Then
            PswBaruTxt.Clear()
            PswBaruTxt.ForeColor = Color.DimGray

            PswBaruTxt.PasswordChar = "x"
        End If
    End Sub
    Private Sub PswLamaTxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PswLamaTxt.Leave
        If PswLamaTxt.Text = "Masukan Password Lama" Or PswLamaTxt.Text = "" Then
            PswLamaTxt.Text = "Masukan Password Lama"
            PswLamaTxt.ForeColor = Color.DimGray

            PswLamaTxt.PasswordChar = "x"
        End If
    End Sub
    Private Sub PswLamaTxt_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PswLamaTxt.MouseClick
        If PswLamaTxt.Text = "Masukan Password Lama" Then
            PswLamaTxt.Clear()
            PswLamaTxt.ForeColor = Color.DimGray

            PswLamaTxt.PasswordChar = "x"
        End If
    End Sub
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim i As New System.Drawing.Drawing2D.LinearGradientBrush _
           (Panel1.ClientRectangle, Color.Gold, Color.WhiteSmoke, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(i, Panel1.ClientRectangle)
    End Sub
End Class