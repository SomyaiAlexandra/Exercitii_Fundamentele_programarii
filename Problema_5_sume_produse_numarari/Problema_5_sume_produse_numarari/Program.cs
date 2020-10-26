using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5_sume_produse_numarari
{
	class Program
	{
		static void Main(string[] args)
		{
			// Somyai Alexandra
			// (#338) Să se scrie un program care citește numărul natural n 
			//  și determină suma S=1^1+2^2+ ... + n^n.

			Console.WriteLine("Introduceti un numar natural");

			int n = int.Parse(Console.ReadLine());
			int S = 0;

			for (int i = 1; i <= n; i++)

				S += i * i;

			Console.WriteLine("Suma este egala cu {0} ", S);
			Console.ReadKey();



		}
	}
}
