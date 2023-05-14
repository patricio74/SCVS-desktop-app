'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows

Public Class SCVS_Login

    Private Sub SCVS_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radAdmin.Checked = True
        userLogin()
    End Sub

    'hides the textboxes pag RFID gagamitin
    Public Sub userRFID()
        txtboxUsername.Clear()
        txtboxPassword.Clear()
        txtboxRFID.Clear()
        chkShow.Checked = False
        grpUserLogin.Hide()
        btnRFID.Hide()
        btnPassword.Show()
        grpRFIDLogin.Show()
        txtboxRFID.Focus()
    End Sub
    Public Sub userLogin()
        txtboxUsername.Clear()
        txtboxPassword.Clear()
        txtboxRFID.Clear()
        grpRFIDLogin.Hide()
        btnPassword.Hide()
        btnRFID.Show()
        grpUserLogin.Show()
        txtboxUsername.Focus()
    End Sub

    Private Sub btnRFID_Click(sender As Object, e As EventArgs) Handles btnRFID.Click
        userRFID()
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        userLogin()
    End Sub

    Private Sub radAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmin.CheckedChanged
        'para nakafocus sa textbox pagkaclick ng radio button
        If grpUserLogin.Visible Then
            txtboxPassword.Clear()
            txtboxUsername.Focus()
            chkShow.Checked = False
        ElseIf grpRFIDLogin.Visible Then
            txtboxRFID.Focus()
        End If
    End Sub

    Private Sub radStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged
        If grpUserLogin.Visible Then
            txtboxPassword.Clear()
            txtboxUsername.Focus()
            chkShow.Checked = False
        ElseIf grpRFIDLogin.Visible Then
            txtboxRFID.Focus()
        End If
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.CheckState = CheckState.Checked Then
            txtboxPassword.UseSystemPasswordChar = False
        Else
            txtboxPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If grpUserLogin.Visible Then
            'admin login
            If radAdmin.Checked Then
                If txtboxUsername.Text = "" Then
                    MessageBox.Show("Username cannot be empty", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf txtboxPassword.Text = "" Then
                    MessageBox.Show("Password cannot be empty", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Try
                        Dim conn As New MySqlConnection(getConString)

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
                            txtboxPassword.Clear()
                            chkShow.CheckState = False
                            conn.Close()
                            Me.Hide()
                            Admin.Show()
                        Else
                            MessageBox.Show("Invalid username/password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            conn.Close()
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
                        Dim conn As New MySqlConnection(getConString)
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
                                    txtboxPassword.Clear()
                                    chkShow.CheckState = False
                                    Student.Show()
                                    Me.Hide()
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
        ElseIf grpRFIDLogin.Visible Then
            Dim rfidTag As String = txtboxRFID.Text.Trim()
            'admin RFID login
            If radAdmin.Checked = True Then
                ' Check if the RFID tag is valid
                If String.IsNullOrEmpty(rfidTag) Then
                    MessageBox.Show("Please scan your RFID tag.")
                    txtboxRFID.Focus()
                    Return
                End If

                ' Check the database for the RFID tag and vote status
                Dim query As String = "SELECT * FROM admin WHERE RFID = @RFIDTag"
                Using connection As New MySqlConnection(getConString)
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@RFIDTag", rfidTag)
                        Try
                            connection.Open()
                            Dim reader As MySqlDataReader = command.ExecuteReader()

                            If reader.Read() Then
                                Dim username As String = reader("email").ToString()
                                Admin.Show()
                                'txtboxRFID.Clear()
                                Me.Hide()
                            Else
                                MessageBox.Show("User RFID tag not found.")
                                txtboxRFID.Clear()
                                txtboxRFID.Focus()
                            End If

                            reader.Close()
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message)
                        End Try
                    End Using
                End Using

                'student RFID login
            ElseIf radStudent.Checked = True Then
                ' Check if the RFID tag is valid
                If String.IsNullOrEmpty(rfidTag) Then
                    MessageBox.Show("Please scan your RFID tag.")
                    txtboxRFID.Focus()
                    Return
                End If

                ' Check the database for the RFID tag and vote status
                Dim query As String = "SELECT * FROM voters WHERE RFID = @RFIDTag"
                Using connection As New MySqlConnection(getConString)
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@RFIDTag", rfidTag)
                        Try
                            connection.Open()
                            Dim reader As MySqlDataReader = command.ExecuteReader()

                            If reader.Read() Then
                                Dim username As String = reader("email").ToString()
                                Dim voteStatus As String = reader("VoteStatus").ToString()

                                If voteStatus = "voted" Then
                                    txtboxRFID.Clear()
                                    txtboxRFID.Focus()
                                    MessageBox.Show("You have already voted.")
                                Else
                                    ' MessageBox.Show("Welcome to SCVS, " & username & "!")
                                    Student.Show()
                                    Me.Hide()
                                End If
                            Else
                                MessageBox.Show("User RFID tag not found.")
                                txtboxRFID.Clear()
                                txtboxRFID.Focus()
                            End If

                            reader.Close()
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message)
                        End Try
                    End Using
                End Using
            End If
        End If
    End Sub
End Class