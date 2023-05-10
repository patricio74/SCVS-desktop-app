Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radAdmin.Checked = True
        txtboxUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'admin login
        If radAdmin.Checked Then
            If txtboxUsername.Text = "" Then
                MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtboxPassword.Text = "" Then
                MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Dim conn As New MySqlConnection("server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;")

                    Dim command As New MySqlCommand("SELECT `Email`, `Pass` FROM `admin` WHERE `Email` = @usn AND `Pass` = @pass;")
                    command.Connection = conn 'set the connection property of the command object

                    command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtboxUsername.Text
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtboxPassword.Text
                    Dim adapter As New MySqlDataAdapter()
                    Dim table As New DataTable()
                    adapter.SelectCommand = command 'set the SelectCommand property of the adapter object

                    conn.Open() 'open the database connection
                    adapter.Fill(table)

                    If txtboxUsername.Text.Trim() = "" Then
                        MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf txtboxPassword.Text.Trim() = "" Then
                        MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf table.Rows.Count > 0 Then 'check if there are any rows returned from the query
                        AdmMenu.Show()
                        txtboxPassword.Clear()
                        SCVS_Login.Hide()
                        chkShow.CheckState = False
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
            'student login
        ElseIf radStudent.Checked Then
            If txtboxUsername.Text = "" Then
                MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtboxPassword.Text = "" Then
                MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Dim conn As New MySqlConnection("server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;")

                    Dim command As New MySqlCommand("SELECT `email`, `pass`, `votestatus` FROM `voters` WHERE `email` = @usn AND `pass` = @pass")
                    command.Connection = conn 'set the connection property of the command object

                    command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtboxUsername.Text
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtboxPassword.Text
                    Dim adapter As New MySqlDataAdapter()
                    Dim table As New DataTable()
                    adapter.SelectCommand = command 'set the SelectCommand property of the adapter object

                    conn.Open() 'open the database connection
                    adapter.Fill(table)

                    If txtboxUsername.Text.Trim() = "" Then
                        MessageBox.Show("Username field cannot be empty.", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf txtboxPassword.Text.Trim() = "" Then

                        MessageBox.Show("Password cannot field be empty.", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else


                        If table.Rows.Count > 0 Then
                            Dim votestatus As String = table.Rows(0)("votestatus").ToString()
                            If votestatus = "voted" Then
                                MessageBox.Show("You have already voted!", "Voting Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                txtboxPassword.Clear()
                            Else
                                StdMenu.Show()
                                txtboxPassword.Clear()
                                chkShow.CheckState = False
                                SCVS_Login.Hide()
                            End If
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
            End If
        End If
    End Sub

    Private Sub chkShow_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.CheckState = CheckState.Checked Then
            txtboxPassword.UseSystemPasswordChar = False
        Else
            txtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub radAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmin.CheckedChanged
        txtboxUsername.Clear()
        txtboxPassword.Clear()
        txtboxUsername.Focus()
    End Sub

    Private Sub radStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged
        txtboxUsername.Clear()
        txtboxPassword.Clear()
        txtboxUsername.Focus()
    End Sub
End Class
