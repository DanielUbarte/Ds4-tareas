// See https://aka.ms/new-console-template for more information
//aquí serán los cambios del segundo programa
//segundo programa 
//area de un rectangulo con variable var
//declaracion de variables
var ladoA = 0d;
var ladoB = 0d;
var resultados = 0d;

//entrada de datos
Console.WriteLine("Calcula el area de un rectangulo!!");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());


ladoA++; //incrementa en 1
ladoA--; //decrementa en 1

resultados = ladoA * ladoB;

//resultados = ladoA + ladoB; //suma
//resultados = ladoA - ladoB; //resta
//resultados = ladoA / ladoB; //division
//resultados = ladoA * ladoB; //multiplicacion
//resultados = ladoA % ladoB; //restante
//resultados = (ladoA * ladoB) / 2; triangulo rectangulo
//salida de datos
Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + resultados);
