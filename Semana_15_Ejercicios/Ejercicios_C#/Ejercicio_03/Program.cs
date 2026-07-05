using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] ventas = new double[3, 4];

            IngresarVentas(ventas);

            Console.WriteLine("\nMATRIZ DE VENTAS:");
            MostrarMatriz(ventas);

            Console.WriteLine("\nREPORTE DE VENTAS:");
            AnalizarVentas(ventas);

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
        static void IngresarVentas(double[,] ventas)
        {
            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                Console.WriteLine($"Sede {i + 1}");

                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    Console.Write($"Venta del día {j + 1}: S/");

                    ventas[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }
        static void MostrarMatriz(double[,] ventas)
        {
            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    Console.Write($"{"S/" + ventas[i, j].ToString("F2"),12}");
                }

                Console.WriteLine();
            }
        }
        static void AnalizarVentas(double[,] ventas)
        {
            double mayor = ventas[0, 0];

            int filaMayor = 0;
            int colMayor = 0;

            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                double totalSede = 0;

                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    totalSede = totalSede + ventas[i, j];

                    if (ventas[i, j] > mayor)
                    {
                        mayor = ventas[i, j];

                        filaMayor = i;
                        colMayor = j;
                    }
                }

                Console.WriteLine($"Sede {i + 1}: S/{totalSede:F2}");
            }

            Console.WriteLine($"Mayor venta: S/{mayor:F2} en sede {filaMayor + 1}, día {colMayor + 1}");
        }
    }
}
