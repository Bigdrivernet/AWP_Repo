using System;

namespace Schaltjahr_Rechner_komisch
{
    class Program
    {
        
        static void Main(string[] args)
        {
            uint uiYear;
            bool bLeapYear = false;

            Console.Write("Bitte geben Sie ein Jahr ein: ");
            uiYear = Convert.ToUInt32(Console.ReadLine());

            if (uiYear % 4 == 0) {
                if (uiYear % 100 == 0) {
                    if (uiYear % 400 == 0) {
                        bLeapYear = true;
                    }
                    else {
                        bLeapYear = false;
                    }
                }
                else {
                    bLeapYear = true;
                }
            }
            else {
                bLeapYear = false;
            }

            Console.WriteLine($"{uiYear} ist {string.Format("{0:ein;0;kein}", bLeapYear.GetHashCode())} Schaltjahr.");
        }
    }
}