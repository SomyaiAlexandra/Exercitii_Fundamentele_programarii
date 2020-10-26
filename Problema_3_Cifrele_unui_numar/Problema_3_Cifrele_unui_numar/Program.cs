using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3_Cifrele_unui_numar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Se da un numar natural n. Sa se calculeze produsul primelor 2 cifre ale numarului n.

            int P = 1;
            int n = int.Parse(Console.ReadLine());

            while (n > 100)
                n = n / 10;
            while (n != 0)
            {
                P = P * (n % 10);
                n = n / 10;
            }
            Console.WriteLine("Produsul este {0}", P);
            Console.ReadKey();



        }
    }
}
