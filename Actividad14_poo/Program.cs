// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var superman = new SuperHero();

superman.ID = 1;
superman.Name = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.SuperPoderes = new [] { "Super Fuerza", "Vuelo", "Visión de Rayos X" };
superman.PuedeVolar = true;

class SuperHero {
    public int ID;
    public string Name;
    public string IdentidadSecreta;
    public string Ciudad;
    public string[] SuperPoderes;
    public bool PuedeVolar;

}