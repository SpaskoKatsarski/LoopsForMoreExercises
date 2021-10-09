using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double maxDiff = double.MinValue;
            bool areEqual = true;
            double previousSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    sum = number1 + number2;
                }
                else if (i != 0)
                {
                    if (sum != number1 + number2)
                    {
                        areEqual = false;
                    }
                    if (maxDiff < Math.Abs(number1 + number2 - previousSum))
                    {
                        maxDiff = Math.Abs(number1 + number2 - previousSum);
                    }                    
                }
                previousSum = number1 + number2;
            }
            if (areEqual)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
