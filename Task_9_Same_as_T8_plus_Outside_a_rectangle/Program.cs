using System;

namespace Task_9_Same_as_T8_plus_Outside_a_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5)
             * и едновременно с това извън право­ъгълника ((-1, 1), (5, 5). 
             * Пояснение: правоъгълникът е зададен чрез координатите на горния си ляв и долния си десен ъгъл.
             * Упътване: Използвайте кода от предходната задача и добавете проверка за правоъгълника. 
             * Една точка е вътре в даден правоъгълник със стени успоредни на координатните оси, когато е вдясно от лявата му стена,
             * вляво от дясната му стена, надолу от горната му стена и нагоре от долната му стена.
             */

            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the point O({0},{1}) inside K((0,0), 5) ?",x,y);
            if ((x * x) + (y * y) <= 5)
            {
                Console.WriteLine("Yes.");
            }
            else
            {
                Console.WriteLine("No.");
            }

            Console.WriteLine("\nIs the point O({0},{1}) outside the rectangle ?", x, y);
            if ((x < -1 || x > 5) && (y < 1 || y > 5))
            {
                Console.WriteLine("Yes.");
            }
            else
            {
                Console.WriteLine("No.");
            }
        }
    }
}
