// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text;
using System.Text.RegularExpressions;

// 1) Leer cuento.txt
if (!File.Exists("cuento.txt"))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("No se encontró 'cuento.txt' en el directorio actual.");
    Console.ResetColor();
    Console.WriteLine("Coloca el archivo junto al ejecutable o márcalo como 'Copy to Output Directory'.");
    return;
}

// ===== RETO 1: string.Concat() =====
{
    string parte1 = "Bitín";
    string parte2 = "Explorador";
    string salida = string.Concat(parte1, " ", parte2);
    Console.WriteLine("nos muestra utilizando el concat, lo siguiente: "+ salida);
}
