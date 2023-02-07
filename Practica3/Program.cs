using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escriba un programa de aplicación que solicite al usuario que ingrese un número de mes (1 a 12) e imprima el nombre del mes
            // correspondiente. Si el valor ingresado no está en ese rango debe imprimir "Mes inválido". Utilice la sentencia switch.

            Console.WriteLine("Ingrese un número de mes (1 a 12): ");
            int numMes = int.Parse(Console.ReadLine());

            switch (numMes)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Mes inválido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
