'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

Public Class Admin
    Dim connect As New MySqlConnection(getConString)
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        admLogout()
    End Sub

    'clear tab bago iview
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 'register student tab

            Case 1 'update/delete info tab
                voterInfo()
                clearUpdForm()
            Case 2 'candidates tab

            Case 3 'result tab
                'reset browser, sync current time sa label
                admResultTab()
            Case 4 'about SCVS tab

            Case Else ' all other tab pages
                ' do nothing
        End Select
    End Sub

    'REGISTER TAB
    Private Sub btnRegStudent_Click(sender As Object, e As EventArgs) Handles btnRegStudent.Click
        If firstname.Text = "" Or lastname.Text = "" Or middlename.Text = "" Or cboxCourse.Text = "" Or cboxYear.Text = "" Or email.Text = "" Or pass.Text = "" Or txtRFID.Text = "" Then
            MessageBox.Show("fill up all fields to continue.", "Error!")
        Else
            Try
                connect.Open()
                ' Check if the RFID already exists in the database
                Dim checkRFIDQuery As String = "SELECT COUNT(*) FROM voters WHERE RFID = @rfid"
                Dim checkRFIDCommand As New MySqlCommand(checkRFIDQuery, connect)
                checkRFIDCommand.Parameters.AddWithValue("@rfid", txtRFID.Text)
                Dim rfidCount As Integer = Convert.ToInt32(checkRFIDCommand.ExecuteScalar())

                If rfidCount > 0 Then
                    MsgBox("RFID already exists in the database. Please use different RFID.", vbExclamation, "Error!")
                    txtRFID.Focus()
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
                        clearRegFrom()
                        ' Show if registration is successful
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

    'cancel button sa reg tab
    Private Sub btnCancelReg_Click(sender As Object, e As EventArgs) Handles btnCancelReg.Click
        clearRegFrom()
    End Sub

    'UPDATE TAB
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

    'update button sa upd tab
    Private Sub btnUpdStudent_Click(sender As Object, e As EventArgs) Handles btnUpdStudent.Click
        Try
            connect.Open()
            Dim SQL As String =
                "UPDATE voters SET First_name ='" & updFirstname.Text & "', Last_name ='" & updLastname.Text & "', Middle_name ='" & updMiddlename.Text & "', Course ='" & updCourse.Text & "',Yr ='" & updYear.Text & "', Email ='" & updEmail.Text & "', RFID = '" & updRFID.Text & "'   
                WHERE Student_number ='" & stdNum.Text & "' "
            Dim cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Voter info updated!", vbInformation, "Admin")
            Else
                MsgBox("Voter info update failed!", vbCritical, "Admin")
            End If
            clearUpdForm()
            voterInfo()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'delete button sa upd tab
    Private Sub btnDelStudent_Click(sender As Object, e As EventArgs) Handles btnDelStudent.Click
        Try
            connect.Open()
            Dim SQL As String = "DELETE FROM voters WHERE Student_number = '" & stdNum.Text & "' "
            Dim cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Voter info deleted!", vbInformation, "Admin")
            Else
                MsgBox("Voter info deletion failed!", vbCritical, "Admin")
            End If
            clearUpdForm()
            voterInfo()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'cancel button sa upd tab
    Private Sub btnClrStudent_Click(sender As Object, e As EventArgs) Handles btnClrStudent.Click
        clearUpdForm()
        For Each selectedItem As ListViewItem In ListView1.SelectedItems
            selectedItem.Selected = False
        Next
    End Sub

    'CANDIDATES TAB
    Private Sub btnAddCandid_Click(sender As Object, e As EventArgs) Handles btnAddCandid.Click

    End Sub

    Private Sub btnUpdCandid_Click(sender As Object, e As EventArgs) Handles btnUpdCandid.Click

    End Sub

    Private Sub btnDelCandid_Click(sender As Object, e As EventArgs) Handles btnDelCandid.Click

    End Sub

    'RESULT TAB


    'refresh result tab
    Private Sub btnRefreshResult_Click(sender As Object, e As EventArgs) Handles btnRefreshResult.Click
        admResultTab()
    End Sub

    'ABOUT TAB
    Private Sub btnWebsite_Click(sender As Object, e As EventArgs) Handles btnViewWebsite.Click
        Process.Start("https://scvs.000webhostapp.com/")
    End Sub
End Class