Public Class frm_payment

    Private Sub PaymentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital_managementDataSet)

    End Sub

    Private Sub frm_payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital_managementDataSet.payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.Hospital_managementDataSet.payments)

    End Sub
End Class