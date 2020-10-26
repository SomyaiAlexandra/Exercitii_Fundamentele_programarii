using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5_Cifrele_unui_numar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Calculati suma cifrelor unui numar dat.

            Console.WriteLine("Introduceti un numar n");

            int S = 0;
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                S = S + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Suma este egala cu {0}", S);
            Console.ReadKey();


        }
    }
}
