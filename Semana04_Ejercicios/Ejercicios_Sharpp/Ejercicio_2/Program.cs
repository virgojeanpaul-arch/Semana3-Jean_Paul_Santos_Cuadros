using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menú de operaciones");
            Console.WriteLine("1. Calcular área del círculo");
            Console.WriteLine("2. Calcular área de un cuadrado");
            Console.WriteLine("3. Calcular área de un tríangulo");
            Console.WriteLine("4. Salir");
            Console.Write("Elegir una de las opciones (1-4): ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("r: ");
                    double r = double.Parse(Console.ReadLine());
                    double area = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("Área círculo = p * r2");
                    Console.WriteLine($"Resultado: {area:f2}");
                    break;
                case 2:
                    Console.Write("lado: ");
                    double lado = double.Parse(Console.ReadLine());
                    double l = Math.Pow(lado, 2);
                    Console.WriteLine("Área cuadrado = lado2");
                    Console.WriteLine("Resultado: " + l);
                    break;
                case 3:
                    Console.Write("base: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("altura: ");
                    double a = double.Parse(Console.ReadLine());
                    area = (b * a) / 2;
                    Console.WriteLine("Área tríangulo = (base * altura) / 2");
                    Console.WriteLine("Resultado: " + area);
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción invalida. Ingrese un número del 1 al 4");
                    break;
            }
        }
    }
}
