Public Class Form1

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
      
        If TextBox1.Text = "17001" Then
            Hierarchy_Admin_Form.TabControl2.SelectTab(1)
            Hierarchy_Admin_Form.Label8.Text = "ADMIN"
            Me.Close()
            Hierarchy_Admin_Form.Panel36.Visible = True
            Hierarchy_Admin_Form.Panel37.Visible = False
        Else
            Label1.Visible = True

        End If



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class