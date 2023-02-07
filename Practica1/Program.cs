using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que solicite al usuario ingresar su nombre y apellido, e imprima por consola un saludo personalizado
            // usando ese nombre e informe entre () la cantidad de letras que conforman la oración impresa. Ejemplo:
            // Hola Juan Perez, bienvenido a la materia (40)

            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            string saludo = "Hola " + nombre + " " + apellido + ", bienvenido a la materia";

            int cantCaracteres = saludo.Length;

            Console.WriteLine(saludo + " (" + cantCaracteres + ")");

            Console.ReadKey();
        }
    }
}
