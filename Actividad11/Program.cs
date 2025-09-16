// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Actividad 11, for 

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//actividad 10, ciclo while
Console.WriteLine("Hello, World!");
int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int platzicoins = 0;
string message = "";
string ControlOtraCarta = "";
string switchControl = "menu";
System.Random random = new System.Random();
//Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer
while (true) {

    Console.WriteLine("Welcome al platzino");
    Console.WriteLine("¿Cuantos platzicoins deseas? \n Ingresa un numero entero \n Recuerda que necesitas una por juego");
    platzicoins = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < platzicoins; i++)
    {
    totalJugador = 0;
    totalDealer = 0;
    num = 0;
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("Escriba ‘21’ para jugar al 21");
            switchControl = Console.ReadLine();
            break;
        case "21":
            do
            {
                System.Random raandom = new System.Random();
                num = raandom.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine("Toma tu carta, jugador,");
                Console.WriteLine($"Te salió el número: {num} ");
                Console.WriteLine("¿Deseas otra carta ?");
                ControlOtraCarta = Console.ReadLine();
            } while (ControlOtraCarta == "Si" || ControlOtraCarta == "si" || ControlOtraCarta == "yes");
            totalDealer = random.Next(16, 22);
            Console.WriteLine($"El dealer tiene un total de: {totalDealer}");
            if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "Venciste al dealer, felicidades";
                switchControl = "menu";
            }
            else if (totalJugador >= 22)
            {
                message = "Perdiste vs el dealer, te pasaste de 21";
                switchControl = "menu";
            }
            else if (totalJugador <= totalDealer)
            {
                message = "Perdiste vs el dealer, lo siento";
                switchControl = "menu";
            }
            else
            {
                message = "condición no válida";
            }
            Console.WriteLine(message);
            break;
        default:
            Console.WriteLine("Valor ingresa no válido en el  C A S I N O");
            break;
    }        
    }

}