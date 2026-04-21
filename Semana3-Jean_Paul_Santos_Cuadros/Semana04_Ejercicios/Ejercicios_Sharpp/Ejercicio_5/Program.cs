using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Acceso permitido. Bienvenido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
                int faltan = Math.Abs(18 - edad);
                Console.WriteLine("Te faltan " + faltan + " años para acceder");
            }
        }
    }
}
