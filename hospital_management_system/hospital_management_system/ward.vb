Public Class frm_ward

    Private Sub WardsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WardsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WardsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_managementDataSet)

    End Sub

    Private Sub frm_ward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_managementDataSet.wards' table. You can move, or remove it, as needed.
        Me.WardsTableAdapter.Fill(Me.Hospital_managementDataSet.wards)

    End Sub
End Class