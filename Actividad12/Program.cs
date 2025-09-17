// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//actividad 12, ciclo for
//Console.WriteLine("Hello, World!");
int totalJugador; //suma de las cartas del jugador
int totalDealer; //suma de las cartas del dealer
int num; //numero aleatorio de la carta
int platzicoins = 0; //moneda del casino
string message = ""; //mensaje final
string ControlOtraCarta = ""; //control para pedir otra carta
string switchControl = "menu"; //control del switch
System.Random random = new System.Random(); //objeto random
Boolean jugar = true; //control para seguir jugando

//Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
//cartas o en caso de tener menos
//de 21 igual tener mayor puntuación que el dealer
while (jugar) { //ciclo para seguir jugando
    //Inicio del juego
    Console.WriteLine("Welcome al platzino");
    Console.WriteLine("¿Cuantos platzicoins deseas? \n Ingresa un numero entero \n Recuerda que necesitas una por juego");
    platzicoins = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < platzicoins; i++) { //ciclo por cada platzicoin
        //inicialización de variables
        totalJugador = 0;
        totalDealer = 0;
        num = 0;
        switch (switchControl) { //inicio del switch
            case "menu": //menú principal
                Console.WriteLine("Escriba ‘21’ para jugar al 21");
                switchControl = Console.ReadLine();
                i = i - 1; //resta uno para no gastar platzicoin en el menú
                break;
            case "21":
                do //ciclo para pedir cartas 
                {
                    System.Random raandom = new System.Random(); //objeto random
                    num = raandom.Next(1, 12); //número aleatorio entre 1 y 11
                    totalJugador = totalJugador + num; //suma del total del jugador
                    Console.WriteLine("Toma tu carta, jugador,");
                    Console.WriteLine($"Te salió el número: {num} "); //muestra el número random
                    Console.WriteLine("Tu carta actual es de: "+totalJugador); //muestra el total actual
                    Console.WriteLine("¿Deseas otra carta ?");
                    ControlOtraCarta = Console.ReadLine(); //lee la respuesta
                } while (ControlOtraCarta == "Si" || ControlOtraCarta == "si" || ControlOtraCarta == "yes");
                Console.WriteLine($"Tu total es de: {totalJugador}"); //muestra el total final
                totalDealer = random.Next(16, 22);  //número aleatorio entre 16 y 21 para el dealer
                Console.WriteLine($"El dealer tiene un total de: {totalDealer}"); //muestra el total del dealer
                if (totalJugador > totalDealer && totalJugador < 22)
                { //condición para ganar
                    message = "Venciste al dealer, felicidades";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                { //condición para pasarse de 21
                    message = "Perdiste vs el dealer, te pasaste de 21";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                { //condición para perder
                    message = "Perdiste vs el dealer, lo siento";
                    switchControl = "menu";
                }
                else if (totalJugador == totalDealer)
                { //condición para empate
                    message = "Empataste con el dealer";
                    switchControl = "menu";
                }
                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Valor ingresa no válido en el  C A S I N O");
                i--; //resta uno para no gastar platzicoin en el menú
                break;
        }
    }
    Console.WriteLine("¿Deseas seguir jugando? Si/No"); 
    string seguirJugando = Console.ReadLine();
    //control para seguir jugando o no
    if ( seguirJugando == "si" || seguirJugando == "Si" || seguirJugando == "yes")
    {
        jugar = true; //devuelve true para el ciclo while
    } else
    {
        jugar = false; //cambia a false para salir del ciclo while y terminar el programa
    }

}