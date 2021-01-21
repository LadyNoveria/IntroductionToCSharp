using System;

namespace HW2._5
{
    class Program
    {
        public enum Months
        {
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
            /*(*) Если пользователь указал месяц из зимнего периода, 
             * а средняя температура > 0, вывести сообщение «Дождливая зима».*/
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите среднесуточную температуру");
            int averageDailyTemperature = Convert.ToInt32(Console.ReadLine());

            if (averageDailyTemperature > 0 && (numberOfMonth == 1 || numberOfMonth == 2 || numberOfMonth == 12)) { 
                Console.WriteLine("Дождливая зима");
            }
            else
                Console.WriteLine($"Сейчас месяц {(Months)numberOfMonth}");
          
            readKey();
        }
        public static void readKey()
        {
            Console.ReadKey();
        }
    }
}
