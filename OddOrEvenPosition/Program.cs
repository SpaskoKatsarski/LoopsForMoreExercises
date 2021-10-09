using System;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    if (input > evenMax)
                    {
                        evenMax = input;
                    }
                    if (input < evenMin)
                    {
                        evenMin = input;
                    }
                    evenSum += input;
                }
                else
                {
                    if (input > oddMax)
                    {
                        oddMax = input;
                    }
                    if (input < oddMin)
                    {
                        oddMin = input;
                    }
                    oddSum += input;
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
