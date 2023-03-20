Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'pang clear sa form
    Public Sub Clearballot()
        stdNum.Clear()
        firstname.Clear()
        middlename.Clear()
        lastname.Clear()
        course.Clear()
        yrsec.Clear()
        email.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'insert into mo sql commands

        'if successful sya eto dapat next
        Ballot.Show()
        Me.Hide()
    End Sub

    'return
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormMenu.Show()
        Me.Hide()
    End Sub
End Class