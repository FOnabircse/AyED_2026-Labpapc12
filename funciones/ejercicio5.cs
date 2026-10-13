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
            codigo();
        }

        static void codigo()
        {
            Console.Write("Ingrese un número de dos digitos: ");
            string numero = Console.ReadLine();

            char[] caracteres = numero.ToCharArray();
            Array.Reverse(caracteres);
            string numeroinvertido = new string(caracteres);

            Console.WriteLine("Cantidad de dígitos: " + numero.Length);

            if (numero == numeroinvertido)
            {
                Console.WriteLine("El número " + numero + " es capicúa");
            }
            else
            {
                Console.WriteLine("El número " + numero + " no es capicúa");
            }
        }
    }
}