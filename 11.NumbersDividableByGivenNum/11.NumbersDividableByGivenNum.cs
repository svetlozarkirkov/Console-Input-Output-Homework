using System;
using System.Collections.Generic;

namespace NumbersDividableByGivenNum
{
    class NumbersDividableByGivenNum
    {
        static void Main()
        {
            Console.Write("start = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("end = ");
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("\np = {0}",p);
        }
    }
}
