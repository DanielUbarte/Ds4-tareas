// See https://aka.ms/new-console-template for more information
//aquí serán los cambios del segundo programa
//segundo programa 
//area de un rectangulo con variable var

var ladoA = 1.1;
var ladoB = 1.1;
var resultados = 1.1;


Console.WriteLine("Calcula el area de un rectangulo!!");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());


resultados = ladoA * ladoB;

Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + resultados);
