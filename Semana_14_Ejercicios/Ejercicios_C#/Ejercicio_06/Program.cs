using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static string[] nombres = { "Ana", "Luis", "María", "Carlos" };

        static double[] notas = { 18, 14, 19, 11 };

        static void Ordenar_Ranking()
        {

            for (int i = 0; i < notas.Length - 1; i++)
            {
                for (int j = 0; j < notas.Length - 1 - i; j++)
                {
                    if (notas[j] < notas[j + 1])
                    {
                        double auxNota = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = auxNota;

                        string auxNombre = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = auxNombre;
                    }
                }
            }
        }
        static void Mostrar_Ranking()
        {
            Console.WriteLine("\n=== RANKING DE ESTUDIANTES ===\n");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + nombres[i] + " - Nota: " + notas[i]);
            }

            Console.WriteLine("\nPrimer puesto: " + nombres[0] + " (" + notas[0] + ")");
        }
        static void Main(string[] args)
        {
            Ordenar_Ranking();
            Mostrar_Ranking();
        }
    }
}
