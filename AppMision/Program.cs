using AppMision.Models;

/*
Jugador jugador = new Jugador("Carlito", 250);
jugador.AddAccion("Llegar al castillo");
jugador.AddMisionSuperada("Misión 1");


MisionCasiImposible m1 = new MisionCasiImposible("Misión CI", "dificil", 100, 300);

var resultadoCastillo = m1.AddAccionRequerida("Llegar al castillo");
var resultadoEncuentra = m1.AddAccionRequerida("Encontrar la espada.");


bool superada = m1.SuperaMision(jugador);

Console.WriteLine(superada ? "Misión Superada" : "Misión No Superada");
*/

/*
Mision m1 = new Mision("buscando la olla del duende", "facil", 100, 0);
Mision m2 = new Mision("lobo está?", "intermedio", 200, 100);
Mision m5 = new MisionCasiImposible("san jorge un poroto", "dificil", 500, 300);

((MisionCasiImposible)m5).AddAccionRequerida("Derrotar 10 dragones");

Aventura av1 = new Aventura("D&D");
av1.AgregarMision(m1);
av1.AgregarMision(m5);
av1.AgregarMision(m2);

Jugador player1 = new Jugador();
player1.Nombre = "Carlito";
player1.Aventura = av1;

Jugador player2 = new Jugador();
player2.Nombre = "Fernando";
player2.Aventura = av1;

player2.AddAccion("derrotar 10 dragones");

av1.AgregarJugador(player1);
av1.AgregarJugador(player2);


foreach(var item in av1.MetodoSinNombre())
{
    Console.WriteLine(item);
}
*/

int[] lista = { 2, 6, 8, 3, 5, 0, 2, 6 }; // Arreglo de ejemplo
int objetivo = 8; // Valor objetivo
List<int[]> pares = ClassAdicicional.EncontrarPares(lista, objetivo); // Llama al método para encontrar pares

// Imprime los pares de índices
foreach (var par in pares)
{
    Console.WriteLine($"({par[0]}, {par[1]})");
}