Public Class frm_patient

    Private Sub Patient_detailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Patient_detailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Patient_detailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_managementDataSet)

    End Sub

    Private Sub frm_patient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_managementDataSet.patient_details' table. You can move, or remove it, as needed.
        Me.Patient_detailsTableAdapter.Fill(Me.Hospital_managementDataSet.patient_details)

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class