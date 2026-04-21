using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Consumo de kWh: ");
            double kWh = double.Parse(Console.ReadLine());

            double subtotal = 5.00 + (kWh * 0.55);
            double igv = subtotal * 0.18;
            double total = subtotal + igv;

            Console.WriteLine($"Subtotal de kWh (sin IGV): " + subtotal.ToString("F2"));
            Console.WriteLine($"IGV: " + igv.ToString("F2"));
            Console.WriteLine($"Total a pagar: " + total.ToString("F2"));

        }
    }
}
