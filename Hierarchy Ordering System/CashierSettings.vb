Public Class CashierSettings

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Me.Close()
        Hierarchy_Cashier_Form.Show()
    End Sub

    Private Sub OvalShape2_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape2.Click
        If OvalShape2.Left > 336 Then
            Timer2.Start()
        End If

        If OvalShape2.Left < 364 Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        OvalShape2.Left += 5
        If OvalShape2.Left >= 364 Then
            Timer1.Stop()
            RectangleShape2.FillColor = Color.FromArgb(0, 158, 89)
            Adsform.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location + New Point(100, 100)
            Adsform.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        OvalShape2.Left -= 5
        If OvalShape2.Left <= 336 Then
            Timer2.Stop()
            RectangleShape2.FillColor = Color.FromArgb(64, 64, 64)
            Adsform.Close()

        End If
    End Sub

    Private Sub OvalShape1_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape1.Click
        If OvalShape1.Left > 336 Then
            Timer4.Start()
        End If

        If OvalShape1.Left < 364 Then
            Timer3.Start()
        End If
    End Sub


    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        OvalShape1.Left += 5
        If OvalShape1.Left >= 364 Then
            Timer3.Stop()
            RectangleShape1.FillColor = Color.FromArgb(0, 158, 89)
            Hierarchy_Cashier_Form.FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        OvalShape1.Left -= 5
        If OvalShape1.Left <= 336 Then
            Timer4.Stop()
            RectangleShape1.FillColor = Color.FromArgb(64, 64, 64)
            Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
            Dim x As Integer = boundWidth - Me.Width
            Dim y As Integer = boundHeight - Me.Height
            Hierarchy_Cashier_Form.Height = y
            Hierarchy_Cashier_Form.Width = x
            Hierarchy_Cashier_Form.WindowState = FormWindowState.Maximized
            Hierarchy_Cashier_Form.FormBorderStyle = FormBorderStyle.None
            'Hierarchy_Cashier_Form.TopMost = True
        End If
    End Sub



    Private Sub CashierSettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class