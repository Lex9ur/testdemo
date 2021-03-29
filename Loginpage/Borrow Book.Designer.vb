<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrow_Book
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Username = New System.Windows.Forms.Label()
        Me.StudentID = New System.Windows.Forms.Label()
        Me.nameofbook = New System.Windows.Forms.Label()
        Me.dateofborrow = New System.Windows.Forms.Label()
        Me.returndate = New System.Windows.Forms.Label()
        Me.signed = New System.Windows.Forms.Label()
        Me.Txtsignedby = New System.Windows.Forms.TextBox()
        Me.TxtDateofreturn = New System.Windows.Forms.TextBox()
        Me.TxtDateofBorrow = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtStudentID = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(21, 72)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 0
        Me.Username.Text = "Username"
        '
        'StudentID
        '
        Me.StudentID.AutoSize = True
        Me.StudentID.Location = New System.Drawing.Point(21, 140)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.Size = New System.Drawing.Size(58, 13)
        Me.StudentID.TabIndex = 1
        Me.StudentID.Text = "Student ID"
        '
        'nameofbook
        '
        Me.nameofbook.AutoSize = True
        Me.nameofbook.Location = New System.Drawing.Point(4, 219)
        Me.nameofbook.Name = "nameofbook"
        Me.nameofbook.Size = New System.Drawing.Size(75, 13)
        Me.nameofbook.TabIndex = 2
        Me.nameofbook.Text = "Name of Book"
        '
        'dateofborrow
        '
        Me.dateofborrow.AutoSize = True
        Me.dateofborrow.Location = New System.Drawing.Point(234, 75)
        Me.dateofborrow.Name = "dateofborrow"
        Me.dateofborrow.Size = New System.Drawing.Size(78, 13)
        Me.dateofborrow.TabIndex = 3
        Me.dateofborrow.Text = "Date of Borrow"
        '
        'returndate
        '
        Me.returndate.AutoSize = True
        Me.returndate.Location = New System.Drawing.Point(247, 140)
        Me.returndate.Name = "returndate"
        Me.returndate.Size = New System.Drawing.Size(65, 13)
        Me.returndate.TabIndex = 4
        Me.returndate.Text = "Return Date"
        '
        'signed
        '
        Me.signed.AutoSize = True
        Me.signed.Location = New System.Drawing.Point(257, 219)
        Me.signed.Name = "signed"
        Me.signed.Size = New System.Drawing.Size(55, 13)
        Me.signed.TabIndex = 5
        Me.signed.Text = "Signed By"
        '
        'Txtsignedby
        '
        Me.Txtsignedby.Location = New System.Drawing.Point(333, 219)
        Me.Txtsignedby.Name = "Txtsignedby"
        Me.Txtsignedby.Size = New System.Drawing.Size(140, 20)
        Me.Txtsignedby.TabIndex = 6
        '
        'TxtDateofreturn
        '
        Me.TxtDateofreturn.Location = New System.Drawing.Point(333, 137)
        Me.TxtDateofreturn.Name = "TxtDateofreturn"
        Me.TxtDateofreturn.Size = New System.Drawing.Size(140, 20)
        Me.TxtDateofreturn.TabIndex = 7
        '
        'TxtDateofBorrow
        '
        Me.TxtDateofBorrow.Location = New System.Drawing.Point(333, 72)
        Me.TxtDateofBorrow.Name = "TxtDateofBorrow"
        Me.TxtDateofBorrow.Size = New System.Drawing.Size(140, 20)
        Me.TxtDateofBorrow.TabIndex = 8
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(88, 216)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(139, 20)
        Me.TxtName.TabIndex = 9
        '
        'TxtStudentID
        '
        Me.TxtStudentID.Location = New System.Drawing.Point(88, 140)
        Me.TxtStudentID.Name = "TxtStudentID"
        Me.TxtStudentID.Size = New System.Drawing.Size(139, 20)
        Me.TxtStudentID.TabIndex = 10
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(88, 72)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(139, 20)
        Me.TxtUsername.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Borrow"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Borrow_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 334)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtStudentID)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtDateofBorrow)
        Me.Controls.Add(Me.TxtDateofreturn)
        Me.Controls.Add(Me.Txtsignedby)
        Me.Controls.Add(Me.signed)
        Me.Controls.Add(Me.returndate)
        Me.Controls.Add(Me.dateofborrow)
        Me.Controls.Add(Me.nameofbook)
        Me.Controls.Add(Me.StudentID)
        Me.Controls.Add(Me.Username)
        Me.Name = "Borrow_Book"
        Me.Text = "Borrow_Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents StudentID As System.Windows.Forms.Label
    Friend WithEvents nameofbook As System.Windows.Forms.Label
    Friend WithEvents dateofborrow As System.Windows.Forms.Label
    Friend WithEvents returndate As System.Windows.Forms.Label
    Friend WithEvents signed As System.Windows.Forms.Label
    Friend WithEvents Txtsignedby As System.Windows.Forms.TextBox
    Friend WithEvents TxtDateofreturn As System.Windows.Forms.TextBox
    Friend WithEvents TxtDateofBorrow As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
