// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Actividad 8, switch

int totalJugador = 0; //puntos del jugador
int Totaldealer = 15; //puntos del dealer
string message = " "; //mensaje a mostrar
string switchControl = " "; //variable para controlar el switch

//menú principal
Console.WriteLine("Escribe 'reglas' para ver las reglas del juego o escribe '21' para jugar blackjack");
switchControl = Console.ReadLine(); //lee la opción del usuario
switch (switchControl) {
        case "reglas": //muestra las reglas del juego
        Console.WriteLine("Welcome al casino");
            Console.WriteLine("//para ganar en blackjack el jugador debe tener 21 puntos" +
            " o menos y tener mas puntos que el dealer");
        break;//fin case reglas

        case "21": 
            //para ganar en blackjack el jugador debe tener 21 puntos o menos y tener mas puntos que el dealer
            Console.WriteLine("ingresa un número entre 1 y 21");
            totalJugador = Convert.ToInt32(Console.ReadLine());//lee el número del jugador

            if (totalJugador > 21) //si el jugador tiene más de 21 puntos
        {
                message = "Opción invalidada, tú número debe ser menor o igual a 21";
                Console.WriteLine(message);
            }
            else if (totalJugador <= Totaldealer)//si el jugador tiene menos o igual puntos que el dealer
        {
                message = "Perdiste vs el dealer, lo siento";
                Console.WriteLine(message);
            }
            else if (totalJugador > Totaldealer)//si el jugador tiene más puntos que el dealer
        {
                message = "Venciste al dealer, felicidades";
                Console.WriteLine(message);
            }
            break;
            default: //si la opción no es ni reglas ni 21
                Console.WriteLine("Opción inválida, escribe 'reglas' o '21'");
            break;
}