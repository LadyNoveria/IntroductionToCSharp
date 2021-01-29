using System;

namespace HW4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. */
            Console.WriteLine("Введите порядковый номер числа Фибоначчи");
            int number = Convert.ToInt32(Console.ReadLine());
            int numFib = fib(number);
            Console.WriteLine($"Число в порядковом номере {number} = {numFib}");
            Console.ReadKey();
        }

        public static int fib(int number)
        {
            if (number < 2)
            {
                return number;
            }
            return fib(number - 1) + fib(number - 2);
        }
    }
}
