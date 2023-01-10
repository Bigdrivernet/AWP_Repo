using System;

namespace Quadrat_Kubikmeter_Rechner
{
    class Program
    {
        
        static void Main(string[] args)
        {
            uint[] uiMode = new uint[2];

            Console.WriteLine("Bitte wählen Sie:");
            Console.WriteLine("1 : Flächen- und Umfangberechnung");
            Console.WriteLine("2 : Volumen- und oberflächenberechnung");
            Console.Write("Ihre Auswahl: ");
            uiMode[0] = Convert.ToUInt32(Console.ReadLine()); //1 -> Area; 2 -> Volume

            Console.WriteLine();
            Console.WriteLine();

            switch (uiMode[0]) {
                case 1:
                    Console.WriteLine("1 : Rechteck");
                    Console.WriteLine("2 : Dreieck");
                    Console.WriteLine("3 : Kreis");
                    Console.Write("Ihre Auswahl: ");
                    uiMode[1] = Convert.ToUInt32(Console.ReadLine()); //1 -> Rectangle; 2 -> Triangle; 3 -> Circle
                    break;
                
                case 2:
                    Console.WriteLine("1 : Quader");
                    Console.WriteLine("2 : Zylinder");
                    Console.WriteLine("3 : Kugel");
                    Console.Write("Ihre Auswahl: ");
                    uiMode[1] = Convert.ToUInt32(Console.ReadLine()); //1 -> Quboid; 2 -> Cylinder; 3 -> Sphere
                    break;
            }

        	Console.WriteLine();
            Console.WriteLine();

            switch (uiMode) {
                case [1, 1]:
                    Console.Write("Seite a: ");
                    float fRectSideA = float.Parse(Console.ReadLine());
                    Console.Write("Seite b: ");
                    float fRectSideB = float.Parse(Console.ReadLine());

                    float fRectCircumference = 2 * fRectSideA + 2 * fRectSideB;
                    float fRectArea = fRectSideA * fRectSideB;
                    
                    Console.WriteLine($"Die Fläche beträgt ca. {fRectArea:0.00} m²");
                    Console.WriteLine($"Der Umfang beträgt ca. {fRectCircumference:0.00} m");
                    break;
                
                case [1, 2]:
                    Console.Write("Seite a: ");
                    float fTriSideA = float.Parse(Console.ReadLine());
                    Console.Write("Seite b: ");
                    float fTriSideB = float.Parse(Console.ReadLine());
                    Console.Write("Seite c: ");
                    float fTriSideC = float.Parse(Console.ReadLine());

                    float fTriCircumference = fTriSideA + fTriSideB + fTriSideC;
                    float fTriArea = (float)Math.Sqrt((fTriCircumference / 2) * (fTriCircumference - fTriSideA) * (fTriCircumference - fTriSideB) * (fTriCircumference - fTriSideC));

                    Console.WriteLine($"Die Fläche beträgt ca. {fTriArea:0.00} m²");
                    Console.WriteLine($"Der Umfang beträgt ca. {fTriCircumference:0.00} m");
                    break;

                case [1, 3]:
                    Console.Write("Radius: ");
                    float fCircRadius = float.Parse(Console.ReadLine());

                    float fCircCircumference = 2 * (float)Math.PI * fCircRadius;
                    float fCircArea = (float)Math.PI * (float)Math.Pow(fCircRadius, 2);

                    Console.WriteLine($"Die Fläche beträgt ca. {fCircArea:0.00} m²");
                    Console.WriteLine($"Der Umfang beträgt ca. {fCircCircumference:0.00} m");
                    break;
                
                case [2, 1]:
                    Console.Write("Länge: ");
                    float fQuboidSideA = float.Parse(Console.ReadLine());
                    Console.Write("Breite: ");
                    float fQuboidSideB = float.Parse(Console.ReadLine());
                    Console.Write("Höhe: ");
                    float fQuboidSideC = float.Parse(Console.ReadLine());

                    float fQuboidSurface = 2 * (fQuboidSideA * fQuboidSideB + fQuboidSideB * fQuboidSideC + fQuboidSideC * fQuboidSideA);
                    float fQuboidVolume = fQuboidSideA * fQuboidSideB * fQuboidSideC;

                    Console.WriteLine($"Die Oberfläche beträgt ca. {fQuboidSurface:0.00} m²");
                    Console.WriteLine($"Der Umfang beträgt ca. {fQuboidVolume:0.00} m");
                    break;
                
                case [2, 2]:
                    Console.Write("Radius: ");
                    float fCylRadius = float.Parse(Console.ReadLine());
                    Console.Write("Höhe: ");
                    float fCylHeight = float.Parse(Console.ReadLine());

                    float fCylSurface = (float)Math.PI * (float)Math.Pow(fCylRadius, 2) + 2 * (float)Math.PI * fCylRadius * fCylHeight;
                    float fCylVolume = (float)Math.PI * (float)Math.Pow(fCylRadius, 2) * fCylHeight;

                    Console.WriteLine($"Die Oberfläche beträgt ca. {fCylSurface:0.00} m²");
                    Console.WriteLine($"Der Umfang beträgt ca. {fCylVolume:0.00} m");
                    break;
                
                case [2, 3]:
                    Console.Write("Radius: ");
                    float fSphereRadius = float.Parse(Console.ReadLine());

                    float fSphereSurface = 4 * (float)Math.PI * (float)Math.Pow(fSphereRadius, 2);
                    float fSphereVolume = (float)4 / 3 * (float)Math.PI * (float)Math.Pow(fSphereRadius, 3);

                    Console.WriteLine($"Die Oberfläche beträgt ca. {fSphereSurface:0.00} m²");
                    Console.WriteLine($"Der Umfang beträgt ca. {fSphereVolume:0.00} m");
                    break;
            }
        }
    }
}