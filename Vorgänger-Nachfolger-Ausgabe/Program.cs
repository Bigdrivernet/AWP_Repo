using System;

namespace Vorgänger_Nachfolger_Ausgabe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ushort usPrevious, usInput, usNext;
            Console.Write("Bitte geben Sie eine Zahl zwischen 0 und 65535 ein: ");
            usInput = ushort.Parse(Console.ReadLine());

            usPrevious = (ushort)(usInput - 1);
            usNext = (ushort)(usInput + 1);

            Console.WriteLine($"Der Vorgänger ist: {usPrevious}");
            Console.WriteLine($"Der Nachfolger ist: {usNext}");
        }
    }
}