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
            double[] temperaturas = new double[7];
            string[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Ingrese la temperatura mas alta del " + dias[i] + ": ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());

            }
            double maximo = temperaturas[0];
            double minimo = temperaturas[0];
            double suma = 0;
            foreach (double temperatura in temperaturas)
            {
                if (temperatura > maximo) maximo = temperatura;
                if (temperatura < minimo) minimo = temperatura;
                suma += temperatura;
            }

            double promedio = suma / 7;
            Console.WriteLine("Temperatura mas alta: " + maximo + ".");
            Console.WriteLine("Temperatura mas baja: " + minimo + ".");
            Console.WriteLine("Promedio de la semana: " + promedio + ".");
        }
    }
}