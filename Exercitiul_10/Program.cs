using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //(#3480) Se dă un număr natural n. Calculați ultima cifră a lui 9^n.

            Console.WriteLine("Introduceti un numar n");
            int n, n1, p;
            n = int.Parse(Console.ReadLine());
            n1 = 9;
            p = (int)Math.Pow(n1, n);
            Console.WriteLine(p);
            Console.WriteLine("Ultima cifra a lui 9^n este...");
            Console.WriteLine(p%10);
            Console.ReadKey();





        }
    }
}
