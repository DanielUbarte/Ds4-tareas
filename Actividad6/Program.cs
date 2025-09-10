// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Ricardo Pérez ID!");
int altura = 168;
int edad = 89;
string nombre = "Ricardo Pérez";
string informacion = "nació en Hidalgo, es estudiante de gastronomía y astronomía";
var hobbie = "deportista";

string tarjetaDeIdentificacion = $"La información de {nombre} es la siguiente \n" +
    $"Su edad es {edad}\n" +
    $"su altura es de {altura} cms\n Información relevante {informacion}\n además, su hobbie es de: {hobbie}";

Console.WriteLine(tarjetaDeIdentificacion);

string result = "La información de " + nombre + " es la siguiente \n" + informacion + " tiene " +
    edad + " años, mide " + altura + "cms, su hobbie favorito es" +hobbie;

Console.WriteLine(result);
