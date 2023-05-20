'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient

Module moduleDatabase
    Public Function getConString() As String
        Dim server As String = "db4free.net"
        Dim database As String = "scvs_perez"
        Dim uid As String = "scvsystem"
        Dim password As String = "scvsystemprz23"
        Dim connectionString As String = $"Server={server};Database={database};Uid={uid};Pwd={password};"
        Return connectionString
    End Function

    Public Sub connectToServer()
        Dim connectionString As String = getConString()
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
        Catch ex As Exception
            'Connection failed
            MsgBox("Failed to connect to database: " & ex.Message)
            connection.Close()
        End Try
    End Sub
End Module