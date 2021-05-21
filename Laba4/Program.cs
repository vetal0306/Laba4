using System;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Var 7: y = ((a+b)^2 + m) / (1 + x^a + b^a),  a = lg0,83 = 0,08, b = e^a = 1,08,  m = x-1
            double a = 0.08, b = 1.08;
            double x = double.Parse(Console.ReadLine());
            double m = x - 1;
            double x1 = (a + b); //a+b
            double x2 = Math.Pow(x1, 2) + m; //(a+b)^2 + m
            double x3 = 1 + Math.Pow(x, a) + Math.Pow(b, a);
            double y = x2 / x3;
            Console.WriteLine(y);
        }
    }
}
