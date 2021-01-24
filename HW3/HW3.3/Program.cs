using System;

namespace HW3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, выводящую введенную пользователем строку в обратном
             *порядке (olleH вместо Hello).*/
            Console.WriteLine("Введите любую строку");
            string enteredString = Console.ReadLine();

            //Вывод строки задом наперед
            stringOutput(enteredString);
            readKey();
        }

        //Вывод строки задом наперед
        private static void stringOutput(string enteredString)
        {
            for (int i = enteredString.Length - 1; i >= 0; i--)
            {
                Console.Write(enteredString[i]);
            }
        }

        public static void readKey()
        {
            Console.ReadKey();
        }
    }
}
