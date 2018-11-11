using System;

namespace Task_1_IF_odd_or_even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and I'll tell you if it's Even or Odd:");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Your number is Even.");
            }
            else
            {
                Console.WriteLine("Your number is Odd.");
            }

        }
    }
}
