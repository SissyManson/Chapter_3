using System;

namespace Task_2_Bool_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.
                Упътване: Ползвайте логическо "И" (оператора &&) и операцията % за остатък при деление. Можете да решите задачата 
                    и чрез само една проверка – за деление на 35 (помислете защо).*/

            Console.WriteLine("Enter a number & find out if it's divisible by 5 and 7.");
            int number = int.Parse(Console.ReadLine());

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("It is divisible by both 5 and 7.");
            }
            else
            {
                Console.WriteLine("It is NOT divisible by both 5 and 7.");
            }
            //ERROR
        }
    }
}
