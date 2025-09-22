// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.decripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.niveldos;

var poderFuerza = new SuperPoder();
poderVolar.Nombre = "Super Fuerza";
poderVolar.decripcion = "Capacidad para levantar objetos extremadamente pesados";
poderVolar.Nivel = NivelPoder.niveltres;

var superman = new SuperHero();

superman.ID = 1;
superman.Name = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(poderFuerza);

superman.SuperPoderes = poderesSuperman;

Console.WriteLine($"SuperHeroe: {superman.Name}, Identidad: {superman.IdentidadSecreta}, Ciudad: {superman.Ciudad}, Puede Volar: {superman.PuedeVolar}");
Console.WriteLine("SuperPoderes:");

class SuperHero
{
    public int ID;
    public string Name;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

}

class SuperPoder {
    public string Nombre;
    public string decripcion;
    public NivelPoder Nivel;
}

enum NivelPoder {
    niveluno,
    niveldos,
    niveltres
}