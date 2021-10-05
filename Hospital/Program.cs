using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;
            // doctors = 7 (at first)

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0 && untreatedPatients >= 20)
                {
                    doctors++;
                }

                int patients = int.Parse(Console.ReadLine());
    
                if (patients >= 0)
                {    
                    if (patients >= doctors)
                    {
                        treatedPatients += doctors;
                    }
                    else
                    {
                        treatedPatients += patients;
                    }
                    if (patients > doctors)
                    {
                        untreatedPatients += patients - doctors;
                    }
                }
                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
