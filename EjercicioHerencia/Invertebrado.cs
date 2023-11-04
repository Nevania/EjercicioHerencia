using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Invertebrado : Animal
    {
        public string tipo { get; set; }
        public bool tienePatas { get; set; }
        public int numeroPatas { get; set; }
        public bool tieneConcha { get; set; }

        public Invertebrado(string nombre, string color, int tamano, string familia, string tipo, bool tienePatas, int numeroPatas, bool tieneConcha):
            base(nombre, color, tamano, familia)
        {
            this.tipo = tipo;
            this.tienePatas = tienePatas;
            this.numeroPatas = numeroPatas;
            this.tieneConcha = tieneConcha;
        }
    }

}

