@Code

    ViewBag.Title = "Inicio"

End Code

<main>
    <div class="pelicula-principal">
        <div class="contenedor">
            <h3 class="titulo">¡Bienvenido!</h3>
            <p class="descripcion">
                Como parte de tu suscripción tienes acceso a contenido premium, ingresa a cualquiera de nuestros catálogos.
            </p>
            <button role="button" class="boton" onclick="location.href='@Url.Action("CategoriaPeliculas", "Usuario")'">Peliculas</button>
            <button role="button" class="boton">Música</button>
        </div>
    </div>
    <script src="https://kit.fontawesome.com/2c36e9b7b1.js" "></script>
</main>