'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Module moduleStudent
    Public Sub stdLogout()
        scvsLogin.userRFID()
        scvsLogin.userLogin()
        scvsLogin.radAdmin.Checked = True
        scvsLogin.Show()
        scvsStudent.TabControl1.SelectedIndex = 0
        scvsStudent.Hide()
    End Sub
    Public Sub stdCandidInfo()
        Dim cmmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Try
            scvsStudent.ListView2.Items.Clear()
            Dim connectionString As String = getConString()
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM candidate"
                cmmd = New MySqlCommand(sql, connection)
                da = New MySqlDataAdapter(cmmd)
                ds = New DataSet
                da.Fill(ds, "Tables")
                For r = 0 To ds.Tables(0).Rows.Count - 1
                    Dim lvitm As New ListViewItem()
                    lvitm.Text = ds.Tables(0).Rows(r)("candid_id").ToString()
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("candid_name").ToString())
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("candid_position").ToString())
                    scvsStudent.ListView2.Items.Add(lvitm)
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'updates the label of student result tab
    Public Sub stdResultTab()
        Dim currentTime As DateTime = DateTime.Now
        scvsStudent.lblResultTime.Text = "Election result as of " & currentTime.ToString("h:mm tt")
        scvsStudent.lblResultDate.Text = currentTime.ToString("MM/dd/yy")
        scvsStudent.resultWebBrowser.Refresh()
        scvsStudent.resultWebBrowser.Navigate("https://scvs-result.000webhostapp.com/")
    End Sub

    Public Function getCandid(position As String) As List(Of String)
        Dim candidates As New List(Of String)()

        Using connection As New MySqlConnection(getConString)
            connection.Open()

            Dim query As String = "SELECT candid_name FROM candidate WHERE candid_position = @position"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@position", position)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        candidates.Add(reader.GetString(0))
                    End While
                    reader.Close()
                End Using
            End Using
            connection.Close()
        End Using
        Return candidates
    End Function
    Public Sub PopulateListBox(position As String, listBox As ListBox)
        Dim candidates As List(Of String) = getCandid(position)
        listBox.Items.Clear()
        For Each candidateName As String In candidates
            listBox.Items.Add(candidateName)
        Next
    End Sub
    Public Sub loadListBox()
        PopulateListBox("PRESIDENT", scvsStudent.listPresident)
        PopulateListBox("VICE PRESIDENT", scvsStudent.listVicePres)
        PopulateListBox("SECRETARY", scvsStudent.listSecretary)
        PopulateListBox("TREASURER", scvsStudent.listTres)
        PopulateListBox("AUDITOR", scvsStudent.listAud)
        PopulateListBox("PUBLIC RELATIONS OFFICER", scvsStudent.listPRO)
        PopulateListBox("FIRST YEAR REPRESENTATIVE", scvsStudent.listFirst)
        PopulateListBox("SECOND YEAR REPRESENTATIVE", scvsStudent.listSecond)
        PopulateListBox("THIRD YEAR REPRESENTATIVE", scvsStudent.listThird)
        PopulateListBox("FOURTH YEAR REPRESENTATIVE", scvsStudent.listFourth)
    End Sub
    Public Sub clrVotingForm()
        scvsStudent.listPresident.ClearSelected()
        scvsStudent.listVicePres.ClearSelected()
        scvsStudent.listSecretary.ClearSelected()
        scvsStudent.listTres.ClearSelected()
        scvsStudent.listAud.ClearSelected()
        scvsStudent.listPRO.ClearSelected()
        scvsStudent.listFirst.ClearSelected()
        scvsStudent.listSecond.ClearSelected()
        scvsStudent.listThird.ClearSelected()
        scvsStudent.listFourth.ClearSelected()
    End Sub
End Module