using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int fibOne = 0;
            int fibTwo = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",fibOne);
                fibOne = fibTwo - fibOne;
                fibTwo += fibOne;
            }
            Console.WriteLine();
        }
    }
}
