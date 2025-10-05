// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); 
//video 5
using System.Linq; // Necesario para usar LINQ

var frutas = new string[] {"Sandía" , "Fresa" , "Mango" , "Mango de azucar"
, "Mango Tomy" }; // Arreglo de frutas

var Mangolist = frutas.Where(p => p.StartsWith("Mango")).ToList(); // Filtra las frutas que empiezan con "Mango" y las convierte en una lista
Mangolist.ForEach(p => Console.WriteLine(p));// Imprime cada fruta en la lista

