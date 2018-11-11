using System;

namespace Task_11_Value_of_a_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дадено е число n и позиция p. Напишете поредица от операции, които да отпечатат стойността на бита на позиция p от числото n 
             * (0 или 1). Пример: n=35, p=5 -> 1. Още един пример: n=35, p=6 -> 0.
            */
            int n = 35; // 00100011
            int p = 5;
            int i = 1; // 00000001
            int mask = i << p; // Move the 1st bit left by p positions
                               // If i & mask are positive then the p-th bit of n is 1
            Console.WriteLine((n & mask) != 0 ? 1 : 0);

        }
    }
}
