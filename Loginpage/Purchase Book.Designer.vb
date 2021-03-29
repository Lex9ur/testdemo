<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_Book
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
        Me.Purchasedate = New System.Windows.Forms.Label()
        Me.Amount = New System.Windows.Forms.Label()
        Me.signed = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.TxtStudentid = New System.Windows.Forms.TextBox()
        Me.Txtpurchase = New System.Windows.Forms.TextBox()
        Me.Txtsignedby = New System.Windows.Forms.TextBox()
        Me.Txtpayed = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(13, 45)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 0
        Me.Username.Text = "Username"
        '
        'StudentID
        '
        Me.StudentID.AutoSize = True
        Me.StudentID.Location = New System.Drawing.Point(15, 127)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.Size = New System.Drawing.Size(58, 13)
        Me.StudentID.TabIndex = 1
        Me.StudentID.Text = "Student ID"
        '
        'nameofbook
        '
        Me.nameofbook.AutoSize = True
        Me.nameofbook.Location = New System.Drawing.Point(-2, 194)
        Me.nameofbook.Name = "nameofbook"
        Me.nameofbook.Size = New System.Drawing.Size(75, 13)
        Me.nameofbook.TabIndex = 2
        Me.nameofbook.Text = "Name of Book"
        '
        'Purchasedate
        '
        Me.Purchasedate.AutoSize = True
        Me.Purchasedate.Location = New System.Drawing.Point(226, 45)
        Me.Purchasedate.Name = "Purchasedate"
        Me.Purchasedate.Size = New System.Drawing.Size(89, 13)
        Me.Purchasedate.TabIndex = 3
        Me.Purchasedate.Text = "Date of purchase"
        '
        'Amount
        '
        Me.Amount.AutoSize = True
        Me.Amount.Location = New System.Drawing.Point(239, 127)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(76, 13)
        Me.Amount.TabIndex = 4
        Me.Amount.Text = "Amount Payed"
        '
        'signed
        '
        Me.signed.AutoSize = True
        Me.signed.Location = New System.Drawing.Point(260, 194)
        Me.signed.Name = "signed"
        Me.signed.Size = New System.Drawing.Size(55, 13)
        Me.signed.TabIndex = 5
        Me.signed.Text = "Signed By"
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(76, 191)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(144, 20)
        Me.Txtname.TabIndex = 6
        '
        'TxtStudentid
        '
        Me.TxtStudentid.Location = New System.Drawing.Point(76, 124)
        Me.TxtStudentid.Name = "TxtStudentid"
        Me.TxtStudentid.Size = New System.Drawing.Size(144, 20)
        Me.TxtStudentid.TabIndex = 7
        '
        'Txtpurchase
        '
        Me.Txtpurchase.Location = New System.Drawing.Point(321, 42)
        Me.Txtpurchase.Name = "Txtpurchase"
        Me.Txtpurchase.Size = New System.Drawing.Size(170, 20)
        Me.Txtpurchase.TabIndex = 8
        '
        'Txtsignedby
        '
        Me.Txtsignedby.Location = New System.Drawing.Point(321, 191)
        Me.Txtsignedby.Name = "Txtsignedby"
        Me.Txtsignedby.Size = New System.Drawing.Size(170, 20)
        Me.Txtsignedby.TabIndex = 9
        '
        'Txtpayed
        '
        Me.Txtpayed.Location = New System.Drawing.Point(321, 124)
        Me.Txtpayed.Name = "Txtpayed"
        Me.Txtpayed.Size = New System.Drawing.Size(170, 20)
        Me.Txtpayed.TabIndex = 10
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(76, 42)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(144, 20)
        Me.TxtUsername.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(321, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Purchase"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(76, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Purchase_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 309)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Txtpayed)
        Me.Controls.Add(Me.Txtsignedby)
        Me.Controls.Add(Me.Txtpurchase)
        Me.Controls.Add(Me.TxtStudentid)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.signed)
        Me.Controls.Add(Me.Amount)
        Me.Controls.Add(Me.Purchasedate)
        Me.Controls.Add(Me.nameofbook)
        Me.Controls.Add(Me.StudentID)
        Me.Controls.Add(Me.Username)
        Me.Name = "Purchase_Book"
        Me.Text = "Purchase_Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents StudentID As System.Windows.Forms.Label
    Friend WithEvents nameofbook As System.Windows.Forms.Label
    Friend WithEvents Purchasedate As System.Windows.Forms.Label
    Friend WithEvents Amount As System.Windows.Forms.Label
    Friend WithEvents signed As System.Windows.Forms.Label
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents TxtStudentid As System.Windows.Forms.TextBox
    Friend WithEvents Txtpurchase As System.Windows.Forms.TextBox
    Friend WithEvents Txtsignedby As System.Windows.Forms.TextBox
    Friend WithEvents Txtpayed As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
