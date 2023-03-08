using System;

namespace BruttoNettoRechner
{
    internal class Program
    {
        static double nettoBerechnen(double dBruttopreis, int iMwSt) {
            return dBruttopreis * 100 / (100 + iMwSt);
        }

        static double bruttoBerechnen(double dNettopreis) {
            return dNettopreis * 0.19;
        }
        static void Main(string[] args)
        {
            double dBruttopreis = 0, dNettopreis;
            int iMwSt;
            Console.Write("Bitte geben Sie den Bruttopreis ein [€]: ");
            dBruttopreis = double.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie den Steuersatz ein [%]: ");
            iMwSt = Convert.ToInt32(Console.ReadLine());

            dNettopreis = nettoBerechnen(dBruttopreis, iMwSt);

            Console.WriteLine($"Der Nettopreis beträgt: {dNettopreis:0.00} €");
        }
    }
}