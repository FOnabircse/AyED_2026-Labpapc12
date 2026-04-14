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
            Double peso;
            Double diferencia;

            Console.Write("Ingrese su peso ");
            peso = Convert.ToDouble(Console.ReadLine());

            if (peso <= 5000)
            {
                Console.WriteLine("Despegue autorizado.Buen viaje, Mando.");
            }

            else 
            {
                diferencia = (peso - 5000);
                Console.WriteLine("Alerta: Exceso de peso. Debes descargar " + diferencia + " kg para despegar ");
            }
        }
    }
}
