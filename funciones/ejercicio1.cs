using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            jose();
        }
        static void jose()
        {
            double acumulador = 0;
            int par = 0;
            int impar = 0;

            Console.Write("Ingrese números enteros: ");
            int cantidad = int.Parse(Console.ReadLine());

            double[] numeros = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = double.Parse(Console.ReadLine());
                acumulador += numeros[i];
                if (numeros[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            double menor = numeros[0];
            double mayor = numeros[0];
            foreach (double a in numeros)
            {
                if (a < menor)
                {
                    menor = a;
                }

                if (a > mayor)
                {
                    mayor = a;
                }
            }

            double promedio = acumulador / cantidad;

            Console.WriteLine("Número mayor: " + mayor);
            Console.WriteLine("Número menor: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Cantidad de pares: " + par);
            Console.WriteLine("Cantidad de impares: " + impar);
        }
    }
}