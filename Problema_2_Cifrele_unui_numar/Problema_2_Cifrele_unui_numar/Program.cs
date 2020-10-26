using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2_Cifrele_unui_numar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // Intoduceti un numar n de la tastatura si sa se arate cate cifre impare are numarul.

            

            int n = int.Parse(Console.ReadLine());
            int m;
            int imp = 1;

            for (int i = 1; i < n; i++)
            {
                m = int.Parse(Console.ReadLine());

                if (m % 2 == 1)
                    imp++;
            }
            if (imp == 1)
            
                Console.WriteLine("Nu exista cifre pare");
            
            else
                Console.WriteLine(imp);
            Console.ReadKey();

        }
    }
}
