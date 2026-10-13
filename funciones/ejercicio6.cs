using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            codigo();
        }
        static void codigo()
        {
            Console.Write("Ingrese números: ");
            int cantidad = int.Parse(Console.ReadLine());

            double[] numero = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numero[i] = double.Parse(Console.ReadLine());
            }
            double mayor;
            double segundomayor;
            if (numero[0] > numero[1])
            {
                mayor = numero[0];
                segundomayor = numero[1];
            }
            else
            {
                mayor = numero[1];
                segundomayor = numero[0];
            }

            for (int i = 2; i < cantidad; i++)
            {
                if (numero[i] > mayor)
                {
                    segundomayor = mayor;
                    mayor = numero[i];
                }
                else if (numero[i] > segundomayor && numero[i] < mayor)
                {
                    segundomayor = numero[i];
                }
            }
            Console.WriteLine("El segundo más grande es: " + segundomayor);
        }
    }
}