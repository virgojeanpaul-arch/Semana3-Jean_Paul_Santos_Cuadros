using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            Ingresar(matriz);

            Console.WriteLine("\nMATRIZ ORIGINAL:");

            Imprimir(matriz);

            ReemplazarDiagonal(matriz);

            Console.WriteLine($"\nMATRIZ MODIFICADA:");

            Imprimir(matriz);
        }
        static void Ingresar(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"Posición [{i + 1},{j + 1}]: ");

                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Imprimir(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
        static void ReemplazarDiagonal(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        m[i,j] = 0;
                    }
                }
            }
        }
    }
}
