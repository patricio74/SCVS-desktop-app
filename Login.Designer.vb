<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radAdmin = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radStudent)
        Me.GroupBox1.Controls.Add(Me.radAdmin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkShow)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtboxPassword)
        Me.GroupBox1.Controls.Add(Me.txtboxUsername)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(122, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 344)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'radStudent
        '
        Me.radStudent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radStudent.AutoSize = True
        Me.radStudent.BackColor = System.Drawing.Color.Transparent
        Me.radStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.radStudent.Location = New System.Drawing.Point(207, 43)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(78, 24)
        Me.radStudent.TabIndex = 5
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Student"
        Me.radStudent.UseVisualStyleBackColor = False
        '
        'radAdmin
        '
        Me.radAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radAdmin.AutoSize = True
        Me.radAdmin.BackColor = System.Drawing.Color.Transparent
        Me.radAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.radAdmin.Location = New System.Drawing.Point(132, 43)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(69, 24)
        Me.radAdmin.TabIndex = 4
        Me.radAdmin.TabStop = True
        Me.radAdmin.Text = "Admin"
        Me.radAdmin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LOGIN AS:"
        '
        'chkShow
        '
        Me.chkShow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShow.AutoSize = True
        Me.chkShow.BackColor = System.Drawing.Color.Transparent
        Me.chkShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.chkShow.Location = New System.Drawing.Point(49, 218)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(58, 18)
        Me.chkShow.TabIndex = 2
        Me.chkShow.Text = "Show"
        Me.chkShow.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(46, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "USERNAME"
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxPassword.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtboxPassword.Location = New System.Drawing.Point(49, 181)
        Me.txtboxPassword.MaxLength = 25
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(297, 31)
        Me.txtboxPassword.TabIndex = 1
        Me.txtboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtboxPassword.UseSystemPasswordChar = True
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxUsername.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtboxUsername.Location = New System.Drawing.Point(49, 107)
        Me.txtboxUsername.MaxLength = 25
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(297, 31)
        Me.txtboxUsername.TabIndex = 0
        Me.txtboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.Goldenrod
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(164, 245)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(70, 70)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Size = New System.Drawing.Size(640, 491)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radAdmin As RadioButton
End Class
