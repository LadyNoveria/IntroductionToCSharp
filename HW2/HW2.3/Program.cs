using System;

namespace HW2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить, является ли введённое пользователем число чётным.

            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            /*
            switch (number % 2 == 0)
            {
                case true:
                    Console.WriteLine("Число четное");
                    break;
                default:
                    Console.WriteLine("Число не четное");
                    break;
            }
            */

            if (number % 2 == 0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число не четное");

            readKey();
        }

        public static void readKey()
        {
            Console.ReadKey();
        }
    }
}
