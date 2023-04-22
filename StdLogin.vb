'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class StdLogin


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim conn As New MySqlConnection("server=db4free.net; userid=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;")

            Dim command As New MySqlCommand("SELECT `email`, `pass` FROM `voters` WHERE `email` = @usn AND `pass` = @pass")
            command.Connection = conn 'set the connection property of the command object

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user.Text
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text
            Dim adapter As New MySqlDataAdapter()
            Dim table As New DataTable()
            adapter.SelectCommand = command 'set the SelectCommand property of the adapter object

            conn.Open() 'open the database connection
            adapter.Fill(table)

            If user.Text.Trim() = "" Or user.Text.Trim().ToLower() = "username" Then
                MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf password.Text.Trim() = "" Or password.Text.Trim().ToLower() = "password" Then

                MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else


                If table.Rows.Count > 0 Then
                    StdMenu.Show()
                    Me.Hide()
                    user.Clear()
                    password.Clear()
                    CheckBox1.CheckState = False
                Else
                    MessageBox.Show("Invalid username/password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show("A MySQL exception occurred: " + ex.Message, "MySQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidOperationException
            MessageBox.Show("An invalid operation exception occurred: " + ex.Message, "Invalid Operation Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An exception occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'about
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub


    'show/hide passworf
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            password.UseSystemPasswordChar = False
            'naiyakXD
            eye.Image = Image.FromFile("C:\Users\jpper\OneDrive\Documents\VB\VotingSystem_Perez\show.jpg")
        Else
            password.UseSystemPasswordChar = True
            'nakapikit
            eye.Image = Image.FromFile("C:\Users\jpper\OneDrive\Documents\VB\VotingSystem_Perez\hide.png")
        End If
    End Sub

    Private Sub eye_Click(sender As Object, e As EventArgs) Handles eye.Click
        CheckBox1.Checked = Not CheckBox1.Checked
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblSwitchLogin.Click
        user.Clear()
        password.Clear()
        CheckBox1.Checked = False
        Me.Hide()
        AdmLogin.Show()
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
