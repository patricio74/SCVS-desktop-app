'created by: Perez, J.P.
'BSIT-3F
'Group 5

'Imports System.IO.Ports
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class scvsStudent

    'Dim WithEvents serialPort As New SerialPort()
    Dim candidIdDictionary As New Dictionary(Of ListBox, Integer)()

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadListBox()
        'Try
        'serialPort = New SerialPort()
        'serialPort.PortName = "COM5"
        'serialPort.BaudRate = 115200
        'serialPort.Parity = Parity.None
        'serialPort.StopBits = StopBits.One
        'serialPort.DataBits = 8
        'serialPort.Handshake = Handshake.None
        'serialPort.DtrEnable = True
        'serialPort.RtsEnable = True
        'serialPort.NewLine = vbCrLf
        'serialPort.Open()
        'Catch ex As Exception
        'MessageBox.Show("Failed to open the serial port: " & ex.Message)
        'End Try
    End Sub
    Private Sub scvsStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If serialPort.IsOpen() Then
        'serialPort.Close()
        'End If
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listPresident.SelectedIndexChanged,
        listVicePres.SelectedIndexChanged, listSecretary.SelectedIndexChanged, listTres.SelectedIndexChanged,
        listAud.SelectedIndexChanged, listPRO.SelectedIndexChanged, listFirst.SelectedIndexChanged, listSecond.SelectedIndexChanged,
        listThird.SelectedIndexChanged, listFourth.SelectedIndexChanged
        Using connection As New MySqlConnection(getConString)
            connection.Open()
            Dim listBox As ListBox = DirectCast(sender, ListBox)

            If listBox.SelectedItem IsNot Nothing Then
                Dim selectedCandidate As String = listBox.SelectedItem.ToString()
                Dim query As String = "SELECT candid_id FROM candidate WHERE candid_name = @candid_name"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@candid_name", selectedCandidate)
                Dim candidId As Integer = CInt(command.ExecuteScalar())

                candidIdDictionary(listBox) = candidId
            Else
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

            Dim chkStatusQuery As String = "SELECT * FROM student WHERE email = @username OR rfid = @tag"

            Using connect As New MySqlConnection(getConString)
                connect.Open()

                Dim cmd As New MySqlCommand(chkStatusQuery, connect)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@tag", tag)

                Dim uid As Integer = 0
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso Integer.TryParse(result.ToString(), uid) Then
                    uid = Convert.ToInt32(result)
                End If

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim voteStatus As String = If(Not IsDBNull(reader("votestatus")), reader.GetString("votestatus"), "")
                    'Dim phoneNumber As String = If(Not IsDBNull(reader("phone_number")), reader.GetString("phone_number"), "")
                    reader.Close()
                    If voteStatus = "voted" Then
                        MsgBox("You have already voted!", vbInformation, "Admin")
                        clrVotingForm()
                        connect.Close()
                        Return
                    Else
                        ' Iterate through the Dictionary to insert votes for each ListBox
                        For Each pair As KeyValuePair(Of ListBox, Integer) In candidIdDictionary
                            Dim listBox As ListBox = pair.Key
                            Dim candidId As Integer = pair.Value

                            ' Insert vote into the vote table
                            Dim query As String = "INSERT INTO vote (user_id, candid_id) VALUES (@user_id, @candid_id)"
                            cmd = New MySqlCommand(query, connect)
                            cmd.Parameters.AddWithValue("@user_id", uid)
                            cmd.Parameters.AddWithValue("@candid_id", candidId)
                            cmd.ExecuteNonQuery()
                        Next

                        Dim updateQuery As String = "UPDATE student SET votestatus = 'voted' WHERE user_id = @user_id"
                        cmd = New MySqlCommand(updateQuery, connect)
                        cmd.Parameters.AddWithValue("@user_id", uid)
                        cmd.ExecuteNonQuery()

                        ' Send a message to the user
                        'If serialPort.IsOpen = True Then

                        'serialPort.Write("AT" & vbCrLf)
                        'serialPort.Write("AT+CMGF=1" & vbCrLf)
                        'serialPort.Write(phoneNumber)

                        'Dim message As String = "THANK YOU FOR USING SCVS!" & vbCrLf & "Your vote has been submitted successfully." & vbCrLf & "" & vbCrLf & "To view vote result, you may visit SCVS website: https://scvs.000webhostapp.com/"
                        'Dim response As String = serialPort.ReadExisting()
                        'Do Until response.Contains(">")
                        'response &= serialPort.ReadExisting()
                        'Loop
                        'serialPort.Write(message & Chr(26))
                        'System.Threading.Thread.Sleep(5000)
                        'Dim newresponse = serialPort.ReadExisting()
                        'If newresponse.Contains("OK") Then
                        'MessageBox.Show("message sent succesfully.", "Error", MessageBoxButtons.OK)
                        'Else
                        'MessageBox.Show("Failed to send message.", "Error", MessageBoxButtons.OK)
                        'End If
                        '   Else
                        '  MessageBox.Show("Error: Invalid Port", "Port", MessageBoxButtons.OK)
                        'End If

                        MessageBox.Show("Votes submitted successfully!")
                    End If
                Else
                    reader.Close()
                    MsgBox("User not found!", vbInformation, "Admin")
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