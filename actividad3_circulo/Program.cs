// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Bienvenido, calculemos círculos!");

var radio = 0d; //declaracion de variable
var resultado = 0d;

const double Pi =  3.14;

Console.WriteLine("Ingrese el valor del radio: ");//entrada de datos
radio = Convert.ToDouble(Console.ReadLine());

resultado = Pi * radio * radio;//operacion

Console.WriteLine("El área del círculo es: " + resultado);//salida de datos

