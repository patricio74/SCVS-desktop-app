'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows

Public Class SCVS_Login
    'user controls reference
    Dim rfidLogin = New RFID
    Dim userLogin = New Login

    Private Sub SCVS_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the panel
        Panel2.Controls.Add(rfidLogin)
        Panel2.Controls.Add(userLogin)
        userLogin.BringToFront()
        rfidLogin.Enabled = False
    End Sub
    Private Sub SCVS_Login_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            Me.ControlBox = False
            Me.FormBorderStyle = FormBorderStyle.None
        Else
            Me.ControlBox = True
            Me.FormBorderStyle = FormBorderStyle.FixedSingle ' or any other border style you want
        End If
    End Sub

    Private Sub btnRFID_Click(sender As Object, e As EventArgs) Handles btnRFID.Click
        btnRFID.Visible = False
        btnPassword.Visible = True
        userLogin.Enabled = False
        rfidLogin.Enabled = True
        rfidLogin.BringToFront()
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        btnPassword.Visible = False
        btnRFID.Visible = True
        userLogin.Enabled = True
        rfidLogin.Enabled = False
        userLogin.BringToFront()
    End Sub

End Class