Public Class Pharmacy
    Dim bill As Double = 0.0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name, sym As String
        Dim no As Double

        name = TextBox1.Text + " " + TextBox2.Text         'name of customer
        sym = TextBox4.Text                                'symptoms
        no = TextBox3.Text                                 ' no

        Pharmacy_bill.Show()

        Pharmacy_bill.TextBox1.Text = name                 'add everything to pharmavy_bill
        Pharmacy_bill.TextBox2.Text = no
        Pharmacy_bill.TextBox3.Text = sym

        'assign total bill 
        Pharmacy_bill.TextBox5.Text = bill
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Add(ComboBox1.SelectedItem)    'adds the item selected into list
        'logic of bill calculation 
        If ComboBox1.SelectedIndex = 0 Then
            bill += 8.09
        End If
        If ComboBox1.SelectedIndex = 1 Then
            bill += 3
        End If
        If ComboBox1.SelectedIndex = 2 Then
            bill += 1000
        End If
        If ComboBox1.SelectedIndex = 3 Then
            bill += 16.73
        End If
        If ComboBox1.SelectedIndex = 4 Then
            bill += 60
        End If
        If ComboBox1.SelectedIndex = 5 Then
            bill += 5.5
        End If
        If ComboBox1.SelectedIndex = 6 Then
            bill += 6.6
        End If
        If ComboBox1.SelectedIndex = 7 Then
            bill += 139
        End If
        If ComboBox1.SelectedIndex = 8 Then
            bill += 550
        End If
        If ComboBox1.SelectedIndex = 9 Then
            bill += 40
        End If
    End Sub

End Class