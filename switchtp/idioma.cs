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
            Console.WriteLine("Eliga el idioma");
            Console.WriteLine("1: Ingles");
            Console.WriteLine("2: Francés");
            Console.WriteLine("3: Alemán");
            Console.Write("Indique la opción que quiera: ");

            String opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": Console.WriteLine("Hello"); break;
                case "2": Console.WriteLine("Salut"); break;
                case "3": Console.WriteLine("Hallo"); break;
                default: Console.WriteLine("Idioma no encontrado"); break;
            }
        }
    }
}
