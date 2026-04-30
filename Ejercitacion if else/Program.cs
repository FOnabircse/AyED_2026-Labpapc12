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
            int combustible;
            int combustiblenecesario;
            int distancia;
            int diferencia;

            Console.Write("Ingrese el combustible actual disponible: ");
            combustible = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la distancia al destino en años luz: ");
            distancia = Convert.ToInt32(Console.ReadLine());

            combustiblenecesario = distancia * 12;

            diferencia = combustiblenecesario - combustible;

            if (combustible >= combustiblenecesario)
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");
            }

            else
            {
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + diferencia + " litros");
            }
        }
    }
}
