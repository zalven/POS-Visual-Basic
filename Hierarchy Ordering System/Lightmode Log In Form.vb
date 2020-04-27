Imports System.Data.OleDb
Public Class Lightlogin
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        If acticashier.Checked Then
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HierarchyDb.accdb")
            Dim cmd As OleDbCommand = New OleDbCommand(
                       "SELECT * FROM cashier WHERE username = '" &
                       username.Text & "' AND [password] = '" & password.Text & "' ", con)
            con.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                Me.Hide()
                Hierarchy_Cashier_Form.Usname = username.Text
                Hierarchy_Cashier_Form.Show()
            Else
                logininfoerror.Show()
            End If
        ElseIf actiadmin.Checked Then
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\HierarchyDb.accdb")
            Dim cmd As OleDbCommand = New OleDbCommand(
                       "SELECT * FROM admin WHERE username = '" &
                       username.Text & "' AND [password] = '" & password.Text & "' ", con)
            con.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                Me.Hide()
                Hierarchy_Admin_Form.Show()
            Else
                logininfoerror.Show()
            End If
        Else
            acctypelblerr.Show()
        End If
    End Sub


    Private Sub closebtn_Click(sender As System.Object, e As System.EventArgs) 
        Me.Close()
        LoadingForm.Close()
    End Sub

    Private Sub minimizebtn_Click(sender As System.Object, e As System.EventArgs) 
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub username_TextChanged(sender As System.Object, e As System.EventArgs) Handles username.TextChanged
        actiadmin.Checked = False
        acticashier.Checked = False
        acctypelblerr.Hide()
        logininfoerror.Hide()
    End Sub

    Private Sub actiadmin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles actiadmin.CheckedChanged
        acctypelblerr.Hide()
        logininfoerror.Hide()
    End Sub

    Private Sub acticashier_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles acticashier.CheckedChanged
        acctypelblerr.Hide()
        logininfoerror.Hide()
    End Sub

    Private Sub password_TextChanged(sender As System.Object, e As System.EventArgs) Handles password.TextChanged
        acctypelblerr.Hide()
        actiadmin.Checked = False
        acticashier.Checked = False
        logininfoerror.Hide()
    End Sub

    Private Sub Lightlogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class