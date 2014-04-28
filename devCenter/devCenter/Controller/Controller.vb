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

        MyBase.Get("/x") = Function(parameters)
                               Dim builder As New StringBuilder()
                               builder.AppendLine("<!DOCTYPE HTML>" & vbTab)
                               builder.AppendLine("<html>" & vbTab)
                               builder.AppendLine("<body>" & vbTab)
                               builder.AppendLine("<div class=""content"">" & vbTab)
                               builder.AppendLine("<ul>" & vbTab)

                               Dim di As New DirectoryInfo("C:\temp\")
                               Dim smFiles As FileInfo() = di.GetFiles()
                               For Each fi As FileInfo In smFiles

                                   builder.AppendFormat("<li><a href=""{0}"">{1}</a></li>" & vbTab & vbLf, Path.GetFileNameWithoutExtension(fi.Name), Path.GetFileNameWithoutExtension(fi.Name))
                               Next

                               builder.AppendLine("</ul>" & vbTab)
                               builder.AppendLine("</div>" & vbTab)
                               builder.AppendLine("</body>" & vbTab)
                               builder.AppendLine("</html>" & vbTab)

                               Return builder.ToString()
                           End Function

        MyBase.Get("/musicshare") = Function(parameters)
                                        Dim sc As New SongCollection()
                                        Dim s As New Song
                                        s.Artist = "test_Artist"
                                        s.Genre = "test_Genre"
                                        s.Title = "test_Title"
                                        sc.AddSongToListOfSongs(s)

                                        s = New Song()
                                        s.Artist = "test1_Artist"
                                        s.Genre = "test1_Genre"
                                        s.Title = "test1_Title"
                                        sc.AddSongToListOfSongs(s)

                                        'Dim sc As New List(Of String)

                                        'sc.Add("hallo")
                                        'sc.Add("velo")
                                        'sc.Add("hallo2")
                                        'sc.Add("3rad")

                                        Return View("index.vbhtml", sc)
                                    End Function
    End Sub

    Public Sub StartHosting()
        host = New NancyHost(New Uri("http://localhost:80/"))
        host.Start()
        Dim s As New Song

        If Not open Then
            Process.Start("http://localhost/musicshare")
            open = True
        End If

    End Sub

    Public Sub StopHosting()
        host.Stop()
        host.Dispose()
    End Sub



End Class


