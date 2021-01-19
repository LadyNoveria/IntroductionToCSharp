using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя:");
            string nameUser = Console.ReadLine();
            DateTime date = DateTime.Today;
            Console.WriteLine("Приветствую, " + nameUser + ". Сегодня " + date.ToString("d"));
            Console.ReadLine();
        }
    }
}
