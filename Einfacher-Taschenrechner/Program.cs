using System;

namespace Einfacher_Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dNumber1, dNumber2, dResult = 0.0;
            string sOperator;

            Console.Write("Geben Sie die erste Zahl ein: ");
            dNumber1 = double.Parse(Console.ReadLine());
            Console.Write("Geben Sie die zweite Zahl ein: ");
            dNumber2 = double.Parse(Console.ReadLine());
            Console.Write("Wählen Sie die Operation (+, -, *, /): ");
            sOperator = Console.ReadLine();

            switch (sOperator) {
                case "+":
                    dResult = dNumber1 + dNumber2;
                    break;
                
                case "-":
                    dResult = dNumber1 - dNumber2;
                    break;
                
                case "*":
                    dResult = dNumber1 * dNumber2;
                    break;

                case "/":
                    dResult = dNumber1 / dNumber2;
                    break;
            }

            Console.WriteLine($"Das Ergebnis ist {dResult}");
        }
    }
}