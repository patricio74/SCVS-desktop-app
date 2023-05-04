Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class admRFIDLogin
    Dim connectionString As String = ("server=db4free.net; user=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;")

    Private Sub admRFIDLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function CheckRFIDInDatabase(rfid As String) As Boolean
        Dim result As Boolean = False
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM voters WHERE RFID = @rfid"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@rfid", rfid)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count > 0 Then
                        result = True
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("A MySQL exception occurred: " + ex.Message, "MySQL Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidOperationException
            MessageBox.Show("An invalid operation exception occurred: " + ex.Message, "Invalid Operation Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An exception occurred: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function

    Private Sub btnRFIDLogin_Click(sender As Object, e As EventArgs) Handles btnRFIDLogin.Click
        Dim rfid As String = txtRFID.Text.Trim()

        If CheckRFIDInDatabase(rfid) Then
            AdmMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("User RFID not found in the database!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnUsePass_Click(sender As Object, e As EventArgs) Handles btnUsePass.Click
        AdmLogin.Show()
        Me.Hide()
    End Sub
End Class