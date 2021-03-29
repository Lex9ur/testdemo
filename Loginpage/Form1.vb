Imports System.Data
Imports System.Data.SqlClient





Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Username As String = txtUser.Text
        Dim Password As String = txtPass.Text
        If Username = "Martin" Or Password = "Martin" Then
            Me.Hide()
            Dim myForm As New Form3
            myForm.Show()
        Else
            MessageBox.Show("login Unsuccessful")
        End If






    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim myConn As New SqlConnection("server=localhost;user id=root;password=root;database=Library")
        Dim cmd As SqlCommand = New SqlCommand("select * from Login where Username='" + txtUser.Text + "' and Password='" + txtPass.Text + "'", myConn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login  Success", "information", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Login  unsuccessful", "information", MessageBoxButtons.OK)
        End If




    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim myForm As New Form2
        myForm.Show()
    End Sub
End Class
