Imports Nancy
Imports Nancy.Conventions
Imports Nancy.Hosting.Self
Imports System.Environment
Imports System.Net

Public Class devCenter

    Private c As New Controller

    Private Sub cmd_On_Click(sender As Object, e As EventArgs) Handles cmd_On.Click
        labelResult.Text = "On"
        c.StartHosting()
        cmd_On.Enabled = False
        cmd_Off.Enabled = True
        Me.BringToFront()
    End Sub

    Private Sub cmd_Off_Click(sender As Object, e As EventArgs) Handles cmd_Off.Click
        labelResult.Text = "Off"
        c.StopHosting()
        cmd_Off.Enabled = False
        cmd_On.Enabled = True
    End Sub

    Private Sub devCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hostname As String = Dns.GetHostName()
        lbl_IpAddress.Text = "Eigene IP-Adresse: " & CType(Dns.GetHostByName(hostname).AddressList.GetValue(0), IPAddress).ToString
    End Sub
End Class
