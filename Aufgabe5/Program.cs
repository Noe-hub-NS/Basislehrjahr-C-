using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int Anzahlkm = Convert.ToInt32(Console.ReadLine());

            if (Anzahlkm > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
            }

            else if (Anzahlkm <= 42)
            {
                double n = Anzahlkm * 1000 / 400;
                Console.WriteLine("\nDas sind " + n + " Runden.");
                Console.WriteLine("\nBereit für den Lauf? (0 für Ja/ 1 für Nein)");
                int ready = Convert.ToInt32(Console.ReadLine());


                if (ready == 0)
                {
                    int i = 0;
                    while (i <= n)
                    {
                        i++;

                        Console.WriteLine("Du läufst Runde " + (i - 1));
                    }

                    Console.WriteLine("\nDu hast es geschafft!");
                }

                if (ready == 1)
                {
                    Console.WriteLine("\nKomm wenn du bereit bist!");
                }

            }
        }
    }
}
