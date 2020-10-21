using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somyai Alexandra
            // (#832)Fiind dată nota unui elev să se afișeze dacă acesta este corigent sau promovat.

            Console.WriteLine("Introduceti nota elevului");

            int n; // n reprezinta nota elevului
            n = int.Parse(Console.ReadLine());

            if (n > 5) Console.WriteLine("Elevul este PROMOVAT");

            if (n == 5) Console.WriteLine("Elevul este PROMOVAT");

            if (n < 5) Console.WriteLine("Elevul este CORIGENT");

            Console.ReadKey();


        
        }
    }
}
