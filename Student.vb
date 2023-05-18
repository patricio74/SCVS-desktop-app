'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class Student
    Dim connect As New MySqlConnection(getConString)
    Dim cmd As MySqlCommand

    Dim presname, prespos As String
    Dim vicename, vicepos As String
    Dim secname, secpos As String
    Dim treaname, treapos As String
    Dim audname, audpos As String
    Dim proname, propos As String
    Dim firsname, firspos As String
    Dim seconame, secopos As String
    Dim thirname, thirpos As String
    Dim fourname, fourpos As String

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        stdLogout()
    End Sub

    'clear tab bago iview
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 'vote tab
                'insert na lang code para masync names ng candid sa mga text ng radbuttons
            Case 1 'candidates tab
                stdCandidInfo()
            Case 2 'result tab
                'sync current tiem sa label
                stdResultTab()
            Case 3 'about SCVS tab

            Case Else ' all other tab pages
                ' do nothing
        End Select
    End Sub

    'VOTE TAB
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            connect = New MySqlConnection(getConString)
            connect.Open()

            Dim username As String = SCVS_Login.txtboxUsername.Text
            Dim tag As String = SCVS_Login.txtboxRFID.Text

            ' Check if the user or RFID tag has already voted
            Dim checkQuery As String = "SELECT votestatus FROM voters WHERE email = '" & SCVS_Login.txtboxUsername.Text & "' OR rfid = '" & SCVS_Login.txtboxRFID.Text & "'"
            cmd = New MySqlCommand(checkQuery, connect)
            Dim voteStatus As String = Convert.ToString(cmd.ExecuteScalar())

            If voteStatus = "voted" Then
                MsgBox("You have already voted!", vbInformation, "Admin")
                clearVote()
                Return
            End If

            ' Insert candidates
            Dim insertQuery As String =
            "INSERT INTO candidates (full_name, Position) 
            values('" & presname & "','" & prespos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & vicename & "','" & vicepos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & secname & "','" & secpos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & treaname & "','" & treapos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & audname & "','" & audpos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & proname & "','" & propos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & firsname & "','" & firspos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & seconame & "','" & secopos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & thirname & "','" & thirpos & "');
            INSERT INTO candidates (full_name, Position) 
            values('" & fourname & "','" & fourpos & "');"

            ' Execute multiple SQL statements in a single transaction
            Using transaction As MySqlTransaction = connect.BeginTransaction()
                cmd = New MySqlCommand() With {
                .Connection = connect,
                .Transaction = transaction
                }
                Try
                    ' Execute INSERT statements
                    cmd.CommandText = insertQuery
                    cmd.ExecuteNonQuery()

                    ' Update voter's vote status
                    Dim updateQuery As String = "UPDATE voters SET votestatus='voted' WHERE email='" & SCVS_Login.txtboxUsername.Text & "' OR rfid='" & SCVS_Login.txtboxRFID.Text & "';"
                    cmd.CommandText = updateQuery
                    cmd.ExecuteNonQuery()

                    ' Commit the transaction if all statements succeed
                    transaction.Commit()

                    MsgBox("Vote submitted successfully!", vbInformation, "Admin")
                    clearVote()
                Catch ex As Exception
                    ' Rollback the transaction if any error occurs
                    transaction.Rollback()
                    MsgBox("Vote failed!", vbCritical, "Admin")
                End Try
            End Using
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearVote()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            presname = RadioButton1.Text
            prespos = "PRESIDENT"
            President.Text = presname
        Else
            President.Clear()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            presname = RadioButton2.Text
            prespos = "PRESIDENT"
            President.Text = presname
        Else
            President.Clear()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            presname = RadioButton3.Text
            prespos = "PRESIDENT"
            President.Text = presname
        Else
            President.Clear()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            vicename = RadioButton4.Text
            vicepos = "VICE PRESIDENT"
            VicePres.Text = vicename
        Else
            VicePres.Clear()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            vicename = RadioButton5.Text
            vicepos = "VICE PRESIDENT"
            VicePres.Text = vicename
        Else
            VicePres.Clear()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            vicename = RadioButton6.Text
            vicepos = "VICE PRESIDENT"
            VicePres.Text = vicename
        Else
            VicePres.Clear()
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            secname = RadioButton7.Text
            secpos = "SECRETARY"
            Secretary.Text = secname
        Else
            Secretary.Clear()
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            secname = RadioButton8.Text
            secpos = "SECRETARY"
            Secretary.Text = secname
        Else
            Secretary.Clear()
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            secname = RadioButton9.Text
            secpos = "SECRETARY"
            Secretary.Text = secname
        Else
            Secretary.Clear()
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            treaname = RadioButton10.Text
            treapos = "TREASURER"
            Treasurer.Text = treaname
        Else
            Treasurer.Clear()
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            treaname = RadioButton11.Text
            treapos = "TREASURER"
            Treasurer.Text = treaname
        Else
            Treasurer.Clear()
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            treaname = RadioButton12.Text
            treapos = "TREASURER"
            Treasurer.Text = treaname
        Else
            Treasurer.Clear()
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            audname = RadioButton13.Text
            audpos = "AUDITOR"
            Auditor.Text = audname
        Else
            Auditor.Clear()
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            audname = RadioButton14.Text
            audpos = "AUDITOR"
            Auditor.Text = audname
        Else
            Auditor.Clear()
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            audname = RadioButton15.Text
            audpos = "AUDITOR"
            Auditor.Text = audname
        Else
            Auditor.Clear()
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            proname = RadioButton16.Text
            propos = "PUBLIC RELATIONS OFFICER"
            PROfficer.Text = proname
        Else
            PROfficer.Clear()
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            proname = RadioButton17.Text
            propos = "PUBLIC RELATIONS OFFICER"
            PROfficer.Text = proname
        Else
            PROfficer.Clear()
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            proname = RadioButton18.Text
            propos = "PUBLIC RELATIONS OFFICER"
            PROfficer.Text = proname
        Else
            PROfficer.Clear()
        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked = True Then
            firsname = RadioButton19.Text
            firspos = "FIRST YEAR REPRESENTATIVE"
            firstrep.Text = firsname
        Else
            firstrep.Clear()
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked = True Then
            firsname = RadioButton20.Text
            firspos = "FIRST YEAR REPRESENTATIVE"
            firstrep.Text = firsname
        Else
            firstrep.Clear()
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked = True Then
            firsname = RadioButton21.Text
            firspos = "FIRST YEAR REPRESENTATIVE"
            firstrep.Text = firsname
        Else
            firstrep.Clear()
        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        If RadioButton22.Checked = True Then
            seconame = RadioButton22.Text
            secopos = "SECOND YEAR REPRESENTATIVE"
            secondrep.Text = seconame
        Else
            secondrep.Clear()
        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        If RadioButton23.Checked = True Then
            seconame = RadioButton23.Text
            secopos = "SECOND YEAR REPRESENTATIVE"
            secondrep.Text = seconame
        Else
            secondrep.Clear()
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked = True Then
            seconame = RadioButton24.Text
            secopos = "SECOND YEAR REPRESENTATIVE"
            secondrep.Text = seconame
        Else
            secondrep.Clear()
        End If
    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        If RadioButton25.Checked = True Then
            thirname = RadioButton25.Text
            thirpos = "THIRD YEAR REPRESENTATIVE"
            thirdrep.Text = thirname
        Else
            thirdrep.Clear()
        End If
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        If RadioButton26.Checked = True Then
            thirname = RadioButton26.Text
            thirpos = "THIRD YEAR REPRESENTATIVE"
            thirdrep.Text = thirname
        Else
            thirdrep.Clear()
        End If
    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged
        If RadioButton27.Checked = True Then
            thirname = RadioButton27.Text
            thirpos = "THIRD YEAR REPRESENTATIVE"
            thirdrep.Text = thirname
        Else
            thirdrep.Clear()
        End If
    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged
        If RadioButton28.Checked = True Then
            fourname = RadioButton28.Text
            fourpos = "FOURTH YEAR REPRESENTATIVE"
            fourrep.Text = fourname
        Else
            fourrep.Clear()
        End If
    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged
        If RadioButton29.Checked = True Then
            fourname = RadioButton29.Text
            fourpos = "FOURTH YEAR REPRESENTATIVE"
            fourrep.Text = fourname
        Else
            fourrep.Clear()
        End If
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        If RadioButton30.Checked = True Then
            fourname = RadioButton30.Text
            fourpos = "FOURTH YEAR REPRESENTATIVE"
            fourrep.Text = fourname
        Else
            fourrep.Clear()
        End If
    End Sub


    'RESULT TAB
    'refresh result tab
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        stdResultTab()
    End Sub

    'ABOUT TAB
    Private Sub btnWebsite_Click(sender As Object, e As EventArgs) Handles btnWebsite.Click
        Process.Start("https://scvs.000webhostapp.com/")
    End Sub
End Class