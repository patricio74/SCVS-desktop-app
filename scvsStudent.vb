'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class scvsStudent
    Private Sub Student_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadListBox()
    End Sub

    Dim candidIdDictionary As New Dictionary(Of ListBox, Integer)()

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listPresident.SelectedIndexChanged,
        listVicePres.SelectedIndexChanged, listSecretary.SelectedIndexChanged, listTres.SelectedIndexChanged,
        listAud.SelectedIndexChanged, listPRO.SelectedIndexChanged, listFirst.SelectedIndexChanged, listSecond.SelectedIndexChanged,
        listThird.SelectedIndexChanged, listFourth.SelectedIndexChanged
        Using connection As New MySqlConnection(getConString)
            connection.Open()
            Dim listBox As ListBox = DirectCast(sender, ListBox)

            'Get the selected candidate's name
            If listBox.SelectedItem IsNot Nothing Then
                Dim selectedCandidate As String = listBox.SelectedItem.ToString()

                'Query the database for the candid_id based on the selected candidate's name
                Dim query As String = "SELECT candid_id FROM candidate WHERE candid_name = @candid_name"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@candid_name", selectedCandidate)
                Dim candidId As Integer = CInt(command.ExecuteScalar())

                'Store the candid_id in the Dictionary for later use
                candidIdDictionary(listBox) = candidId
            Else
                'handle the case when no item is selected
            End If
            connection.Close()
        End Using
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        clrVotingForm()
        stdLogout()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0 'vote tab
                loadListBox()
            Case 1 'candidates tab
                stdCandidInfo()
            Case 2 'result tab
                'sync current tiem sa label
                stdResultTab()
            Case 3 'about SCVS tab

            Case Else 'other tab pages
                'do nothing
        End Select
    End Sub

    'VOTE TAB
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim username As String = scvsLogin.txtboxUsername.Text
            Dim tag As String = scvsLogin.txtboxRFID.Text

            'check if the user or RFID tag has already voted
            Dim chkStatusQuery As String = "SELECT votestatus FROM student WHERE email = @username OR rfid = @tag"

            Using connect As New MySqlConnection(getConString)
                connect.Open()

                Dim cmd As New MySqlCommand(chkStatusQuery, connect)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@tag", tag)

                Dim voteStatus As String = Convert.ToString(cmd.ExecuteScalar())

                'get student_id
                Dim getIdQuery As String = "SELECT user_id FROM student WHERE email = @username OR rfid = @tag"
                cmd = New MySqlCommand(getIdQuery, connect)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@tag", tag)

                Dim uid As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If voteStatus = "voted" Then
                    MsgBox("You have already voted!", vbInformation, "Admin")
                    clrVotingForm()
                    connect.Close()
                    Return
                Else
                    'Iterate through the Dictionary to insert votes for each ListBox
                    For Each pair As KeyValuePair(Of ListBox, Integer) In candidIdDictionary
                        Dim listBox As ListBox = pair.Key
                        Dim candidId As Integer = pair.Value

                        'insert vote into the vote table
                        Dim query As String = "INSERT INTO vote (user_id, candid_id) VALUES (@user_id, @candid_id)"
                        cmd = New MySqlCommand(query, connect)
                        cmd.Parameters.AddWithValue("@user_id", uid)
                        cmd.Parameters.AddWithValue("@candid_id", candidId)
                        cmd.ExecuteNonQuery()
                    Next

                    'Update student votestatus to 'voted' to prevent duplicate voting
                    Dim updateQuery As String = "UPDATE student SET votestatus = 'voted' WHERE user_id = @user_id"
                    cmd = New MySqlCommand(updateQuery, connect)
                    cmd.Parameters.AddWithValue("@user_id", uid)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Votes submitted successfully!")
                End If
                connect.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clrVotingForm()
    End Sub

    'RESULT TAB
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        stdResultTab()
    End Sub
    Private Sub lblOpenLink_Click(sender As Object, e As EventArgs) Handles lblOpenLink.Click
        Dim link As String = "https://scvs-result.000webhostapp.com/"
        Process.Start(link)
    End Sub

    'ABOUT TAB
    Private Sub btnWebsite_Click(sender As Object, e As EventArgs) Handles btnWebsite.Click
        Process.Start("https://scvs.000webhostapp.com/")
    End Sub
End Class