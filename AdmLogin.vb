'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class AdmLogin
    Private Sub AdmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'admin username: admin
        'password: 1234
        'If user.Text = "admin" And pass.Text = "1234" Then
        'AdmMenu.Show()
        'Me.Hide()
        'user.Clear()
        'pass.Clear()
        'CheckBox1.CheckState = False
        'ElseIf user.Text = "" Then
        'MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'ElseIf pass.Text = "" Then
        'MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        'MessageBox.Show("Invalid username/password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        If user.Text = "" Then
            MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf pass.Text = "" Then
            MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim conn As New MySqlConnection("server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;")

                Dim command As New MySqlCommand("SELECT `Email`, `Pass` FROM `admin` WHERE `Email` = @usn AND `Pass` = @pass;")
                command.Connection = conn 'set the connection property of the command object

                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user.Text
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass.Text
                Dim adapter As New MySqlDataAdapter()
                Dim table As New DataTable()
                adapter.SelectCommand = command 'set the SelectCommand property of the adapter object

                conn.Open() 'open the database connection
                adapter.Fill(table)

                If user.Text.Trim() = "" Or user.Text.Trim().ToLower() = "username" Then
                    MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf pass.Text.Trim() = "" Or pass.Text.Trim().ToLower() = "password" Then
                    MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf table.Rows.Count > 0 Then 'check if there are any rows returned from the query
                    AdmMenu.Show()
                    Me.Hide()
                    pass.Clear()
                    CheckBox1.CheckState = False
                Else
                    MessageBox.Show("Invalid username/password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As MySqlException
                MessageBox.Show("A MySQL exception occurred: " + ex.Message, "MySQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As InvalidOperationException
                MessageBox.Show("An invalid operation exception occurred: " + ex.Message, "Invalid Operation Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("An exception occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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

    Private Sub btnUseRFID_Click(sender As Object, e As EventArgs) Handles btnUseRFID.Click
        admRFIDLogin.Show()
        Me.Hide()
    End Sub
End Class