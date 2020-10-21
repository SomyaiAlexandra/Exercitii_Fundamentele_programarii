using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_sume_produse_numarari
{
    class Program
    {
        static void Main(string[] args)
        {
            // (#1360)Se citește n număr natural. Calculați suma tuturor numerelor 
            // naturale mai mici sau egale cu n.

            Console.WriteLine("Introduceti nu numar natural n");

            float n = float.Parse(Console.ReadLine());

            float Gauss = n*(n + 1) / 2;

            Console.WriteLine("Suma este egala cu ...");

            Console.WriteLine(Gauss);

            Console.ReadKey();

        }
    }
}
           
