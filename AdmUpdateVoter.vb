'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class AdmUpdateVoter
    Dim connect As MySqlConnection
    'Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = votingsystem_perez"
    Dim constring As String = "server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;"

    Dim cmd As MySqlCommand
    Dim itemcol(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Public Sub VoterInfo()
        Try
            ListView1.Items.Clear()
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim sql As String = "SELECT * FROM voters"
            cmd = New MySqlCommand(sql, connect)
            da = New MySqlDataAdapter(cmd)
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
            firstname.Text = ListView1.SelectedItems(0).SubItems(1).Text
            middlename.Text = ListView1.SelectedItems(0).SubItems(2).Text
            lastname.Text = ListView1.SelectedItems(0).SubItems(3).Text
            cboxCourse.Text = ListView1.SelectedItems(0).SubItems(4).Text
            cboxYear.Text = ListView1.SelectedItems(0).SubItems(5).Text
            email.Text = ListView1.SelectedItems(0).SubItems(6).Text
            rfid.Text = ListView1.SelectedItems(0).SubItems(7).Text
        End If
    End Sub
    Public Sub Clearinfo()
        stdNum.Clear()
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()
        cboxCourse.SelectedIndex = -1
        cboxYear.SelectedIndex = -1
        email.Clear()
        rfid.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Voterinfo()
    End Sub

    'return button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdmMenu.Show()
        Me.Hide()
        Call Voterinfo()
        Call Clearinfo()
    End Sub

    'update button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String =
                "UPDATE voters SET First_name ='" & firstname.Text & "', Last_name ='" & lastname.Text & "', Middle_name ='" & middlename.Text & "', Course ='" & cboxCourse.Text & "',Yr ='" & cboxYear.Text & "', Email ='" & email.Text & "', RFID = '" & rfid.Text & "'   
                WHERE Student_number ='" & stdNum.Text & "' "
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Voter info updated!", vbInformation, "Admin")
            Else
                MsgBox("Voter info update failed!", vbCritical, "Admin")
            End If
            Call Voterinfo()
            Call Clearinfo()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'delete button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
            Call Voterinfo()
            Call Clearinfo()
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class