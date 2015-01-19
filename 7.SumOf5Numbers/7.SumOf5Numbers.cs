using System;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {  
                sum += Convert.ToDouble(nums[i].ToString());
            }
            Console.WriteLine("Sum = {0}",sum);
        }
    }
}
