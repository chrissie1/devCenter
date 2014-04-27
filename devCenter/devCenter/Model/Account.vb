Public Class Account
    Private _userName As String
    Private _eMail As String
    Private _password As Security.SecureString
    Private _createdOn As Date
    Private _playLists As List(Of Playlist)
    Private _ipAddress As String
    Private _macAddress As String
    Private _hardwareId As String

    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property

    Public Property EMail() As String
        Get
            Return _eMail
        End Get
        Set(value As String)
            _eMail = value
        End Set
    End Property

    Public Property Password() As Security.SecureString
        Get
            Return _password
        End Get
        Set(value As Security.SecureString)
            _password = value
        End Set
    End Property

    Public ReadOnly Property CreatedOn() As Date
        Get
            Return _createdOn
        End Get
    End Property

    Public Function Playlists() As List(Of Playlist)
        Return _playLists
    End Function

    Public Sub AddPlaylistToListOfPlaylists(ByRef playlist As Playlist)
        _playLists.Add(playlist)
    End Sub

    Public ReadOnly Property IPAddress() As String
        Get
            Return _ipAddress
        End Get
    End Property

    Public ReadOnly Property MacAddress() As String
        Get
            Return _macAddress
        End Get
    End Property

    Public ReadOnly Property HardwareId() As String
        Get
            Return _hardwareId
        End Get
    End Property
End Class
