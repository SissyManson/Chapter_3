using System;

namespace Task_3_if_the_third_digit_is_7
{

    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете израз, който да проверява дали третата цифра (отдясно на ляво) на дадено цяло число е 7.
    Упътване: Разделете числото на 100 и го запишете в нова променлива. Нея разделете на 10 и вземете остатъкът.
    Остатъкът от делението на 10 е третата цифра от първоначалното число. Проверете равна ли е на 7.
                */

            Console.WriteLine("Checks if the third digit(right to left) of a given integer is 7. Enter a number:");
            int num = int.Parse(Console.ReadLine());
            //int num2 = num / 100;
            //int num3 = num2 % 10;
            //bool res = (um3 == 7) ? true : false;

            bool res = (num/100)%10 == 7 ? true : false;
            Console.WriteLine(res);
            
            //all I get is False
        }
    }
}
