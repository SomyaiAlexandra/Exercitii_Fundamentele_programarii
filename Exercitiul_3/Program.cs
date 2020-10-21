using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // (#167) Să se scrie un program care citeşte de la tastatură un număr întreg şi determină semnul său.

            Console.WriteLine("Introduceti un numar intreg");

            int n;
            n = int.Parse(Console.ReadLine());

            if (n > 0) Console.WriteLine("Numarul e POZITIV");

            if (n < 0) Console.WriteLine("Numarul e NEGATIV");
            
            if (n == 0) Console.WriteLine("Numarul e NUL");

            Console.ReadKey();


        }
    }
}
