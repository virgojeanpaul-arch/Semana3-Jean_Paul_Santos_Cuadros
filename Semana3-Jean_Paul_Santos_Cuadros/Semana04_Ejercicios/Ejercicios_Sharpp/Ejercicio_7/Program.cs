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
            Console.Write("Ingrese examen parcial: ");
            double Exam_Par = double.Parse(Console.ReadLine());
            Console.Write("Ingrese examen final: ");
            double Exam_Fin = double.Parse(Console.ReadLine());
            Console.Write("Ingrese práctica 1: ");
            double p1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese práctica 2: ");
            double p2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese práctica 3: ");
            double p3 = double.Parse(Console.ReadLine());

            double prom_prac = (p1 + p2 + p3 - Math.Min(p1, Math.Min(p2, p3))) / 2;
            double prom_final = (Exam_Par + Exam_Fin + prom_prac) / 3;

            Console.WriteLine("Promedio de prácticas: " + prom_prac);
            Console.WriteLine($"Promedio final: {prom_final:F2}");

            if (prom_final >= 18)
            {
                Console.WriteLine("Excelente");
            }
            else if (prom_final >= 14)
            {
                Console.WriteLine("Bueno");
            }
            else if (prom_final >= 10)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Deficiente");
            }
        }
    }
}
