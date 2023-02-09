using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Codifique la clase Hora de tal forma que al ejecutar el siguiente programa de aplicación(Main):

            // Hora h = new Hora(23,30,15);
            // h.imprimir();

            // Se imprima por consola: 23 HORAS, 30 MINUTOS Y 15 SEGUNDOS

            Hora h = new Hora(23, 30, 15);
            Console.WriteLine(h.Imprimir());

            // 2) Agregue un segundo constructor a la clase Hora para que pueda recibir la hora en un solo parámetro de clase string. Así el siguiente código:

            // Hora h1 = new Hora(23, 30, 15);
            // Hora h2 = new Hora("14:25:47");
            // h1.imprimir();
            // h2.imprimir();

            // produce la siguiente salida: 
            // 23 HORAS, 30 MINUTOS Y 15 SEGUNDOS
            // 14 HORAS, 25 MINUTOS Y 47 SEGUNDOS

            Hora h2 = new Hora("14:25:47");
            Console.WriteLine(h2.Imprimir());



            Console.ReadKey();
        }
    }
}
