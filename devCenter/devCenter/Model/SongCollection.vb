Namespace Model
    Public Class SongCollection
        Private _listOfSongs As New List(Of Song)

        Public Function ListOfSongs() As List(Of Song)
            Return _listOfSongs
        End Function

        Public Sub AddSongToListOfSongs(ByRef song As Song)
            _listOfSongs.Add(song)

        End Sub




    End Class
End Namespace


