Public Class FrmLoading
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Hide()
            FrmLogin.Show()
        End If
        Label5.Text = Math.Round((ProgressBar1.Value / 100) * 100, 1) & "%"
    End Sub
End Class