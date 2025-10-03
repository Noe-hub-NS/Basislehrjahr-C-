using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Zahl1;
            int Zahl2;
            int Summe;

            Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            Zahl2 = Convert.ToInt32(Console.ReadLine());
            Summe = Zahl1 * Zahl2;
            Console.WriteLine("Die Summe der beiden Zahlen ist: " + Summe);


        }
    }
}
