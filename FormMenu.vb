'created by: Perez, J.P.
'BSIT-3F
'Group 5
Public Class FormMenu
    'add vote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Register.Show()
        Me.Hide()
    End Sub

    'update vote
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateVoter.Show()
        Me.Hide()
    End Sub

    'logout button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.Show()
        Me.Hide()
    End Sub

    'about button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About.Show()
    End Sub

    'view result
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Result.Show()
        Me.Hide()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class