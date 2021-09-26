# JuegoPreguntas

El programa consiste en un videojuego, en el cual se pondrá a prueba tus habilidades al responder preguntas de cultura general, tiene 5 niveles, por cada nivel la dificualtad de las preguntas va aumentado, las preguntas tienen 4 opciones de respuesta, escoge la respuesta correcta para avanzar de nivel. Cada nivel tiene una recompensa en puntos, al momento de perder, ganar o retirarse se mostraran los puntos acumulados.

# ¿Como jugar?

Para jugar se debe oprimir el botón 'INICIAR EL JUEGO'.
Ingresar tu nombre en la casilla adecuanda y precionar 'CONTINUAR'.
Aparerá una pregunta y se te mostrará el nivel de esa pregunta, respondes la pregunta que creas correcta y le das al botón 'SIGUIENTE', para avanzar al siguiente nivel la respuesta debe de ser correcta, en caso contrario se te llevará a la pantalla de GAME OVER.
Al momento de llevar al ultimo nivel(5) y responder correctamente te llevará a la pantalla de Victoria.

# ¿Como agregar preguntas?

Para agragar preguntas debes oprimir el botón 'CONFIGURACIÓN'.
Ahí podrás añadir la pregunta, el nivel de su categoria y las posibles respuestas, solo debes checkear la respuesta que consideres correcta.
//Si no checkeas al menos una respuesta no funcionará, de la misma forma que si checkeas 2 o mas.
Para guardar tu pregunta en la Base de datos debes oprimir el botón 'GUARDAR'.
En caso de no querer guardala oprima el botón 'SALIR'.

# Software

El juego contiene una base de datos de SQL server, la cual pueden encontrar como un Script en la carperta ScriptSQL.
Ademas lleva una carpeta imagenes las cuales fueron las utilizadas para la creación del diseño.


El proyecto cuenta con 3 capas, la capa visual llamada Challenge, la capa de Negocio y la capa de Datos.

El software cuenta con su validaciones.

El historial de jugadores se almacena en la base de datos.

