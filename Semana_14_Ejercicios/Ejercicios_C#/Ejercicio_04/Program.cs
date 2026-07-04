using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static string Normalizar_Codigo(string codigo)
        {
            codigo = codigo.Trim();
            codigo = codigo.Replace("-", "");
            codigo = codigo.ToUpper();

            return codigo;
        }
        static bool Tiene_Longitud_Valida(string codigo)
        {
            return codigo.Length == 8;
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese código de comprobante: ");
            string codigo_ingresado = Console.ReadLine();
            string codigo_normalizado = Normalizar_Codigo(codigo_ingresado);

            Console.WriteLine($"Código normalizado: {codigo_normalizado}");

            if (Tiene_Longitud_Valida(codigo_normalizado))
            {
                Console.WriteLine("Código válido.");
            }
            else
            {
                Console.WriteLine("Código inválido. Debe tener 8 caracteres.");
            }
        }
    }
}
