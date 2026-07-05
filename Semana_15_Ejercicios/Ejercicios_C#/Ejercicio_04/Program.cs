using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] asistencia = new int[2, 3];

            IngresarAsistencia(asistencia);

            Console.WriteLine("\nMATRIZ DE ASISTENCIA:");
            MostrarMatriz(asistencia);

            Console.WriteLine("\nREPORTE DE ASISTENCIA:");
            AnalizarAsistencia(asistencia);

            Console.WriteLine("\nPresione una tecla para finalizar...");
            Console.ReadKey();
        }
        static void IngresarAsistencia(int[,] asistencia)
        {
            for (int i = 0; i < asistencia.GetLength(0); i++)
            {
                Console.WriteLine($"Turno {i + 1}");

                for (int j = 0; j < asistencia.GetLength(1); j++)
                {
                    Console.Write($"Asistencia en sesión {j + 1}: ");

                    asistencia[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void MostrarMatriz(int[,] asistencia)
        {
            for (int i = 0; i < asistencia.GetLength(0); i++)
            {
                for (int j = 0; j < asistencia.GetLength(1); j++)
                {
                    Console.Write($"{asistencia[i, j],8}");
                }

                Console.WriteLine();
            }
        }
        static void AnalizarAsistencia(int[,] asistencia)
        {
            int filas = asistencia.GetLength(0);
            int columnas = asistencia.GetLength(1);

            for (int j = 0; j < columnas; j++)
            {
                int suma = 0;

                for (int i = 0; i < filas; i++)
                {
                    suma = suma + asistencia[i, j];
                    double promedio = suma / (double)filas;

                    Console.WriteLine($"Sesión {j + 1}: promedio {promedio:F2}");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < asistencia.GetLength(0); i++)
            {
                int menor = asistencia[i, 0];

                for (int j = 0; j < asistencia.GetLength(1); j++)
                {
                    if (asistencia[i, j] < menor)
                    {
                        menor = asistencia[i, j];
                    }
                }

                Console.WriteLine($"Turno {i + 1}: menor asistencia {menor}");
            }
        }
    }
}
