'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient
Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Module scvsModule
    Public Function getConString() As String
        Dim server As String = "db4free.net"
        Dim database As String = "voting_system"
        Dim uid As String = "patricc"
        Dim password As String = "votingsystem"
        Dim connectionString As String = $"Server={server};Database={database};Uid={uid};Pwd={password};"
        Return connectionString
    End Function

    Public Sub connectToServer()
        Dim connectionString As String = getConString()
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            ' Connection established successfully
        Catch ex As Exception
            ' Connection failed
            MsgBox("Failed to connect to database: " & ex.Message)
        End Try
    End Sub

    'ADMIN FORM FUNCTIONS
    'Admin logout btn
    Public Sub admLogout()
        SCVS_Login.userRFID()
        SCVS_Login.userLogin()
        SCVS_Login.radAdmin.Checked = True
        SCVS_Login.Show()
        Admin.TabControl1.SelectedIndex = 0
        clearRegFrom()
        clearUpdForm()
        Admin.Hide()
    End Sub

    'updates the label of admin result tab
    Public Sub admResultTab()
        Dim currentTime As DateTime = DateTime.Now
        Admin.lblResultTime.Text = "Election result as of " & currentTime.ToString("h:mm tt")
        Admin.lblResultDate.Text = currentTime.ToString("MM/dd/yy")
        Admin.resultWebBrowser.Navigate("https://websiteniperez.netlify.app/")
    End Sub

    'pang clear sa register tab
    Public Sub clearRegFrom()
        Admin.firstname.Clear()
        Admin.middlename.Clear()
        Admin.lastname.Clear()
        Admin.cboxCourse.SelectedIndex = -1
        Admin.cboxYear.SelectedIndex = -1
        Admin.email.Clear()
        Admin.pass.Clear()
        Admin.txtRFID.Clear()
    End Sub

    'clear update tab
    Public Sub clearUpdForm()
        Admin.stdNum.Clear()
        Admin.updFirstname.Clear()
        Admin.updMiddlename.Clear()
        Admin.updLastname.Clear()
        Admin.updCourse.SelectedIndex = -1
        Admin.updYear.SelectedIndex = -1
        Admin.updEmail.Clear()
        Admin.updRFID.Clear()
    End Sub

    'student info listview
    Public Sub voterInfo()
        Dim cmmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Try
            Admin.ListView1.Items.Clear()
            Dim connectionString As String = getConString()
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM voters"
                cmmd = New MySqlCommand(sql, connection)
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
                    Admin.ListView1.Items.Add(lvitm)
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    'STUDENT FORM FUNCTIONS
    Public Sub stdLogout()
        SCVS_Login.userRFID()
        SCVS_Login.userLogin()
        SCVS_Login.radAdmin.Checked = True
        SCVS_Login.Show()
        clearVote()
        Student.TabControl1.SelectedIndex = 0
        Student.Hide()
    End Sub
    'updates the label of student result tab
    Public Sub stdResultTab()
        Dim currentTime As DateTime = DateTime.Now
        Student.lblResultTime.Text = "Election result as of " & currentTime.ToString("h:mm tt")
        Student.lblResultDate.Text = currentTime.ToString("MM/dd/yy")
        Student.resultWebBrowser.Navigate("https://websiteniperez.netlify.app/")
    End Sub

    'clear radbuttons, textboxes sa vote tab
    Public Sub clearVote()
        Student.RadioButton1.Checked = False
        Student.RadioButton2.Checked = False
        Student.RadioButton3.Checked = False
        Student.RadioButton4.Checked = False
        Student.RadioButton5.Checked = False
        Student.RadioButton6.Checked = False
        Student.RadioButton7.Checked = False
        Student.RadioButton8.Checked = False
        Student.RadioButton9.Checked = False
        Student.RadioButton10.Checked = False
        Student.RadioButton11.Checked = False
        Student.RadioButton12.Checked = False
        Student.RadioButton13.Checked = False
        Student.RadioButton14.Checked = False
        Student.RadioButton15.Checked = False
        Student.RadioButton16.Checked = False
        Student.RadioButton17.Checked = False
        Student.RadioButton18.Checked = False
        Student.RadioButton19.Checked = False
        Student.RadioButton20.Checked = False
        Student.RadioButton21.Checked = False
        Student.RadioButton22.Checked = False
        Student.RadioButton23.Checked = False
        Student.RadioButton24.Checked = False
        Student.RadioButton25.Checked = False
        Student.RadioButton26.Checked = False
        Student.RadioButton27.Checked = False
        Student.RadioButton28.Checked = False
        Student.RadioButton29.Checked = False
        Student.RadioButton30.Checked = False
    End Sub

End Module
