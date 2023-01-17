using System;

namespace PraktikantenRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1 = 0.0;
            double zahl2 = 0.0;
            double ergebnis = 0.0;                              //Variablen für Zahlen
            char rechenzeichen;                                 //Variable für Rechenzeichen
            char cWiederholen;

            do {
                Console.Write("Geben Sie die erste Zahl ein: ");    //Eingabeaufforderung ausgeben
                zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Geben Sie das Rechenzeichen ein: "); //Eingabeaufforderung ausgeben
                rechenzeichen = Convert.ToChar(Console.ReadLine());

                Console.Write("Geben Sie die zweite Zahl ein: ");   //Eingabeaufforderung ausgeben
                zahl2 = Convert.ToDouble(Console.ReadLine());       //Eingabe einlesen

                if (rechenzeichen == '+')                             //je nach Operator berechnen
                    ergebnis = zahl1 + zahl2;
                if (rechenzeichen == '-')
                    ergebnis = zahl1 - zahl2;
                if (rechenzeichen == '*')
                    ergebnis = zahl1 * zahl2;
                if (rechenzeichen == '/')
                    ergebnis = zahl1 / zahl2;
                if (rechenzeichen == '%')
                    ergebnis = zahl1 % zahl2;
                if (rechenzeichen == '^')
                    ergebnis = Math.Pow(zahl1, zahl2);

                //Aufgabe noch mal komplett ausgeben
                Console.WriteLine($"{zahl1} {rechenzeichen} {zahl2} = {ergebnis}");

                Console.Write("Wollen Sie weiterechnen? (Y/N) ");
                cWiederholen = Convert.ToChar(Console.ReadLine());

            } while ((cWiederholen == 'y') || (cWiederholen == 'Y'));
        }
    }
}
