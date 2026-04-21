using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Monto de soles: ");
            double monto = double.Parse(Console.ReadLine());

            double hacia_Arriba = Math.Ceiling(monto);
            double hacia_Abajo = Math.Floor(monto);
            int truncado = (int)Math.Truncate(monto);
            double redondeado = Math.Round(monto, 2);

            Console.WriteLine($"Monto original: {monto}");
            Console.WriteLine($"Ceiling (hacia arriba): {hacia_Arriba}");
            Console.WriteLine($"Floor (hacia abajo): {hacia_Abajo}");
            Console.WriteLine($"Truncado (casting int): {truncado}");
            Console.WriteLine($"Redondeado (2 decimales): {redondeado}");
        }
    }
}
