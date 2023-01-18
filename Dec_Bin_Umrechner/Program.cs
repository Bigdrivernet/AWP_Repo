using System;

namespace DecBinUmrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int iDezimal;

            Console.Write("Bitte geben Sie eine Zahl ein: ");
            iDezimal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Convert.ToString(iDezimal, 2));
        }
    }
}