// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Animal
{
    public string nombre { get; set; }
    public string color { get; set; }
    public int tamano { get; set; }
    public string familia { get; set; }

    public Animal(string nombre, string color, int tamano, string familia)
    {
        this.nombre = nombre;
        this.color = color;
        this.tamano = tamano;
        this.familia = familia;
    }
}