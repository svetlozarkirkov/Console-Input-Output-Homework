using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfElements
{
    class SumOfElements
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long[] nums = input.Split(' ').Select(s => Convert.ToInt64(s)).ToArray();
            List<long> digits = nums.Cast<long>().ToList();
            List<long> sums = new List<long>();
            List<long> diffs = new List<long>();

            for (int i = 0; i < nums.Length; i++)
            {
                List<long> tempList = new List<long>();
                tempList.AddRange(digits);
                long tempDigit = tempList[i];
                tempList.RemoveAt(i);

                if (tempList.Sum() == tempDigit)
                {
                    sums.Add(tempList.Sum());
                }
                else if (tempList.Sum() != tempDigit)
                {
                    if (tempDigit > tempList.Sum())
                    {
                        diffs.Add(tempDigit - tempList.Sum());
                    }
                    else
                    {
                        diffs.Add(tempList.Sum() - tempDigit);
                    }

                }
            }

            if (sums.Count > 0)
            {
                Console.WriteLine("Yes, sum=" + sums.Max());
            }
            else if (sums.Count == 0)
            {
                Console.WriteLine("No, diff=" + diffs.Min());
            }
        }
    }
}