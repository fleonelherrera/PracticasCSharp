using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que lea 2 palabras y determine si son palíndromos entre ellas. (Ej: "abbccd" y "dccbba" son palíndromos)

            Console.WriteLine("Ingrese la primera palabra: ");
            string primerPalabra = Console.ReadLine();

            Console.WriteLine("Ingrese la segunda palabra: ");
            string segundaPalabra = Console.ReadLine();

            if (sonPalindromas(primerPalabra, segundaPalabra))
            {
                Console.WriteLine("Son palindromas");
            }
            else
            {
                Console.WriteLine("No son palindromas");
            }

            Console.ReadKey();
        }
        static bool sonPalindromas(string pal1, string pal2)
        {
            string palabraInvertida = "";

            int cantCarPrimerPalabra = pal1.Length;

            if (cantCarPrimerPalabra == pal2.Length)
            {
                for (int i = pal2.Length - 1; i >= 0; i--)
                {
                    palabraInvertida += pal2[i];
                }
                if (pal1 == palabraInvertida)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
