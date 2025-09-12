// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Actividad 8, switch

//condicionales_Actividad 7

int totalJugador = 10;
int Totaldealer = 15;
string message = " ";
string switchControl = "";

//para ganar en blackjack el jugador debe tener 21 puntos o menos y tener mas puntos que el dealer
Console.WriteLine("ingresa un número entre 1 y 21");
totalJugador = Convert.ToInt32(Console.ReadLine());

switch (switchControl) {
    case "menu":
        Console.WriteLine("Welcome al casino");
        Console.WriteLine("Escriba blackjack");
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
}