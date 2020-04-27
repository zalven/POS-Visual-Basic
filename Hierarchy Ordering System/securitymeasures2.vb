Imports System.Data.OleDb
Public Class securitymeasures2
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HierarchyDb.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand(
                   "SELECT * FROM admin WHERE username = '" &
                   username.Text & "' AND [password] = '" & password.Text & "' ", con)
        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            Hierarchy_Cashier_Form.cancel()
            Hierarchy_Cashier_Form.compute()
            Hierarchy_Cashier_Form.receiptoimage.Height = 200
            Hierarchy_Cashier_Form.receiptoimage.Width = 212
            Me.Close()
        Else

        End If
    End Sub

    Private Sub closeform_Click(sender As System.Object, e As System.EventArgs) Handles closeform.Click
        Me.Close()
    End Sub
End Class