using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notas = new int[3, 3];

            IngresarNotas(notas);

            Console.WriteLine("\nMATRIZ DE NOTAS:");

            MostrarMatriz(notas);

            Console.WriteLine("\nPROMEDIO POR ESTUDIANTE:");

            MostrarPromediosPorEstudiante(notas);
        }
        static void IngresarNotas(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}");

                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese nota del criterio {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void MostrarMatriz(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
        static void MostrarPromediosPorEstudiante(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                int suma = 0;

                for (int j = 0; j < columnas; j++)
                {
                    suma = suma + matriz[i, j];
                }

                double promedio = suma / (double)columnas;

                Console.WriteLine($"Estudiante {i + 1}: {promedio:F2}");
            }
        }
    }
}
