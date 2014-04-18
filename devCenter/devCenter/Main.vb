Imports Nancy
Imports Nancy.Conventions

Public Class devCenter

    Private Sub cmd_On_Click(sender As Object, e As EventArgs) Handles cmd_On.Click
        labelResult.Text = "On"
    End Sub

    Private Sub cmd_Off_Click(sender As Object, e As EventArgs) Handles cmd_Off.Click
        labelResult.Text = "Off"
    End Sub
End Class
