Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient

Public Class RFID

    Private connectionString As String = "server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;"
    Private Sub RFID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radAdmin.Checked = True
        txtboxRFID.Focus()
    End Sub
    Private Sub RFID_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        txtboxRFID.Clear()
        txtboxRFID.Focus()
    End Sub

    Private Sub radAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmin.CheckedChanged
        txtboxRFID.Clear()
        txtboxRFID.Focus()
    End Sub

    Private Sub radStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged
        txtboxRFID.Clear()
        txtboxRFID.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim rfidTag As String = txtboxRFID.Text.Trim()
        'admin RFID login
        If radAdmin.Checked = True Then
            ' Check if the RFID tag is valid
            If String.IsNullOrEmpty(rfidTag) Then
                MessageBox.Show("Please scan your RFID tag.")
                txtboxRFID.Focus()
                Return
            End If

            ' Check the database for the RFID tag and vote status
            Dim query As String = "SELECT * FROM admin WHERE RFID = @RFIDTag"
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RFIDTag", rfidTag)
                    Try
                        connection.Open()
                        Dim reader As MySqlDataReader = command.ExecuteReader()

                        If reader.Read() Then
                            Dim username As String = reader("email").ToString()
                            Admin.Show()
                            'txtboxRFID.Clear()
                            SCVS_Login.Hide()
                        Else
                            MessageBox.Show("User RFID tag not found.")
                            txtboxRFID.Clear()
                            txtboxRFID.Focus()
                        End If

                        reader.Close()
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End Using
            End Using

            'student RFID login
        ElseIf radStudent.Checked = True Then
            ' Check if the RFID tag is valid
            If String.IsNullOrEmpty(rfidTag) Then
                MessageBox.Show("Please scan your RFID tag.")
                Return
            End If

            ' Check the database for the RFID tag and vote status
            Dim query As String = "SELECT * FROM voters WHERE RFID = @RFIDTag"
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RFIDTag", rfidTag)
                    Try
                        connection.Open()
                        Dim reader As MySqlDataReader = command.ExecuteReader()

                        If reader.Read() Then
                            Dim username As String = reader("email").ToString()
                            Dim voteStatus As String = reader("VoteStatus").ToString()

                            If voteStatus = "voted" Then
                                txtboxRFID.Clear()
                                txtboxRFID.Focus()
                                MessageBox.Show("You have already voted.")
                            Else
                                ' MessageBox.Show("Welcome to SCVS, " & username & "!")
                                StdMenu.Show()
                                SCVS_Login.Hide()
                            End If
                        Else
                            MessageBox.Show("User RFID tag not found.")
                            txtboxRFID.Clear()
                            txtboxRFID.Focus()
                        End If

                        reader.Close()
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub

End Class
