using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // (#1260) Se citesc două numere naturale. 
            // Afișați suma, diferenţa, produsul şi câtul lor, în această ordine, separate prin câte un spațiu.
            Console.WriteLine("Introduceti doua numere naturale");

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Suma numerelor este...");
            Console.WriteLine(a + b);
            Console.WriteLine("Diferenta dintre numere este...");
            Console.WriteLine(a - b);
            Console.WriteLine("Produsul numerelor este...");
            Console.WriteLine(a * b);
            Console.WriteLine("Catul numerelor este...");
            Console.WriteLine(a / b);

            Console.ReadKey();





        }
    }
}
