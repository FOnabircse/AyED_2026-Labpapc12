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
            Console.Write("Ingrese un numero entero positivo: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero entero positivo: ");
            int num2 = int.Parse(Console.ReadLine());
            int CantNumero = num2 - num1;
            int[] primos = new int[CantNumero];
            int cantidad = 0;

            for (int i = num1; i <= num2; i++)
            {
                int contador = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    primos[cantidad] = i;
                    cantidad++;
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(primos[i]);
            }
        }
    }
}