using System;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double moneyLeft = money;
            double yearsOfIvancho = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    moneyLeft -= 12000;
                }
                else
                {
                    moneyLeft -= 12000 + 50 * yearsOfIvancho;
                }
                yearsOfIvancho++;
            }

            double moneySpent = money - moneyLeft;

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyLeft:f2} dollars left.");
            }
            else
            {
                double difference = Math.Abs(money - moneySpent);
                Console.WriteLine($"He will need {difference:f2} dollars to survive.");
            }
        }
    }
}
