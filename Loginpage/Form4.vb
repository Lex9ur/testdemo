Public Class Form4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Username As String = TxtUsename.Text
        Dim Studentid As String = TxtStudentid.Text
        Dim nameofbook As String = TxtNameofbook.Text
        Dim Lossdate As String = TxtLossdate.Text
        Dim Datereported As String = TxtReportdate.Text
        Dim Signed As String = TxtSignedby.Text
        If Username = "Alex Kyali" Or Studentid = "18/45678" Or nameofbook = "The Rise" Or Lossdate = "02/3/2020" Then
 Or Datereported = "12/12/2020" Or Signed = "Lec Kamau Kitonga" Then
            MessageBox.Show("Borrow_Book has been reported")
        Else
            MessageBox.Show("Report failed")
        End If



    End Sub
End Class