<!DOCTYPE html>
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Cartita animada</title>
  <link rel="stylesheet" href="style.css">
</head>
<body class="body">

  <div class="carta-contenedor-3d"> 
    <div class="carta-enfrente">
      <img src="sello.png" alt="Sello">
      <p>Con cariño 💕</p>
    </div>

    <div class="carta-trasera">
      <div class="solapa-superior"></div>
      <div class="solapa-inferior"></div>
      <div class="solapa-izquierda"></div>
      <div class="solapa-derecha"></div>
      <div class="carta-interior">
        <div class="contenido-carta">
          <h3>💌</h3>
          <p>Cuanto más tiempo estoy contigo,<br>más te amo ❤️</p>
          <img src="flores.png" alt="flores">
        </div>
      </div>
    </div>
  </div>

  <script>
  document.addEventListener("DOMContentLoaded", () => {
    const carta = document.querySelector(".carta-contenedor-3d");
    const solapaSuperior = document.querySelector(".solapa-superior");
    const cartaInterior = document.querySelector(".carta-interior");
    
    // 1. Gira la carta para mostrar el lado del sobre (trasero) después de 2 segundos.
    setTimeout(() => {
      carta.classList.add("girada");
    }, 2000); 
    
    // 2. Abre el sobre después de 4 segundos.
    setTimeout(() => {
      solapaSuperior.classList.add("abierta");
      cartaInterior.classList.add("abierta");
    }, 4000);
  });
  // ELIMINASTE el 'setTimeout' duplicado que estaba aquí.
  </script>

</body>
</html>