Public Class Adsform


    Dim a As Integer = 0
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick


        If a = 0 Then
            TabControl1.SelectedIndex = a
            a += 1
        ElseIf a = 1 Then
            TabControl1.SelectedIndex = a
            a += 1
        ElseIf a = 2 Then
            TabControl1.SelectedIndex = a
            a += 1
        ElseIf a = 3 Then
            TabControl1.SelectedIndex = a
            a += 1
        ElseIf a = 4 Then
            TabControl1.SelectedIndex = a
            a = 0
        End If
    End Sub

    Private Sub Adsform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        dateupdate.Start()
    End Sub

    Public Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Public Sub totalval_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub fnlchange_Click(sender As Object, e As EventArgs) Handles fnlchange.Click

    End Sub

    Private Sub dateupdate_Tick(sender As Object, e As EventArgs) Handles dateupdate.Tick
        datelbl.Text = System.DateTime.Now.ToShortDateString & "  " & System.DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class