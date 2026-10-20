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
            pipo();
        }

        static void pipo()
        {
            Console.Write("Ingrese un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            int cantidad = 0;

            while (numero <= 0)
            {
                Console.WriteLine("El numero no es positivo");
                Console.Write("Ingrese un numero entero positivo: ");
                numero = int.Parse(Console.ReadLine());
            }

            for (int inicio = 1; inicio < numero; inicio++)
            {
                int suma = 0;
                int fin = inicio;

                while (suma < numero)
                {
                    suma = suma + fin;
                    fin++;
                }

                if (suma == numero)
                {
                    cantidad++;

                    Console.Write(cantidad + ") ");

                    for (int k = inicio; k < fin; k++)
                    {
                        Console.Write(k);

                        if (k < fin - 1)
                        {
                            Console.Write(" + ");
                        }
                    }

                    Console.WriteLine(" = " + numero);
                }
            }

            if (cantidad == 0)
            {
                Console.WriteLine("No hay números consecutivos que lo representen.");
            }
        }
    }
}