using System;

namespace Task_6_Rectangle_perimeter_and_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the rectangle, w= ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("h= ");
            int h = Convert.ToInt32(Console.ReadLine());
            int S = w * h;
            Console.WriteLine("Rectangle's: perimeter P= {0}, area S= {1}",2*(w+h),S);
        }
    }
}
