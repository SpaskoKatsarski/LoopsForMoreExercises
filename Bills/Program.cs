using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE_FOR_WATER_PER_MONTH = 20;
            const double PRICE_FOR_INTERNET_PER_MONTH = 15;

            int months = int.Parse(Console.ReadLine());

            double priceForElectricty = 0;
            double priceForWater = 0;
            double priceForInternet = 0;
            double others = 0;

            for (int i = 0; i < months; i++)
            {
                double priceForElectrictyPerMonth = double.Parse(Console.ReadLine());

                priceForElectricty += priceForElectrictyPerMonth;
                priceForWater += PRICE_FOR_WATER_PER_MONTH;
                priceForInternet += PRICE_FOR_INTERNET_PER_MONTH;
                others += (priceForElectrictyPerMonth + PRICE_FOR_WATER_PER_MONTH + PRICE_FOR_INTERNET_PER_MONTH) + 0.20 * (priceForElectrictyPerMonth + PRICE_FOR_WATER_PER_MONTH + PRICE_FOR_INTERNET_PER_MONTH);
            }
            double average = (priceForElectricty + priceForWater + priceForInternet + others) / months;
            Console.WriteLine($"Electricity: {priceForElectricty:f2} lv\nWater: {priceForWater:f2} lv\nInternet: {priceForInternet:f2} lv\nOther: {others:f2} lv\nAverage: {average:f2} lv");
        }
    }
}
