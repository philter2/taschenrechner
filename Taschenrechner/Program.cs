using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {

            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen
            Console.WriteLine("Erste Zahl eingeben und mit Enter bestätigen:");
            string ersterSummand = Console.ReadLine();
            Console.WriteLine("Zweite Zahl eingeben und mit Enter bestätigen:");
            string zweiterSummand = Console.ReadLine();

            // Konvertierung string to float
            double ersterSumandInt = Convert.ToDouble(ersterSummand);
            double zweiterSummandInt = Convert.ToDouble(zweiterSummand);

            // Berechnung ausführen
            double summe = ersterSumandInt + zweiterSummandInt;


            // Ausgabe
            Console.WriteLine("Ergebnis: {0}", summe);
            Console.ReadLine();
        }
    }
}
