Public Class Purchase_Book

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim myForm As New Form3

        myForm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Username As String = TxtUsername.Text
        Dim StudentID As String = TxtStudentid.Text
        Dim nameofbook As String = Txtname.Text
        Dim Purchasedate As String = Txtpurchase.Text
        Dim Amount As String = Txtpayed.Text
        Dim signed As String = Txtsignedby.Text
        If Username = "Mutua" Or StudentID = "16/78690" Or nameofbook = "Articulater" Or Purchasedate = "10/2/2021" Or Amount = "Ksh2500" Or signed = "Dr.Kuria" Then
            MessageBox.Show("Book authorised  for purchase")
        Else
            MessageBox.Show("Book not authorised for sale")
        End If
    End Sub
End Class