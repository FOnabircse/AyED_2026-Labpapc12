using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            jose();
        }
        static void jose()
        {
            double acumulador1 = 0;
            double acumulador2 = 0;
            int negativos = 0;
            int positivos = 0;
            int ceros = 0;


            Console.Write("Ingrese la cantidad deseada de números: ");
            int cantidad = int.Parse(Console.ReadLine());

            double[] numeros = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = double.Parse(Console.ReadLine());
                if (numeros[i] < 0)
                {
                    acumulador2 += numeros[i];
                    negativos++;
                }
                else if (numeros[i] > 0)
                {
                    acumulador1 += numeros[i];
                    positivos++;
                }
                else if (numeros[i] == 0)
                {
                    ceros++;
                }
            }
            double promedio1 = acumulador1 / positivos;
            double promedio2 = acumulador2 / negativos;

            Console.WriteLine("Promedio de negativos: " + promedio2);
            Console.WriteLine("Promedio de positivos: " + promedio1);
            Console.WriteLine("Cantidad de positivos: " + positivos);
            Console.WriteLine("Cantidad de negativos: " + negativos);
            Console.WriteLine("Cantidad de ceros: " + ceros);
        }
    }
}