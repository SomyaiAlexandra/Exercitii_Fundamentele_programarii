using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4_sume_produse_numarari
{
	class Program
	{
		static void Main(string[] args)
		{
			// Somyai Alexandra
			// (#49) Să se scrie un program care citește numărul natural n și determină valoarea lui n!.

			Console.WriteLine("Introduceti un numar natural n...");
			int n = int.Parse(Console.ReadLine());
			int p = 1;

			for (int i = 1; i <= n; i++) 
			p *= i;

			Console.WriteLine("n! este {0}", p);
			Console.ReadKey();



		}
	}
}
