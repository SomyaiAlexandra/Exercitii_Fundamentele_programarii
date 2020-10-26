using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_Cifrele_unui_numar
{
	class Program
	{
		static void Main(string[] args)
		{
            // Somyai Alexandra
            // Introduceti un numar n de la tastatura si sa se arate numarul de cifre al acestuia.

            Console.WriteLine("Introduceti un numar intreg");
			int a = int.Parse(Console.ReadLine());
			int b = 0;

			do
			{
				a = a / 10;
				b++;
			}
			while (a != 0);

            Console.WriteLine("Numarul are {1} cifre", a, b);
			Console.ReadKey();

		}
	}
}
