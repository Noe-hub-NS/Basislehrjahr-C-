using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie die Anzahl Tage ihres Monats an?");
            string input = Console.ReadLine();
            int zahl = 0;
            bool isNumber = int.TryParse(input, out zahl);
            
            if (isNumber)
            {
                if (zahl >= 28 && zahl <= 31)
                {
                    Console.WriteLine("Der Monat hat " + (zahl * 86400 )+ " Sekunden.");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Ein Monat hat zwischen 28 und 31 Tagen.");
                }
            }            
        }
    }
}
