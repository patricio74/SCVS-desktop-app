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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelSidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.panelSidebar.Size = New System.Drawing.Size(244, 549)
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
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
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
        Me.Label7.Location = New System.Drawing.Point(47, 520)
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
        Me.Panel1.Size = New System.Drawing.Size(640, 64)
        Me.Panel1.TabIndex = 9
        '
        'btnRFID
        '
        Me.btnRFID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRFID.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnRFID.Location = New System.Drawing.Point(480, 12)
        Me.btnRFID.Name = "btnRFID"
        Me.btnRFID.Size = New System.Drawing.Size(121, 35)
        Me.btnRFID.TabIndex = 1
        Me.btnRFID.Text = "Use RFID"
        Me.btnRFID.UseVisualStyleBackColor = True
        '
        'btnPassword
        '
        Me.btnPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPassword.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnPassword.Location = New System.Drawing.Point(461, 12)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(159, 35)
        Me.btnPassword.TabIndex = 2
        Me.btnPassword.Text = "Use Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        Me.btnPassword.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(241, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 491)
        Me.Panel2.TabIndex = 0
        '
        'SCVS_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(879, 549)
        Me.Controls.Add(Me.panelSidebar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
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
        Me.ResumeLayout(False)

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
    Friend WithEvents Panel2 As Panel
End Class
