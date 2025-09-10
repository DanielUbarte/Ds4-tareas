// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//declaración de variales implícitas
var (valor1, valor2, valor3) = (10, 9, 9);

//salida de estos datos
Console.WriteLine("Los valores son: " + valor1 + ", " + valor2 + ", " + valor3);

//comparaciones con operador igual
bool result = valor1 == valor2;
Console.WriteLine("El resultado de la comparación de valor1 == valor2 es: " + result);

//comparación con operador diferente
result = valor1 != valor3;
Console.WriteLine("El resultado de la comparación de valor1 != valor2 es: " + result);

//comparaciones con operador mayor que
result = valor2 > valor3;
Console.WriteLine("El resultado de la comparación de valor2 > valor3 es: " + result);

//comparaciones con operador menor que
result = valor2 < valor3;
Console.WriteLine("El resultado de la comparación de valor2 < valor3 es: " + result);

//comparaciones con operador mayor o igual que
result = valor1 >= valor2;
Console.WriteLine("El resultado de la comparación de valor1 >= valor2 es: " + result);

//comparaciones con operador menor o igual que
result = valor3 <= valor1;
Console.WriteLine("El resultado de la comparación valor3 <= valor1 es: " + result);

