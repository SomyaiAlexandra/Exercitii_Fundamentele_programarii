using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // (#1282) Se dă un număr. Să se afișeze rădăcina sa pătrată.

            Console.WriteLine("Introduceti un numar n");
            int n;
            n = int.Parse(Console.ReadLine());
            double r = Math.Sqrt(n);

            Console.WriteLine("Radacina patrata a numarului este...");
            Console.WriteLine(r); 
            Console.ReadKey();





        }
    }
}
