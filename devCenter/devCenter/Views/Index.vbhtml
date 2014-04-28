@Inherits Nancy.ViewEngines.Razor.NancyRazorViewBase


<!DOCTYPE html>
<html>
<head>
    <title></title>
</head>
<body>
    <h1>test</h1>

    <!--
        for each song in listofsongs
            <li>song.Artist</li>
            <li>song.Genre</li>
            <li>song.Title</li>
        next
        -->

    @*@For Each s As String In Model
        @<li>@s</li>
    Next*@

    @Model.ListOfSongs(1).Artist

 
       
</body>
</html>