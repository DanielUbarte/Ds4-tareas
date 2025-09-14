// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Actividad 9, ciclo while

int num = 0; //variable para numero aleatorio
int totalJugador = 0; //variable para la suma total de cartas del jugador
int Totaldealer = 16; //variable inicializada con el total del dealer
string message = " "; //variable para mensajes
string switchControl = " "; //variable para el switch
string resCarta = " "; //variable para la respuesta de si quiere otra carta

while (true) //inicia el ciclo
{
    //indicaciones para el usuario
    Console.WriteLine("Escribe 'reglas' para ver las reglas del juego o escribe '21' para jugar blackjack");
    switchControl = Console.ReadLine(); //lee la respuesta del usuario para entrar al switch
    switch (switchControl)
    {
        case "reglas":
            Console.WriteLine("Welcome al casino"); //mensaje de bienvenida
            Console.WriteLine("//para ganar en blackjack el jugador debe tener 21 puntos" +
            " o menos y tener mas puntos que el dealer");
            break;  //fin del case reglas

        case "21":
            //para ganar en blackjack el jugador debe tener 21 puntos o menos y tener mas puntos que el dealer
            do
            {
                System.Random random = new System.Random(); //objeto random sacado del sistema
                num = random.Next(1, 12); //genera un numero aleatorio entre 1 y 12 y lo recibe num
                totalJugador = totalJugador + num; //suma el numero aleatorio al total del jugador
                Console.WriteLine("toma tu carta, jugador"); //mensaje para el jugador
                Console.WriteLine("te salió: "+num);
                Console.WriteLine("¿Deseas otra carta?");
                resCarta = Console.ReadLine(); //lee la respuesta del jugador
            } while (resCarta == "Si" || resCarta == "si"); //si la respuesta es si, se repite el ciclo

            if (totalJugador > 21) //si el total del jugador es mayor a 21
            {
                message = "Opción invalidada, tú número debe ser menor o igual a 21";
                Console.WriteLine(message);
            }
            else if (totalJugador <= Totaldealer) //si el total del jugador es menor o igual al total del dealer
            {
                message = "Perdiste vs el dealer, lo siento";
                Console.WriteLine(message);
            }
            else if (totalJugador > Totaldealer) //si el total del jugador es mayor al total del dealer
            {
                message = "Venciste al dealer, felicidades";
                Console.WriteLine(message);
            }
            break;
            default: //si la opción no es ni reglas ni 21
            Console.WriteLine("Opción inválida, escribe 'reglas' o '21'");
                break;
    }
}