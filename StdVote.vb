'created by: Perez, J.P.
'BSIT-3F
'Group 5

Imports MySql.Data.MySqlClient
Public Class StdVote
    Dim connect As MySqlConnection
    'Dim constring As String = "DATA SOURCE = localhost; USER id = root; DATABASE = votingsystem_perez"
    Dim constring As String = "server=db4free.net; userid=patricc; password=votingsystem; database=voting_system; port=3306; old guids = true;"

    Dim cmd As MySqlCommand

    Dim presname, prespos As String
    Dim vicename, vicepos As String
    Dim secname, secpos As String
    Dim treaname, treapos As String
    Dim audname, audpos As String
    Dim proname, propos As String
    Dim firsname, firspos As String
    Dim seconame, secopos As String
    Dim thirname, thirpos As String
    Dim fourname, fourpos As String

    Private Sub Ballot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'pang clear sa form
    Public Sub Clearballot()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False
        RadioButton14.Checked = False
        RadioButton15.Checked = False
        RadioButton16.Checked = False
        RadioButton17.Checked = False
        RadioButton18.Checked = False
        RadioButton19.Checked = False
        RadioButton20.Checked = False
        RadioButton21.Checked = False
        RadioButton22.Checked = False
        RadioButton23.Checked = False
        RadioButton24.Checked = False
        RadioButton25.Checked = False
        RadioButton26.Checked = False
        RadioButton27.Checked = False
        RadioButton28.Checked = False
        RadioButton29.Checked = False
        RadioButton30.Checked = False
    End Sub

    'submit vote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connect = New MySqlConnection(constring)
            connect.Open()
            Dim username As String = StdLogin.user.Text
            Dim SQL As String =
                "INSERT INTO candidates (full_name, Position) 
                values('" & presname & "','" & prespos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & vicename & "','" & vicepos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & secname & "','" & secpos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & treaname & "','" & treapos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & audname & "','" & audpos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & proname & "','" & propos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & firsname & "','" & firspos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & seconame & "','" & secopos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & thirname & "','" & thirpos & "');
                INSERT INTO candidates (full_name, Position) 
                values('" & fourname & "','" & fourpos & "');
                UPDATE voters SET votestatus='voted' WHERE email='" & username & "';
                "
            cmd = New MySqlCommand(SQL, connect)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i <> 0 Then
                MsgBox("Vote submitted successfuly!", vbInformation, "Admin")
                StdLogin.Show()
                Me.Hide()
                Call Clearballot()
            Else
                MsgBox("Vote failed!", vbCritical, "Admin")
            End If
            Call Clearballot()
            connect.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Clearballot()
    End Sub

    'return button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StdMenu.Show()
        Me.Hide()
        Call Clearballot()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            presname = "Juanito Santos"
            prespos = "President"
            President.Text = presname
        Else
            President.Clear()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            presname = "Maria Cruz"
            prespos = "President"
            President.Text = presname
        Else
            President.Clear()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            presname = "Eduardo Reyes"
            prespos = "President"
            President.Text = presname
        Else
            President.Clear()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            vicename = "Rosario Garcia"
            vicepos = "Vice President"
            VicePres.Text = vicename
        Else
            VicePres.Clear()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            vicename = "Ferdinand Lim"
            vicepos = "Vice President"
            VicePres.Text = vicename
        Else
            VicePres.Clear()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            vicename = "Ysabel Rivera"
            vicepos = "Vice President"
            VicePres.Text = vicename
        Else
            VicePres.Clear()
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            secname = "Benigno Tan"
            secpos = "Secretary"
            Secretary.Text = secname
        Else
            Secretary.Clear()
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            secname = "Victoria Reyes"
            secpos = "Secretary"
            Secretary.Text = secname
        Else
            Secretary.Clear()
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            secname = "Rafaela Villanueva"
            secpos = "Secretary"
            Secretary.Text = secname
        Else
            Secretary.Clear()
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            treaname = "Josefa Alcantara"
            treapos = "Treasurer"
            Treasurer.Text = treaname
        Else
            Treasurer.Clear()
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            treaname = "Emilio Ramos"
            treapos = "Treasurer"
            Treasurer.Text = treaname
        Else
            Treasurer.Clear()
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            treaname = "Consuelo Cruz"
            treapos = "Treasurer"
            Treasurer.Text = treaname
        Else
            Treasurer.Clear()
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            audname = "Marcelo Mercado"
            audpos = "Auditor"
            Auditor.Text = audname
        Else
            Auditor.Clear()
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            audname = "Paz Herrera"
            audpos = "Auditor"
            Auditor.Text = audname
        Else
            Auditor.Clear()
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            audname = "Ramonito Cruz"
            audpos = "Auditor"
            Auditor.Text = audname
        Else
            Auditor.Clear()
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            proname = "Trinidad Lopez"
            propos = "Public Relations Officer"
            PROfficer.Text = proname
        Else
            PROfficer.Clear()
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            proname = "Marcelina Reyes"
            propos = "Public Relations Officer"
            PROfficer.Text = proname
        Else
            PROfficer.Clear()
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            proname = "Ricardo de la Cruz"
            propos = "Public Relations Officer"
            PROfficer.Text = proname
        Else
            PROfficer.Clear()
        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked = True Then
            firsname = "Romulo Rodriguez"
            firspos = "First Year Representative"
            firstrep.Text = firsname
        Else
            firstrep.Clear()
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked = True Then
            firsname = "Esperanza Gonzales"
            firspos = "First Year Representative"
            firstrep.Text = firsname
        Else
            firstrep.Clear()
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked = True Then
            firsname = "Felipe Cruz"
            firspos = "First Year Representative"
            firstrep.Text = firsname
        Else
            firstrep.Clear()
        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        If RadioButton22.Checked = True Then
            seconame = "Ana Luna"
            secopos = "Second Year Representative"
            secondrep.Text = seconame
        Else
            secondrep.Clear()
        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        If RadioButton23.Checked = True Then
            seconame = "Gregorio Santos"
            secopos = "Second Year Representative"
            secondrep.Text = seconame
        Else
            secondrep.Clear()
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked = True Then
            seconame = "Aurora Reyes"
            secopos = "Second Year Representative"
            secondrep.Text = seconame
        Else
            secondrep.Clear()
        End If
    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        If RadioButton25.Checked = True Then
            thirname = "Manuelito Cruz"
            thirpos = "Third Year Representative"
            thirdrep.Text = thirname
        Else
            thirdrep.Clear()
        End If
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        If RadioButton26.Checked = True Then
            thirname = "Lourdes de la Cruz"
            thirpos = "Third Year Representative"
            thirdrep.Text = thirname
        Else
            thirdrep.Clear()
        End If
    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged
        If RadioButton27.Checked = True Then
            thirname = "Rodrigo Flores"
            thirpos = "Third Year Representative"
            thirdrep.Text = thirname
        Else
            thirdrep.Clear()
        End If
    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged
        If RadioButton28.Checked = True Then
            fourname = "Gloria Sanchez"
            fourpos = "Fourth Year Representative"
            fourrep.Text = fourname
        Else
            fourrep.Clear()
        End If
    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged
        If RadioButton29.Checked = True Then
            fourname = "Domingo Abad"
            fourpos = "Fourth Year Representative"
            fourrep.Text = fourname
        Else
            fourrep.Clear()
        End If
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        If RadioButton30.Checked = True Then
            fourname = "Angelita Sarmiento"
            fourpos = "Fourth Year Representative"
            fourrep.Text = fourname
        Else
            fourrep.Clear()
        End If
    End Sub
End Class