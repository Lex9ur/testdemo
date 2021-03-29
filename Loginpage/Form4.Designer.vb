<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.Label()
        Me.Studentid = New System.Windows.Forms.Label()
        Me.Nameofbook = New System.Windows.Forms.Label()
        Me.Lossdate = New System.Windows.Forms.Label()
        Me.Datereported = New System.Windows.Forms.Label()
        Me.Signed = New System.Windows.Forms.Label()
        Me.TxtUsename = New System.Windows.Forms.TextBox()
        Me.TxtStudentid = New System.Windows.Forms.TextBox()
        Me.TxtNameofbook = New System.Windows.Forms.TextBox()
        Me.TxtLossdate = New System.Windows.Forms.TextBox()
        Me.TxtReportdate = New System.Windows.Forms.TextBox()
        Me.TxtSignedby = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(390, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(12, 41)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(52, 13)
        Me.Username.TabIndex = 2
        Me.Username.Text = "Usename"
        '
        'Studentid
        '
        Me.Studentid.AutoSize = True
        Me.Studentid.Location = New System.Drawing.Point(6, 103)
        Me.Studentid.Name = "Studentid"
        Me.Studentid.Size = New System.Drawing.Size(58, 13)
        Me.Studentid.TabIndex = 3
        Me.Studentid.Text = "Student ID"
        '
        'Nameofbook
        '
        Me.Nameofbook.AutoSize = True
        Me.Nameofbook.Location = New System.Drawing.Point(6, 162)
        Me.Nameofbook.Name = "Nameofbook"
        Me.Nameofbook.Size = New System.Drawing.Size(74, 13)
        Me.Nameofbook.TabIndex = 4
        Me.Nameofbook.Text = "Name of book"
        '
        'Lossdate
        '
        Me.Lossdate.AutoSize = True
        Me.Lossdate.Location = New System.Drawing.Point(294, 41)
        Me.Lossdate.Name = "Lossdate"
        Me.Lossdate.Size = New System.Drawing.Size(67, 13)
        Me.Lossdate.TabIndex = 5
        Me.Lossdate.Text = "Date of Loss"
        '
        'Datereported
        '
        Me.Datereported.AutoSize = True
        Me.Datereported.Location = New System.Drawing.Point(284, 103)
        Me.Datereported.Name = "Datereported"
        Me.Datereported.Size = New System.Drawing.Size(77, 13)
        Me.Datereported.TabIndex = 6
        Me.Datereported.Text = "Date Reported"
        '
        'Signed
        '
        Me.Signed.AutoSize = True
        Me.Signed.Location = New System.Drawing.Point(307, 165)
        Me.Signed.Name = "Signed"
        Me.Signed.Size = New System.Drawing.Size(54, 13)
        Me.Signed.TabIndex = 7
        Me.Signed.Text = "Signed by"
        '
        'TxtUsename
        '
        Me.TxtUsename.Location = New System.Drawing.Point(89, 38)
        Me.TxtUsename.Name = "TxtUsename"
        Me.TxtUsename.Size = New System.Drawing.Size(166, 20)
        Me.TxtUsename.TabIndex = 8
        '
        'TxtStudentid
        '
        Me.TxtStudentid.Location = New System.Drawing.Point(89, 96)
        Me.TxtStudentid.Name = "TxtStudentid"
        Me.TxtStudentid.Size = New System.Drawing.Size(166, 20)
        Me.TxtStudentid.TabIndex = 9
        '
        'TxtNameofbook
        '
        Me.TxtNameofbook.Location = New System.Drawing.Point(89, 162)
        Me.TxtNameofbook.Name = "TxtNameofbook"
        Me.TxtNameofbook.Size = New System.Drawing.Size(166, 20)
        Me.TxtNameofbook.TabIndex = 10
        '
        'TxtLossdate
        '
        Me.TxtLossdate.Location = New System.Drawing.Point(390, 38)
        Me.TxtLossdate.Name = "TxtLossdate"
        Me.TxtLossdate.Size = New System.Drawing.Size(164, 20)
        Me.TxtLossdate.TabIndex = 11
        '
        'TxtReportdate
        '
        Me.TxtReportdate.Location = New System.Drawing.Point(390, 100)
        Me.TxtReportdate.Name = "TxtReportdate"
        Me.TxtReportdate.Size = New System.Drawing.Size(164, 20)
        Me.TxtReportdate.TabIndex = 12
        '
        'TxtSignedby
        '
        Me.TxtSignedby.Location = New System.Drawing.Point(390, 165)
        Me.TxtSignedby.Name = "TxtSignedby"
        Me.TxtSignedby.Size = New System.Drawing.Size(164, 20)
        Me.TxtSignedby.TabIndex = 13
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(89, 211)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(291, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "I will adhere to Library regulations rules on missing books" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 385)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtSignedby)
        Me.Controls.Add(Me.TxtReportdate)
        Me.Controls.Add(Me.TxtLossdate)
        Me.Controls.Add(Me.TxtNameofbook)
        Me.Controls.Add(Me.TxtStudentid)
        Me.Controls.Add(Me.TxtUsename)
        Me.Controls.Add(Me.Signed)
        Me.Controls.Add(Me.Datereported)
        Me.Controls.Add(Me.Lossdate)
        Me.Controls.Add(Me.Nameofbook)
        Me.Controls.Add(Me.Studentid)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents Studentid As System.Windows.Forms.Label
    Friend WithEvents Nameofbook As System.Windows.Forms.Label
    Friend WithEvents Lossdate As System.Windows.Forms.Label
    Friend WithEvents Datereported As System.Windows.Forms.Label
    Friend WithEvents Signed As System.Windows.Forms.Label
    Friend WithEvents TxtUsename As System.Windows.Forms.TextBox
    Friend WithEvents TxtStudentid As System.Windows.Forms.TextBox
    Friend WithEvents TxtNameofbook As System.Windows.Forms.TextBox
    Friend WithEvents TxtLossdate As System.Windows.Forms.TextBox
    Friend WithEvents TxtReportdate As System.Windows.Forms.TextBox
    Friend WithEvents TxtSignedby As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
