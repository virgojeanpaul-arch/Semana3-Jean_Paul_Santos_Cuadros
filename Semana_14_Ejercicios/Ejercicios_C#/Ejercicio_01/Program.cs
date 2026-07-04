using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static bool Codigo_Valido(string esperado, string ingresado)
        {
            string codigo_Ingresado_Normalizado = ingresado.Trim().ToUpper();
            string codigo_Esperado_Normalizado = esperado.Trim().ToUpper();

            return codigo_Ingresado_Normalizado.CompareTo(codigo_Esperado_Normalizado) == 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Código esperado: ");
            string esperado = Console.ReadLine();

            Console.Write("Código ingresado: ");
            string ingresado = Console.ReadLine();

            if (Codigo_Valido(ingresado, esperado))
            {
                Console.WriteLine("Código aceptado.");
            }
            else
            {
                Console.WriteLine("Código no coincide");
            }
        }
    }
}
