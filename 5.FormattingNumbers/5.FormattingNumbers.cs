using System;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());
            string second;
            string third;
            //Checking if "b" and "c" have fractional parts (to satisfy the examples)
            if (b%1==0)
            {
                second = b.ToString();
            }
            else
            {
                second = b.ToString("0.00");
            }
            if (c%1==0)
            {
                third = c.ToString();
            }
            else
            {
                third = c.ToString("0.000");
            }
            
            Console.WriteLine("|{0}|{1}|{2}|{3}|",a.ToString("X").PadRight(10,' '),
                Convert.ToString(a,2).PadLeft(10,'0'),
                second.PadLeft(10, ' '), 
                third.PadRight(10));
        }
    }
}
