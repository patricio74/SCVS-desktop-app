'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows
Imports System.Runtime.Remoting.Contexts

Public Class scvsLogin

    Private Sub SCVS_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showLogin()
        radAdmin.Checked = True
        userLogin()
        connectToServer()
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
    Private Sub showReg()
        grpReg.Show()
        grpUserLogin.Hide()
        panelRegister.Show()
        panelLogin.Hide()
        lblLogin.Hide()
        radAdmin.Hide()
        radStudent.Hide()
        btnLogin.Hide()
    End Sub
    Private Sub showLogin()
        grpUserLogin.Show()
        grpReg.Hide()
        panelRegister.Hide()
        panelLogin.Show()
        lblLogin.Show()
        radAdmin.Show()
        radStudent.Show()
        btnLogin.Show()
    End Sub
    Public Sub clearForm()
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()
        cboxCourse.SelectedIndex = -1
        cboxYear.SelectedIndex = -1
        email.Clear()
        pass.Clear()
        txtRFID.Clear()
        txtContactNum.Text = ""
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

                        Dim command As New MySqlCommand("SELECT `email`, `Pword` FROM `admin` WHERE `email` = @usn AND `pword` = @pass;")
                        command.Connection = conn

                        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtboxUsername.Text
                        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtboxPassword.Text
                        Dim adapter As New MySqlDataAdapter()
                        Dim table As New DataTable()
                        adapter.SelectCommand = command

                        conn.Open()
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
                            scvsAdmin.Show()
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
                        Dim command As New MySqlCommand("SELECT `email`, `pword`, `votestatus` FROM `student` WHERE `email` = @usn AND `pword` = @pass")
                        command.Connection = conn

                        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtboxUsername.Text
                        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtboxPassword.Text
                        Dim adapter As New MySqlDataAdapter()
                        Dim table As New DataTable()
                        adapter.SelectCommand = command

                        conn.Open()
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
                                    scvsStudent.Show()
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
                If String.IsNullOrEmpty(rfidTag) Then
                    MessageBox.Show("Please scan your RFID tag.")
                    txtboxRFID.Focus()
                    Return
                End If

                Dim query As String = "SELECT * FROM admin WHERE rfid = @RFIDTag"
                Using connection As New MySqlConnection(getConString)
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@RFIDTag", rfidTag)
                        Try
                            connection.Open()
                            Dim reader As MySqlDataReader = command.ExecuteReader()

                            If reader.Read() Then
                                Dim username As String = reader("email").ToString()
                                scvsAdmin.Show()
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
                If String.IsNullOrEmpty(rfidTag) Then
                    MessageBox.Show("Please scan your RFID tag.")
                    txtboxRFID.Focus()
                    Return
                End If

                Dim query As String = "SELECT * FROM student WHERE rfid = @RFIDTag"
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
                                    'MessageBox.Show("Welcome to SCVS, " & username & "!")
                                    scvsStudent.Show()
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

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        MessageBox.Show("Relax and try to remember your password!", "Forgot password?", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        showReg()
    End Sub

    Private Sub lblLog_Click(sender As Object, e As EventArgs) Handles lblLog.Click
        showLogin()
    End Sub

    Private Sub btnRegStudent_Click(sender As Object, e As EventArgs) Handles btnRegStudent.Click
        Dim phoneNumber As String = txtContactNum.Text.Replace("-", "")
        If firstname.Text = "" Or lastname.Text = "" Or middlename.Text = "" Or cboxCourse.Text = "" Or cboxYear.Text = "" Or email.Text = "" Or pass.Text = "" Or txtRFID.Text = "" Or txtContactNum.Text = "" Then
            MessageBox.Show("fill up all fields to continue.", "Error!")
        ElseIf phoneNumber.Length <> 13 Then
            MessageBox.Show("Please enter your valid 11 digit phone number!", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNum.Focus()
            txtContactNum.SelectAll()
        Else
            Try
                Dim connect As New MySqlConnection(getConString)
                connect.Open()
                'Check if the RFID already exists in the database
                Dim checkRFIDQuery As String = "SELECT COUNT(*) FROM student WHERE RFID = @rfid"
                Dim checkRFIDCommand As New MySqlCommand(checkRFIDQuery, connect)
                checkRFIDCommand.Parameters.AddWithValue("@rfid", txtRFID.Text)
                Dim rfidCount As Integer = Convert.ToInt32(checkRFIDCommand.ExecuteScalar())

                If rfidCount > 0 Then
                    MsgBox("RFID already exists in the database. Please use different RFID.", vbExclamation, "Error!")
                    txtRFID.Focus()
                Else
                    Dim insertQuery As String = "INSERT INTO student (firstname, lastname, middlename, course, yrsec, email, pword, rfid, phone_number) 
                                            VALUES (@firstName, @lastName, @middleName, @course, @year, @email, @pass, @rfid, @number)"
                    Dim insertCommand As New MySqlCommand(insertQuery, connect)
                    insertCommand.Parameters.AddWithValue("@firstName", firstname.Text)
                    insertCommand.Parameters.AddWithValue("@lastName", lastname.Text)
                    insertCommand.Parameters.AddWithValue("@middleName", middlename.Text)
                    insertCommand.Parameters.AddWithValue("@course", cboxCourse.Text)
                    insertCommand.Parameters.AddWithValue("@year", cboxYear.Text)
                    insertCommand.Parameters.AddWithValue("@email", email.Text)
                    insertCommand.Parameters.AddWithValue("@pass", pass.Text)
                    insertCommand.Parameters.AddWithValue("@rfid", txtRFID.Text)
                    insertCommand.Parameters.AddWithValue("@number", phoneNumber)

                    Dim i As Integer = insertCommand.ExecuteNonQuery()

                    If i <> 0 Then
                        MsgBox("Student registered successfully!", vbInformation, "Admin")
                        clearForm()
                    Else
                        MsgBox("Error!", vbCritical, "Admin")
                    End If
                End If
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class