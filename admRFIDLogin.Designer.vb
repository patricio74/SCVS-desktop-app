<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admRFIDLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admRFIDLogin))
        Me.btnUsePass = New System.Windows.Forms.Button()
        Me.txtRFID = New System.Windows.Forms.TextBox()
        Me.btnRFIDLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUsePass
        '
        Me.btnUsePass.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUsePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsePass.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsePass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUsePass.Location = New System.Drawing.Point(334, 12)
        Me.btnUsePass.Name = "btnUsePass"
        Me.btnUsePass.Size = New System.Drawing.Size(147, 36)
        Me.btnUsePass.TabIndex = 48
        Me.btnUsePass.Text = "Use password"
        Me.btnUsePass.UseVisualStyleBackColor = False
        '
        'txtRFID
        '
        Me.txtRFID.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtRFID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRFID.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtRFID.Location = New System.Drawing.Point(49, 82)
        Me.txtRFID.MaxLength = 50
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.ReadOnly = True
        Me.txtRFID.Size = New System.Drawing.Size(400, 36)
        Me.txtRFID.TabIndex = 47
        Me.txtRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRFIDLogin
        '
        Me.btnRFIDLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.btnRFIDLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRFIDLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRFIDLogin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFIDLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnRFIDLogin.Location = New System.Drawing.Point(170, 135)
        Me.btnRFIDLogin.Name = "btnRFIDLogin"
        Me.btnRFIDLogin.Size = New System.Drawing.Size(154, 57)
        Me.btnRFIDLogin.TabIndex = 46
        Me.btnRFIDLogin.Text = "LOGIN"
        Me.btnRFIDLogin.UseVisualStyleBackColor = False
        '
        'admRFIDLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(493, 225)
        Me.Controls.Add(Me.btnUsePass)
        Me.Controls.Add(Me.txtRFID)
        Me.Controls.Add(Me.btnRFIDLogin)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "admRFIDLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin RFID Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUsePass As Button
    Friend WithEvents txtRFID As TextBox
    Friend WithEvents btnRFIDLogin As Button
End Class
