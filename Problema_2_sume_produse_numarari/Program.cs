using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2_sume_produse_numarari
{
    class Program
    {
        static void Main(string[] args)
        {
            // (#46) Să se scrie un program care citește numărul natural n 
            // și determină suma S=2+4+..+(2n).

            Console.WriteLine("Introduceti un numar natural");

            
            int n = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Suma este egala cu...");

            int S =  n * (n + 1);

            Console.WriteLine(S);

            Console.ReadKey();



        }
    }
}
