<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scvsAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scvsAdmin))
        Me.panelSidebar = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpReg = New System.Windows.Forms.GroupBox()
        Me.txtContactNum = New System.Windows.Forms.MaskedTextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnCancelReg = New System.Windows.Forms.Button()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnClrStudent = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.updRFID = New System.Windows.Forms.TextBox()
        Me.updYear = New System.Windows.Forms.ComboBox()
        Me.updCourse = New System.Windows.Forms.ComboBox()
        Me.btnDelStudent = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnUpdStudent = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.updEmail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.updLastname = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.updMiddlename = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.updFirstname = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.stdNum = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnAddCandid = New System.Windows.Forms.Button()
        Me.cboxAddCandid = New System.Windows.Forms.ComboBox()
        Me.txtAddCandid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtCandidNum = New System.Windows.Forms.TextBox()
        Me.lblCandidPos = New System.Windows.Forms.Label()
        Me.lblCandidName = New System.Windows.Forms.Label()
        Me.cboxCandidPos = New System.Windows.Forms.ComboBox()
        Me.txtCandidName = New System.Windows.Forms.TextBox()
        Me.btnDelCandid = New System.Windows.Forms.Button()
        Me.btnUpdCandid = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblOpenLink = New System.Windows.Forms.Label()
        Me.resultWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.lblResultDate = New System.Windows.Forms.Label()
        Me.btnRefreshResult = New System.Windows.Forms.Button()
        Me.lblResultTime = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.grpMembers = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnViewWebsite = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelSidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpReg.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.grpMembers.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.panelSidebar.Size = New System.Drawing.Size(262, 1061)
        Me.panelSidebar.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(35, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Student Council Voting System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(99, 154)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(54, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 59)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SCVS"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(34, 489)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 40)
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
        Me.Label7.Location = New System.Drawing.Point(61, 1032)
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
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(430, 37)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Welcome to SCVS Admin page."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(262, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1659, 64)
        Me.Panel1.TabIndex = 101
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(1519, 11)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(121, 43)
        Me.btnLogout.TabIndex = 999
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1658, 997)
        Me.TabControl1.TabIndex = 100
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.grpReg)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1650, 959)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "   Register student   "
        '
        'grpReg
        '
        Me.grpReg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpReg.BackColor = System.Drawing.Color.White
        Me.grpReg.Controls.Add(Me.btnRegStudent)
        Me.grpReg.Controls.Add(Me.txtContactNum)
        Me.grpReg.Controls.Add(Me.Label44)
        Me.grpReg.Controls.Add(Me.btnCancelReg)
        Me.grpReg.Controls.Add(Me.firstname)
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
        Me.grpReg.Location = New System.Drawing.Point(256, 202)
        Me.grpReg.Name = "grpReg"
        Me.grpReg.Size = New System.Drawing.Size(883, 555)
        Me.grpReg.TabIndex = 68
        Me.grpReg.TabStop = False
        '
        'txtContactNum
        '
        Me.txtContactNum.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtContactNum.Location = New System.Drawing.Point(473, 352)
        Me.txtContactNum.Mask = "+63-000-000-0000"
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(355, 33)
        Me.txtContactNum.TabIndex = 8
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(469, 327)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(124, 22)
        Me.Label44.TabIndex = 69
        Me.Label44.Text = "Phone number:"
        '
        'btnCancelReg
        '
        Me.btnCancelReg.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelReg.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelReg.FlatAppearance.BorderSize = 0
        Me.btnCancelReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelReg.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnCancelReg.Location = New System.Drawing.Point(394, 492)
        Me.btnCancelReg.Name = "btnCancelReg"
        Me.btnCancelReg.Size = New System.Drawing.Size(106, 43)
        Me.btnCancelReg.TabIndex = 10
        Me.btnCancelReg.Text = "cancel"
        Me.btnCancelReg.UseVisualStyleBackColor = False
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.White
        Me.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstname.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.firstname.Location = New System.Drawing.Point(58, 96)
        Me.firstname.MaxLength = 25
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(356, 33)
        Me.firstname.TabIndex = 0
        '
        'btnRegStudent
        '
        Me.btnRegStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRegStudent.BackColor = System.Drawing.Color.Goldenrod
        Me.btnRegStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegStudent.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnRegStudent.Location = New System.Drawing.Point(350, 420)
        Me.btnRegStudent.Name = "btnRegStudent"
        Me.btnRegStudent.Size = New System.Drawing.Size(192, 69)
        Me.btnRegStudent.TabIndex = 9
        Me.btnRegStudent.Text = "Register"
        Me.btnRegStudent.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(55, 71)
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
        Me.Label2.Location = New System.Drawing.Point(469, 237)
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
        Me.middlename.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.middlename.Location = New System.Drawing.Point(58, 178)
        Me.middlename.MaxLength = 25
        Me.middlename.Name = "middlename"
        Me.middlename.Size = New System.Drawing.Size(356, 33)
        Me.middlename.TabIndex = 1
        '
        'txtRFID
        '
        Me.txtRFID.BackColor = System.Drawing.Color.White
        Me.txtRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRFID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRFID.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtRFID.Location = New System.Drawing.Point(472, 262)
        Me.txtRFID.MaxLength = 10
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(356, 33)
        Me.txtRFID.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(55, 153)
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
        Me.Label1.Location = New System.Drawing.Point(469, 153)
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
        Me.lastname.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lastname.Location = New System.Drawing.Point(58, 262)
        Me.lastname.MaxLength = 25
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(356, 33)
        Me.lastname.TabIndex = 2
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.White
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pass.Location = New System.Drawing.Point(472, 178)
        Me.pass.MaxLength = 25
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(356, 33)
        Me.pass.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(55, 237)
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
        Me.cboxYear.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cboxYear.FormattingEnabled = True
        Me.cboxYear.Items.AddRange(New Object() {"1A", "1B", "1C", "1D", "1E", "1F", "2A", "2B", "2C", "2D", "2E", "2F", "3A", "3B", "3C", "3D", "3E", "3F", "4A", "4B", "4C", "4D"})
        Me.cboxYear.Location = New System.Drawing.Point(59, 433)
        Me.cboxYear.Name = "cboxYear"
        Me.cboxYear.Size = New System.Drawing.Size(132, 31)
        Me.cboxYear.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(55, 408)
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
        Me.cboxCourse.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cboxCourse.FormattingEnabled = True
        Me.cboxCourse.Items.AddRange(New Object() {"BS INFORMATION TECHNOLOGY", "BS COMPUTER ENGINEERING", "BS ELEMENTARY EDUCATION", "BS SECONDARY EDUCATION", "BS ENTREPRENEURSHIP", "BS BUSINESS MANAGEMENT"})
        Me.cboxCourse.Location = New System.Drawing.Point(58, 352)
        Me.cboxCourse.Name = "cboxCourse"
        Me.cboxCourse.Size = New System.Drawing.Size(356, 31)
        Me.cboxCourse.TabIndex = 3
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.White
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.email.Location = New System.Drawing.Point(472, 96)
        Me.email.MaxLength = 25
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(356, 33)
        Me.email.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(468, 71)
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
        Me.Label15.Location = New System.Drawing.Point(55, 327)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 22)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Course:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(418, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(614, 61)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Student Registration Form"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.btnDelStudent)
        Me.TabPage2.Controls.Add(Me.btnUpdStudent)
        Me.TabPage2.Controls.Add(Me.btnClrStudent)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.updRFID)
        Me.TabPage2.Controls.Add(Me.updYear)
        Me.TabPage2.Controls.Add(Me.updCourse)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.updEmail)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.updLastname)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.updMiddlename)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.updFirstname)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.stdNum)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1650, 959)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "   Update student   "
        '
        'btnClrStudent
        '
        Me.btnClrStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnClrStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClrStudent.FlatAppearance.BorderSize = 0
        Me.btnClrStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClrStudent.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClrStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnClrStudent.Location = New System.Drawing.Point(842, 877)
        Me.btnClrStudent.Name = "btnClrStudent"
        Me.btnClrStudent.Size = New System.Drawing.Size(177, 43)
        Me.btnClrStudent.TabIndex = 80
        Me.btnClrStudent.Text = "clear textboxes"
        Me.btnClrStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClrStudent.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(759, 714)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 22)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "RFID:"
        '
        'updRFID
        '
        Me.updRFID.BackColor = System.Drawing.Color.White
        Me.updRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updRFID.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.updRFID.Location = New System.Drawing.Point(763, 739)
        Me.updRFID.MaxLength = 10
        Me.updRFID.Name = "updRFID"
        Me.updRFID.Size = New System.Drawing.Size(356, 37)
        Me.updRFID.TabIndex = 77
        '
        'updYear
        '
        Me.updYear.BackColor = System.Drawing.Color.White
        Me.updYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.updYear.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.updYear.FormattingEnabled = True
        Me.updYear.Items.AddRange(New Object() {"1A", "1B", "1C", "1D", "1E", "1F", "2A", "2B", "2C", "2D", "2E", "2F", "3A", "3B", "3C", "3D", "3E", "3F", "4A", "4B", "4C", "4D"})
        Me.updYear.Location = New System.Drawing.Point(989, 673)
        Me.updYear.Name = "updYear"
        Me.updYear.Size = New System.Drawing.Size(132, 31)
        Me.updYear.TabIndex = 74
        '
        'updCourse
        '
        Me.updCourse.BackColor = System.Drawing.Color.White
        Me.updCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.updCourse.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.updCourse.FormattingEnabled = True
        Me.updCourse.Items.AddRange(New Object() {"BS INFORMATION TECHNOLOGY", "BS COMPUTER ENGINEERING", "BS ELEMENTARY EDUCATION", "BS SECONDARY EDUCATION", "BS ENTREPRENEURSHIP", "BS BUSINESS MANAGEMENT"})
        Me.updCourse.Location = New System.Drawing.Point(763, 597)
        Me.updCourse.Name = "updCourse"
        Me.updCourse.Size = New System.Drawing.Size(358, 31)
        Me.updCourse.TabIndex = 73
        '
        'btnDelStudent
        '
        Me.btnDelStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnDelStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelStudent.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnDelStudent.Location = New System.Drawing.Point(958, 798)
        Me.btnDelStudent.Name = "btnDelStudent"
        Me.btnDelStudent.Size = New System.Drawing.Size(139, 65)
        Me.btnDelStudent.TabIndex = 79
        Me.btnDelStudent.Text = "DELETE"
        Me.btnDelStudent.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(170, 154)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1109, 402)
        Me.ListView1.TabIndex = 66
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student no."
        Me.ColumnHeader1.Width = 92
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First name"
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Middle name"
        Me.ColumnHeader3.Width = 134
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last name"
        Me.ColumnHeader4.Width = 134
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Course"
        Me.ColumnHeader5.Width = 229
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Yr/Sec"
        Me.ColumnHeader6.Width = 62
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Email"
        Me.ColumnHeader7.Width = 180
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "RFID"
        Me.ColumnHeader8.Width = 120
        '
        'btnUpdStudent
        '
        Me.btnUpdStudent.BackColor = System.Drawing.Color.Goldenrod
        Me.btnUpdStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdStudent.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdStudent.Location = New System.Drawing.Point(793, 798)
        Me.btnUpdStudent.Name = "btnUpdStudent"
        Me.btnUpdStudent.Size = New System.Drawing.Size(139, 65)
        Me.btnUpdStudent.TabIndex = 78
        Me.btnUpdStudent.Text = "UPDATE"
        Me.btnUpdStudent.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(761, 572)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 22)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Course:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(333, 785)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 22)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Email:"
        '
        'updEmail
        '
        Me.updEmail.BackColor = System.Drawing.Color.White
        Me.updEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updEmail.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.updEmail.Location = New System.Drawing.Point(337, 810)
        Me.updEmail.MaxLength = 25
        Me.updEmail.Name = "updEmail"
        Me.updEmail.Size = New System.Drawing.Size(356, 37)
        Me.updEmail.TabIndex = 76
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(985, 648)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 22)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "Year/Section:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(336, 714)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 22)
        Me.Label20.TabIndex = 77
        Me.Label20.Text = "Last name:"
        '
        'updLastname
        '
        Me.updLastname.BackColor = System.Drawing.Color.White
        Me.updLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updLastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.updLastname.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.updLastname.Location = New System.Drawing.Point(337, 739)
        Me.updLastname.MaxLength = 25
        Me.updLastname.Name = "updLastname"
        Me.updLastname.Size = New System.Drawing.Size(356, 37)
        Me.updLastname.TabIndex = 72
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(333, 644)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 22)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Middle name:"
        '
        'updMiddlename
        '
        Me.updMiddlename.BackColor = System.Drawing.Color.White
        Me.updMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updMiddlename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.updMiddlename.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updMiddlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.updMiddlename.Location = New System.Drawing.Point(337, 669)
        Me.updMiddlename.MaxLength = 25
        Me.updMiddlename.Name = "updMiddlename"
        Me.updMiddlename.Size = New System.Drawing.Size(356, 37)
        Me.updMiddlename.TabIndex = 70
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(333, 573)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 22)
        Me.Label22.TabIndex = 71
        Me.Label22.Text = "First name:"
        '
        'updFirstname
        '
        Me.updFirstname.BackColor = System.Drawing.Color.White
        Me.updFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updFirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.updFirstname.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.updFirstname.Location = New System.Drawing.Point(337, 598)
        Me.updFirstname.MaxLength = 25
        Me.updFirstname.Name = "updFirstname"
        Me.updFirstname.Size = New System.Drawing.Size(356, 37)
        Me.updFirstname.TabIndex = 68
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(759, 644)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 22)
        Me.Label23.TabIndex = 69
        Me.Label23.Text = "Student Number:"
        '
        'stdNum
        '
        Me.stdNum.BackColor = System.Drawing.Color.White
        Me.stdNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stdNum.Cursor = System.Windows.Forms.Cursors.No
        Me.stdNum.Enabled = False
        Me.stdNum.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.stdNum.Location = New System.Drawing.Point(763, 669)
        Me.stdNum.MaxLength = 10
        Me.stdNum.Name = "stdNum"
        Me.stdNum.ReadOnly = True
        Me.stdNum.Size = New System.Drawing.Size(192, 37)
        Me.stdNum.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(376, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(654, 61)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Update Student Information"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.ListView2)
        Me.TabPage3.Controls.Add(Me.Label42)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1650, 959)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "   Candidates list   "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.btnAddCandid)
        Me.GroupBox2.Controls.Add(Me.cboxAddCandid)
        Me.GroupBox2.Controls.Add(Me.txtAddCandid)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(885, 524)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 341)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add new candidate"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(38, 154)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(156, 22)
        Me.Label45.TabIndex = 89
        Me.Label45.Text = "Candidate Position:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(38, 69)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(137, 22)
        Me.Label46.TabIndex = 88
        Me.Label46.Text = "Candidate name:"
        '
        'btnAddCandid
        '
        Me.btnAddCandid.BackColor = System.Drawing.Color.Goldenrod
        Me.btnAddCandid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCandid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCandid.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCandid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAddCandid.Location = New System.Drawing.Point(166, 241)
        Me.btnAddCandid.Name = "btnAddCandid"
        Me.btnAddCandid.Size = New System.Drawing.Size(130, 55)
        Me.btnAddCandid.TabIndex = 92
        Me.btnAddCandid.Text = "ADD"
        Me.btnAddCandid.UseVisualStyleBackColor = True
        '
        'cboxAddCandid
        '
        Me.cboxAddCandid.BackColor = System.Drawing.Color.White
        Me.cboxAddCandid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxAddCandid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAddCandid.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAddCandid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cboxAddCandid.FormattingEnabled = True
        Me.cboxAddCandid.Items.AddRange(New Object() {"PRESIDENT", "VICE PRESIDENT", "SECRETARY", "TREASURER", "AUDITOR", "PUBLIC RELATIONS OFFICER", "FIRST YEAR REPRESENTATIVE", "SECOND YEAR REPRESENTATIVE", "THIRD YEAR REPRESENTATIVE", "FOURTH YEAR REPRESENTATIVE"})
        Me.cboxAddCandid.Location = New System.Drawing.Point(42, 179)
        Me.cboxAddCandid.Name = "cboxAddCandid"
        Me.cboxAddCandid.Size = New System.Drawing.Size(369, 31)
        Me.cboxAddCandid.TabIndex = 91
        '
        'txtAddCandid
        '
        Me.txtAddCandid.BackColor = System.Drawing.Color.White
        Me.txtAddCandid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddCandid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddCandid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddCandid.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddCandid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtAddCandid.Location = New System.Drawing.Point(42, 94)
        Me.txtAddCandid.MaxLength = 50
        Me.txtAddCandid.Name = "txtAddCandid"
        Me.txtAddCandid.Size = New System.Drawing.Size(369, 37)
        Me.txtAddCandid.TabIndex = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.txtCandidNum)
        Me.GroupBox1.Controls.Add(Me.lblCandidPos)
        Me.GroupBox1.Controls.Add(Me.lblCandidName)
        Me.GroupBox1.Controls.Add(Me.cboxCandidPos)
        Me.GroupBox1.Controls.Add(Me.txtCandidName)
        Me.GroupBox1.Controls.Add(Me.btnDelCandid)
        Me.GroupBox1.Controls.Add(Me.btnUpdCandid)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(885, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 341)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update candidate info"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(223, 47)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(103, 22)
        Me.Label43.TabIndex = 91
        Me.Label43.Text = "Candid. no.:"
        '
        'txtCandidNum
        '
        Me.txtCandidNum.BackColor = System.Drawing.Color.White
        Me.txtCandidNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCandidNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCandidNum.Cursor = System.Windows.Forms.Cursors.No
        Me.txtCandidNum.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCandidNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtCandidNum.Location = New System.Drawing.Point(332, 38)
        Me.txtCandidNum.MaxLength = 10
        Me.txtCandidNum.Name = "txtCandidNum"
        Me.txtCandidNum.ReadOnly = True
        Me.txtCandidNum.Size = New System.Drawing.Size(79, 37)
        Me.txtCandidNum.TabIndex = 93
        Me.txtCandidNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCandidPos
        '
        Me.lblCandidPos.AutoSize = True
        Me.lblCandidPos.BackColor = System.Drawing.Color.Transparent
        Me.lblCandidPos.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandidPos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblCandidPos.Location = New System.Drawing.Point(38, 164)
        Me.lblCandidPos.Name = "lblCandidPos"
        Me.lblCandidPos.Size = New System.Drawing.Size(156, 22)
        Me.lblCandidPos.TabIndex = 89
        Me.lblCandidPos.Text = "Candidate Position:"
        '
        'lblCandidName
        '
        Me.lblCandidName.AutoSize = True
        Me.lblCandidName.BackColor = System.Drawing.Color.Transparent
        Me.lblCandidName.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandidName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblCandidName.Location = New System.Drawing.Point(38, 79)
        Me.lblCandidName.Name = "lblCandidName"
        Me.lblCandidName.Size = New System.Drawing.Size(137, 22)
        Me.lblCandidName.TabIndex = 88
        Me.lblCandidName.Text = "Candidate name:"
        '
        'cboxCandidPos
        '
        Me.cboxCandidPos.BackColor = System.Drawing.Color.White
        Me.cboxCandidPos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboxCandidPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCandidPos.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCandidPos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.cboxCandidPos.FormattingEnabled = True
        Me.cboxCandidPos.Items.AddRange(New Object() {"PRESIDENT", "VICE PRESIDENT", "SECRETARY", "TREASURER", "AUDITOR", "PUBLIC RELATIONS OFFICER", "FIRST YEAR REPRESENTATIVE", "SECOND YEAR REPRESENTATIVE", "THIRD YEAR REPRESENTATIVE", "FOURTH YEAR REPRESENTATIVE"})
        Me.cboxCandidPos.Location = New System.Drawing.Point(42, 189)
        Me.cboxCandidPos.Name = "cboxCandidPos"
        Me.cboxCandidPos.Size = New System.Drawing.Size(369, 31)
        Me.cboxCandidPos.TabIndex = 87
        '
        'txtCandidName
        '
        Me.txtCandidName.BackColor = System.Drawing.Color.White
        Me.txtCandidName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCandidName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCandidName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCandidName.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCandidName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtCandidName.Location = New System.Drawing.Point(42, 104)
        Me.txtCandidName.MaxLength = 50
        Me.txtCandidName.Name = "txtCandidName"
        Me.txtCandidName.Size = New System.Drawing.Size(369, 37)
        Me.txtCandidName.TabIndex = 86
        '
        'btnDelCandid
        '
        Me.btnDelCandid.BackColor = System.Drawing.Color.Transparent
        Me.btnDelCandid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelCandid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelCandid.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelCandid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnDelCandid.Location = New System.Drawing.Point(280, 250)
        Me.btnDelCandid.Name = "btnDelCandid"
        Me.btnDelCandid.Size = New System.Drawing.Size(130, 55)
        Me.btnDelCandid.TabIndex = 89
        Me.btnDelCandid.Text = "DELETE"
        Me.btnDelCandid.UseVisualStyleBackColor = False
        '
        'btnUpdCandid
        '
        Me.btnUpdCandid.BackColor = System.Drawing.Color.Goldenrod
        Me.btnUpdCandid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdCandid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdCandid.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdCandid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdCandid.Location = New System.Drawing.Point(143, 250)
        Me.btnUpdCandid.Name = "btnUpdCandid"
        Me.btnUpdCandid.Size = New System.Drawing.Size(130, 55)
        Me.btnUpdCandid.TabIndex = 88
        Me.btnUpdCandid.Text = "UPDATE"
        Me.btnUpdCandid.UseVisualStyleBackColor = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.White
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(150, 160)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(0)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(702, 705)
        Me.ListView2.TabIndex = 85
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Candid. no."
        Me.ColumnHeader9.Width = 101
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Candidate Name"
        Me.ColumnHeader10.Width = 270
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Candidate Position"
        Me.ColumnHeader11.Width = 312
        '
        'Label42
        '
        Me.Label42.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(562, 75)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(356, 61)
        Me.Label42.TabIndex = 84
        Me.Label42.Text = "Candidates list"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage4.Controls.Add(Me.lblOpenLink)
        Me.TabPage4.Controls.Add(Me.resultWebBrowser)
        Me.TabPage4.Controls.Add(Me.lblResultDate)
        Me.TabPage4.Controls.Add(Me.btnRefreshResult)
        Me.TabPage4.Controls.Add(Me.lblResultTime)
        Me.TabPage4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1650, 959)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "   View result   "
        '
        'lblOpenLink
        '
        Me.lblOpenLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblOpenLink.AutoSize = True
        Me.lblOpenLink.BackColor = System.Drawing.Color.Transparent
        Me.lblOpenLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOpenLink.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblOpenLink.Location = New System.Drawing.Point(596, 908)
        Me.lblOpenLink.Name = "lblOpenLink"
        Me.lblOpenLink.Size = New System.Drawing.Size(296, 24)
        Me.lblOpenLink.TabIndex = 85
        Me.lblOpenLink.Text = "open website in external browser"
        Me.lblOpenLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resultWebBrowser
        '
        Me.resultWebBrowser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.resultWebBrowser.IsWebBrowserContextMenuEnabled = False
        Me.resultWebBrowser.Location = New System.Drawing.Point(98, 187)
        Me.resultWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.resultWebBrowser.Name = "resultWebBrowser"
        Me.resultWebBrowser.Size = New System.Drawing.Size(1304, 644)
        Me.resultWebBrowser.TabIndex = 84
        Me.resultWebBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'lblResultDate
        '
        Me.lblResultDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultDate.AutoSize = True
        Me.lblResultDate.BackColor = System.Drawing.Color.Transparent
        Me.lblResultDate.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblResultDate.Location = New System.Drawing.Point(397, 134)
        Me.lblResultDate.Name = "lblResultDate"
        Me.lblResultDate.Size = New System.Drawing.Size(123, 29)
        Me.lblResultDate.TabIndex = 83
        Me.lblResultDate.Text = "MM/dd/yy"
        Me.lblResultDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefreshResult
        '
        Me.btnRefreshResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefreshResult.BackColor = System.Drawing.Color.Goldenrod
        Me.btnRefreshResult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshResult.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnRefreshResult.Location = New System.Drawing.Point(668, 846)
        Me.btnRefreshResult.Name = "btnRefreshResult"
        Me.btnRefreshResult.Size = New System.Drawing.Size(163, 54)
        Me.btnRefreshResult.TabIndex = 81
        Me.btnRefreshResult.Text = "Refresh"
        Me.btnRefreshResult.UseVisualStyleBackColor = True
        '
        'lblResultTime
        '
        Me.lblResultTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultTime.AutoSize = True
        Me.lblResultTime.BackColor = System.Drawing.Color.Transparent
        Me.lblResultTime.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblResultTime.Location = New System.Drawing.Point(391, 75)
        Me.lblResultTime.Name = "lblResultTime"
        Me.lblResultTime.Size = New System.Drawing.Size(641, 61)
        Me.lblResultTime.TabIndex = 66
        Me.lblResultTime.Text = "Election result as of --:-- hr"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage5.Controls.Add(Me.grpMembers)
        Me.TabPage5.Controls.Add(Me.btnViewWebsite)
        Me.TabPage5.Controls.Add(Me.Label25)
        Me.TabPage5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.Location = New System.Drawing.Point(4, 34)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1650, 959)
        Me.TabPage5.TabIndex = 3
        Me.TabPage5.Text = "   About SCVS   "
        '
        'grpMembers
        '
        Me.grpMembers.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.grpMembers.Controls.Add(Me.Label24)
        Me.grpMembers.Controls.Add(Me.Label41)
        Me.grpMembers.Controls.Add(Me.Label39)
        Me.grpMembers.Controls.Add(Me.Label40)
        Me.grpMembers.Controls.Add(Me.Label26)
        Me.grpMembers.Controls.Add(Me.Label27)
        Me.grpMembers.Controls.Add(Me.Label28)
        Me.grpMembers.Controls.Add(Me.Label29)
        Me.grpMembers.Controls.Add(Me.Label30)
        Me.grpMembers.Controls.Add(Me.Label31)
        Me.grpMembers.Controls.Add(Me.Label32)
        Me.grpMembers.Controls.Add(Me.Label33)
        Me.grpMembers.Controls.Add(Me.Label34)
        Me.grpMembers.Controls.Add(Me.Label35)
        Me.grpMembers.Controls.Add(Me.Label36)
        Me.grpMembers.Controls.Add(Me.Label37)
        Me.grpMembers.Controls.Add(Me.Label38)
        Me.grpMembers.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMembers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.grpMembers.Location = New System.Drawing.Point(216, 253)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(957, 457)
        Me.grpMembers.TabIndex = 81
        Me.grpMembers.TabStop = False
        '
        'Label24
        '
        Me.Label24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(571, 115)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(199, 14)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Student Council Voting System"
        '
        'Label41
        '
        Me.Label41.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label41.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label41.Location = New System.Drawing.Point(590, 62)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(165, 59)
        Me.Label41.TabIndex = 40
        Me.Label41.Text = "SCVS"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(547, 348)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 22)
        Me.Label39.TabIndex = 38
        Me.Label39.Text = "group:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label40.Location = New System.Drawing.Point(609, 337)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(116, 35)
        Me.Label40.TabIndex = 37
        Me.Label40.Text = "Group 5"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(174, 161)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(194, 35)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "Asurto, Liezel"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(107, 110)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 22)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "leader:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label28.Location = New System.Drawing.Point(174, 99)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(264, 35)
        Me.Label28.TabIndex = 34
        Me.Label28.Text = "Perez, John Patrick"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label29.Location = New System.Drawing.Point(174, 337)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(252, 35)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "Roldan, Jay Harold"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(87, 172)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(81, 22)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "members:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label31.Location = New System.Drawing.Point(174, 221)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(232, 35)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "Carolino, Hazelle"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.Location = New System.Drawing.Point(174, 278)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(213, 35)
        Me.Label32.TabIndex = 30
        Me.Label32.Text = "Martisano, Jave"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(510, 289)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(93, 22)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "course/sec:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label34.Location = New System.Drawing.Point(609, 278)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(110, 35)
        Me.Label34.TabIndex = 28
        Me.Label34.Text = "BSIT-3F"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(519, 172)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 22)
        Me.Label35.TabIndex = 27
        Me.Label35.Text = "instructor:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label36.Location = New System.Drawing.Point(609, 161)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(246, 35)
        Me.Label36.TabIndex = 26
        Me.Label36.Text = "Mr. Felix Quintana"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(535, 232)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(68, 22)
        Me.Label37.TabIndex = 25
        Me.Label37.Text = "subject:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label38.Location = New System.Drawing.Point(609, 221)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(118, 35)
        Me.Label38.TabIndex = 24
        Me.Label38.Text = "ELECT 3"
        '
        'btnViewWebsite
        '
        Me.btnViewWebsite.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnViewWebsite.BackColor = System.Drawing.Color.Goldenrod
        Me.btnViewWebsite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewWebsite.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewWebsite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnViewWebsite.Location = New System.Drawing.Point(565, 755)
        Me.btnViewWebsite.Name = "btnViewWebsite"
        Me.btnViewWebsite.Size = New System.Drawing.Size(255, 67)
        Me.btnViewWebsite.TabIndex = 79
        Me.btnViewWebsite.Text = "Visit website"
        Me.btnViewWebsite.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(205, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(968, 61)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "Automated Student Council Voting System"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(262, 64)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1658, 997)
        Me.Panel2.TabIndex = 11
        '
        'scvsAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1920, 1061)
        Me.Controls.Add(Me.panelSidebar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "scvsAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelSidebar.ResumeLayout(False)
        Me.panelSidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpReg.ResumeLayout(False)
        Me.grpReg.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.grpMembers.ResumeLayout(False)
        Me.grpMembers.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSidebar As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRFID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents cboxYear As ComboBox
    Friend WithEvents cboxCourse As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents middlename As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents btnRegStudent As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents updRFID As TextBox
    Friend WithEvents updYear As ComboBox
    Friend WithEvents updCourse As ComboBox
    Friend WithEvents btnDelStudent As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnUpdStudent As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents updEmail As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents updLastname As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents updMiddlename As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents updFirstname As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents stdNum As TextBox
    Friend WithEvents lblResultTime As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents btnViewWebsite As Button
    Friend WithEvents btnCancelReg As Button
    Friend WithEvents btnClrStudent As Button
    Friend WithEvents grpReg As GroupBox
    Friend WithEvents btnRefreshResult As Button
    Friend WithEvents grpMembers As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnDelCandid As Button
    Friend WithEvents btnUpdCandid As Button
    Friend WithEvents btnAddCandid As Button
    Friend WithEvents lblResultDate As Label
    Friend WithEvents resultWebBrowser As WebBrowser
    Friend WithEvents Label42 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents cboxCandidPos As ComboBox
    Friend WithEvents txtCandidName As TextBox
    Friend WithEvents lblCandidPos As Label
    Friend WithEvents lblCandidName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtCandidNum As TextBox
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents cboxAddCandid As ComboBox
    Friend WithEvents txtAddCandid As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents lblOpenLink As Label
    Friend WithEvents txtContactNum As MaskedTextBox
End Class
