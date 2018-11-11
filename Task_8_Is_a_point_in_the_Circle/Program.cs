using System;

namespace Task_8_Is_a_point_in_the_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5). 
             * Пояснение: точката (0,0) е център на окръжността, а радиусът й е 5.
             * Упътване: Използвайте питагоровата теорема a2 + b2 = c2. За да е точката вътре в кръга,
             * то x*x + y*y следва да е по-малко или равно на 5.
             */

            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if ((x*x)+(y*y)<=5)
            {
                Console.WriteLine("The point O({0},{1}) is inside K((0,0), 5) ?", x, y);
            }
            else
            {
                Console.WriteLine("The point O({0},{1}) is outside K((0,0), 5) ?", x, y);
            }
        }
    }
}
