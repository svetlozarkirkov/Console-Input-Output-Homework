using System;

namespace SumOfNnumbers
{
    class SumOfNnumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("n{0} = ",i+1);
                result += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = {0}",result);
        }
    }
}
