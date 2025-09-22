
using System.Text;
using Actividad19_poo.Models;

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

enum NivelPoder
{
    niveluno,
    niveldos,
    niveltres
}

public record superHeroRecord(int ID, string Nombre, string Identidad);