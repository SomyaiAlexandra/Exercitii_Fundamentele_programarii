using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Sa se scrie un program care determina aria totala a unui cub pentru care se cunoaste lungimea laturii.

            Console.WriteLine("Introduceti latura cubului");

            int latura = int.Parse(Console.ReadLine());
            double Arie = Math.Pow(latura, 2) * 6;

            Console.WriteLine("Aria este egala cu"); Console.WriteLine(Arie);
            Console.ReadKey();

        }
    }
}
