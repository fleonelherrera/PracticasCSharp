using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Implemente la clase Alumno para modelar alumnos en una Universidad. Agregue como estado lo que considere necesario para el problema.
            // Piense como implementaría los horarios de cursada de un alumno? (piense que debe guardar día, hora y materia a cursar en ese horario.
            // Como comportamiento implemente el método inscripcionACursada(string dia, string horam string materia)

            Alumno a1 = new Alumno("Franco", 42689235, "Hombre");

            a1.inscripcionACursada("lunes", 19, "introducción a la programación");

            Console.WriteLine(a1.Nombre);
            Console.WriteLine(a1.DNI);
            Console.WriteLine(a1.Genero);
            Console.WriteLine(a1.diaCursada);
            Console.WriteLine(a1.horaCursada);
            Console.WriteLine(a1.materiaCursada);


            // 2) Implemente la clase Profesor para modelar profesores en una Universidad. Agréguele como estado lo que considere necesario para el
            // problema. Considere que un profesor conoce la lista de materias que dicta. Como comportamiento implemente el método dictadoDeCurso
            // (string materia)

            Profesor p1 = new Profesor("Roberto", 10876345, "Hombre");

            Console.WriteLine(p1.dictadoDeCurso("Matematica"));

            // 3) Implemente la clase Materia que permita asociarle el profesor y la lista de los alumnos inscriptos en ella.


            // NOTA: creo un alumno para agregar a la lista que le voy a pasar a la materia.

            Alumno a2 = new Alumno("Martin", 43768976, "Hombre");
            List<Alumno> listaAlumnos = new List<Alumno>();
            listaAlumnos.Add(a1);
            listaAlumnos.Add(a2);

            Materia Matematica = new Materia(p1, listaAlumnos);


            // Veo el profesor de la materia
            Console.WriteLine(Matematica.Profesor.Nombre);

            // Veo el nombre de los alumnos de la materia
            foreach (var item in Matematica.ListaAlumnos)
            {
                Console.WriteLine(item.Nombre);
            }

            // 4) Usando las clases definidas en los ejercicios anteriores implemente la clase Universidad que permita:
            // a) La inscripción de alumnos a materias
            // b) La asignación de profesores a las materias
            // c) Listar el profesor y los alumnos de una determinada materia


            Console.ReadKey();
        }
    }
}
