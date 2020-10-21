using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numere_de_tip_grindina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student: Somyai Alexandra
            // Se da un nr. intreg. Daca este par se imparte la doi. Daca este impar se multiplic de 3 ori si se adauga 1. 
            // Pentru un nr. dat afisati secventa de etape pana cand acesta ajunge la 1.
            // Tema1 un nr. care tinde +500 pasi. Raspunsul este = 9223372036854775807 sau 9223372036854775806 sau 98989898989898 sau 112233445566778899
            // Tema2 cel mai mic nr. care tine +500 pasi. Raspunsul este = NECUNOSCUT 

            Console.WriteLine("Introduceti un numar");

            long nrp = 0;
            long n = long.Parse(Console.ReadLine());
            while (n != 1) 
            {
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = n * 3 + 1;
                Console.Write(n + " ");
                nrp++;
            }

            Console.Write("Numarul are ");
            Console.Write(nrp);
            Console.Write(" pasi");
            Console.ReadKey();


        }
    }
}
