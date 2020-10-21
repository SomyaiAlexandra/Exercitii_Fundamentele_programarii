using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Calculati aria unui triunghi.
            Console.WriteLine("Intoduceti cele 3 laturi ale triunghiului");

            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double semiperimetru = (a + b + c) / 2;
            double aria = (double)Math.Sqrt(semiperimetru * (semiperimetru - a) * (semiperimetru - b) * (semiperimetru - c));

            Console.WriteLine("Aria este egala cu...");
            Console.WriteLine(aria);
            Console.ReadKey();


        }
    }
}
