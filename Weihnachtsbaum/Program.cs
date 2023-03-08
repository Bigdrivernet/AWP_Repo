using System;

namespace Weihnachtsbaum
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i_Hoehe = 0, i_Variante = 0;
            do {
                Console.Write("Welche Variante soll gezeichnet werden? <1-5>: ");
                i_Variante = Convert.ToInt32(Console.ReadLine());
            } while (i_Variante < 0 || i_Variante > 5);

            do {
                Console.Write("Bitte geben Sie die Höhe des Baumes ein: ");
                i_Hoehe = Convert.ToInt32(Console.ReadLine());
            } while (i_Hoehe <= 0);

            switch (i_Variante) {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < i_Hoehe; i++) {
                        Console.WriteLine("\nX");
                    }
                    break;
                
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < i_Hoehe; i++) {
                        for (int j = 0; j <= i; j++) {
                            Console.Write("X ");
                        }
                        Console.Write("\n\n");
                    }
                    break;
                
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < i_Hoehe; i++) {
                        for (int j = 0; j < i_Hoehe - i; j++) {
                            Console.Write("  ");
                        }
                        for (int j = 0; j <= i*2; j++) {
                            Console.Write("X ");
                        }
                        Console.Write("\n\n");
                    }
                    break;
                
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < i_Hoehe; i++) {
                        for (int j = 0; j < i_Hoehe - i; j++) {
                            Console.Write("  ");
                        }
                        for (int j = 0; j <= i*2; j++) {
                            Console.Write("X ");
                        }
                        Console.Write("\n\n");
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    for (int i = 0; i < 2; i++) {
                        for (int j = 0; j < i_Hoehe; j++) {
                            Console.Write("  ");
                        }
                        Console.WriteLine("H");
                    }
                    break;

                case 5:
                    Random Random = new Random();
                    int i_Halb = 10;
                    int i_Current = 1;
                    int i_Next = 0;
                    for (int i = 0; i < i_Hoehe; i++) {
                        for (int j = 0; j < i_Halb - i_Current / 2; j++) {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < i_Current; j++) {
                            switch(Random.Next(0, 10)) {
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("O");
                                    break;
                                case 2:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("I");
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("X");
                                    break;
                            }
                        }
                        Console.Write("\n");
                        i_Next = 2 * Random.Next(1, i_Halb + 1) + 1;
                        if ((i_Next >= i_Current) || (i_Current <= 7)) {
                            i_Current += 2;
                        }
                        else {
                            i_Current -= 8;
                            if (i_Current <= 1) {
                                i_Current = 5;
                            }
                        }
                    }
                    for (int i = 0; i < 3; i++) {
                        for (int j = 0; j < i_Halb; j++) {
                            Console.Write(" ");
                        }
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("H\n");
                    }
                    break;
            }
        }
    }
}