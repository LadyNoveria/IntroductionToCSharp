using System;

namespace HW4._3
{
    class Program
    {
        enum Seasons
        {
            Winter = 1, Spring, Summer, Autumn
        }
        static void Main(string[] args)
        {
            /*Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
             * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод, 
             * принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, 
             * весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название 
             * времени года. Если введено некорректное число, вывести в консоль текст «Ошибка: введите число 
             * от 1 до 12».*/

            int numberOfMonth = OutputMonth();
            Seasons season = GetSeason(numberOfMonth);
            Console.WriteLine($"Время года: {season}");
        }

        public static int OutputMonth()
        {
            int month;
            Console.WriteLine("Введите порядковый номер месяца");
            while (true)
            {
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12.");
                    continue;
                }
                else
                {
                    return month;
                }
            }
        }

        static Seasons GetSeason(int numberOfMonth)
        {
            Seasons seasonofYear = new Seasons();
            switch (numberOfMonth)
            {
                case 1:
                case 2:
                    seasonofYear = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    seasonofYear = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    seasonofYear = Seasons.Summer;
                    break;
                case 12:
                    seasonofYear = Seasons.Winter;
                    break;
                default:
                    seasonofYear = Seasons.Autumn;
                    break;
            }
            return seasonofYear;
        }
    }
}
