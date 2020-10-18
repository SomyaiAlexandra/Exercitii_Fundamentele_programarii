using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Sa se scrie un program care determina volumul unui cub pentru care se cunoaste lungimea laturii.

            Console.WriteLine("Introduceti latura cubului");

            int latura = int.Parse(Console.ReadLine());
            double Volum = Math.Pow(latura, 3);

            Console.WriteLine("Volumul este egal cu"); Console.WriteLine(Volum);
            Console.ReadKey();
        }
    }
}
