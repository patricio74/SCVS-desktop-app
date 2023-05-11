Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

Public Class Admin
    Private Sub Admin_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            Me.ControlBox = False
            Me.FormBorderStyle = FormBorderStyle.None
        Else
            Me.ControlBox = True
            Me.FormBorderStyle = FormBorderStyle.FixedSingle ' or any other border style you want
        End If
    End Sub

    Dim connect As MySqlConnection
    'localhost
    'Dim constring As String = "server = localhost; userid = root; DATABASE = votingsystem_perez"

    'online db
    Dim constring As String = "server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;"
    Dim cmd As MySqlCommand

    'pang clear sa register form
    Public Sub clearRegFrom()
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()
        cboxCourse.SelectedIndex = -1
        cboxYear.SelectedIndex = -1
        email.Clear()
        pass.Clear()
        txtRFID.Clear()
    End Sub

    'clear update tab
    Public Sub clearUpdForm()
        stdNum.Clear()
        updFirstname.Clear()
        updMiddlename.Clear()
        updLastname.Clear()
        updCourse.SelectedIndex = -1
        updYear.SelectedIndex = -1
        updEmail.Clear()
        updRFID.Clear()
    End Sub

    Public Sub VoterInfo()
        Dim cmmd As MySqlCommand
        Dim itemcol(999) As String
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Try
            ListView1.Items.Clear()
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim sql As String = "SELECT * FROM voters"
            cmmd = New MySqlCommand(sql, connect)
            da = New MySqlDataAdapter(cmmd)
            ds = New DataSet
            da.Fill(ds, "Tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                Dim lvitm As New ListViewItem()
                lvitm.Text = ds.Tables(0).Rows(r)("student_number").ToString()
                lvitm.SubItems.Add(ds.Tables(0).Rows(r)("first_name").ToString())
                lvitm.SubItems.Add(ds.Tables(0).Rows(r)("middle_name").ToString())
                lvitm.SubItems.Add(ds.Tables(0).Rows(r)("last_name").ToString())
                lvitm.SubItems.Add(ds.Tables(0).Rows(r)("course").ToString())
                lvitm.SubItems.Add(ds.Tables(0).Rows(r)("yr").ToString())
                lvitm.SubItems.Add(ds.Tables(0).Rows(r)("email").ToString())
                lvitm.SubItems.Add(ds.Tables(0).Rows(r)("RFID").ToString())
                ListView1.Items.Add(lvitm)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connect.Close()
        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            stdNum.Text = ListView1.SelectedItems(0).SubItems(0).Text
            updFirstname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            updMiddlename.Text = ListView1.SelectedItems(0).SubItems(2).Text
            updLastname.Text = ListView1.SelectedItems(0).SubItems(3).Text
            updCourse.Text = ListView1.SelectedItems(0).SubItems(4).Text
            updYear.Text = ListView1.SelectedItems(0).SubItems(5).Text
            updEmail.Text = ListView1.SelectedItems(0).SubItems(6).Text
            updRFID.Text = ListView1.SelectedItems(0).SubItems(7).Text
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        SCVS_Login.Show()
        Me.Hide()
    End Sub

    'register tab
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
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
                        Call clearRegFrom()
                        ' Show if registration is successful
                    Else
                        MsgBox("Error!", vbCritical, "Admin")
                    End If
                End If
                Call clearRegFrom()
                connect.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    'update button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String =
                "UPDATE voters SET First_name ='" & updFirstname.Text & "', Last_name ='" & updLastname.Text & "', Middle_name ='" & updMiddlename.Text & "', Course ='" & updCourse.Text & "',Yr ='" & updYear.Text & "', Email ='" & updEmail.Text & "', RFID = '" & updRFID.Text & "'   
                WHERE Student_number ='" & stdNum.Text & "' "
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Voter info updated!", vbInformation, "Admin")
            Else
                MsgBox("Voter info update failed!", vbCritical, "Admin")
            End If
            Call VoterInfo()
            Call clearUpdForm()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String = "DELETE FROM voters WHERE Student_number = '" & stdNum.Text & "' "
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Voter info deleted!", vbInformation, "Admin")
            Else
                MsgBox("Voter info deletion failed!", vbCritical, "Admin")
            End If
            Call VoterInfo()
            Call clearUpdForm()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 'register student tab
                clearRegFrom() 'call the function to clear the tab
            Case 1 'update/delete info tab
                clearUpdForm()
                'Case 2

            Case Else ' all other tab pages
                ' do nothing
        End Select
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call VoterInfo()
    End Sub
End Class