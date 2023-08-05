Public Class frm_pharmacy

    Private Sub PharmacyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PharmacyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_managementDataSet)

    End Sub

    Private Sub frm_pharmacy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_managementDataSet.pharmacy' table. You can move, or remove it, as needed.
        Me.PharmacyTableAdapter.Fill(Me.Hospital_managementDataSet.pharmacy)

    End Sub
End Class