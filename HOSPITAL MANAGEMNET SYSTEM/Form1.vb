Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_page.Show()
        Me.Hide()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        About_us.Show()
    End Sub

    Private Sub SevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SevicesToolStripMenuItem.Click
        Services.Show()
    End Sub

    Private Sub EmergencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmergencyToolStripMenuItem.Click
        Emergency.Show()

    End Sub

    Private Sub PharmecyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PharmecyToolStripMenuItem.Click
        Pharmacy.Show()
    End Sub

    Private Sub AppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentToolStripMenuItem.Click
        Appointment.Show()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        contact_us.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        MessageBox.Show("!!! THANK YOU !!! ", "*** LIFECARE HOSPITAL ***", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class
