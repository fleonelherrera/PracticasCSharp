using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que lea por teclado una secuencia de números y que imprima el valor máximo, el valor mínimo de dicho conjunto y
            //el valor promedio.

            Console.WriteLine("Ingrese cantidad de numeros a ingresar: ");
            double cantNum = double.Parse(Console.ReadLine());

            double maximo = 0;
            double minimo = 9999999;
            double sumaNumeros = 0;

            for (int i = 0; i < cantNum; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                double numActual = double.Parse(Console.ReadLine());

                if (numActual > maximo)
                {
                    maximo = numActual;
                }
                if (numActual < minimo)
                {
                    minimo = numActual;
                }
                sumaNumeros += numActual;
            }

            Console.WriteLine("El número maximo es: " + maximo);
            Console.WriteLine("El número mínimo es: " + minimo);
            Console.WriteLine("El valor promedio es: " + sumaNumeros / cantNum);


            // Escriba un programa que imprima en la consola todos los números pares que además sean múltiplos de 5 y esten comprendidos entre 250 y 900

            for (int i = 250; i <= 900; i++)
            {
                int esPar = i % 2;
                int esMultiplo = i % 5;
                if (esPar == 0 & esMultiplo == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Implemente un programa que permita al usuario ingresar números por la consola. A medida que se van ingresando los valores el sistema debe
            // mostrar por la consola la suma acumulada de los mismos. El proceso termina cuando se ingresa un 0. Informar al final la cant total de
            // num ingresados y sumados.

            Console.WriteLine("Ingrese un número: ");
            double numIngresado = double.Parse(Console.ReadLine());

            double suma = 0;
            int cantNumIngresados = 0;
            while (numIngresado != 0)
            {
                suma += numIngresado;
                cantNumIngresados ++;
                Console.WriteLine("Suma total de los números ingresados: " + suma);

                Console.WriteLine("Ingrese un número: ");
                numIngresado = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Cantidad de numeros ingresados: " + cantNumIngresados);
            Console.WriteLine("Valor final de la suma: " + suma);














            Console.ReadKey();
        }
    }
}
