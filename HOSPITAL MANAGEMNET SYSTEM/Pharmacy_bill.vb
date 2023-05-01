Public Class Pharmacy_bill

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'give acknowledgement to user
        MessageBox.Show("Medcines Booked successfully !!!", "***Pharmacy Bill -->", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Me.Close()
    End Sub

End Class