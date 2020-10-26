using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4_Cifrele_unui_numar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Sa se scrie un program care determina oglinditul unui numar citit de la tastatura.

            Console.WriteLine("Introduceti un numar");

            int n = int.Parse(Console.ReadLine());
            int oglinda = 0;

            do
            {
                oglinda = oglinda * 10 + n % 10;
                n = n / 10;
            }
            while (n != 0);
            Console.WriteLine("Oglinditul numarului este {0}", oglinda);
            Console.ReadKey();

        }
    }
}
