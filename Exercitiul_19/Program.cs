using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se citesc doua numere a si b reprezentand lungimile laturilor unui dreptungi.
            // Sa se calculeze perimetrul, aria si lungimea diagonalei dreptunghiului.

            Console.WriteLine("Introdeceti lungimea laturii");
            int L = int.Parse(Console.ReadLine());

            Console.WriteLine("Intoduceti latimea laturii");
            int l = int.Parse(Console.ReadLine());

            int Perimetru = (L + l) * 2;
            Console.WriteLine($"Perimetrul dreptunghiului este {Perimetru}");

            int Arie = L * l;
            Console.WriteLine($"Aria dreptunghiului este {Arie}");
            
            int d = (int)Math.Sqrt(L * L + l * l);
            int Diagonala = (int)Math.Pow(d, 2);
            Console.WriteLine($"Diagonala dreptunghiului este {Diagonala}");

            Console.ReadKey();
            
            

        }
    }
}
