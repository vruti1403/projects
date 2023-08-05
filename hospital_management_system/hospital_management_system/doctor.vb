Public Class frm_doctor

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_managementDataSet)

    End Sub


    Private Sub Doctor_detailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Doctor_detailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Doctor_detailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_managementDataSet)

    End Sub

    Private Sub frm_doctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_managementDataSet.doctor_details' table. You can move, or remove it, as needed.
        Me.Doctor_detailsTableAdapter.Fill(Me.Hospital_managementDataSet.doctor_details)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click

    End Sub

    Private Sub lbl_doctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_doctor.Click

    End Sub
End Class