using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarRegresivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador = 0;

            Console.Write("Ingrese un numero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("ERROR");
                Console.Write("Ingrese un numero positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            else
            {
                while (contador < numero)
                {
                    contador++;
                    Console.WriteLine(contador);
                }
            }
        }
    }
}
