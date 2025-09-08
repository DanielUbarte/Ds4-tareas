// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Este ejemplo es de git");

//Actividad 1
//programa que calcula el area de un rectangulo
double ladoA;
double ladoB;
double resultado;

Console.WriteLine("Calcula el area de un rectangulo!!");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());


resultado = ladoA * ladoB;

Console.WriteLine("El lado A es: " + ladoA + " El lado B es: " + ladoB + " El resultado es: " + resultado);
