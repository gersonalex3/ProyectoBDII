<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title | CloudStream</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" href="~/Content/Estilos.css">
    <link href="https://fonts.googleapis.com/css2?family=Bebas+Neue&family=Open+Sans:wght@400;600&display=swap" rel="stylesheet">
    <title>CStream</title>
</head>
<body>
    <header>
        <div class="contenedor">
            <h2 class="logotipo">Cloud Stream</h2>
            <nav>
                <a @Html.ActionLink("Inicio", "Index", "Home")></a>
                <a href="#">Programas</a>
                <a href="#">Películas</a>
                <a href="#">Gratuito</a>
                <a href="#">Mi Cuenta</a>
            </nav>
        </div>
    </header>

    <script src="https://kit.fontawesome.com/2c36e9b7b1.js" crossorigin="anonymous"></script>
        @RenderBody()
</body>
</html>
