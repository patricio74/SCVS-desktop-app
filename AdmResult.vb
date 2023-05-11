'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Public Class AdmResult
    Dim connect As MySqlConnection
    'Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = votingsystem_perez"
    Dim constring As String = "server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;"
    Dim cmd As MySqlCommand
    Dim itemcol(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    'return
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdmMenu.Show()
        Me.Hide()
    End Sub

    'listview
    Public Sub voteresult()
        Try
            ListView1.Items.Clear()
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim sql As String = "SELECT COUNT(full_name) as Votes, full_name, position
                                    FROM candidates group by full_name, position
                                    ORDER BY position;"
            cmd = New MySqlCommand(sql, connect)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcol(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitm As New ListViewItem(itemcol)
                ListView1.Items.Add(lvitm)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connect.Close()
    End Sub

    'refresh
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call voteresult()
    End Sub

    Private Sub AdmResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call voteresult()
    End Sub

End Class