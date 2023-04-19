Public Class StdMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        StdVote.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StdResult.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        About.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        StdLogin.Show()
        Me.Hide()
    End Sub

    Private Sub StdMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class