Public Class Form2

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Username As String = TxtUsername.Text
        Dim StudentID As String = TxtStudentID.Text
        Dim PhoneNo As String = TxtPhoneNo.Text
        Dim Email As String = TxtEmail.Text
        Dim Gender As String = TxtGender.Text
        Dim Age As String = TxtAge.Text
        Dim Password As String = TxtPassword.Text
        Dim confirm As String = TxtConfirm.Text
        If Username = "Alex" Or StudentID = "18/04009" Or PhoneNo = "0740569496" Or Email = "alexmwend9@gmail.com" Or Age = "23" Or Gender = "Male" Or Password = "1234" Or confirm = "1234" Then
            Me.Hide()
            Dim myForm As New Form3
            myForm.Show()

        Else
            MessageBox.Show("Incorrect registration.")
        End If

     
    End Sub
End Class