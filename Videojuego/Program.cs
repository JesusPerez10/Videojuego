using Videojuego.Clase_base;

JuegoAccion ac = new JuegoAccion();
ac.armas = true;
ac.titulo = "Call of Duty";
ac.AnioLanzamiento = "2017";
ac.calificacion = "10";
ac.jugando = true;
string resultado = ac.mostrardetallesAccion();
Console.WriteLine(resultado);
