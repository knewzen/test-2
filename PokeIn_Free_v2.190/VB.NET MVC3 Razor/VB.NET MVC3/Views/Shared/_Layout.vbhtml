﻿<!DOCTYPE html>
<html>
<head>
    <title>@ViewData("Title")</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/Scripts/jquery-1.4.4.min.js")" type="text/javascript"></script>
</head>

<body>
    <div class="page">

        <div id="header">
            <div id="title">
                <h1>PokeIn MVC Razor VB Sample</h1>
            </div>

            <div id="logindisplay">
                @Html.Partial("_LogOnPartial")
            </div>

            <div id="menucontainer">

                <ul id="menu">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                </ul>

            </div>
        </div>

        <div id="main">
            @RenderBody()
            <div id="footer">
            </div>
        </div>
    </div>
</body>
</html>
