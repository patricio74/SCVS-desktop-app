'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports System.Runtime.Remoting.Contexts

Public Class Register
    Dim connect As MySqlConnection
    Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = votingsystem_perez"
    Dim cmd As MySqlCommand
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'pang clear sa form
    Public Sub Clearballot()
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()
        course.Clear()
        yrsec.Clear()
        email.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim SQL As String =
                "INSERT INTO voters (First_name, Last_name, Middle_name, Course, Year, Email) 
                values('" & firstname.Text & "','" & lastname.Text & "','" & middlename.Text & "','" & course.Text & "','" & yrsec.Text & "','" & email.Text & "');"
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Successful!", vbInformation, "Admin")

                'shows the ballot form if registration is successful
                Ballot.Show()
                Me.Hide()
            Else
                MsgBox("Error!", vbCritical, "Admin")
            End If
            Call Clearballot()
            connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Call Clearballot()

    End Sub

    'return
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class