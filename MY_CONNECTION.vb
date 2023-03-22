'created by: Perez, J.P.
'BSIT-3F
'Group 5

'for login page database connection

Imports MySql.Data.MySqlClient

Public Class MY_CONNECTION

    Private connection As New MySqlConnection("DATA SOURCE = localhost; USER id = root; DATABASE = votingsystem_perez")

    ' return the connection
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    ' open the connection
    Sub openConnection()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

    End Sub

    ' close the connection
    Sub closeConnection()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

End Class