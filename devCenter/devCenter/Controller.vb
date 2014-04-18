Imports System.IO
Imports Nancy
Imports Nancy.Hosting.Self
Imports Nancy.Conventions
Imports System.Text

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

        MyBase.Get("/") = Function(parameters) "test"

        MyBase.Get("/list") = Function(parameters)
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
    End Sub

    Public Sub StartHosting()
        host = New NancyHost(New Uri("http://localhost:80"))
        host.Start()
        If Not open Then
            Process.Start("http://localhost:80/")
            open = True
        End If

    End Sub

    Public Sub StopHosting()
        host.Stop()
        host.Dispose()
    End Sub



End Class


