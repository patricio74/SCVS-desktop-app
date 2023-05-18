<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SCVS_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCVS_Login))
        Me.panelSidebar = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.lblRFIDRegister = New System.Windows.Forms.Label()
        Me.txtboxRFID = New System.Windows.Forms.TextBox()
        Me.lblRFID = New System.Windows.Forms.Label()
        Me.lblRFIDNoAcc = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.panelSidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grpUserLogin.SuspendLayout()
        Me.grpRFIDLogin.SuspendLayout()
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
        Me.panelSidebar.Size = New System.Drawing.Size(244, 524)
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
        Me.Label7.Location = New System.Drawing.Point(47, 495)
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnRFID)
        Me.Panel1.Controls.Add(Me.btnPassword)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(241, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 56)
        Me.Panel1.TabIndex = 9
        '
        'btnRFID
        '
        Me.btnRFID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRFID.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnRFID.Location = New System.Drawing.Point(566, 9)
        Me.btnRFID.Name = "btnRFID"
        Me.btnRFID.Size = New System.Drawing.Size(121, 40)
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
        Me.btnPassword.Size = New System.Drawing.Size(159, 40)
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
        Me.chkShow.BackColor = System.Drawing.Color.Transparent
        Me.chkShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.chkShow.Location = New System.Drawing.Point(44, 179)
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
        Me.lblPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblPass.Location = New System.Drawing.Point(41, 123)
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
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(41, 58)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(85, 16)
        Me.lblUser.TabIndex = 29
        Me.lblUser.Text = "USERNAME"
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxPassword.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtboxPassword.Location = New System.Drawing.Point(44, 142)
        Me.txtboxPassword.MaxLength = 25
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(297, 31)
        Me.txtboxPassword.TabIndex = 2
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
        Me.txtboxUsername.Location = New System.Drawing.Point(44, 77)
        Me.txtboxUsername.MaxLength = 25
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(297, 31)
        Me.txtboxUsername.TabIndex = 1
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
        Me.grpUserLogin.BackColor = System.Drawing.Color.White
        Me.grpUserLogin.Controls.Add(Me.lblForgotPass)
        Me.grpUserLogin.Controls.Add(Me.lblRegister)
        Me.grpUserLogin.Controls.Add(Me.lblNoAcc)
        Me.grpUserLogin.Controls.Add(Me.lblUser)
        Me.grpUserLogin.Controls.Add(Me.chkShow)
        Me.grpUserLogin.Controls.Add(Me.txtboxUsername)
        Me.grpUserLogin.Controls.Add(Me.lblPass)
        Me.grpUserLogin.Controls.Add(Me.txtboxPassword)
        Me.grpUserLogin.Location = New System.Drawing.Point(368, 145)
        Me.grpUserLogin.Name = "grpUserLogin"
        Me.grpUserLogin.Size = New System.Drawing.Size(384, 242)
        Me.grpUserLogin.TabIndex = 0
        Me.grpUserLogin.TabStop = False
        '
        'lblForgotPass
        '
        Me.lblForgotPass.AutoSize = True
        Me.lblForgotPass.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPass.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblForgotPass.Location = New System.Drawing.Point(226, 200)
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
        Me.lblRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblRegister.Location = New System.Drawing.Point(203, 26)
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
        Me.lblNoAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblNoAcc.Location = New System.Drawing.Point(42, 26)
        Me.lblNoAcc.Name = "lblNoAcc"
        Me.lblNoAcc.Size = New System.Drawing.Size(163, 18)
        Me.lblNoAcc.TabIndex = 31
        Me.lblNoAcc.Text = "Don't have an account yet?"
        '
        'grpRFIDLogin
        '
        Me.grpRFIDLogin.BackColor = System.Drawing.Color.White
        Me.grpRFIDLogin.Controls.Add(Me.lblRFIDRegister)
        Me.grpRFIDLogin.Controls.Add(Me.txtboxRFID)
        Me.grpRFIDLogin.Controls.Add(Me.lblRFID)
        Me.grpRFIDLogin.Controls.Add(Me.lblRFIDNoAcc)
        Me.grpRFIDLogin.Location = New System.Drawing.Point(368, 145)
        Me.grpRFIDLogin.Name = "grpRFIDLogin"
        Me.grpRFIDLogin.Size = New System.Drawing.Size(384, 215)
        Me.grpRFIDLogin.TabIndex = 26
        Me.grpRFIDLogin.TabStop = False
        '
        'lblRFIDRegister
        '
        Me.lblRFIDRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblRFIDRegister.AutoSize = True
        Me.lblRFIDRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRFIDRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRFIDRegister.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFIDRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblRFIDRegister.Location = New System.Drawing.Point(203, 148)
        Me.lblRFIDRegister.Name = "lblRFIDRegister"
        Me.lblRFIDRegister.Size = New System.Drawing.Size(58, 18)
        Me.lblRFIDRegister.TabIndex = 35
        Me.lblRFIDRegister.Text = "Register"
        '
        'txtboxRFID
        '
        Me.txtboxRFID.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtboxRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxRFID.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtboxRFID.Location = New System.Drawing.Point(45, 86)
        Me.txtboxRFID.MaxLength = 10
        Me.txtboxRFID.Name = "txtboxRFID"
        Me.txtboxRFID.Size = New System.Drawing.Size(299, 37)
        Me.txtboxRFID.TabIndex = 20
        Me.txtboxRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRFID
        '
        Me.lblRFID.AutoSize = True
        Me.lblRFID.BackColor = System.Drawing.Color.Transparent
        Me.lblRFID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblRFID.Location = New System.Drawing.Point(42, 67)
        Me.lblRFID.Name = "lblRFID"
        Me.lblRFID.Size = New System.Drawing.Size(41, 16)
        Me.lblRFID.TabIndex = 24
        Me.lblRFID.Text = "RFID"
        '
        'lblRFIDNoAcc
        '
        Me.lblRFIDNoAcc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblRFIDNoAcc.AutoSize = True
        Me.lblRFIDNoAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblRFIDNoAcc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRFIDNoAcc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFIDNoAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblRFIDNoAcc.Location = New System.Drawing.Point(42, 148)
        Me.lblRFIDNoAcc.Name = "lblRFIDNoAcc"
        Me.lblRFIDNoAcc.Size = New System.Drawing.Size(163, 18)
        Me.lblRFIDNoAcc.TabIndex = 34
        Me.lblRFIDNoAcc.Text = "Don't have an account yet?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Goldenrod
        Me.btnLogin.BackgroundImage = Global.VotingSystem_Perez.My.Resources.Resources.icons8_right_100
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(520, 397)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(80, 80)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'SCVS_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 524)
        Me.Controls.Add(Me.radStudent)
        Me.Controls.Add(Me.radAdmin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.panelSidebar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpUserLogin)
        Me.Controls.Add(Me.grpRFIDLogin)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SCVS_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to SCVS!"
        Me.panelSidebar.ResumeLayout(False)
        Me.panelSidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpUserLogin.ResumeLayout(False)
        Me.grpUserLogin.PerformLayout()
        Me.grpRFIDLogin.ResumeLayout(False)
        Me.grpRFIDLogin.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents lblRFIDRegister As Label
    Friend WithEvents lblRFIDNoAcc As Label
End Class
