using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            jose();
        }
        static void jose()
        {
            Console.Write("Ingrese un numero positivo: ");
            int numero = int.Parse(Console.ReadLine());
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma = suma + i;
                }
            }

            if (suma == numero && numero > 0)
            {
                Console.WriteLine("el numero es perfecto.");
            }
            else
            {
                Console.WriteLine("el numero no es perfecto.");
            }
        }
    }
}