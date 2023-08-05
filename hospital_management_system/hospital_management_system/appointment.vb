Public Class frm_appointment

    Private Sub frm_appointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_managementDataSet.appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.Hospital_managementDataSet.appointments)

    End Sub

    Private Sub AppointmentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AppointmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_managementDataSet)

    End Sub
End Class