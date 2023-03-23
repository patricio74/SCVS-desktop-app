'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class StdLogin

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim conn As New MY_CONNECTION()
            Dim adapter As New MySqlDataAdapter()
            Dim table As New DataTable()
            Dim command As New MySqlCommand("SELECT `email`, `student_number` FROM `voters` WHERE `email` = @usn AND `student_number` = @pass", conn.getConnection())

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user.Text
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass.Text
            If user.Text.Trim() = "" Or user.Text.Trim().ToLower() = "username" Then
                MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf pass.Text.Trim() = "" Or pass.Text.Trim().ToLower() = "password" Then

                MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                adapter.SelectCommand = command
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    StdMenu.Show()
                    Me.Hide()
                    user.Clear()
                    pass.Clear()
                    CheckBox1.CheckState = False
                Else
                    MessageBox.Show("Invalid username/password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'about
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub


    'show/hide passworf
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblSwitchLogin.Click
        user.Clear()
        pass.Clear()
        CheckBox1.Checked = False
        Me.Hide()
        AdmLogin.Show()
    End Sub
End Class
