using Actividad19_poo.Models;
using Actividad21_poo.model;
using Actividad24_poo;           // Importa las clases definidas en tu proyecto (SuperPoder, SuperHero, etc.)
//Video 18
//interfaces

try
{
    var imprimirInfo = new ImprimirInfo(); // Instancia de la clase para imprimir información

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

    var regeneracion = new SuperPoder();
    regeneracion.Nombre = "regeneracion";
    regeneracion.decripcion = "Capacidad de regenerarte";
    regeneracion.Nivel = NivelPoder.niveldos;

    //comparar ambos niveles de poder y mostrará cual es mas fuerte
    String Result = (poderVolar.Nivel < poderFuerza.Nivel) ? $"{poderFuerza.Nombre} es un poder mas fuerte que {poderVolar.Nombre}" :
        $"{poderVolar.Nombre} es un poder mas fuerte que {poderFuerza.Nombre}";

    // === Creación de un superhéroe ===
    var superman = new SuperHeroe();
    superman.ID = 1;                        // Identificador
    superman.Nombre = "Superman";           // Nombre público
    superman.IdentidadSecreta = "Clark Kent"; // Identidad secreta
    superman.Ciudad = "Metropolis";         // Ciudad de origen
    superman.PuedeVolar = true;             // Indica que puede volar

    imprimirInfo.ImprimirSuperHeroe(superman); // Imprime la información del superhéroe

    // === Asignación de poderes a Superman ===
    List<SuperPoder> poderesSuperman = new List<SuperPoder>();
    poderesSuperman.Add(poderVolar);        // Se agrega el poder de volar
    poderesSuperman.Add(poderFuerza);       // Se agrega el poder de fuerza
    superman.SuperPoderes = poderesSuperman; // Se asigna la lista de poderes al héroe
    string resultSalvarMundo = superman.SalvarElMundo(); // Llamada al método heredado de Heroe
    Console.WriteLine(resultSalvarMundo); // Se muestra el resultado en consola

    string resultSalvarTierra = superman.SalvarLaTierra(); // Llamada al método específico de SuperHeroe
    Console.WriteLine(resultSalvarTierra); // Línea en blanco para separar secciones en la consola

    Console.WriteLine(); // Línea en blanco para separar secciones en la consola

    Console.WriteLine("Listado de poderes de Superman:");
    string resultSuperPoderes = superman.UsarSuperPoderes();// Llamada al método para usar superpoderes
    Console.WriteLine(resultSuperPoderes);  // Se muestra el resultado en consola

    var wolverine = new AntiHeroe();// Se instancia un antihéroe
    wolverine.ID = 5;
    wolverine.Nombre = "Wolverine";
    wolverine.IdentidadSecreta = "Logan";
    wolverine.PuedeVolar = false;

    imprimirInfo.ImprimirSuperHeroe(wolverine);// Imprime la información del antihéroe

    // === Asignación de poderes a Superman ===
    List<SuperPoder> poderesWolverine = new List<SuperPoder>();
    poderesWolverine.Add(regeneracion);        // Se agrega el poder de volar
    poderesWolverine.Add(poderFuerza);       // Se agrega el poder de fuerza
    wolverine.SuperPoderes = poderesWolverine; // Se asigna la lista de poderes al héroe
    String resultWolverine = wolverine.UsarSuperPoderes();
    Console.WriteLine(resultWolverine);  // Se muestra el resultado en consola

    string accionAntiheroe = wolverine.RealizarAccionDeAntiheroe("Ataca la policia ");// Llamada al método específico del antihéroe
    Console.WriteLine(accionAntiheroe);

    string accionheroe = superman.RealizarAccionDeHeroe("Saca personas del he edificio en llama");// Llamada al método específico del antihéroe
    Console.WriteLine(accionheroe);


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

