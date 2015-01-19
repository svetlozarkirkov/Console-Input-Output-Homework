using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0, j = n / 2, k = 1; i <= n / 2; i++)
            {
                Console.Write(new string('-', j));
                Console.Write(new string('*', k));
                Console.Write(new string('-', j));
                Console.WriteLine();
                j--;
                k += 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', n - 2));
                Console.Write(new string('|', 1));
                Console.WriteLine();
            }
        }
    }
}