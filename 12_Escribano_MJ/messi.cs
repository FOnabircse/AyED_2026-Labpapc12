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
        Double num1;
        Double num2;
        Double Suma;
        Double Resta;
        Double Multiplicacion;
        Double Division;

        Console.Write("Elegí un número ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Elegí otro número ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Suma = num1 + num2;
        Resta = num1 - num2;
        Multiplicacion = num1 * num2;
        Division = num1 / num2;

        Console.WriteLine("La suma entre "+ num1 +" y "+ num2 +" da "+ Suma +"");
        Console.WriteLine("La resta entre " + num1 + " y " + num2 + " da " + Resta +"");
        Console.WriteLine("La multiplicacion entre " + num1 + " y " + num2 + " da " + Multiplicacion +"");
        Console.WriteLine("La division entre " + num1 + " y " + num2 + " da " + Division +"");
    }
}
}
