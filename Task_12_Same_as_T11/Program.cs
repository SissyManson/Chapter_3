using System;

namespace Task_12_Same_as_T11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Напишете булев израз, който проверява дали битът на позиция p на цялото число v има стойност 1. Пример v=5, p=1 -> false.
             */

            Console.WriteLine("Cheks if the bit on 'p' position has value 1.");
            Console.Write("Enter a number: ");
            int v = int.Parse(Console.ReadLine());

            Console.Write("\nEnter a 'p' position: ");
            int p = int.Parse(Console.ReadLine());
            
            int pos = 1 << p;
            bool isOne = (v & pos) != 0 ? true : false;
            Console.WriteLine("The bit at position {0} of number {1} is 1?\n {2}", p, v, isOne);
        }
    }
}
