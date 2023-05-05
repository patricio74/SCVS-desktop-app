'created by: Perez, J.P.
'BSIT-3F
'Group 5

Public Class AdmMenu
    'add vote
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdmRegister.Show()
        Me.Hide()
    End Sub

    'update vote
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdmUpdateVoter.Show()
        Me.Hide()
    End Sub

    'logout button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdmLogin.user.Clear()
        AdmLogin.pass.Clear()
        admRFIDLogin.txtRFID.Clear()
        AdmLogin.Show()
        Me.Hide()
    End Sub

    'about button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        About.Show()
    End Sub

    'view result
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        admResult.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("https://scvs.000webhostapp.com/")
    End Sub
End Class