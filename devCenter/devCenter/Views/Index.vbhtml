@Inherits Nancy.ViewEngines.Razor.NancyRazorViewBase(of list(of String))
<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="http://code.jquery.com/mobile/1.4.2/jquery.mobile-1.4.2.min.css">
    <script src="http://code.jquery.com/jquery-1.10.2.min.js"></script>
    <script src="http://code.jquery.com/mobile/1.4.2/jquery.mobile-1.4.2.min.js"></script>
</head>
<body>
    <div data-role="page" id="pageone">
        <div data-role="main" class="ui-content">
            <h2>musicShare</h2>
            <form class="ui-filterable">
                <input id="myFilter" data-type="search">
            </form>

            <ul data-role="listview" data-inset="true" data-filter="true" data-input="#myFilter" data-autodividers="true" data-icon="false">
                @For Each s As String In Model
                    @<li>
                        <a href="#">
                            <img src="http://icons.iconarchive.com/icons/wwalczyszyn/iwindows/96/Music-Library-icon.png" />
                            <h2>@s</h2>
                            <p style="font-color: yellow;">5<img src="http://icons.iconarchive.com/icons/gpritiranjan/simple-christmas/24/star-icon.png" /></p>
                        </a>
                    </li>
                Next
            </ul>
        </div>
    </div>
</body>
</html>
