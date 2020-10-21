using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somyai Alexandra
            // (#109) Să se scrie un program care citeşte de la tastatură un număr natural.
            // Verifică dacă numărul este par sau impar.

            Console.WriteLine("Introduceti un numar natural");

            int n;
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) Console.WriteLine("Numarul este PAR");

            if (n % 2 == 1)Console.WriteLine("Numarul este IMPAR");

            Console.ReadKey();

        
        
        
        }
    }
}
