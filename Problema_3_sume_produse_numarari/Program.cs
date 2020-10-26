using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3_sume_produse_numarari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // (#332) Să se scrie un program care citește numărul natural n 
            // și determină suma S=1*2+2*3+3*4+...+n*(n+1).

            Console.WriteLine("Introduceti un numar natural n");

            int n = int.Parse(Console.ReadLine());
            int S = 0;

            Console.WriteLine("Suma numerelor este...");

            for (int i = 1; i <= n; i++)

                S += i * (i + 1);

            Console.WriteLine(S);
            Console.ReadKey();



        }
    }
}
