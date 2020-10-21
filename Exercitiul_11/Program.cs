using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Se citeste de la tastatura un numar natural de 3 cifre. 
            // Sa se stabileasca daca are toate cifrele egale.
            Console.WriteLine("Introduceti un numar natural de 3 cifre");
            int n;
            n = int.Parse(Console.ReadLine());
            int c1 = n / 100;
            int c2 = (n % 100) / 10;
            int c3 = n % 10;

            if ((c1 == c2) && (c2 == c3))
                Console.WriteLine("Cifrele numarului sunt egale {0}", c1);
            else Console.WriteLine("Cifrele numarului sunt diferite");

            Console.ReadKey();



        }
    }
}
