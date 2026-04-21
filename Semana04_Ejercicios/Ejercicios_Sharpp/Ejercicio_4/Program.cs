using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Categoría: ");
            string cat = Console.ReadLine().ToUpper();
            Console.Write("Horas: ");
            double horas = double.Parse(Console.ReadLine());
            Console.Write("Años: ");
            int anios = int.Parse(Console.ReadLine());
            double tarifa = 0;

            if (cat == "A") tarifa = 33.50;
            else if (cat == "B") tarifa = 29.80;
            else if (cat == "C") tarifa = 25.60;
            else
            {
                Console.WriteLine("Categoria inválida");
                return;
            }

            double bono = 0;

            if (anios <= 3) bono = 0.00;                                                                        
            else if (anios >= 4 && anios <= 10) bono = 0.10;
            else if (anios >= 11 && anios <= 17) bono = 0.20;
            else bono = 0.30;

            double sueldoFinal = tarifa * horas * (1 + bono);
            Console.WriteLine($"Sueldo: S/. {sueldoFinal:F2}");
        }
    }
}
