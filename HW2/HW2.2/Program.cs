using System;

namespace HW2._2
{
    class Program
    {
        public enum Months { 
            January = 1, 
            February, 
            March, 
            April, 
            May, 
            June, 
            July, 
            August, 
            September, 
            October, 
            November, 
            December        
        }
        static void Main(string[] args)
        {
            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.

            Console.WriteLine("Введите порядковый номер текущего месяца");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сейчас месяц {(Months)numberOfMonth}");

            readKey();
        }

        public static void readKey()
        {
            Console.ReadKey();
        }
    }
}
