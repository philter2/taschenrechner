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
            string ersteZahl = HoleBenutzerEingabe("Erste Zahl eingeben und mit Enter bestätigen:");
            string zweiteZahl = HoleBenutzerEingabe("Zweite Zahl eingeben und mit Enter bestätigen:");

            // Konvertierung string to double
            // ToDo: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahlDouble = Convert.ToDouble(ersteZahl);
            double zweiteZahlDouble = Convert.ToDouble(zweiteZahl);

            // Konvertierung double to long
            long testZahl1 = Convert.ToInt32(ersteZahlDouble);
            long estZahl2 = Convert.ToInt32(zweiteZahlDouble);

            // Berechnung wählen
            string berechnungsArt = HoleBenutzerEingabe("Berechnungsart wählen 1 (Addieren) oder 2 (Subtrahieren) und Eingabe bestätigen");
            int berechnungsArtInt = Convert.ToInt32(berechnungsArt);

            // Berechnung ausführen
            double ergebnis;
            if (berechnungsArtInt == 1)
            {
                ergebnis = Addieren(ersteZahlDouble, zweiteZahlDouble);
            }
            else if (berechnungsArtInt == 2)
            {
                ergebnis = Subtrahieren(ersteZahlDouble, zweiteZahlDouble);
            }
            
            
            // Ausgabe
            Console.WriteLine("Ergebnis: {0}", ergebnis);
            HoleBenutzerEingabe("Zum beenden bitte Taste drücken");
        }


        static double Addieren(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }

        static double Subtrahieren (double minuend, double subtrahend)
        {
            double ergebnis = minuend - subtrahend;
            return ergebnis;
        }


        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.WriteLine(ausgabeText);
            string summand = Console.ReadLine();
            return summand;
        }
    }

}
