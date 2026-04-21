using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el peso en kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());

            double imc = peso / Math.Pow(estatura, 2);
            double imcRed = Math.Round(imc, 2);

            Console.WriteLine($"IMC: {imcRed}");

            if (imc < 18.5)
            {
                Console.WriteLine("Bajo peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidad");
            }
        }
    }
}
