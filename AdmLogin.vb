'created by: Perez, J.P.
'BSIT-3F
'Group 5

Public Class AdmLogin
    Private Sub AdmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'admin username: admin
        'password: 1234
        If user.Text = "admin" And pass.Text = "1234" Then
            AdmMenu.Show()
            Me.Hide()
            user.Clear()
            pass.Clear()
            CheckBox1.CheckState = False
        ElseIf user.Text = "" Then
            MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pass.Text = "" Then
            MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Invalid username/password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'show/hide pass
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            pass.UseSystemPasswordChar = False
            'naiyakXD
            eye.Image = Image.FromFile("C:\Users\jpper\OneDrive\Documents\VB\VotingSystem_Perez\show.jpg")
        Else
            pass.UseSystemPasswordChar = True
            'nakapikit
            eye.Image = Image.FromFile("C:\Users\jpper\OneDrive\Documents\VB\VotingSystem_Perez\hide.png")
        End If
    End Sub

    Private Sub eye_Click(sender As Object, e As EventArgs) Handles eye.Click
        CheckBox1.Checked = Not CheckBox1.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub

    Private Sub lblSwitchLogin_Click(sender As Object, e As EventArgs) Handles lblSwitchLogin.Click
        user.Clear()
        pass.Clear()
        CheckBox1.Checked = False
        Me.Hide()
        StdLogin.Show()
    End Sub
End Class