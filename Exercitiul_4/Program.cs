using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // (#168) Să se scrie un program care citeşte de la tastatură două numere întregi a şi b.
            // Verifică dacă cele doua numere au acelaşi semn.

            Console.WriteLine("Intoduceti doua numere intregi");

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0) Console.WriteLine("DA! Ambele numere sunt pozitive");
            if (a < 0 && b < 0) Console.WriteLine("DA! Ambele numere sunt negative");
            if (a < 0 && b > 0) Console.WriteLine("NU! Numerele nu au acelasi semn");
            if (a > 0 && b < 0) Console.WriteLine("NU! Numerele nu au acelasi semn");


            Console.ReadKey();






        }
    }
}
