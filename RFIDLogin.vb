Imports System.Data.SqlClient

Public Class RFIDLogin
    Dim connectionString As String = ("server=db4free.net; userid=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;")
    Private Sub RFIDLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtRFID_TextChanged(sender As Object, e As EventArgs) Handles txtRFID.TextChanged

    End Sub

    Private Sub btnRFIDLogin_Click(sender As Object, e As EventArgs) Handles btnRFIDLogin.Click

    End Sub


    Private Function CheckRFIDInDatabase(rfid As String) As Boolean
        Dim result As Boolean = False

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

        Return result
    End Function
End Class