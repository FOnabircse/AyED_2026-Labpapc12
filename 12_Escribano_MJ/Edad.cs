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
            int adn;
            int edad;
            Console.Write("¿Cual es tu año de nacimiento?: ");
            adn = Convert.ToInt32(Console.ReadLine());

            edad = (2026 - adn);

            Console.WriteLine("Si naciste en el año " + adn + " tu edad al comenzar el año es de " + edad);
        }
    }
}
