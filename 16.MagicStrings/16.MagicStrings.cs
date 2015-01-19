using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicStrings
{
    class MagicStrings
    {
        static void Main()
        {
            int diff = int.Parse(Console.ReadLine());
            string[] letters = new string[4] { "s", "n", "k", "p" };
            int[] lettersWeight = new int[4] { 3, 4, 1, 5 };
            int count = 0;
            List<string> collected = new List<string>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int m = 0; m < 4; m++)
                        {
                            for (int n = 0; n < 4; n++)
                            {
                                for (int o = 0; o < 4; o++)
                                {
                                    for (int p = 0; p < 4; p++)
                                    {
                                        for (int q = 0; q < 4; q++)
                                        {
                                            string[] temp = new string[8] {letters[i],letters[j],letters[k],letters[m],
                                                letters[n], letters[o], letters[p], letters[q]};
                                            int[] tempInt = new int[8] {lettersWeight[i], lettersWeight[j], lettersWeight[k],
                                            lettersWeight[m], lettersWeight[n], lettersWeight[o], lettersWeight[p],
                                            lettersWeight[q]};

                                            int tempSumLeft = tempInt[0] + tempInt[1] + tempInt[2] + tempInt[3];
                                            int tempSumRight = tempInt[4] + tempInt[5] + tempInt[6] + tempInt[7];

                                            if (tempSumRight - tempSumLeft == diff || tempSumLeft - tempSumRight == diff)
                                            {
                                                string collect = string.Join("", temp);
                                                collected.Add(collect);
                                                count++;
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                collected.Sort();
                foreach (var item in collected)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}