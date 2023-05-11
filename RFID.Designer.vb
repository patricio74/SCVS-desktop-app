<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RFID
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RFID))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radAdmin = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxRFID = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtboxRFID)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 271)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.BackColor = System.Drawing.Color.Transparent
        Me.radStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.radStudent.Location = New System.Drawing.Point(206, 44)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(78, 24)
        Me.radStudent.TabIndex = 3
        Me.radStudent.TabStop = True
        Me.radStudent.Text = "Student"
        Me.radStudent.UseVisualStyleBackColor = False
        '
        'radAdmin
        '
        Me.radAdmin.AutoSize = True
        Me.radAdmin.BackColor = System.Drawing.Color.Transparent
        Me.radAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.radAdmin.Location = New System.Drawing.Point(131, 44)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(69, 24)
        Me.radAdmin.TabIndex = 2
        Me.radAdmin.TabStop = True
        Me.radAdmin.Text = "Admin"
        Me.radAdmin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LOGIN AS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(45, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RFID"
        '
        'txtboxRFID
        '
        Me.txtboxRFID.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtboxRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxRFID.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtboxRFID.Location = New System.Drawing.Point(48, 107)
        Me.txtboxRFID.MaxLength = 10
        Me.txtboxRFID.Name = "txtboxRFID"
        Me.txtboxRFID.Size = New System.Drawing.Size(299, 37)
        Me.txtboxRFID.TabIndex = 0
        Me.txtboxRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Goldenrod
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(165, 173)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(70, 70)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'RFID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RFID"
        Me.Size = New System.Drawing.Size(640, 491)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxRFID As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radAdmin As RadioButton
End Class
