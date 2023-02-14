using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defina una clase Persona con 3 campos: Nombre, edad y DNI. En el constructor use parámetros cuyos nombres coincidan con los campos privados
            // del objeto (usar this). Agregue los métodos correspondientes a cada campo para poder consultar y modificar su contenido.

            Persona p1 = new Persona("Franco", 22, 42680156);

            // Agregue a la clase Persona un método esMayorQue(Persona p) que devuelva verdadero si la persona que recibe el mensaje es más grande que la
            // persona recibida como parámetro.

            Persona p2 = new Persona("Nicolas", 24, 43567987);

            bool resultado = p1.esMayorQue(p2);
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
