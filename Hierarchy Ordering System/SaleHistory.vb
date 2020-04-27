Public Class SaleHistory

    Private Sub SALEHISTORYBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.SALEHISTORYBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HierarchyHistoryDbDataSet)

    End Sub

    Private Sub SaleHistory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HierarchyHistoryDbDataSet.SALEHISTORY' table. You can move, or remove it, as needed.
        Me.SALEHISTORYTableAdapter.Fill(Me.HierarchyHistoryDbDataSet.SALEHISTORY)
        Me.TopMost = True
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub


    Private Sub SALEHISTORYDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SALEHISTORYDataGridView.CellContentClick

    End Sub
End Class