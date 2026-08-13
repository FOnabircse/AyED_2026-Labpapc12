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
            int aprobados = 0;
            int desaprobados = 0;
            double[] notas = new double[10];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            foreach (double nota in notas)
            {
                suma += nota;

                if (nota >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }
            double promedio = suma / notas.Length;
            Console.WriteLine("Aprobados: " + aprobados + ".");
            Console.WriteLine("Desaprobados: " + desaprobados + ".");
            Console.WriteLine("Promedio de notas: " + promedio + ".");

        }
    }
}