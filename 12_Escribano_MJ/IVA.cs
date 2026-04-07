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
            int minutos;
            int horas;
            int minutosrestantes;
            int precioph;
            int preciopm;
            int preciototal;
            int montofinal;
            int iva;

            Console.Write("Ingrese cuantos minutos estuvo en el estacionamiento ");
            minutos = Convert.ToInt32(Console.ReadLine());

            horas = minutos / 60;
            minutosrestantes = minutos % 60;

            precioph = horas * 6000;
            preciopm = minutosrestantes * 50;

            preciototal = precioph + preciopm;

            iva = preciototal * 21/100;

            montofinal = preciototal + iva;

            Console.WriteLine("Si el auto estuvo estacionado "+ horas +" horas y "+ minutosrestantes +" minutos, sumandole el IVA el monto final es de "+ montofinal);

        }
    }
}
