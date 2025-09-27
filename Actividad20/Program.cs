
using Actividad19_poo.Models;           // Importa las clases definidas en tu proyecto (SuperPoder, SuperHero, etc.)
//Video 12
//Encapsulamiento en Programación Orientada a Objetos

try
{
    // === Creación de poderes ===
    var poderVolar = new SuperPoder();      // Se instancia un poder
    poderVolar.Nombre = "Super Volar";      // Nombre del poder
    poderVolar.decripcion = "Capacidad para volar y planear en el aire"; // Descripción del poder
    poderVolar.Nivel = NivelPoder.niveldos; // Se asigna el nivel del poder (según enum)

    // Segundo poder
    var poderFuerza = new SuperPoder();
    poderFuerza.Nombre = "Super Fuerza";
    poderFuerza.decripcion = "Capacidad para levantar objetos extremadamente pesados";
    poderFuerza.Nivel = NivelPoder.niveltres;

    //comparar ambos niveles de poder y mostrará cual es mas fuerte
    String Result = (poderVolar.Nivel < poderFuerza.Nivel) ? $"{poderFuerza.Nombre} es un poder mas fuerte que {poderVolar.Nombre}" :
        $"{poderVolar.Nombre} es un poder mas fuerte que {poderFuerza.Nombre}";

    // === Creación de un superhéroe ===
    var superman = new SuperHero();
    superman.ID = 1;                        // Identificador
    superman.Nombre = "Superman";           // Nombre público
    superman.IdentidadSecreta = "Clark Kent"; // Identidad secreta
    superman.Ciudad = "Metropolis";         // Ciudad de origen
    superman.PuedeVolar = true;             // Indica que puede volar

    // === Asignación de poderes a Superman ===
    List<SuperPoder> poderesSuperman = new List<SuperPoder>();
    poderesSuperman.Add(poderVolar);        // Se agrega el poder de volar
    poderesSuperman.Add(poderFuerza);       // Se agrega el poder de fuerza
    superman.SuperPoderes = poderesSuperman; // Se asigna la lista de poderes al héroe

    Console.WriteLine(); // Línea en blanco para separar secciones en la consola
    Console.WriteLine("Listado de poderes de Superman:");
    // Superman usa sus poderes
    string resultSuperPoderes = superman.UsarSuperPoderes();
    Console.WriteLine(resultSuperPoderes);  // Se muestra el resultado en consola
}
catch (Exception ex)
{
    Console.WriteLine($"Se ha producido un error: {ex.Message}");
}

// === Enumeración de niveles de poder ===
enum NivelPoder
{
    niveluno,   // Nivel 1
    niveldos,   // Nivel 2
    niveltres   // Nivel 3
}

// === Record de superhéroe ===
// Define un tipo inmutable por valor, que permite comparaciones por contenido
public record superHeroRecord(int ID, string Nombre, string Identidad);