using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una temperatura C°: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * (9.0 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine("Temperatura en celsius: " + celsius);
            Console.WriteLine($"Temperatura en fahrenheit: {fahrenheit:F2}");
            Console.WriteLine($"Temperatura en kelvin: {kelvin:F2}");
        }
    }
}
