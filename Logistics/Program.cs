using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_FOR_MINIBUS_PER_TON = 200;
            const double PRICE_FOR_TRUCK_PER_TON = 175;
            const double PRICE_FOR_TRAIN_PER_TON = 120;

            int cargos = int.Parse(Console.ReadLine());

            double priceForCargoForMinibus = 0;
            double priceForCargoForTruck = 0;
            double priceForCargoForTrain = 0;
            double totalWeight = 0;
            double weightForMinibus = 0;
            double weightForTruck = 0;
            double weightForTrain = 0;

            for (int i = 0; i < cargos; i++)
            {
                int weightOfCargoInTons = int.Parse(Console.ReadLine());

                if (weightOfCargoInTons <= 3)
                {
                    priceForCargoForMinibus += weightOfCargoInTons * PRICE_FOR_MINIBUS_PER_TON;
                    weightForMinibus += weightOfCargoInTons;
                }
                else if (weightOfCargoInTons <= 11)
                {
                    priceForCargoForTruck += weightOfCargoInTons * PRICE_FOR_TRUCK_PER_TON;
                    weightForTruck += weightOfCargoInTons;
                }
                else
                {
                    priceForCargoForTrain += weightOfCargoInTons * PRICE_FOR_TRAIN_PER_TON;
                    weightForTrain += weightOfCargoInTons;
                }
                totalWeight += weightOfCargoInTons;
            }
            double averagePrice = (priceForCargoForTrain + priceForCargoForTruck + priceForCargoForMinibus) / totalWeight;
            double convertMinibus = (double) weightForMinibus / totalWeight * 100;
            double convertTruck = (double) weightForTruck / totalWeight * 100;
            double convertTrain = (double) weightForTrain / totalWeight * 100;

            Console.WriteLine($"{averagePrice:f2}\n{convertMinibus:f2}%\n{convertTruck:f2}%\n{convertTrain:f2}%");
        }
    }
}
