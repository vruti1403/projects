Public Class dashboard

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_payment.Click
        frm_payment.Show()
    End Sub

    Private Sub btn_doctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doctor.Click
        frm_doctor.Show()


    End Sub

    Private Sub btn_appointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_appointment.Click
        frm_appointment.Show()

    End Sub

    Private Sub btn_patient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_patient.Click
        frm_patient.Show()

    End Sub

    Private Sub btn_pharmacy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pharmacy.Click
        frm_pharmacy.Show()
    End Sub

    Private Sub btn_ward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ward.Click
        frm_ward.Show()
    End Sub
End Class