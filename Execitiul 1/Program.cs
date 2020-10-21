using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execitiul_1
{
    class Program
    {
        static void Main(string[] args)
        {
        // Somyai Alexandra 
        // (#939)Se dau 2 numere naturale. Calculaţi suma celor 2 numere date.

        Console.WriteLine("Introduceti doua numere naturale");

        int a, b;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma celor doua numere este...");

        Console.WriteLine(a + b);

        Console.ReadKey();


    }
}
}
