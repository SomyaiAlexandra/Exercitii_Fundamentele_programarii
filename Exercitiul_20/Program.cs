using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interschimbati valorile a doua numere.
            int x, y, aux;

            Console.WriteLine("Introduceti primul numar(x)");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar(y)");
            y = int.Parse(Console.ReadLine());

            aux = x; x = y; y = aux;

            Console.WriteLine("Dupa interschimbare x={0}, y={1}", x,y);

            Console.ReadKey();








        }
    }
}
