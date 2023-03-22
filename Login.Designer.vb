<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.eye = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.eye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(183, 570)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 60)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.user.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.user.Location = New System.Drawing.Point(86, 337)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(352, 31)
        Me.user.TabIndex = 1
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pass.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pass.Location = New System.Drawing.Point(86, 429)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(352, 31)
        Me.pass.TabIndex = 2
        Me.pass.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(86, 466)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 20)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = False
        Me.CheckBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.VotingSystem_Perez.My.Resources.Resources.icons8_info_48
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(11, 701)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'eye
        '
        Me.eye.BackColor = System.Drawing.Color.Transparent
        Me.eye.BackgroundImage = CType(resources.GetObject("eye.BackgroundImage"), System.Drawing.Image)
        Me.eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.eye.InitialImage = CType(resources.GetObject("eye.InitialImage"), System.Drawing.Image)
        Me.eye.Location = New System.Drawing.Point(393, 431)
        Me.eye.Name = "eye"
        Me.eye.Size = New System.Drawing.Size(43, 27)
        Me.eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.eye.TabIndex = 19
        Me.eye.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Enter your email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Enter your student number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(47, 709)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "©2023 BSIT-3F Group 5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(-23, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(577, 38)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "   Automated Student Council   "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(176, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 32)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "GROUP #5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(-15, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(564, 38)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "             Voting System             "
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(524, 740)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.eye)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "G5 Voting System"
        CType(Me.eye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents user As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents eye As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
