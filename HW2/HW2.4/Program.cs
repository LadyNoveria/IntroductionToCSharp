using System;

namespace HW2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Для полного закрепления понимания простых типов найдите любой чек, 
            либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
            только за место динамических, по вашему мнению, данных (это может быть дата, 
            название магазина, сумма покупок) подставляйте переменные, которые были заранее 
            заготовлены до вывода на консоль.*/

            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            readKey();
        }

        public static void readKey()
        {
            Console.ReadKey();
        }
    }
}
