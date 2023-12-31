﻿
<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Select Address</title>
    @Styles.Render("~/Content/css")
    <script src='https://www.google.com/recaptcha/api.js' async defer></script>
</head>

<body>
    <header>
        <img src="https://www.box.co.uk/Images/box-logo2-FP_2110111013.svg" width="70" height="70" alt="Logo">
        <nav>
            <span class="menu-toggle">&#9776;</span>
            <ul>
                <li><a href="#">Home</a></li>
                <li><a href="#">About</a></li>
                <li><a href="#">Contact</a></li>
            </ul>
        </nav>
    </header>
    @RenderBody()

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/BoxScripts")
    @RenderSection("scripts", required:=False)

</body>
</html>
