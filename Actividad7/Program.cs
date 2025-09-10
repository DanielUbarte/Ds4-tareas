// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//condicionales_Actividad 7

int totalJugador = 10;
int Totaldealer = 15;
string message = " ";

//para ganar en blackjack el jugador debe tener 21 puntos o menos y tener mas puntos que el dealer
Console.WriteLine("ingresa un número entre 1 y 21");
totalJugador = Convert.ToInt32(Console.ReadLine());

if (totalJugador > 21)
{
    message = "Opción invalidada, tú número debe ser menor o igual a 21";
    Console.WriteLine(message);
}
else if (totalJugador <= Totaldealer)
{
    message = "Perdiste vs el dealer, lo siento";
    Console.WriteLine(message);
}
else if (totalJugador > Totaldealer)
{
    message = "Venciste al dealer, felicidades";
    Console.WriteLine(message);
}