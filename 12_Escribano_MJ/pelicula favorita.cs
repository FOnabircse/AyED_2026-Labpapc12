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
            string nombre;
            string pelicula;
            Console.WriteLine("Hola usuario");
            Console.Write("¿Cual es tu nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu pelicula favorita?: ");
            pelicula = Console.ReadLine();

            Console.WriteLine("Hola amigo " + nombre + " con el respeto que se merece " + pelicula + " es una mierda");
        }
    }
}
