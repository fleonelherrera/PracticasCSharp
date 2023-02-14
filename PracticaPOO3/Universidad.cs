using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO3
{
    internal class Universidad
    {
        public List<Materia> listaMaterias { get; set; }

        public string inscribirAlumnos(List<Alumno> listAlumnos)
        {
            Materia matematica = new Materia(listAlumnos);
            listaMaterias.Add(matematica);
            string msj = "Se inscribió a los alumnos en la materia";
            return msj;
        }

        public string asignarProfesor(Profesor p1, Materia m1)
        {
            m1 = new Materia(p1);
            string msj = "profesor asignado a la materia";
            return msj;
        }
        public void ListarProfeYAlumnos(Materia m1)
        {
            Console.WriteLine(m1.Profesor);
            Console.WriteLine(m1.ListaAlumnos);
        }
    }
}
