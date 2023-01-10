using System;

namespace WahlOMat
{
    class Program
    {
        
        static void Main(string[] args)
        {
            uint uiVotes1, uiVotes2, uiVotesTotal = 0;
            float fPercent1, fPercent2 = 0;
            char cTopLeft = (char)0x2554;
            char cHorizontal = (char)0x2550;
            char cTopRight = (char)0x2557;
            char cBottomLeft = (char)0x255A;
            char cBottomRight = (char)0x255D;
            char cVertical = (char)0x2551;

            Console.WriteLine("--------Wahl-O-Mat--------\n");

            Console.Write("Bitte geben Sie die Stimmen für Kandidat 1 an: ");
            uiVotes1 = Convert.ToUInt32(Console.ReadLine()); //Read Input from Console -> Convert two UInt

            Console.Write("Bitte geben Sie die Stimmen für Kandidat 2 an: ");
            uiVotes2 = Convert.ToUInt32(Console.ReadLine()); //Read Input from Console -> Convert two UInt

            Console.WriteLine(""); //Insert empty line for formatting reasons

            uiVotesTotal = uiVotes1 + uiVotes2;
            fPercent1 = ((float)uiVotes1 / (float)uiVotesTotal) * 100; //Calc percentage for Candidate 1
            fPercent2 = ((float)uiVotes2 / (float)uiVotesTotal) * 100; //Calc percentage for Candidate 2

            Console.Write(cTopLeft);
            for (int i = 0; i <= 34; i++) {
                Console.Write(cHorizontal);
            }
            Console.WriteLine(cTopRight);

            Console.WriteLine($"{cVertical} Das amtliche Endergebnis lautet:  {cVertical}");
            Console.WriteLine($"{cVertical}  Kandidat 1 (in Prozent): {fPercent1,6:##0.00}  {cVertical}"); //Print percentage for candidate 1 with two decimal places and left padding
            Console.WriteLine($"{cVertical}  Kandidat 2 (in Prozent): {fPercent2,6:##0.00}  {cVertical}"); //Print percentage for candidate 2 with two decimal places and left padding
            
            Console.Write(cBottomLeft);
            for (int i = 0; i <= 34; i++) {
                Console.Write(cHorizontal);
            }
            Console.WriteLine(cBottomRight);

            Console.ReadKey();
        }
    }
}