using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fansCount = int.Parse(Console.ReadLine());

            double fansInSectorA = 0;
            double fansInSectorB = 0;
            double fansInSectorV = 0;
            double fansInSectorG = 0;
            // Fans of team 1 are in sector A and B
            // Fans of team 2 are in sector V and G
            for (int i = 0; i < fansCount; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    fansInSectorA++;
                }
                else if (sector == "B")
                {
                    fansInSectorB++;
                }
                else if (sector == "V")
                {
                    fansInSectorV++;
                }
                else if (sector == "G")
                {
                    fansInSectorG++;
                }
            }
            double convertA = fansInSectorA / fansCount * 100;
            double convertB = fansInSectorB / fansCount * 100;
            double convertV = fansInSectorV / fansCount * 100;
            double convertG = fansInSectorG / fansCount * 100;
            double convertAll = (double) fansCount / capacity * 100;

            Console.WriteLine($"{convertA:f2}%\n{convertB:f2}%\n{convertV:f2}%\n{convertG:f2}%\n{convertAll:f2}%");
        }
    }
}
