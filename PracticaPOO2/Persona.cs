using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO2
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int DNI { get; set; }

        public Persona(string nombre, int edad, int dni)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.DNI = dni;
        }

        public bool esMayorQue(Persona p)
        {
            if (Edad > p.Edad)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
