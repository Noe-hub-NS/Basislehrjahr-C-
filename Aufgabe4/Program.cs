using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Monate = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" };
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 12 ein:");
            int zahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monat: " + Monate[zahl - 1]);
        }
    }
}
