// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//video 4

Apuntador apuntadorPlatzi = new Apuntador();
Apuntador apuntadorPlatzi2 = new Apuntador();

apuntadorPlatzi.color = "Negro";
Console.WriteLine(apuntadorPlatzi.color);
apuntadorPlatzi2.color = "Azul";
Console.WriteLine(apuntadorPlatzi2.color);

class Apuntador {
    public string color;
    public double largo;
    public short NumeroDeBotones;
    public bool Stikcers;
}
