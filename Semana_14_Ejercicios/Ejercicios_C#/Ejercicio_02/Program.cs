using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Analizar(string texto)
        {
            int vocales = 0;
            int digitos = 0;
            int espacios = 0;

            texto = texto.ToLower();

            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];

                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'á' || c == 'é' || c == 'í' || c == 'ó' || c == 'ú')

                {
                    vocales++;
                }

                if (char.IsDigit(c))
                {
                    digitos++;
                }

                if (c == ' ')
                {
                    espacios++;
                }
            }

            Console.WriteLine($"Vocales: {vocales}");
            Console.WriteLine($"Digitos: {digitos}");
            Console.WriteLine($"Espacios: {espacios}");
        }
        static void Main(string[] args)
        {
            Console.Write("Observación: ");
            string observacion = Console.ReadLine();

            Analizar(observacion);
        }
    }
}
