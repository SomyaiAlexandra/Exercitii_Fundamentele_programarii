using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sa se scrie un program care determina maximul a doua numere intregi citite de la tastatura.
            
            Console.WriteLine("Introduceti doua numere intregi");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Numarul maxim este...");
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);

            Console.ReadKey();


        }
    }
}
