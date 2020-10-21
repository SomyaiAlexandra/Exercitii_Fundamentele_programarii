using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Se dat trei numere naturale a,b,x. Sa se verifice daca numarul x apartine intervalului [a,b].

            int a, b, x;
            Console.WriteLine("Introduceti cel mai mic numar al intervalului");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Intoduceti cel mai mare numar al intervalului");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul x");
            x = int.Parse(Console.ReadLine());

            if ((x >= a) && (x <= b))
                Console.WriteLine("Numarul x apartine intervalului");
            else
                Console.WriteLine("Numarul x nu apartine intervalului");

            Console.ReadKey();


        }
    }
}
