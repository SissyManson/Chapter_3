using System;

namespace Task_5_Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checks if the third bit is 1. Enter it's sides:");
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("h= ");
            int h = int.Parse(Console.ReadLine());
            
            Console.WriteLine("S= {0}", ((a + b) / 2) * h);
        }
    }
}
