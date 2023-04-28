'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class AdmRegister
    Dim connect As MySqlConnection
    'localhost
    'Dim constring As String = "server = localhost; userid = root; DATABASE = votingsystem_perez"

    'online db
    Dim constring As String = "server=db4free.net; userid=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;"

    Dim cmd As MySqlCommand

    'pang clear sa form
    Public Sub Clearballot()
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()
        cboxCourse.SelectedIndex = -1
        cboxYear.SelectedIndex = -1
        email.Clear()
        pass.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If firstname.Text = "" Or lastname.Text = "" Or middlename.Text = "" Or cboxCourse.Text = "" Or cboxYear.Text = "" Or email.Text = "" Or pass.Text = "" Or txtRFID.Text = "" Then
            MessageBox.Show("fill up all fields to continue.", "Error!")
        Else
            Try
                connect = New MySqlConnection(constring)
                connect.Open()

                ' Check if the RFID already exists in the database
                Dim checkRFIDQuery As String = "SELECT COUNT(*) FROM voters WHERE RFID = @rfid"
                Dim checkRFIDCommand As New MySqlCommand(checkRFIDQuery, connect)
                checkRFIDCommand.Parameters.AddWithValue("@rfid", txtRFID.Text)
                Dim rfidCount As Integer = Convert.ToInt32(checkRFIDCommand.ExecuteScalar())

                If rfidCount > 0 Then
                    MsgBox("RFID already exists in the database. Please use a different RFID.", vbExclamation, "Error")
                Else
                    ' Insert the registration details into the database
                    Dim insertQuery As String = "INSERT INTO voters (First_name, Last_name, Middle_name, Course, Yr, Email, Pass, RFID) 
                                             VALUES (@firstName, @lastName, @middleName, @course, @year, @email, @pass, @rfid)"
                    Dim insertCommand As New MySqlCommand(insertQuery, connect)
                    insertCommand.Parameters.AddWithValue("@firstName", firstname.Text)
                    insertCommand.Parameters.AddWithValue("@lastName", lastname.Text)
                    insertCommand.Parameters.AddWithValue("@middleName", middlename.Text)
                    insertCommand.Parameters.AddWithValue("@course", cboxCourse.Text)
                    insertCommand.Parameters.AddWithValue("@year", cboxYear.Text)
                    insertCommand.Parameters.AddWithValue("@email", email.Text)
                    insertCommand.Parameters.AddWithValue("@pass", pass.Text)
                    insertCommand.Parameters.AddWithValue("@rfid", txtRFID.Text)

                    Dim i As Integer = insertCommand.ExecuteNonQuery()

                    If i <> 0 Then
                        MsgBox("Student registered successfully!", vbInformation, "Admin")
                        Call Clearballot()
                        ' Show if registration is successful
                    Else
                        MsgBox("Error!", vbCritical, "Admin")
                    End If
                End If
                Call Clearballot()
                connect.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'Call Clearballot()

    End Sub

    'return
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdmMenu.Show()
        Call Clearballot()
        Me.Hide()
    End Sub

    Private Sub stdnum_KeyPress(sender As Object, e As KeyPressEventArgs)
        'para number lang input
        '    If IsNumeric(stdnum.Text) Then
        'Do nothing 
        '   Else
        'display error message
        '           MsgBox("Only numbers are allowed", vbCritical, "Error!")
        'clear textbox 
        '   stdnum.Clear()
        'End If
    End Sub

End Class