using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        // METHODE DEFINIEREN in 7 Schritten
        // Modifizierer Definieren (z.B. static)
        // Datentyp des Rückgabewertes definieren
        // Methodennamen definieren
        // Rundeklammern an den Methodennamen anfügen
        // Überlegen welche Parameter benötigt werden (optonal diese definieren)
        // Geschweifte Klammern einfügen
        // Methode implementieren (Anweisungen in den Methodenrumpf schreiben)

 

        static void Main(string[] args)
        {

            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen
            string ersterSummand = HoleSummanden("Erste Zahl eingeben und mit Enter bestätigen:");
            string zweiterSummand = HoleSummanden("Zweite Zahl eingeben und mit Enter bestätigen:");

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

        static string HoleSummanden(string ausgabeText)
        {
            Console.WriteLine(ausgabeText);
            string summand = Console.ReadLine();
            return summand;
        }
    }

}
