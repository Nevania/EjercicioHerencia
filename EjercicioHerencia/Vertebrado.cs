using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Vertebrado : Animal
    {
        public string tipo { get; set; }
        public bool tienePatas { get; set; }
        public bool esDomestico { get; set; }
        public bool esHerbivoro { get; set; }
        public bool esCarnivoro { get; set; }

        public Vertebrado(string nombre, string color, int tamano, string familia, string tipo, bool tienePatas, bool esDomestico, bool esHerbivoro, bool esCarnivoro)
            : base(nombre, color, tamano, familia)
        {
            this.tipo = tipo;
            this.tienePatas = tienePatas;
            this.esDomestico = esDomestico;
            this.esHerbivoro = esHerbivoro;
            this.esCarnivoro = esCarnivoro;
        }

        public void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Tamaño: " + tamano);
            Console.WriteLine("Familia: " + familia);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene Patas: " + tienePatas);
            Console.WriteLine("Es Doméstico: " + esDomestico);
            Console.WriteLine("Es Herbívoro: " + esHerbivoro);
            Console.WriteLine("Es Carnívoro: " + esCarnivoro);
        }
    }
}

