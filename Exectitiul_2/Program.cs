using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exectitiul_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // (#1258) Se dau două numere naturale. Calculați diferenţa lor.
            Console.WriteLine("Introduceti doua numere naturale");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Diferenta dintre cele doua numere este...");

            Console.WriteLine( a - b );

            Console.ReadKey();

            

        }
    }
}
