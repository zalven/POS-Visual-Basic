Public Class Help

    Private Sub InfoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.InfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InfoDataSet)

    End Sub

    Private Sub Help_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InfoDataSet.info' table. You can move, or remove it, as needed.
        Me.InfoTableAdapter.Fill(Me.InfoDataSet.info)
        TabControl1.SelectedTab = TabPage1
        Panel1.Visible = True
        Panel5.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage1
        Panel1.Visible = True
        Panel5.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage2
        Panel1.Visible = False
        Panel5.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabPage3
        Panel1.Visible = False
        Panel5.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabPage4
        Panel1.Visible = False
        Panel5.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class