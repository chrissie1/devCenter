Imports System.IO
Imports Nancy
Imports Nancy.Hosting.Self
Imports Nancy.Conventions
Imports System.Text
Imports devCenter.Model

Public Class ApplicationBootstrapper
    Inherits DefaultNancyBootstrapper
    Protected Overrides Sub ConfigureConventions(nancyConventions As NancyConventions)
        nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Static", "Static"))
        MyBase.ConfigureConventions(nancyConventions)
    End Sub
End Class


Public Class Controller
    Inherits NancyModule

    Private host As NancyHost
    Dim open As Boolean = False

    Public Sub New()
        MyBase.Get("/musicshare") = Function(parameters)
                                        Dim sc As New List(Of String)
                                        'Dim di As New DirectoryInfo("C:\music")
                                        'Dim smFiles As FileInfo() = di.GetFiles()

                                        'For Each fi As FileInfo In smFiles
                                        '    Dim song As String = fi.Name.Remove(fi.Name.Count - 4)
                                        'sc.Add(Song)
                                        'Next
                                        sc.Add("test1")
                                        sc.Add("test2")
                                        sc.Add("test3")
                                        sc.Sort()

                                        Return View("index.vbhtml", sc)
                                    End Function
    End Sub

    Public Sub StartHosting()
        Dim config = New HostConfiguration()
        config.RewriteLocalhost = False
        host = New NancyHost(config, New Uri("http://localhost:5050/"))
        host.Start()
        Dim s As New Song

        If Not open Then
            Process.Start("http://localhost:5050/musicshare")
            open = True
        End If

    End Sub

    Public Sub StopHosting()
        host.Stop()
        host.Dispose()
    End Sub



End Class


