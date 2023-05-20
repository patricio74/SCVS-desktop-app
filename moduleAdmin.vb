'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Module moduleAdmin
    Public Sub admLogout()
        scvsLogin.userRFID()
        scvsLogin.userLogin()
        scvsLogin.radAdmin.Checked = True
        scvsLogin.Show()
        scvsAdmin.TabControl1.SelectedIndex = 0
        clearRegFrom()
        clearUpdForm()
        scvsAdmin.Hide()
    End Sub

    'update label of admin result tab
    Public Sub admResultTab()
        Dim currentTime As DateTime = DateTime.Now
        scvsAdmin.lblResultTime.Text = "Election result as of " & currentTime.ToString("h:mm tt")
        scvsAdmin.lblResultDate.Text = currentTime.ToString("MM/dd/yy")
        scvsAdmin.resultWebBrowser.Refresh()
        scvsAdmin.resultWebBrowser.Navigate("https://scvs-result.000webhostapp.com/")
    End Sub

    Public Sub clearRegFrom()
        scvsAdmin.firstname.Clear()
        scvsAdmin.middlename.Clear()
        scvsAdmin.lastname.Clear()
        scvsAdmin.cboxCourse.SelectedIndex = -1
        scvsAdmin.cboxYear.SelectedIndex = -1
        scvsAdmin.email.Clear()
        scvsAdmin.pass.Clear()
        scvsAdmin.txtRFID.Clear()
        scvsAdmin.txtContactNum.Clear()
    End Sub

    Public Sub clearUpdForm()
        scvsAdmin.stdNum.Clear()
        scvsAdmin.updFirstname.Clear()
        scvsAdmin.updMiddlename.Clear()
        scvsAdmin.updLastname.Clear()
        scvsAdmin.updCourse.SelectedIndex = -1
        scvsAdmin.updYear.SelectedIndex = -1
        scvsAdmin.updEmail.Clear()
        scvsAdmin.updRFID.Clear()
    End Sub

    'student info listview
    Public Sub voterInfo()
        Dim cmmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Try
            scvsAdmin.ListView1.Items.Clear()
            Dim connectionString As String = getConString()
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM student"
                cmmd = New MySqlCommand(sql, connection)
                da = New MySqlDataAdapter(cmmd)
                ds = New DataSet
                da.Fill(ds, "Tables")
                For r = 0 To ds.Tables(0).Rows.Count - 1
                    Dim lvitm As New ListViewItem()
                    lvitm.Text = ds.Tables(0).Rows(r)("user_id").ToString()
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("firstname").ToString())
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("middlename").ToString())
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("lastname").ToString())
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("course").ToString())
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("yrsec").ToString())
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("email").ToString())
                    lvitm.SubItems.Add(ds.Tables(0).Rows(r)("rfid").ToString())
                    scvsAdmin.ListView1.Items.Add(lvitm)
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub clrCandidForm()
        clrCandidTxt()
        clrAddCandidTxt()
    End Sub
    Public Sub clrCandidTxt()
        scvsAdmin.txtCandidNum.Clear()
        scvsAdmin.txtCandidName.Clear()
        scvsAdmin.cboxCandidPos.SelectedIndex = -1
    End Sub
    Public Sub clrAddCandidTxt()
        scvsAdmin.txtAddCandid.Clear()
        scvsAdmin.cboxAddCandid.SelectedIndex = -1
    End Sub

    'candidates tab listview
    Public Sub admCandidInfo()
        Dim cmmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Try
            scvsAdmin.ListView2.Items.Clear()
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
                    scvsAdmin.ListView2.Items.Add(lvitm)
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
