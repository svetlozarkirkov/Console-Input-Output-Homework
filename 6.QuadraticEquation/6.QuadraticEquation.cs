using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine()); 
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            SolveQuadratic(a,b,c);
        }
        public static void SolveQuadratic(double a, double b, double c)
        {
            double sqrtpart = b * b - 4 * a * c;
            double x, x1, x2;
            if (sqrtpart > 0)
            {
                x1 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (sqrtpart < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x);
            }
        }
    }
}
