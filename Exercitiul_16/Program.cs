using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Calculati media geometrica a doua numere.

            Console.WriteLine("Introduceti doua numere");
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Media geometrica a numerelor este...");
            double mediegeometrica = Math.Sqrt(a*b);
            Console.WriteLine(mediegeometrica);

            Console.ReadKey();
        }
    }
}
