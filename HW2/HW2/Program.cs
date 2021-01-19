using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя минимальную и максимальную 
            //температуру за сутки и вывести среднесуточную температуру.

            Console.WriteLine("Введите минимальную температуру за сутки");
            int minTemperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            int maxTemperature = Convert.ToInt32(Console.ReadLine());
            int averageDailyTemperature = (minTemperature + maxTemperature) / 2;
            Console.WriteLine($"Среднесуточная температура: {averageDailyTemperature}");

            readKey();
        }

        public static void readKey() {
            Console.ReadKey();
        }
    }
}
