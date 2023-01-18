using System;

namespace Anhalteweg
{
    class Program
    {
        static void Main(string[] args)
        {
            double dAnhalteweg, dAbstand, dGeschwindigkeit, dVerzoegerung = 0.0, dReaktion, dVAufprall, dReaktionsweg, dBremsweg;
            char cNochmal;
            string sAuswahl;
            
            do {
                Console.Write("Bitte geben Sie die gefahrene Geschwindigkeit in km/h ein: ");
                dGeschwindigkeit = double.Parse(Console.ReadLine()) / 3.6;

                Console.Write("Bitte geben Sie die restliche Strecke bis zum Hinderniss ein in m: ");
                dAbstand = double.Parse(Console.ReadLine());

                Console.Write("Bitte geben Sie die Reaktionszeit in s ein: ");
                dReaktion = double.Parse(Console.ReadLine());
                
                do {
                Console.WriteLine("Bitte wählen Sie eine Fahrbahnobefläche");
                Console.WriteLine("1 : Beton trocken");
                Console.WriteLine("2 : Beton nass");
                Console.WriteLine("3 : Asphalt trocken");
                Console.WriteLine("4 : Asphalt nass");
                Console.WriteLine("5 : Schnee");
                Console.WriteLine("6 : Eis");
                Console.Write("Ihre Auswahl: ");
                sAuswahl = Console.ReadLine();

                cNochmal = ' ';
                switch (sAuswahl) {
                    case "1":
                        dVerzoegerung = 9.0;
                        break;
                    case "2":
                        dVerzoegerung = 5.0;
                        break;
                    case "3":
                        dVerzoegerung = 7.0;
                        break;
                    case "4":
                        dVerzoegerung = 3.0;
                        break;
                    case "5":
                        dVerzoegerung = 2.0;
                        break;
                    case "6":
                        dVerzoegerung = 1.0;
                        break;
                    default:
                        cNochmal = 'J';
                        break;
                }
                } while (cNochmal == 'J');


                dReaktionsweg = dGeschwindigkeit * dReaktion;
                dBremsweg = (double)Math.Pow(dGeschwindigkeit, 2) / (2 * dVerzoegerung);

                dAnhalteweg = dReaktionsweg + dBremsweg;

                dVAufprall = dGeschwindigkeit - dVerzoegerung * ((Math.Sqrt(2 * dVerzoegerung * (dAbstand - dReaktionsweg) + Math.Pow(dGeschwindigkeit, 2)) - dGeschwindigkeit) / dVerzoegerung);
                dVAufprall = dVAufprall * 3.6;

                Console.WriteLine($"Benötigter Anhalteweg: {dAnhalteweg:0.00} m");

                if (dAnhalteweg < dAbstand) {
                    Console.WriteLine("Glück gehabt!");
                } else {
                    Console.WriteLine("Es kam zum Unfall!");
                    Console.WriteLine($"Die Aufprallgeschwindigkeit beträgt: {dVAufprall} km/h");
                }

                Console.Write("Wollen Sie noch eine Berechnung durchführen? (j/n): ");
                cNochmal = Convert.ToChar(Console.ReadLine());
            } while (cNochmal == 'J' || cNochmal == 'j');
        }
    }
}