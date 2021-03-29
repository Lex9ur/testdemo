Public Class Borrow_Book

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStudentID.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim myForm As New Form3

        myForm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Username As String = TxtUsername.Text
        Dim StudentID As String = TxtStudentID.Text
        Dim nameofbook As String = TxtName.Text
        Dim dateofborrow As String = TxtDateofBorrow.Text
        Dim returndate As String = TxtDateofreturn.Text
        Dim signed As String = Txtsignedby.Text
        If Username = "Dennis" Or StudentID = "17/45900" Or nameofbook = "Importance of LIving happy" Or
            dateofborrow = "12/12/2020" Or returndate = "3/20/2021" Or signed = "Samel Abdul" Then
            MessageBox.Show("Book borrowed")
        Else
            MessageBox.Show("Book not borrowed")
        End If

    End Sub
End Class