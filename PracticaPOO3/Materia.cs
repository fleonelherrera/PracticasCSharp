using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO3
{
    internal class Materia
    {
        public Profesor Profesor { get; set; }
        public List<Alumno> ListaAlumnos { get; set; }

        public Materia(Profesor profesor, List<Alumno> listaAlumnos)
        {
            this.Profesor = profesor;
            this.ListaAlumnos = listaAlumnos;
        }

        // Creo un constructor que solo reciba como parámetro una lista de alumnos para el ejercicio 4

        public Materia(List<Alumno> listaAlumnos)
        {
            this.ListaAlumnos = ListaAlumnos;
        }

        // Creo otro constructor que solo reciba un profesor para asignarlo en el ejercicio 4

        public Materia(Profesor profesor)
        {
            this.Profesor = profesor;
        }
    }
}
