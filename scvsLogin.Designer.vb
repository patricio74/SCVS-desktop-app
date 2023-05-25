<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scvsLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scvsLogin))
        Me.panelSidebar = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.btnRFID = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radAdmin = New System.Windows.Forms.RadioButton()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.grpUserLogin = New System.Windows.Forms.GroupBox()
        Me.lblForgotPass = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblNoAcc = New System.Windows.Forms.Label()
        Me.grpRFIDLogin = New System.Windows.Forms.GroupBox()
        Me.txtboxRFID = New System.Windows.Forms.TextBox()
        Me.lblRFID = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.grpReg = New System.Windows.Forms.GroupBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblHaveAcc = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.btnRegStudent = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.middlename = New System.Windows.Forms.TextBox()
        Me.txtRFID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboxYear = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboxCourse = New System.Windows.Forms.ComboBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.panelRegister = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContactNum = New System.Windows.Forms.MaskedTextBox()
        Me.panelSidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLogin.SuspendLayout()
        Me.grpUserLogin.SuspendLayout()
        Me.grpRFIDLogin.SuspendLayout()
        Me.grpReg.SuspendLayout()
        Me.panelRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSidebar
        '
        Me.panelSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelSidebar.Controls.Add(Me.Label6)
        Me.panelSidebar.Controls.Add(Me.PictureBox1)
        Me.panelSidebar.Controls.Add(Me.Label5)
        Me.panelSidebar.Controls.Add(Me.Label8)
        Me.panelSidebar.Controls.Add(Me.Label7)
        Me.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSidebar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.panelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.panelSidebar.Name = "panelSidebar"
        Me.panelSidebar.Size = New System.Drawing.Size(244, 572)
        Me.panelSidebar.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(33, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Student Council Voting System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.VotingSystem_Perez.My.Resources.Resources.icon92px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(88, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(48, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 52)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SCVS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(37, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 36)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Empowering student voices," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "one vote at a time."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(47, 543)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "©2023 BSIT-3F Group 5"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(328, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Log into your SCVS account."
        '
        'panelLogin
        '
        Me.panelLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelLogin.BackColor = System.Drawing.Color.Goldenrod
        Me.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLogin.Controls.Add(Me.Label4)
        Me.panelLogin.Controls.Add(Me.btnRFID)
        Me.panelLogin.Controls.Add(Me.btnPassword)
        Me.panelLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelLogin.Location = New System.Drawing.Point(241, 0)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(711, 55)
        Me.panelLogin.TabIndex = 9
        '
        'btnRFID
        '
        Me.btnRFID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRFID.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnRFID.Location = New System.Drawing.Point(566, 9)
        Me.btnRFID.Name = "btnRFID"
        Me.btnRFID.Size = New System.Drawing.Size(121, 39)
        Me.btnRFID.TabIndex = 7
        Me.btnRFID.Text = "Use RFID"
        Me.btnRFID.UseVisualStyleBackColor = True
        '
        'btnPassword
        '
        Me.btnPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPassword.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnPassword.Location = New System.Drawing.Point(528, 9)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(159, 39)
        Me.btnPassword.TabIndex = 8
        Me.btnPassword.Text = "Use Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        Me.btnPassword.Visible = False
        '
        'chkShow
        '
        Me.chkShow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShow.AutoSize = True
        Me.chkShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.chkShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.ForeColor = System.Drawing.Color.White
        Me.chkShow.Location = New System.Drawing.Point(44, 159)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(58, 18)
        Me.chkShow.TabIndex = 3
        Me.chkShow.Text = "Show"
        Me.chkShow.UseVisualStyleBackColor = False
        '
        'lblPass
        '
        Me.lblPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(41, 104)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(88, 16)
        Me.lblPass.TabIndex = 30
        Me.lblPass.Text = "PASSWORD"
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(41, 39)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(85, 16)
        Me.lblUser.TabIndex = 29
        Me.lblUser.Text = "USERNAME"
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxPassword.BackColor = System.Drawing.Color.White
        Me.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxPassword.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtboxPassword.Location = New System.Drawing.Point(44, 123)
        Me.txtboxPassword.MaxLength = 25
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(297, 33)
        Me.txtboxPassword.TabIndex = 2
        Me.txtboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtboxPassword.UseSystemPasswordChar = True
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxUsername.BackColor = System.Drawing.Color.White
        Me.txtboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtboxUsername.Location = New System.Drawing.Point(44, 58)
        Me.txtboxUsername.MaxLength = 25
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(297, 33)
        Me.txtboxUsername.TabIndex = 1
        Me.txtboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.BackColor = System.Drawing.Color.Transparent
        Me.radStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.radStudent.Location = New System.Drawing.Point(571, 105)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(78, 24)
        Me.radStudent.TabIndex = 6
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Student"
        Me.radStudent.UseVisualStyleBackColor = False
        '
        'radAdmin
        '
        Me.radAdmin.AutoSize = True
        Me.radAdmin.BackColor = System.Drawing.Color.Transparent
        Me.radAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.radAdmin.Location = New System.Drawing.Point(496, 105)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(69, 24)
        Me.radAdmin.TabIndex = 5
        Me.radAdmin.TabStop = True
        Me.radAdmin.Text = "Admin"
        Me.radAdmin.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblLogin.Location = New System.Drawing.Point(410, 110)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(80, 16)
        Me.lblLogin.TabIndex = 25
        Me.lblLogin.Text = "LOGIN AS:"
        '
        'grpUserLogin
        '
        Me.grpUserLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.grpUserLogin.Controls.Add(Me.lblRegister)
        Me.grpUserLogin.Controls.Add(Me.lblForgotPass)
        Me.grpUserLogin.Controls.Add(Me.lblNoAcc)
        Me.grpUserLogin.Controls.Add(Me.lblUser)
        Me.grpUserLogin.Controls.Add(Me.chkShow)
        Me.grpUserLogin.Controls.Add(Me.txtboxUsername)
        Me.grpUserLogin.Controls.Add(Me.lblPass)
        Me.grpUserLogin.Controls.Add(Me.txtboxPassword)
        Me.grpUserLogin.Location = New System.Drawing.Point(368, 145)
        Me.grpUserLogin.Name = "grpUserLogin"
        Me.grpUserLogin.Size = New System.Drawing.Size(384, 244)
        Me.grpUserLogin.TabIndex = 0
        Me.grpUserLogin.TabStop = False
        '
        'lblForgotPass
        '
        Me.lblForgotPass.AutoSize = True
        Me.lblForgotPass.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPass.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPass.ForeColor = System.Drawing.Color.White
        Me.lblForgotPass.Location = New System.Drawing.Point(226, 159)
        Me.lblForgotPass.Name = "lblForgotPass"
        Me.lblForgotPass.Size = New System.Drawing.Size(115, 18)
        Me.lblForgotPass.TabIndex = 33
        Me.lblForgotPass.Text = "Forgot password?"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegister.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.White
        Me.lblRegister.Location = New System.Drawing.Point(204, 207)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(58, 18)
        Me.lblRegister.TabIndex = 32
        Me.lblRegister.Text = "Register"
        '
        'lblNoAcc
        '
        Me.lblNoAcc.AutoSize = True
        Me.lblNoAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblNoAcc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNoAcc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoAcc.ForeColor = System.Drawing.Color.White
        Me.lblNoAcc.Location = New System.Drawing.Point(42, 207)
        Me.lblNoAcc.Name = "lblNoAcc"
        Me.lblNoAcc.Size = New System.Drawing.Size(163, 18)
        Me.lblNoAcc.TabIndex = 31
        Me.lblNoAcc.Text = "Don't have an account yet?"
        '
        'grpRFIDLogin
        '
        Me.grpRFIDLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.grpRFIDLogin.Controls.Add(Me.txtboxRFID)
        Me.grpRFIDLogin.Controls.Add(Me.lblRFID)
        Me.grpRFIDLogin.Location = New System.Drawing.Point(368, 168)
        Me.grpRFIDLogin.Name = "grpRFIDLogin"
        Me.grpRFIDLogin.Size = New System.Drawing.Size(384, 194)
        Me.grpRFIDLogin.TabIndex = 26
        Me.grpRFIDLogin.TabStop = False
        '
        'txtboxRFID
        '
        Me.txtboxRFID.BackColor = System.Drawing.Color.White
        Me.txtboxRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxRFID.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtboxRFID.Location = New System.Drawing.Point(45, 86)
        Me.txtboxRFID.MaxLength = 10
        Me.txtboxRFID.Name = "txtboxRFID"
        Me.txtboxRFID.Size = New System.Drawing.Size(299, 37)
        Me.txtboxRFID.TabIndex = 20
        Me.txtboxRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtboxRFID.UseSystemPasswordChar = True
        '
        'lblRFID
        '
        Me.lblRFID.AutoSize = True
        Me.lblRFID.BackColor = System.Drawing.Color.Transparent
        Me.lblRFID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFID.ForeColor = System.Drawing.Color.White
        Me.lblRFID.Location = New System.Drawing.Point(42, 67)
        Me.lblRFID.Name = "lblRFID"
        Me.lblRFID.Size = New System.Drawing.Size(41, 16)
        Me.lblRFID.TabIndex = 24
        Me.lblRFID.Text = "RFID"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Goldenrod
        Me.btnLogin.BackgroundImage = Global.VotingSystem_Perez.My.Resources.Resources.icons8_right_100
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(520, 400)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(80, 80)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'grpReg
        '
        Me.grpReg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpReg.BackColor = System.Drawing.Color.Transparent
        Me.grpReg.Controls.Add(Me.txtContactNum)
        Me.grpReg.Controls.Add(Me.lblLog)
        Me.grpReg.Controls.Add(Me.lblHaveAcc)
        Me.grpReg.Controls.Add(Me.Label44)
        Me.grpReg.Controls.Add(Me.firstname)
        Me.grpReg.Controls.Add(Me.btnRegStudent)
        Me.grpReg.Controls.Add(Me.Label9)
        Me.grpReg.Controls.Add(Me.Label2)
        Me.grpReg.Controls.Add(Me.middlename)
        Me.grpReg.Controls.Add(Me.txtRFID)
        Me.grpReg.Controls.Add(Me.Label10)
        Me.grpReg.Controls.Add(Me.Label1)
        Me.grpReg.Controls.Add(Me.lastname)
        Me.grpReg.Controls.Add(Me.pass)
        Me.grpReg.Controls.Add(Me.Label11)
        Me.grpReg.Controls.Add(Me.cboxYear)
        Me.grpReg.Controls.Add(Me.Label12)
        Me.grpReg.Controls.Add(Me.cboxCourse)
        Me.grpReg.Controls.Add(Me.email)
        Me.grpReg.Controls.Add(Me.Label13)
        Me.grpReg.Controls.Add(Me.Label15)
        Me.grpReg.Location = New System.Drawing.Point(241, 55)
        Me.grpReg.Name = "grpReg"
        Me.grpReg.Size = New System.Drawing.Size(711, 517)
        Me.grpReg.TabIndex = 69
        Me.grpReg.TabStop = False
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.BackColor = System.Drawing.Color.Transparent
        Me.lblLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLog.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblLog.Location = New System.Drawing.Point(441, 441)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(46, 20)
        Me.lblLog.TabIndex = 10
        Me.lblLog.Text = "Login"
        '
        'lblHaveAcc
        '
        Me.lblHaveAcc.AutoSize = True
        Me.lblHaveAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblHaveAcc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHaveAcc.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaveAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblHaveAcc.Location = New System.Drawing.Point(264, 441)
        Me.lblHaveAcc.Name = "lblHaveAcc"
        Me.lblHaveAcc.Size = New System.Drawing.Size(178, 20)
        Me.lblHaveAcc.TabIndex = 70
        Me.lblHaveAcc.Text = "Already have an account?"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(369, 272)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(124, 22)
        Me.Label44.TabIndex = 69
        Me.Label44.Text = "Phone number:"
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.White
        Me.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstname.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.firstname.Location = New System.Drawing.Point(41, 68)
        Me.firstname.MaxLength = 25
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(291, 31)
        Me.firstname.TabIndex = 0
        '
        'btnRegStudent
        '
        Me.btnRegStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRegStudent.BackColor = System.Drawing.Color.Goldenrod
        Me.btnRegStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegStudent.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnRegStudent.Location = New System.Drawing.Point(301, 373)
        Me.btnRegStudent.Name = "btnRegStudent"
        Me.btnRegStudent.Size = New System.Drawing.Size(158, 54)
        Me.btnRegStudent.TabIndex = 9
        Me.btnRegStudent.Text = "Register"
        Me.btnRegStudent.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(38, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 22)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(370, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 22)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "RFID:"
        '
        'middlename
        '
        Me.middlename.BackColor = System.Drawing.Color.White
        Me.middlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.middlename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.middlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.middlename.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.middlename.Location = New System.Drawing.Point(41, 142)
        Me.middlename.MaxLength = 25
        Me.middlename.Name = "middlename"
        Me.middlename.Size = New System.Drawing.Size(291, 31)
        Me.middlename.TabIndex = 1
        '
        'txtRFID
        '
        Me.txtRFID.BackColor = System.Drawing.Color.White
        Me.txtRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRFID.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtRFID.Location = New System.Drawing.Point(373, 218)
        Me.txtRFID.MaxLength = 10
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(291, 31)
        Me.txtRFID.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(38, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 22)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Middle name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(370, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Password:"
        '
        'lastname
        '
        Me.lastname.BackColor = System.Drawing.Color.White
        Me.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastname.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lastname.Location = New System.Drawing.Point(41, 218)
        Me.lastname.MaxLength = 25
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(291, 31)
        Me.lastname.TabIndex = 2
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.White
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pass.Location = New System.Drawing.Point(373, 142)
        Me.pass.MaxLength = 25
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(291, 31)
        Me.pass.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(38, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 22)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Last name:"
        '
        'cboxYear
        '
        Me.cboxYear.BackColor = System.Drawing.Color.White
        Me.cboxYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxYear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cboxYear.FormattingEnabled = True
        Me.cboxYear.Items.AddRange(New Object() {"1A", "1B", "1C", "1D", "1E", "1F", "2A", "2B", "2C", "2D", "2E", "2F", "3A", "3B", "3C", "3D", "3E", "3F", "4A", "4B", "4C", "4D"})
        Me.cboxYear.Location = New System.Drawing.Point(42, 369)
        Me.cboxYear.Name = "cboxYear"
        Me.cboxYear.Size = New System.Drawing.Size(106, 26)
        Me.cboxYear.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(38, 344)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 22)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Year/Section:"
        '
        'cboxCourse
        '
        Me.cboxCourse.BackColor = System.Drawing.Color.White
        Me.cboxCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCourse.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cboxCourse.FormattingEnabled = True
        Me.cboxCourse.Items.AddRange(New Object() {"BS INFORMATION TECHNOLOGY", "BS COMPUTER ENGINEERING", "BS ELEMENTARY EDUCATION", "BS SECONDARY EDUCATION", "BS ENTREPRENEURSHIP", "BS BUSINESS MANAGEMENT"})
        Me.cboxCourse.Location = New System.Drawing.Point(41, 297)
        Me.cboxCourse.Name = "cboxCourse"
        Me.cboxCourse.Size = New System.Drawing.Size(291, 26)
        Me.cboxCourse.TabIndex = 3
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.White
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.email.Location = New System.Drawing.Point(373, 68)
        Me.email.MaxLength = 25
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(291, 31)
        Me.email.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(369, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 22)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Email:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(38, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 22)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Course:"
        '
        'panelRegister
        '
        Me.panelRegister.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelRegister.BackColor = System.Drawing.Color.Goldenrod
        Me.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRegister.Controls.Add(Me.Label3)
        Me.panelRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelRegister.Location = New System.Drawing.Point(241, 0)
        Me.panelRegister.Name = "panelRegister"
        Me.panelRegister.Size = New System.Drawing.Size(711, 55)
        Me.panelRegister.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Register to SCVS."
        '
        'txtContactNum
        '
        Me.txtContactNum.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtContactNum.Location = New System.Drawing.Point(373, 297)
        Me.txtContactNum.Mask = "+63-000-000-0000"
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(291, 31)
        Me.txtContactNum.TabIndex = 8
        '
        'scvsLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 572)
        Me.Controls.Add(Me.radStudent)
        Me.Controls.Add(Me.radAdmin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.panelSidebar)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.panelRegister)
        Me.Controls.Add(Me.grpUserLogin)
        Me.Controls.Add(Me.grpRFIDLogin)
        Me.Controls.Add(Me.grpReg)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "scvsLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to SCVS!"
        Me.panelSidebar.ResumeLayout(False)
        Me.panelSidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        Me.grpUserLogin.ResumeLayout(False)
        Me.grpUserLogin.PerformLayout()
        Me.grpRFIDLogin.ResumeLayout(False)
        Me.grpRFIDLogin.PerformLayout()
        Me.grpReg.ResumeLayout(False)
        Me.grpReg.PerformLayout()
        Me.panelRegister.ResumeLayout(False)
        Me.panelRegister.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelSidebar As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents panelLogin As Panel
    Friend WithEvents btnRFID As Button
    Friend WithEvents btnPassword As Button
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radAdmin As RadioButton
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents grpUserLogin As GroupBox
    Friend WithEvents grpRFIDLogin As GroupBox
    Friend WithEvents txtboxRFID As TextBox
    Friend WithEvents lblRFID As Label
    Friend WithEvents lblForgotPass As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblNoAcc As Label
    Friend WithEvents grpReg As GroupBox
    Friend WithEvents Label44 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents btnRegStudent As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents middlename As TextBox
    Friend WithEvents txtRFID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboxYear As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboxCourse As ComboBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblLog As Label
    Friend WithEvents lblHaveAcc As Label
    Friend WithEvents panelRegister As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContactNum As MaskedTextBox
End Class
