using System;

namespace NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('=',10));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('=',10));
        }
    }
}
