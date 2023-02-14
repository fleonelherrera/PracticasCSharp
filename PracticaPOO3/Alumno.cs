using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO3
{
    internal class Alumno
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Genero { get; set; }
        public string diaCursada { get; set; }
        public int horaCursada { get; set; }
        public string materiaCursada { get; set; }

        public Alumno(string nombre, int dni, string genero)
        {
            this.Nombre = nombre;
            this.DNI = dni;
            this.Genero = genero;
        }

        public string inscripcionACursada(string dia, int hora, string materia)
        {
            diaCursada = dia;
            horaCursada = hora;
            materiaCursada = materia;
            string mensaje = "Inscripción a la materia realizada";
            return mensaje;
        }
    }
}
