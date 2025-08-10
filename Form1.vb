Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Public Class Form1
    'Private Label1 As Object
    'Private Label2 As Object
    'Private Label3 As Object
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim con As SQLConnection = New SQLConnection("Data Source=Visual-Program\NKSQL;Initial Catalog=vbmultiuser;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
        Dim cmd As SQLCommand = New SQLCommand("select * from login where username=' " & txtUser.Text & "' and password=' " & txtPass.Text & "' and usertype=' " & ComboBox1.SelectedItem & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("You are loggined as " + dt.Rows(0)(2))
        Else
            MessageBox.Show("error")
        End If

        'MessageBox.Show(Label1.Text)
        'Dim con As SQLConnection = New SQLConnection("Data Source=Visual-Program\NKSQL;Initial Catalog=vbmultiuser;Integrated Security=True")
        'Dim cmd As SQLCommand = New SQLCommand("select * from login where username = ' " & txtUser.Text & " ' password = ' " & txtPass.Text & "' and usertype = '" & ComboBox1.SelectedItem & "'", con)
        'Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        'MessageBox.Show(username.Text)
        'MessageBox.Show(password.Text)
        'MessageBox.Show(ComboBox1.SelectedItem)
        'Dim dt As DataTable = New DataTable()
        'sda.Fill(dt)
        'If (dt.Rows.Count > 0) Then
        'MessageBox.Show("You are Logined as " + dt.Rows(0)(2))
        'Else
        'MessageBox.Show("error")

        'End If
    End Sub
End Class
