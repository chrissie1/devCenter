Public Class Song
    Private _title As String
    Private _artist As String
    Private _genre As String
    Private _votes As Integer = 0

    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
        End Set
    End Property

    Public Property Artist() As String
        Get
            Return _artist
        End Get
        Set(value As String)
            _artist = value
        End Set
    End Property

    Public Property Genre() As String
        Get
            Return _genre
        End Get
        Set(value As String)
            _genre = value
        End Set
    End Property

    Public Function GetAmountOfVotes() As Integer
        Return _votes
    End Function

    Public Sub Vote()
        _votes += 1
    End Sub
End Class
