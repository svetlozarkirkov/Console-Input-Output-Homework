using System;
using System.Collections.Generic;
using System.Linq;

namespace CatchTheBits
{
    class CatchTheBits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            string[] binaries = new string[n];
            List<char> collected = new List<char>();

            for (int i = 0; i < n; i++)
            {
                binaries[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            }

            string joinedBinary = string.Join("", binaries);

            for (int i = 0, j = 1; i < joinedBinary.Length; i++)
            {
                if (i == 1)
                {
                    collected.Add(joinedBinary[i]);
                }
                else if (i == 1 + j * step)
                {
                    collected.Add(joinedBinary[i]);
                    j++;
                }
            }

            string joined = string.Join("", collected);

            if (joined.Length % 8 == 0)
            {
                var final = Split(joined, 8);
                foreach (var item in final)
                {
                    Console.WriteLine(Convert.ToInt32(item, 2));
                }
            }
            else
            {
                string finalJoin = joined.PadRight(joined.Length + (8 - (joined.Length % 8)), '0');
                var final = Split(finalJoin, 8);
                foreach (var item in final)
                {
                    Console.WriteLine(Convert.ToInt32(item, 2));
                }
            }
        }
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            int len = str.Length;
            return Enumerable.Range(0, len / chunkSize).Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}