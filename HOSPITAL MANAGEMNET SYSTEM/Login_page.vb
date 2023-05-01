
Imports System.Text.RegularExpressions
Public Class Login_page

    Dim count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim err As ErrorProvider = New ErrorProvider()
        Dim un_regex As Regex = New Regex("^[a-z A-Z 0-9]{3,20}@[a-zA-Z]{3,20}.(com|in)$")
        Dim pwd_regex As Regex = New Regex("^[a-zA-Z0-9!@#$%^&*()~]{8,20}$")
        Dim un_valid As Boolean
        Dim pwd_valid As Boolean
        count = count + 1
        If count < 3 Then
            un_valid = un_regex.IsMatch(TextBox1.Text)
            pwd_valid = pwd_regex.IsMatch(TextBox2.Text)
            If un_valid And pwd_valid Then
                MessageBox.Show("LOGIN SUCCESSFUL!!! WELCOME TO THE LIFECARE HOSPITAL!", "RESULT-->", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Form1.Show()
                Me.Close()
            End If
            If un_valid = False Then
                err.SetError(TextBox1, "Invalid Username !")
            End If
            If pwd_valid = False Then
                err.SetError(TextBox2, "Invalid Password !")
            End If
        Else
            MessageBox.Show("Sorry! You can't login to the LIFECARE hospital's management system!!!", "Invalid access !!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub Login_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class