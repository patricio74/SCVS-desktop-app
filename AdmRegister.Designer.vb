﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdmRegister))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.stdnum = New System.Windows.Forms.TextBox()
        Me.cboxCourse = New System.Windows.Forms.ComboBox()
        Me.cboxYear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(207, 653)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 72)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 26)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Return"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(106, 472)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 18)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Course:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(104, 550)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 18)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Email:"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.WhiteSmoke
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.email.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Black
        Me.email.Location = New System.Drawing.Point(107, 571)
        Me.email.MaxLength = 50
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(390, 27)
        Me.email.TabIndex = 35
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(392, 472)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 18)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Year/Sect:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(106, 396)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 18)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Last name:"
        '
        'lastname
        '
        Me.lastname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lastname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.ForeColor = System.Drawing.Color.Black
        Me.lastname.Location = New System.Drawing.Point(109, 417)
        Me.lastname.MaxLength = 50
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(388, 27)
        Me.lastname.TabIndex = 32
        Me.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(106, 318)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Middle name:"
        '
        'middlename
        '
        Me.middlename.BackColor = System.Drawing.Color.WhiteSmoke
        Me.middlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.middlename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.middlename.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename.ForeColor = System.Drawing.Color.Black
        Me.middlename.Location = New System.Drawing.Point(109, 339)
        Me.middlename.MaxLength = 50
        Me.middlename.Name = "middlename"
        Me.middlename.Size = New System.Drawing.Size(388, 27)
        Me.middlename.TabIndex = 31
        Me.middlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(106, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "First name:"
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.firstname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.Black
        Me.firstname.Location = New System.Drawing.Point(109, 260)
        Me.firstname.MaxLength = 50
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(388, 27)
        Me.firstname.TabIndex = 30
        Me.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(57, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 38)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Student Information Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(106, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Student number:"
        '
        'stdnum
        '
        Me.stdnum.BackColor = System.Drawing.Color.WhiteSmoke
        Me.stdnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stdnum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdnum.ForeColor = System.Drawing.Color.Black
        Me.stdnum.Location = New System.Drawing.Point(109, 186)
        Me.stdnum.MaxLength = 11
        Me.stdnum.Name = "stdnum"
        Me.stdnum.Size = New System.Drawing.Size(288, 27)
        Me.stdnum.TabIndex = 29
        Me.stdnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboxCourse
        '
        Me.cboxCourse.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboxCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.cboxCourse.FormattingEnabled = True
        Me.cboxCourse.Items.AddRange(New Object() {"BS Information Technology", "BS Computer Engineering", "BS Elementary Education", "BS Secondary Education", "BS Entrepreneurship", "BS Business Management"})
        Me.cboxCourse.Location = New System.Drawing.Point(109, 494)
        Me.cboxCourse.Name = "cboxCourse"
        Me.cboxCourse.Size = New System.Drawing.Size(280, 26)
        Me.cboxCourse.TabIndex = 33
        '
        'cboxYear
        '
        Me.cboxYear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboxYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.cboxYear.FormattingEnabled = True
        Me.cboxYear.Items.AddRange(New Object() {"1A", "1B", "1C", "1D", "2A", "2B", "2C", "2D", "3A", "3B", "3C", "3D", "4A", "4B", "4C", "4D"})
        Me.cboxYear.Location = New System.Drawing.Point(395, 494)
        Me.cboxYear.Name = "cboxYear"
        Me.cboxYear.Size = New System.Drawing.Size(102, 26)
        Me.cboxYear.TabIndex = 34
        '
        'AdmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(593, 780)
        Me.Controls.Add(Me.cboxYear)
        Me.Controls.Add(Me.cboxCourse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.stdnum)
        Me.Controls.Add(Me.Label1)
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
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "AdmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents stdnum As TextBox
    Friend WithEvents cboxCourse As ComboBox
    Friend WithEvents cboxYear As ComboBox
End Class
