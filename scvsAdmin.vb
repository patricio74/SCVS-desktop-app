'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

Public Class scvsAdmin
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
                clearUpdForm()
                voterInfo()
            Case 2 'candidates tab
                clrCandidForm()
                admCandidInfo()
            Case 3 'result tab
                'reset browser, sync current time sa label
                admResultTab()
            Case 4 'about SCVS tab

            Case Else ' all other tab pages
                'do nothing
        End Select
    End Sub


    'REGISTER TAB
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
                    ' Insert the registration details into the database
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
                        clearRegForm()
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
        clearRegForm()
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
                "UPDATE student SET firstname ='" & updFirstname.Text & "', lastname ='" & updLastname.Text & "', middlename ='" & updMiddlename.Text & "', course ='" & updCourse.Text & "', yrsec ='" & updYear.Text & "', email ='" & updEmail.Text & "', rfid = '" & updRFID.Text & "'   
                WHERE user_id ='" & stdNum.Text & "' "
            Dim cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Voter info updated!", vbInformation, "Admin")
            Else
                MsgBox("Failed to update voter info!", vbCritical, "Admin")
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
            Dim SQL As String = "DELETE FROM student WHERE user_id = '" & stdNum.Text & "' "
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
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            txtCandidNum.Text = ListView2.SelectedItems(0).SubItems(0).Text
            txtCandidName.Text = ListView2.SelectedItems(0).SubItems(1).Text
            cboxCandidPos.Text = ListView2.SelectedItems(0).SubItems(2).Text
        End If
    End Sub
    Private Sub btnAddCandid_Click(sender As Object, e As EventArgs) Handles btnAddCandid.Click
        If txtAddCandid.Text = "" Or cboxAddCandid.SelectedIndex = -1 Then
            MessageBox.Show("Fill up candidate name and position to continue.", "Error!")
        Else
            Try
                connect.Open()
                Dim checkDuplicateSQL As String = "SELECT COUNT(*) FROM candidate WHERE candid_name = @fullname AND candid_position = @position"
                Dim checkDuplicateCmd As New MySqlCommand(checkDuplicateSQL, connect)
                checkDuplicateCmd.Parameters.AddWithValue("@fullname", txtAddCandid.Text)
                checkDuplicateCmd.Parameters.AddWithValue("@position", cboxAddCandid.Text)
                Dim duplicateCount As Integer = CInt(checkDuplicateCmd.ExecuteScalar())

                If duplicateCount > 0 Then
                    MsgBox("Candidate with the same name and position already exists.", vbInformation, "Admin")
                    clrAddCandidTxt()
                Else
                    Dim insertSQL As String = "INSERT INTO candidate (candid_name, candid_position) VALUES (@fullname, @position)"
                    Dim insertCmd As New MySqlCommand(insertSQL, connect)
                    insertCmd.Parameters.AddWithValue("@fullname", txtAddCandid.Text)
                    insertCmd.Parameters.AddWithValue("@position", cboxAddCandid.Text)
                    Dim i As Integer = insertCmd.ExecuteNonQuery()

                    If i <> 0 Then
                        MsgBox("Candidate added!", vbInformation, "Admin")
                        clrAddCandidTxt()
                        admCandidInfo()
                    Else
                        MsgBox("Failed to add candidate!", vbCritical, "Admin")
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub


    Private Sub btnUpdCandid_Click(sender As Object, e As EventArgs) Handles btnUpdCandid.Click
        If txtCandidName.Text = "" Or cboxCandidPos.SelectedIndex = -1 Then
            MessageBox.Show("Fill up candidate name and position to continue.", "Error!")
            txtCandidName.Focus()
        Else
            Try
                connect.Open()
                Dim SQL As String = "UPDATE candidate SET candid_name = @name, candid_position = @position WHERE candid_id = @id"
                Dim cmd = New MySqlCommand(SQL, connect)
                cmd.Parameters.AddWithValue("@name", txtCandidName.Text)
                cmd.Parameters.AddWithValue("@position", cboxCandidPos.Text)
                cmd.Parameters.AddWithValue("@id", txtCandidNum.Text)
                Dim i As Integer = cmd.ExecuteNonQuery()

                If i <> 0 Then
                    MsgBox("Candidate info updated!", vbInformation, "Admin")
                    clrCandidTxt()
                    admCandidInfo()
                Else
                    MsgBox("Failed to update candidate info!", vbCritical, "Admin")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connect.Close()
            End Try
        End If
    End Sub

    Private Sub btnDelCandid_Click(sender As Object, e As EventArgs) Handles btnDelCandid.Click
        Try
            connect.Open()
            Dim SQL As String = "DELETE FROM candidate WHERE candid_name = @id"
            Dim cmd = New MySqlCommand(SQL, connect)
            cmd.Parameters.AddWithValue("@id", txtCandidName.Text)
            Dim i As Integer = cmd.ExecuteNonQuery()

            If i <> 0 Then
                MsgBox("Candidate deleted!", vbInformation, "Admin")
                clrCandidTxt()
                admCandidInfo()
            Else
                MsgBox("Candidate deletion failed! No candidate selected.", vbCritical, "Admin")
                clrCandidTxt()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connect.Close()
        End Try
    End Sub

    Private Sub txtAddCandid_Click(sender As Object, e As EventArgs) Handles txtAddCandid.Click
        clrCandidTxt()
    End Sub
    Private Sub txtCandidName_Click(sender As Object, e As EventArgs) Handles txtCandidName.Click
        clrAddCandidTxt()
    End Sub


    'RESULT TAB
    'refresh result tab
    Private Sub btnRefreshResult_Click(sender As Object, e As EventArgs) Handles btnRefreshResult.Click
        admResultTab()
    End Sub
    Private Sub lblOpenLink_Click(sender As Object, e As EventArgs) Handles lblOpenLink.Click
        Dim link As String = "https://scvs-result.000webhostapp.com/"
        Process.Start(link)
    End Sub


    'ABOUT TAB
    Private Sub btnWebsite_Click(sender As Object, e As EventArgs) Handles btnViewWebsite.Click
        Process.Start("https://scvs.000webhostapp.com/")
    End Sub

End Class