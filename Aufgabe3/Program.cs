using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Zahl zwischen 1 und 10 ein.");

            int i = Convert.ToInt32(Console.ReadLine());
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);


            }
        }
    }
}
