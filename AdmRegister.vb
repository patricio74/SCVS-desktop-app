'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient
Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AdmRegister
    Dim connect As MySqlConnection
    Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = votingsystem_perez"
    Dim cmd As MySqlCommand
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'pang clear sa form
    Public Sub Clearballot()
        stdnum.ResetText()
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()
        course.Clear()
        yrsec.Clear()
        email.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If firstname.Text = "" Or lastname.Text = "" Or stdnum.Text = "" Or middlename.Text = "" Or course.Text = "" Or yrsec.Text = "" Or email.Text = "" Then
            MessageBox.Show("fill up all fields to continue.", "Error!")
        Else
            Try
                connect = New MySqlConnection(constring)
                connect.Open()
                Dim SQL As String =
                    "INSERT INTO voters (Student_number, First_name, Last_name, Middle_name, Course, Year, Email) 
                values('" & stdnum.Text & "','" & firstname.Text & "','" & lastname.Text & "','" & middlename.Text & "','" & course.Text & "','" & yrsec.Text & "','" & email.Text & "');"
                cmd = New MySqlCommand(SQL, connect)
                Dim i As Integer = cmd.ExecuteNonQuery

                If i <> 0 Or firstname.Text IsNot "" Then
                    MsgBox("Student registered successfully!", vbInformation, "Admin")
                    'Call Clearballot()
                    'shows if registration is successful
                Else
                    MsgBox("Error!", vbCritical, "Admin")
                End If
                Call Clearballot()
                connect.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'Call Clearballot()

    End Sub

    'return
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdmMenu.Show()
        Call Clearballot()
        Me.Hide()
    End Sub

    Private Sub stdnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stdnum.KeyPress
        'para number lang input
        If IsNumeric(stdnum.Text) Then
            'do nothing 
        Else
            'display error message
            MsgBox("Only numbers are allowed", vbCritical, "Error!")
            'clear textbox 
            stdnum.ResetText()
        End If
    End Sub

End Class