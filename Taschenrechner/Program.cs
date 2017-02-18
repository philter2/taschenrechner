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
            double ersterSumandAlsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandAlsZahl = Convert.ToDouble(zweiterSummand);

            // Berechnung ausführen
            double summe = Addieren(ersterSumandAlsZahl, zweiterSummandAlsZahl);

            // Ausgabe
            Console.WriteLine("Ergebnis: {0}", summe);
            WarteAufBenutzerEingabe();
        }


        static double Addieren(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }


        static void WarteAufBenutzerEingabe()
        {
            Console.Write("Zum beenden bitte Taste drücken");
            Console.ReadLine();
        }
    }
}
