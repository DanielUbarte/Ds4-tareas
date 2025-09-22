// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Super Volar";
poderVolar.decripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.niveldos;

var poderFuerza = new SuperPoder();
poderVolar.Nombre = "Super Fuerza";
poderVolar.decripcion = "Capacidad para levantar objetos extremadamente pesados";
poderVolar.Nivel = NivelPoder.niveltres;

var superman = new SuperHero();

superman.ID = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

var superman2 = new SuperHero();

superman.ID = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

Console.WriteLine(superman == superman2);

superHeroRecord superheroRecord = new superHeroRecord(1, "Superman", "Clark Kent");
superHeroRecord superheroRecord2 = new superHeroRecord(1, "Superman", "Clark Kent");

Console.WriteLine(superheroRecord == superheroRecord2);

/*List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(poderFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);*/

class SuperHero
{
    public int ID;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

    public SuperHero()
    {
        ID = 1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    }
    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in SuperPoderes)
        {
            sb.AppendLine($"{Nombre} esta usando el super poder {item.Nombre}!!");
        }
        return sb.ToString();
    }
}

class SuperPoder
{
    public string Nombre;
    public string decripcion;
    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.niveluno;
    }
}

enum NivelPoder
{
    niveluno,
    niveldos,
    niveltres
}

public record superHeroRecord(int ID, string Nombre, string Identidad);