Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class stdRFIDLogin

    Private connectionString As String = "server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;"

    Private Sub btnRFIDLogin_Click(sender As Object, e As EventArgs) Handles btnRFIDLogin.Click
        Dim rfidTag As String = txtRFID.Text.Trim()

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
                            txtRFID.Clear()
                            MessageBox.Show("You have already voted.")
                        Else
                            MessageBox.Show("Welcome to SCVS, " & username & "!")
                            txtRFID.Clear()
                            StdMenu.Show()
                            Me.Hide()
                        End If
                    Else
                        MessageBox.Show("User RFID tag not found.")
                    End If

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnUsePass_Click(sender As Object, e As EventArgs) Handles btnUsePass.Click
        txtRFID.Clear()
        StdLogin.Show()
        Me.Hide()
    End Sub
End Class
