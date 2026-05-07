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
            double acumulador = 0;
            double temperatura;
            double contador = 0;
            for (int dia = 1; dia <= 7; dia++)
            {
                Console.Write("Ingrese la temperatura del dia " + dia +": ");
                temperatura = double.Parse(Console.ReadLine());
                acumulador = temperatura + acumulador;

                if (temperatura < 0)
                {
                    contador ++;
                }
                if (dia == 7)
                {
                    Console.WriteLine("Hubieron " + contador +" dias abajo de 0° y la suma de la temperatura de todos los dias fue "+ acumulador +".");
                }
            } 
        }
    }
}
