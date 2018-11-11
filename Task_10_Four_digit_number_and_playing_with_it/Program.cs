using System;

namespace Task_10_Four_digit_number_and_playing_with_it
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            Console.WriteLine("Sum of it's digits: {0}", a + b + c + d);
            Console.WriteLine("Digits backwards: {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("Last digit on first place: {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("Replaces the third and second digit: {0}{2}{1}{3}", a, b, c, d);
        }
    }
}
