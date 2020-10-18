using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculati media aritmetica a doua numere.

            Console.WriteLine("Introduceti doua numere");
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Media aritmetica a numerelor este...");
            double mediearitmetica = (a + b) / 2;
            Console.WriteLine(mediearitmetica);

            Console.ReadKey();




        }
    }
}
