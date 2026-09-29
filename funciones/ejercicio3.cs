using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            jose();
        }
        static void jose()
        {
            Console.Write("Ingrese el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int inicio;
            int fin;
            if (numero1 < numero2)
            {
                inicio = numero1;
                fin = numero2;
            }
            else
            {
                inicio = numero2;
                fin = numero1;
            }

            int acumulador = 0;
            int par = 0;
            int impar = 0;

            Console.WriteLine("Numeros entre " + inicio + " y " + fin + ":");

            for (int i = inicio; i <= fin; i++)
            {
                Console.WriteLine(i + "");
                acumulador += i;

                if (i % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }

            Console.WriteLine("Suma total: " + acumulador);
            Console.WriteLine("numeros par: " + par);
            Console.WriteLine("numeros impar: " + impar);
        }
    }
}