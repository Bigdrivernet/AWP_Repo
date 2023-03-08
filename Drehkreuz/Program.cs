using System;

namespace Drehkreuz
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Drehkreuzsteuerung");
			Console.WriteLine("------------------");

			for (int i = 30; i > 0; i--) {
				Console.WriteLine($"Noch {i} {string.Format("{0:Plätze;0;Platz}", (i > 1).GetHashCode())} verfügbar.\nBitte einsteigen!");
				Console.ReadKey();
				Console.WriteLine("\n- Signal Drehkreuz -");
			}
			Console.WriteLine($"Keine freien Plätze mehr verfügbar.\nBitte nicht mehr einsteigen!");
        }
    }
}