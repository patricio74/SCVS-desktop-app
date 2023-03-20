<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.course = New System.Windows.Forms.TextBox()
        Me.yrsec = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.middlename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.stdNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Indigo
        Me.Button1.Location = New System.Drawing.Point(161, 603)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 72)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "PROCEED"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Indigo
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gold
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 26)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Return"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'course
        '
        Me.course.BackColor = System.Drawing.Color.White
        Me.course.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.course.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course.ForeColor = System.Drawing.Color.Indigo
        Me.course.Location = New System.Drawing.Point(89, 467)
        Me.course.MaxLength = 50
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(246, 27)
        Me.course.TabIndex = 34
        Me.course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yrsec
        '
        Me.yrsec.BackColor = System.Drawing.Color.White
        Me.yrsec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.yrsec.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yrsec.ForeColor = System.Drawing.Color.Indigo
        Me.yrsec.Location = New System.Drawing.Point(91, 399)
        Me.yrsec.MaxLength = 10
        Me.yrsec.Name = "yrsec"
        Me.yrsec.Size = New System.Drawing.Size(244, 27)
        Me.yrsec.TabIndex = 33
        Me.yrsec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(88, 446)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 18)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Course:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(88, 510)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 18)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Email:"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.White
        Me.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.email.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Indigo
        Me.email.Location = New System.Drawing.Point(91, 531)
        Me.email.MaxLength = 50
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(344, 27)
        Me.email.TabIndex = 35
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 378)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 18)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Year/Section:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(88, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 18)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Last name:"
        '
        'lastname
        '
        Me.lastname.BackColor = System.Drawing.Color.White
        Me.lastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lastname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.ForeColor = System.Drawing.Color.Indigo
        Me.lastname.Location = New System.Drawing.Point(91, 333)
        Me.lastname.MaxLength = 50
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(344, 27)
        Me.lastname.TabIndex = 32
        Me.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Middle name:"
        '
        'middlename
        '
        Me.middlename.BackColor = System.Drawing.Color.White
        Me.middlename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.middlename.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename.ForeColor = System.Drawing.Color.Indigo
        Me.middlename.Location = New System.Drawing.Point(91, 263)
        Me.middlename.MaxLength = 50
        Me.middlename.Name = "middlename"
        Me.middlename.Size = New System.Drawing.Size(344, 27)
        Me.middlename.TabIndex = 31
        Me.middlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "First name:"
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.White
        Me.firstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.firstname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.Indigo
        Me.firstname.Location = New System.Drawing.Point(91, 192)
        Me.firstname.MaxLength = 50
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(344, 27)
        Me.firstname.TabIndex = 30
        Me.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Student Number:"
        '
        'stdNum
        '
        Me.stdNum.BackColor = System.Drawing.Color.White
        Me.stdNum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdNum.ForeColor = System.Drawing.Color.Indigo
        Me.stdNum.Location = New System.Drawing.Point(91, 125)
        Me.stdNum.MaxLength = 20
        Me.stdNum.Name = "stdNum"
        Me.stdNum.Size = New System.Drawing.Size(244, 27)
        Me.stdNum.TabIndex = 29
        Me.stdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Voter Information Form"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(529, 730)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.yrsec)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.middlename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.stdNum)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents course As TextBox
    Friend WithEvents yrsec As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents middlename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents stdNum As TextBox
    Friend WithEvents Label1 As Label
End Class
