using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario realizar las cuatro operaciones
            // elementales e imprimir el resultado de la operación. Para ello el programa debe mostrar un menú de opciones con cada una de las operaciones, luego
            // de seleccionar la operación el programa pide ingresar dos números, realiza la operación solicitada e imprime el resultado. Cada operación se resuelve
            // con una función. El usuario debe poder realizar tantas operaciones como desee hasta seleccionar una opción de salida.

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("Ingrese el número correspondiente a la operación que desea realizar o 5 si quiere salir: ");
            int opcion = int.Parse(Console.ReadLine());

            while (opcion != 5)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + Sumar());
                        break;
                    case 2:
                        Console.WriteLine("Resultado: " + Restar());
                        break;
                    case 3:
                        Console.WriteLine("Resultado: " + Multiplicar());
                        break;
                    case 4:
                        Console.WriteLine("Resultado: " + Dividir());
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine("Ingrese el número correspondiente a la operación que desea realizar o 5 si quiere salir: ");
                opcion = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();

        }
        static double Sumar()
        {
            Console.WriteLine("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = num1 + num2;

            return resultado;
        }
        static double Restar()
        {
            Console.WriteLine("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = num1 - num2;

            return resultado;
        }
        static double Multiplicar()
        {
            Console.WriteLine("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = num1 * num2;

            return resultado;
        }
        static double Dividir()
        {
            Console.WriteLine("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = num1 / num2;

            return resultado;
        }
    }
}
