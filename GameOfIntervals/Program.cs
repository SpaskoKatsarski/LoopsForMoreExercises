using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double startingScore = 0;
            int case1 = 0;
            int case2 = 0;
            int case3 = 0;
            int case4 = 0;
            int case5 = 0;
            int case6 = 0;

            for (int i = 0; i < moves; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    startingScore += 0.20 * num;
                    case1 += 1;
                }
                else if (num >= 10 && num <= 19)
                {
                    startingScore += 0.30 * num;
                    case2 += 1;
                }
                else if (num >= 20 && num <= 29)
                {
                    startingScore += 0.40 * num;
                    case3 += 1;
                }
                else if (num >= 30 && num <= 39)
                {
                    startingScore += 50;
                    case4 += 1;
                }
                else if (num >= 40 && num <= 50)
                {
                    startingScore += 100;
                    case5 += 1;
                }
                else if (num < 0 || num > 50)
                {
                    startingScore /= 2;
                    case6 += 1;
                }
            }
            double allCases = case1 + case2 + case3 + case4 + case5 + case6;
            double convert1 = case1 / allCases * 100;
            double convert2 = case2 / allCases * 100;
            double convert3 = case3 / allCases * 100;
            double convert4 = case4 / allCases * 100;
            double convert5 = case5 / allCases * 100;
            double convert6 = case6 / allCases * 100;

            Console.WriteLine($"{startingScore:f2}\nFrom 0 to 9: {convert1:f2}%\nFrom 10 to 19: {convert2:f2}%\nFrom 20 to 29: {convert3:f2}%\nFrom 30 to 39: {convert4:f2}%\nFrom 40 to 50: {convert5:f2}%\nInvalid numbers: {convert6:f2}%");
        }
    }
}
