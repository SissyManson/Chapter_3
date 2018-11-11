using System;

namespace Task_7_Your_weight_on_the_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight and see how much it'll be if you were on the Moon:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your weight would be {0} kg.", weight*0.17);
            Console.ResetColor();
        }
    }
}
