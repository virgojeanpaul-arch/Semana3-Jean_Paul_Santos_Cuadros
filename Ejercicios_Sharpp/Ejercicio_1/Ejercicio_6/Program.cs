using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de habitaciones: ");
            int habitaciones = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de baños: ");
            int baños = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de patios: ");
            int patios = int.Parse(Console.ReadLine());

            int total = (habitaciones * 30) + (baños * 10) + (patios * 15);

            Console.WriteLine("Total a pagar: " + total);
        }
    }
}
