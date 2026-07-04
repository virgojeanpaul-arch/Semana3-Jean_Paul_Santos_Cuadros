using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static string[] nombres = { "Ana Torres", "Luis Ramos", "María Díaz" };

        static double[] notas = { 18, 14, 11 };

        static int buscar_Estudiante(string nombre_Buscado)
        {
            nombre_Buscado = nombre_Buscado.Trim().ToLower();

            for (int i = 0; i < nombres.Length; i++)
            {
                string nombre_Actual = nombres[i].ToLower();

                if (nombre_Actual.Contains(nombre_Buscado))
                {
                    return i;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONSULTA DE ESTUDIANTE ===");

            Console.Write("Ingrese el nombre a buscar: ");
            string buscar = Console.ReadLine();

            int posicion = buscar_Estudiante(buscar);

            if (posicion != -1)
            {
                Console.WriteLine("\nEstudiante encontrado.");
                Console.WriteLine("Nombre: " + nombres[posicion]);
                Console.WriteLine("Nota: " + notas[posicion]);
            }
            else
            {
                Console.WriteLine("\nEstudiante no encontrado.");
            }
        }
    }
}
