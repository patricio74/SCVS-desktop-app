'created by: Perez, J.P.
'BSIT-3F
'Group 5
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'username: admin
    'password: admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If user.Text = "admin" And pass.Text = "admin" Then
            FormMenu.Show()
            Me.Hide()
            user.Clear()
            pass.Clear()
            CheckBox1.CheckState = False
        ElseIf user.Text <> "admin" Or pass.Text <> "admin" Then
            MsgBox("Wrong username/password!", vbCritical, "Login failed")
        End If
    End Sub

    'about
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        About.Show()
    End Sub


    'show/hide passworf
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            pass.UseSystemPasswordChar = False
            eye.Image = Image.FromFile("C:\Users\jpper\OneDrive\Documents\VB\VotingSystem_Perez\eye2.png")
        Else
            pass.UseSystemPasswordChar = True
            eye.Image = Image.FromFile("C:\Users\jpper\OneDrive\Documents\VB\VotingSystem_Perez\eye1.png")
        End If
    End Sub

    Private Sub eye_Click(sender As Object, e As EventArgs) Handles eye.Click
        CheckBox1.Checked = Not CheckBox1.Checked
    End Sub
End Class
