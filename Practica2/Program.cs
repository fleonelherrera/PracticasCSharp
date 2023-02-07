using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escriba un programa que calcule la suma de dos números reales introducidos por teclado y muestre el resultado en consola.
            // Ayuda: utilice Double.Parse(st) para obtener el valor real del string st.

            Console.WriteLine("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = num1 + num2;

            Console.WriteLine("El resultado de la suma es: " + resultado);

            Console.ReadKey();
        }
    }
}
