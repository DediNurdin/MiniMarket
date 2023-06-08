Public Class FrmAboutApp
    Dim n As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left = Label1.Left + n
        If Label1.Left < 0 Or Label1.Left > Me.Width - Label1.Width Then
            n = n * -1
        End If
    End Sub
    Private Sub FrmAboutApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
        Timer1.Start()
        n = 1
    End Sub
End Class