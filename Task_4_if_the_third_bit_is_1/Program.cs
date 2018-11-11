using System;

namespace Task_4_if_the_third_bit_is_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checks if the third bit is 1. Enter a number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The third bit of {0} is 1? {1}", num, ((num >> 3) & 1) == 1);
        }
    }
}
