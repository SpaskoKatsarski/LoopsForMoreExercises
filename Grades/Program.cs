using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            int studentsLessThan3 = 0;
            int studentsLessThan4 = 0;
            int studentsLessThan5 = 0;
            int studentsMoreThan5 = 0;

            double gradeLessThan3 = 0;
            double gradeLessThan4 = 0;
            double gradeLessThan5 = 0;
            double gradeMoreThan5 = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 3)
                {
                    studentsLessThan3++;
                    gradeLessThan3 += grade;
                }
                else if (grade < 4)
                {
                    studentsLessThan4++;
                    gradeLessThan4 += grade;
                }
                else if (grade < 5)
                {
                    studentsLessThan5++;
                    gradeLessThan5 += grade;
                }
                else
                {
                    studentsMoreThan5++;
                    gradeMoreThan5 += grade;
                }
            }
            double convertLessThan3 = (double) studentsLessThan3 / students * 100;
            double convertLessThan4 = (double) studentsLessThan4 / students * 100;
            double convertLessThan5 = (double) studentsLessThan5 / students * 100;
            double convertMoreThan5 = (double) studentsMoreThan5 / students * 100;
            double average = (gradeLessThan3 + gradeLessThan4 + gradeLessThan5 + gradeMoreThan5) / students;

            Console.WriteLine($"Top students: {convertMoreThan5:f2}%\nBetween 4.00 and 4.99: {convertLessThan5:f2}%\nBetween 3.00 and 3.99: {convertLessThan4:f2}%\nFail: {convertLessThan3:f2}%\nAverage: {average:f2}");
        }
    }
}
