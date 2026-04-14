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
            Double midiclorianos;

            Console.Write("Ingrese el nivel de midicloriano ");
            midiclorianos = Convert.ToDouble(Console.ReadLine());

            if (midiclorianos > 15000)
            {
                Console.WriteLine("Potencial Maestro Jedi detectado. Avisar al Consejo. ");
            }
            else if (midiclorianos < 15000 & midiclorianos > 5000)
            {
                Console.WriteLine("Aceptable para entrenamiento Padawan");
            }
            if (midiclorianos < 5000)
            {
                Console.WriteLine("No posee sensibilidad a la Fuerza");
            }
        }
    }
}
