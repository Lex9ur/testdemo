Public Class Returnbook

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nameofbook.Click, Nameofbook.Click, nameofbbok.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPickdate.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim myForm As New Form3

        myForm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Username As String = TxtUsername.Text
        Dim StudentID As String = TxtStudentid.Text
        Dim nameofbook As String = TxtNameofbook.Text
        Dim Pickdate As String = TxtPickdate.Text
        Dim Returndate As String = Txtreturndate.Text
        Dim Author As String = TxtAuthorrr.Text
        If Username = "Cathrine" Or StudentID = "12/23456" Or nameofbook = "Physics" Or
            Pickdate = "5/3/2020" Or Returndate = "10/4/2020" Or Author = "C.M.Macharia" Then
            MessageBox.Show(" Book returned")
        Else
            MessageBox.Show("Book not returned")
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class