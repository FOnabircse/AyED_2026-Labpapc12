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
            Console.WriteLine("Indique la opción que quiera:");
            Console.WriteLine("Pizza (P)");
            Console.WriteLine("Sandwich (S)");
            Console.WriteLine("Hamburguesa (H)");
            Console.Write("Eliga lo que quiera comer: ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "P": Console.WriteLine("Pizza $12000"); break;
                case "S": Console.WriteLine("Sandwich $7000"); break;
                case "H": Console.WriteLine("Hamburguesa $8000"); break;
                default: Console.WriteLine("Producto no encontrado"); break;
            }

        }
    }
}
