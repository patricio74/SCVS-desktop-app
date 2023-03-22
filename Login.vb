'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'admin username: admin
    'admin pass: 123456
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conn As New MY_CONNECTION()
            Dim adapter As New MySqlDataAdapter()
            Dim table As New DataTable()
            Dim command As New MySqlCommand("SELECT `email`, `student_number` FROM `voters` WHERE `email` = @usn AND `student_number` = @pass", conn.getConnection())

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user.Text
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass.Text
            If user.Text.Trim() = "" Or user.Text.Trim().ToLower() = "username" Then
                MessageBox.Show("Enter your email to login", "Missing email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf pass.Text.Trim() = "" Or pass.Text.Trim().ToLower() = "password" Then

                MessageBox.Show("Enter your student number to login", "Missing student number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                adapter.SelectCommand = command
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    FormMenu.Show()
                    Me.Hide()
                    user.Clear()
                    pass.Clear()
                    CheckBox1.CheckState = False
                Else
                    MessageBox.Show("This Username Or/And Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'about
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        About.Show()
    End Sub


    'show/hide passworf
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            pass.UseSystemPasswordChar = False
            'naiyakXD
            eye.Image = Image.FromFile("C:\Users\jpper\OneDrive\Documents\VB\VotingSystem_Perez\eye2.png")
        Else
            pass.UseSystemPasswordChar = True
            'normal na mata
            eye.Image = Image.FromFile("C:\Users\jpper\OneDrive\Documents\VB\VotingSystem_Perez\eye1.png")
        End If
    End Sub

    Private Sub eye_Click(sender As Object, e As EventArgs) Handles eye.Click
        CheckBox1.Checked = Not CheckBox1.Checked
    End Sub

End Class
