using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO3
{
    internal class Profesor
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Genero { get; set; }
        public List<string> Materias { get; set; }

        public Profesor(string nombre, int dni, string genero)
        {
            this.Nombre = nombre;
            this.DNI = dni;
            this.Genero = genero;
        }
        public string dictadoDeCurso(string materia)
        {
            List<string> Materias = new List<string>();
            Materias.Add(materia);
            string msj = "La materia se agregó a la lista de materias del profesor";
            return msj;
        }
    }
}
