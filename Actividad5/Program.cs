// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//declaración de variales implícitas
var (valor1, valor2, valor3) = (10, 9, 9);

//salida de estos datos
Console.WriteLine("Los valores son: " + valor1 + ", " + valor2 + ", " + valor3);

bool result = valor1 == valor2;
Console.WriteLine("El resultado de la comparación de valor1 == valor2 es: " + result);

result = valor1 != valor3;
Console.WriteLine("El resultado de la comparación de valor1 != valor2 es: " + result);

result = valor2 > valor3;
Console.WriteLine("El resultado de la comparación de valor2 > valor3 es: " + result);

result = valor2 < valor3;
Console.WriteLine("El resultado de la comparación de valor2 < valor3 es: " + result);

result = valor1 >= valor2;
Console.WriteLine("El resultado de la comparación de valor1 >= valor2 es: " + result);

result = valor3 <= valor1;
Console.WriteLine("El resultado de la comparación valor3 <= valor1 es: " + result);

