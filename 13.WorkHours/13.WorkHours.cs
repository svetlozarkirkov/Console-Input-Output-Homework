using System;

namespace WorkHours
{
    class WorkHours
    {
        static void Main()
        {
            int hoursRequired = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int productivity = int.Parse(Console.ReadLine());
            double realWorkDays = daysAvailable - (daysAvailable * 0.1);
            double productiveHours = (realWorkDays * 12);
            double realWorkHours = Math.Truncate(productiveHours * productivity / 100);

            double diff = realWorkHours - hoursRequired;

            if (diff >= 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(diff);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(diff);
            }
        }
    }
}
